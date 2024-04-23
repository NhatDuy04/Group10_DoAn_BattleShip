using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace battleship
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Credit creditsForm = new Credit();
            creditsForm.Location = Location;
            creditsForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InGame ingame = new InGame();
            ingame.Show();
            Hide();
        }
    }
}
