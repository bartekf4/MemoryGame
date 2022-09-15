using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MemoryGame
{
    /// <summary>
    ///     Singleton Class <c>HighScores</c> is an auxiliary class to handle the scores. Used to retrieve the scores and sort
    ///     them.
    /// </summary>
    internal class HighScores
    {
        /// <summary>
        ///     Field <c>FileUrl</c> holds the path to file containing ranking.
        /// </summary>
        private const string FileUrl = "..\\..\\Scores.txt";

        private static HighScores _instance;

        private HighScores()
        {
            LoadFromFile();
        }

        /// <summary>
        ///     Field <c>items</c> is a list of ScoreItems
        /// </summary>
        public List<ScoreItem> Items { get; } = new List<ScoreItem>();

        /// <summary>
        ///     Allows the singleton.
        /// </summary>
        /// <returns></returns>
        public static HighScores GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HighScores();
                _instance.LoadFromFile();
                return _instance;
            }

            return _instance;
        }

        /// <summary>
        ///     Method <c>LoadFromFile</c> handles the stored ranking of scores in CSV file.
        /// </summary>
        private void LoadFromFile()
        {
            if (File.Exists(FileUrl))
            {
                Items.Clear();

                var lines = File.ReadAllLines(FileUrl);

                foreach (var line in lines)
                {
                    var values = line.Split(';');
                    if (values.Length != 2) continue;
                    var newItem = new ScoreItem
                    {
                        name = values[0]
                    };

                    if (!int.TryParse(values[1], out var score)) continue;
                    newItem.score = score;
                    Items.Add(newItem);
                }
            }
            else
            {
                File.Create(FileUrl);
            }

            Items.Sort((i1, i2) => i2.score.CompareTo(i1.score));
        }

        /// <summary>
        ///     Method <c>SaveToFile</c> saves the ranking in CSV file.
        /// </summary>
        private void SaveToFile()
        {
            var b = new StringBuilder();
            foreach (var item in Items) b.Append(item.name + ";" + item.score + "\n");

            File.WriteAllText(FileUrl, b.ToString());
        }


        /// <summary>
        ///     Method <c>AddScore</c> adds the <c>newScore</c> to existing list of <c>ScoreItems</c> and sort it in descending
        ///     order.
        /// </summary>
        /// <param name="newScore"></param>
        public void AddScore(Score newScore)
        {
            var newItem = new ScoreItem
            {
                name = newScore.GetName(),
                score = newScore.GetScore()
            };

            Items.Add(newItem);
            Items.Sort((i1, i2) => i2.score.CompareTo(i1.score));

            SaveToFile();
        }
    }

    public class ScoreItem
    {
        public string name;
        public int score;
    }
}