using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MainForm : Form
    {
        /// <summary>
        ///     Enum <c>Level</c> contains different difficulties,
        ///     which can be chosen by player
        /// </summary>
        public enum Levels
        {
            Easy,
            Medium,
            Hard
        }

        public string playerName;


        public MainForm()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 1;
        }

        public Levels Level { get; private set; }

        /// <summary>
        ///     Dynamically changes chosen level in listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Level = Levels.Easy;
                    break;
                case 1:
                    Level = Levels.Medium;
                    break;
                case 2:
                    Level = Levels.Hard;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gameForm = new GameForm(this);
            gameForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var scoresForm = new ScoresForm();
            scoresForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            playerName = textBox1.Text;
        }
    }
}