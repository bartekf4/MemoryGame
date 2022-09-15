using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Card : PictureBox
    {
        public Card(int id)
        {
            ID = id;

            InitializeComponent();
        }

        public Card()
        {
            ID = 0;
            InitializeComponent();
        }

        public int ID { get; set; }

        public Image Front { get; set; }
    }
}