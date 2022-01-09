namespace Guess_The_Number_Mini_Game
{
    partial class OneOrTwo
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
            this.btnOnePlay = new System.Windows.Forms.Button();
            this.btnTwoPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnePlay
            // 
            this.btnOnePlay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnePlay.Location = new System.Drawing.Point(135, 18);
            this.btnOnePlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnePlay.Name = "btnOnePlay";
            this.btnOnePlay.Size = new System.Drawing.Size(112, 57);
            this.btnOnePlay.TabIndex = 0;
            this.btnOnePlay.Text = "4 تایی";
            this.btnOnePlay.UseVisualStyleBackColor = true;
            this.btnOnePlay.Click += new System.EventHandler(this.btnOnePlay_Click);
            // 
            // btnTwoPlay
            // 
            this.btnTwoPlay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoPlay.Location = new System.Drawing.Point(15, 18);
            this.btnTwoPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnTwoPlay.Name = "btnTwoPlay";
            this.btnTwoPlay.Size = new System.Drawing.Size(112, 57);
            this.btnTwoPlay.TabIndex = 1;
            this.btnTwoPlay.Text = "6 تایی";
            this.btnTwoPlay.UseVisualStyleBackColor = true;
            // 
            // OneOrTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(263, 88);
            this.Controls.Add(this.btnTwoPlay);
            this.Controls.Add(this.btnOnePlay);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OneOrTwo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   انتخاب نوع بازی";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnePlay;
        private System.Windows.Forms.Button btnTwoPlay;
    }
}