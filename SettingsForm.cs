using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class SettingsForm : Form
    {
        private readonly Settings settings;
        private bool isSaved = true;


        public SettingsForm()
        {
            settings = Settings.GetInstance();

            InitializeComponent();


            SetMinAndMaxForObjects();
            SetInitValues();
        }

        private void SetMinAndMaxForObjects()
        {
            height_trackBar.Maximum = settings.BoardHeightMax;
            height_trackBar.Minimum = settings.BoardHeightMin;

            width_trackBar.Maximum = settings.BoardWidthMax;
            width_trackBar.Minimum = settings.BoardWidthMin;

            visibility_trackBar.Minimum = 0;
            visibility_trackBar.Maximum = settings.VisibilityTimeMax;

            initVisibility_trackBar.Minimum = 0;
            initVisibility_trackBar.Maximum = settings.InitVisibilityTimeMax;
        }

        private void SetInitValues()
        {
            initVisibility_label.Text = settings.InitVisibilityTime.ToString();
            visibility_label.Text = settings.VisibilityTime.ToString();
            height_label.Text = settings.BoardHeight.ToString();
            width_label.Text = settings.BoardWidth.ToString();

            initVisibility_trackBar.Value = settings.InitVisibilityTime;
            visibility_trackBar.Value = settings.VisibilityTime;
            height_trackBar.Value = settings.BoardHeight;
            width_trackBar.Value = settings.BoardWidth;
        }

        private void Unsaved()
        {
            isSaved = false;
        }

        private void SaveSettings()
        {
            settings.BoardHeight = height_trackBar.Value;
            settings.BoardWidth = width_trackBar.Value;
            settings.InitVisibilityTime = initVisibility_trackBar.Value;
            settings.VisibilityTime = visibility_trackBar.Value;
            isSaved = true;
        }

        private void initVisibility_trackBar_ValueChanged(object sender, EventArgs e)
        {
            initVisibility_label.Text = initVisibility_trackBar.Value + @"s";
            Unsaved();
        }

        private void visibility_trackBar_ValueChanged(object sender, EventArgs e)
        {
            visibility_label.Text = visibility_trackBar.Value + @"s";
            Unsaved();
        }

        private void height_trackBar_ValueChanged(object sender, EventArgs e)
        {
            height_label.Text = height_trackBar.Value.ToString();
            Unsaved();
        }

        private void width_trackBar_ValueChanged(object sender, EventArgs e)
        {
            width_label.Text = width_trackBar.Value.ToString();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved) return;
            var response = MessageBox.Show(@"Do you want to save new settings?",
                @"Saving",
                MessageBoxButtons.YesNoCancel);

            switch (response)
            {
                case DialogResult.Yes:
                    SaveSettings();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.No:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }
    }
}