namespace Guess_The_Number_Mini_Game
{
    partial class frm_Start4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConter = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number :";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(65, 42);
            this.txt1.MaxLength = 1;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(26, 21);
            this.txt1.TabIndex = 1;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(97, 42);
            this.txt2.MaxLength = 1;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(26, 21);
            this.txt2.TabIndex = 2;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(129, 42);
            this.txt3.MaxLength = 1;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(26, 21);
            this.txt3.TabIndex = 3;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(161, 42);
            this.txt4.MaxLength = 1;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(26, 21);
            this.txt4.TabIndex = 4;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 10);
            this.txtName.MaxLength = 4564;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 21);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Conter :";
            // 
            // txtConter
            // 
            this.txtConter.Location = new System.Drawing.Point(64, 76);
            this.txtConter.MaxLength = 123;
            this.txtConter.Name = "txtConter";
            this.txtConter.Size = new System.Drawing.Size(59, 21);
            this.txtConter.TabIndex = 5;
            this.txtConter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(129, 76);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(58, 21);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 102);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtConter);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Number";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Start_FormClosing);
            this.Load += new System.EventHandler(this.frm_Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConter;
        private System.Windows.Forms.Button btnPlay;
    }
}

