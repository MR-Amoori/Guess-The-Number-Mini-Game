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
    public partial class frm_Play : Form
    {
        public int Number1
        {
            get; set;
        }
        public int Number2
        {
            get; set;
        }
        public int Number3
        {
            get; set;
        }
        public int Number4
        {
            get; set;
        }
        public int Conter
        {
            get; set;
        }
        public string UserName
        {
            get; set;
        }

        public frm_Play()
        {
            InitializeComponent();
        }
      
        public int ConterNum;
        private void frm_Play_Load(object sender, EventArgs e)
        {
          // this.Text += " ( " + UserName + " )";
            lblConter.Text = Conter.ToString();
            ConterNum = Conter;
        }

        private void button1_Click(object sender, EventArgs e)
             {
            CheckNumber();
            if (lblResult.Text == "1111")
            {
                MessageBox.Show("Goooood ♥ ");
                Application.Exit();
            }
            ConterNum--;
            lblConter.Text = ConterNum.ToString();
            if (int.Parse(lblConter.Text) == 0)
            {
                string Answer = Number1.ToString() + Number2.ToString() + Number3.ToString() + Number4.ToString();
                MessageBox.Show($"Game Over !\nAnswer: {Answer}");
                Application.Exit();
            }

        }

        private void CheckNumber()
        {
            var ResultString = string.Empty;

            if (txt1.Text == Number1.ToString())
            {
                ResultString += "1";
            }
            else if (txt1.Text == Number2.ToString() || txt1.Text == Number3.ToString() || txt1.Text == Number4.ToString())
            {
                ResultString += "2";
            }

            if (txt2.Text == Number2.ToString())
            {
                ResultString += "1";
            }
            else if (txt2.Text == Number1.ToString() || txt2.Text == Number3.ToString() || txt2.Text == Number4.ToString())
            {
                ResultString += "2";
            }

            if (txt3.Text == Number3.ToString())
            {
                ResultString += "1";
            }
            else if (txt3.Text == Number1.ToString() || txt3.Text == Number2.ToString() || txt3.Text == Number4.ToString())
            {
                ResultString += "2";
            }

            if (txt4.Text == Number4.ToString())
            {
                ResultString += "1";
            }
            else if (txt4.Text == Number1.ToString() || txt4.Text == Number2.ToString() || txt4.Text == Number3.ToString())
            {
                ResultString += "2";
            }

            lblResult.Text = ResultString;
        }
    }
}
