using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Number_Mini_Game
{
    public partial class frm_Start : Form
    {

        public frm_Start()
        {

            InitializeComponent();
        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.Green;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.ForeColor = Color.Black;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frm_Play frm_Play = new frm_Play();
            {
                try
                {
                    frm_Play.UserName = txtName.Text;
                    frm_Play.Number1 = int.Parse(txt1.Text);
                    frm_Play.Number2 = int.Parse(txt2.Text);
                    frm_Play.Number3 = int.Parse(txt3.Text);
                    frm_Play.Number4 = int.Parse(txt4.Text);
                    frm_Play.Conter = int.Parse(txtConter.Text);
                    frm_Play.UserName = txtName.Text;
                }
                catch
                {

                    MessageBox.Show("Please Fill In All Fields !");
                    Application.Restart();
                }

            }
            this.Hide();
            frm_Play.ShowDialog();

        }

        private void frm_Start_Load(object sender, EventArgs e)
        {

        }
    }
}
