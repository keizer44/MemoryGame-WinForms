using System;
using System.Windows.Forms;

namespace Memory_Game_X
{
    public partial class StartGameForm : Form
    {

        public StartGameForm()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.ShowDialog();
            this.Hide();
        }

        private void ImmpossibleClick_Click(object sender, EventArgs e)
        {
            Impossible impossibleForm = new Impossible();
            impossibleForm.ShowDialog();
            this.Hide();
        }
    }
}
