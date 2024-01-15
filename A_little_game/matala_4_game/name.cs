using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matala_4_game
{
    public partial class name : Form
    {
        public name()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (txbName.Text == "")
                MessageBox.Show("You must fill your name!", "", MessageBoxButtons.OK);
            else
            {
                mainGame startGame = new mainGame(txbName.Text);
                startGame.ShowDialog();
            }
                   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
