using System;
using System.Windows.Forms;
//Added nuggets
using System.Media;

namespace WaveMusicTool
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
            this.StopButton.Enabled = false;
        }

        private System.Media.SoundPlayer player;

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            using (var FileDialog = new OpenFileDialog())
            {
                FileDialog.Filter = "Wave Audio(*.wav) | *.wav";
                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.DirectoryTextBox.Text = FileDialog.FileName;
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            /*
            if (this.DirectoryTextBox.Text.Length == 0)
            {
                MessageBox.Show("Directory entry is required","Wave Music", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            */
            
            try
            {
                /// <param name="vplayer">Variables</param>
                player = new System.Media.SoundPlayer(DirectoryTextBox.Text);
                player.Play();
                this.StopButton.Enabled = true;
                this.PlayButton.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Wave Music", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                player.Stop();
                this.StopButton.Enabled = false;
                this.PlayButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
