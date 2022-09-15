using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class ScoresForm : Form
    {
        private readonly HighScores highScores;


        public ScoresForm()
        {
            InitializeComponent();
            highScores = HighScores.GetInstance();
            AddElements();
        }


        private void AddElements()
        {
            scores_tableLayoutPanel.RowCount = highScores.Items.Count + 1;

            for (var i = 0; i < highScores.Items.Count; ++i)
            {
                var scoreItem = highScores.Items[i];

                scores_tableLayoutPanel.Controls.Add(
                    new Label
                    {
                        Text = scoreItem.name, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill
                    }, 0, i + 1);

                scores_tableLayoutPanel.Controls.Add(
                    new Label
                    {
                        Text = scoreItem.score.ToString(), TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    }, 0, i + 1);
            }


            foreach (RowStyle rowStyle in scores_tableLayoutPanel.RowStyles)
            {
                if (scores_tableLayoutPanel.RowStyles.IndexOf(rowStyle) == 0) continue;
                rowStyle.SizeType = SizeType.Absolute;
                rowStyle.Height = 50;
            }
        }
    }
}