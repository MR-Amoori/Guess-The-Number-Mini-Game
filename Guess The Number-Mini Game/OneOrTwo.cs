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
    public partial class OneOrTwo : Form
    {
        public OneOrTwo()
        {
            InitializeComponent();
        }

        private void btnOnePlay_Click(object sender, EventArgs e)
        {
            frm_Start4 frm_Start = new frm_Start4();
            frm_Start.Show();
            this.Hide();
        }
    }
}
