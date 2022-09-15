namespace MemoryGame
{
    /// <summary>
    ///     Class <c>Score</c> keeps handles the user's score during the game.
    /// </summary>
    public class Score
    {
        /// <summary>
        ///     Field <c>MistakeValue</c> holds the value of the mistake associated with bad move.
        /// </summary>
        private const int MistakeValue = 100;

        /// <summary>
        ///     Field <c>PairValue</c> holds the value of the guessed cards (good move).
        /// </summary>
        private const int PairValue = 20;

        /// <summary>
        ///     Field <c>TimeTickValue</c> holds the value of the passing time.
        /// </summary>
        private const int TimeTickValue = 10;

        private readonly string name;
        private int score;

        public Score(string name, int initScore)
        {
            this.name = name;
            score = initScore;
        }

        public int GetScore()
        {
            return score;
        }

        public string GetName()
        {
            return name;
        }

        public void MadeMistake()
        {
            score -= MistakeValue;
        }

        public void MadePair()
        {
            score += PairValue;
        }


        public void TimeTicks()
        {
            score -= TimeTickValue;
        }
    }
}