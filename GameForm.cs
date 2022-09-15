using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameForm : Form
    {
        private readonly List<Card> cards = new List<Card>();

        /// <summary>
        ///     Main Window Frame
        /// </summary>
        private readonly MainForm menu;

        /// <summary>
        ///     Instance of singleton Settings class
        /// </summary>
        private readonly Settings settings = Settings.GetInstance(); // to change settings during a game

        /// <summary>
        ///     Settings Window Frame
        /// </summary>
        private readonly SettingsForm settingsForm;

        /// <summary>
        ///     Auxiliary variables used to compare the cards after user's choice
        /// </summary>
        private Card firstCard;

        private int hiddenCards; // number of still covered Cards

        private readonly HighScores highScores;

        /// <summary>
        ///     Auxiliary variables handling the states of the game
        /// </summary>
        private bool isCardTurned;

        private bool isFinished;

        private bool isPaused;
        private int rows, columns;

        /// <summary>
        ///     Current user's score
        /// </summary>
        private Score score;

        /// <summary>
        ///     Scores Window Form. Used to display scores after game
        /// </summary>
        private ScoresForm scoresForm;

        private Card secondCard;

        private double time;


        public GameForm(MainForm owner)
        {
            menu = owner;

            highScores = HighScores.GetInstance();

            settingsForm = new SettingsForm();
            scoresForm = new ScoresForm();

            InitializeComponent();

            Width = settings.BoardWidth;
            Height = settings.BoardHeight;

            InitializeCards();
        }

        private void InitializeCards()
        {
            switch (menu.Level)
            {
                case MainForm.Levels.Easy:
                    rows = 3;
                    columns = 4;
                    hiddenCards = 12;
                    score = new Score(menu.playerName, 2000);
                    break;

                case MainForm.Levels.Medium:
                    hiddenCards = 36;
                    rows = columns = 6;
                    score = new Score(menu.playerName, 10000);
                    break;

                case MainForm.Levels.Hard:
                    hiddenCards = 80;
                    rows = 8;
                    columns = 10;
                    score = new Score(menu.playerName, 50000);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            UpdateScore();

            cards_tableLayoutPanel.RowCount = rows;
            cards_tableLayoutPanel.ColumnCount = columns;

            pause_button.BackColor = Color.Firebrick;


            for (var i = 0; i < rows; ++i)
                cards_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rows));
            for (var i = 0; i < columns; ++i)
                cards_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));


            foreach (RowStyle style in cards_tableLayoutPanel.RowStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Height = 100 / rows;
            }

            foreach (ColumnStyle style in cards_tableLayoutPanel.ColumnStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Width = 100 / columns;
            }

            for (var index = 0; index < hiddenCards; ++index)
            {
                var newCard = new Card(index / 2);
                newCard.Front =
                    Image.FromFile(
                        "..\\..\\Icons\\" + newCard.ID + ".png");
                cards.Add(newCard);
            }

            ShuffleCards();

            for (var i = 0; i < rows; ++i)
            for (var j = 0; j < columns; ++j)
            {
                var newCard = cards[i * columns + j];
                cards_tableLayoutPanel.Controls.Add(newCard, j, i);
                newCard.SizeMode = PictureBoxSizeMode.Zoom;
                newCard.Dock = DockStyle.Fill;
                newCard.BackColor = Color.Silver;

                newCard.Click += Card_Click;

                if (settings.InitVisibilityTime == 0) continue;
                newCard.Image = newCard.Front;
                newCard.Enabled = false;
                isCardTurned = true;
                btnSett.Enabled = false;
            }
        }

        /// <summary>
        ///     Method <c>ShuffleCards</c> used to reshuffle list of the cards. Uses Fisher–Yates algorithm.
        /// </summary>
        private void ShuffleCards()
        {
            var rnd = new Random();

            for (var unShuffled = hiddenCards; unShuffled > 1; --unShuffled)
            {
                var rndTile = rnd.Next(0, unShuffled);

                (cards[rndTile], cards[unShuffled - 1]) = (cards[unShuffled - 1], cards[rndTile]);
            }
        }

        /// <summary>
        ///     Method <c>Card_Click</c> checks if the cards are the same as well as the correctness of the move.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Card_Click(object sender, EventArgs e)
        {
            if (isPaused) return;
            if (firstCard == null) // if it was first card
            {
                firstCard = (Card) sender;

                firstCard.Image = firstCard.Front;
                firstCard.Enabled = false;

                isCardTurned = true;
                btnSett.Enabled = false;
            }

            else if (secondCard == null) // if it was second card
            {
                secondCard = (Card) sender;

                secondCard.Image = secondCard.Front;
                secondCard.Enabled = false;

                if (EqualIDs(firstCard, secondCard))
                    good_guess_timer.Start();
                else
                    bad_guess_timer.Start();
            }
        }

        private void init_visibility_timer_Tick(object sender, EventArgs e)
        {
            foreach (var c in cards)
            {
                c.Image = null;
                c.Enabled = true;
            }

            init_visibility_timer.Enabled = false;
            time_timer.Enabled = true;

            isCardTurned = false;
            btnSett.Enabled = true;
        }

        private void bad_guess_timer_Tick(object sender, EventArgs e)
        {
            bad_guess_timer.Stop();

            firstCard.Enabled = true;
            firstCard.Image = null;
            firstCard = null;

            secondCard.Enabled = true;
            secondCard.Image = null;
            secondCard = null;

            score.MadeMistake();
            UpdateScore();

            isCardTurned = false;
            btnSett.Enabled = true;
        }

        private void good_guess_timer_Tick(object sender, EventArgs e)
        {
            good_guess_timer.Stop();

            firstCard.Visible = false;
            firstCard.Front.Dispose();
            firstCard.Image.Dispose();
            firstCard = null;

            secondCard.Visible = false;
            secondCard.Front.Dispose();
            secondCard.Image.Dispose();
            secondCard = null;

            hiddenCards -= 2;
            score.MadePair();
            UpdateScore();

            isCardTurned = false;
            btnSett.Enabled = true;

            if (hiddenCards == 0) GameFinish();
        }

        /// <summary>
        ///     Method <c>GameFinish</c> used to display the Scores Window Form
        /// </summary>
        private void GameFinish()
        {
            isFinished = true;

            time_timer.Enabled = false;
            highScores.AddScore(score);

            scoresForm = new ScoresForm();
            scoresForm.ShowDialog();
            Close();
        }


        /// <summary>
        ///     Method <c>btn_Sett_Click</c> used to dynamically adjust Settings during the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSett_Click(object sender, EventArgs e)
        {
            if (!isPaused) Pause();

            settingsForm.ShowDialog();

            Width = settings.BoardWidth;
            Height = settings.BoardHeight;

            init_visibility_timer.Interval = settings.InitVisibilityTime * 1000;
            bad_guess_timer.Interval = Convert.ToInt32(settings.VisibilityTime * 1000);
        }

        private void Pause()
        {
            pause_button.Text = @"Unpause";
            pause_button.BackColor = Color.DarkGreen;
            isPaused = true;
        }

        private void Unpause()
        {
            pause_button.Text = @"Pause";
            pause_button.BackColor = Color.Firebrick;

            isPaused = false;
        }

        private void UpdateScore()
        {
            score_label.Text = @"Score: " + score.GetScore();
        }


        private void GameForm_Shown(object sender, EventArgs e)
        {
            if (settings.InitVisibilityTime != 0) // starts timer if value is positive
            {
                init_visibility_timer.Interval = settings.InitVisibilityTime * 1000;
                init_visibility_timer.Enabled = true;
            }

            bad_guess_timer.Interval = Convert.ToInt32(settings.VisibilityTime * 1000);
        }

        private void time_timer_Tick(object sender, EventArgs e)
        {
            if (time % 1000 == 0) score.TimeTicks();
            time += time_timer.Interval;
            time_label.Text = (time / 1000).ToString(CultureInfo.CurrentCulture);
            time_timer.Enabled = true;
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            if (!isCardTurned && !isPaused)
                Pause();
            else if (isPaused) Unpause();
        }

        private static bool EqualIDs(Card first, Card second)
        {
            return first.ID == second.ID;
        }
    }
}