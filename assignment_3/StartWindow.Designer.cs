namespace assignment_3
{
    partial class StartWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teamTwoSrtWinPicBx = new System.Windows.Forms.PictureBox();
            this.teamOneSrtWinPicBx = new System.Windows.Forms.PictureBox();
            this.teamTwoCmboBx = new System.Windows.Forms.ComboBox();
            this.teamOneCmboBx = new System.Windows.Forms.ComboBox();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.invalidLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamTwoSrtWinPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneSrtWinPicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(243, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "The home of rugby statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(167, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select two teams and hit start to create the game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(271, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "RugInfo";
            // 
            // teamTwoSrtWinPicBx
            // 
            this.teamTwoSrtWinPicBx.Location = new System.Drawing.Point(434, 176);
            this.teamTwoSrtWinPicBx.Name = "teamTwoSrtWinPicBx";
            this.teamTwoSrtWinPicBx.Size = new System.Drawing.Size(193, 115);
            this.teamTwoSrtWinPicBx.TabIndex = 13;
            this.teamTwoSrtWinPicBx.TabStop = false;
            // 
            // teamOneSrtWinPicBx
            // 
            this.teamOneSrtWinPicBx.Location = new System.Drawing.Point(60, 176);
            this.teamOneSrtWinPicBx.Name = "teamOneSrtWinPicBx";
            this.teamOneSrtWinPicBx.Size = new System.Drawing.Size(193, 115);
            this.teamOneSrtWinPicBx.TabIndex = 12;
            this.teamOneSrtWinPicBx.TabStop = false;
            // 
            // teamTwoCmboBx
            // 
            this.teamTwoCmboBx.FormattingEnabled = true;
            this.teamTwoCmboBx.Items.AddRange(new object[] {
            "Argentia",
            "Australia",
            "England",
            "France",
            "New Zealand",
            "South Africa"});
            this.teamTwoCmboBx.Location = new System.Drawing.Point(473, 322);
            this.teamTwoCmboBx.Name = "teamTwoCmboBx";
            this.teamTwoCmboBx.Size = new System.Drawing.Size(121, 21);
            this.teamTwoCmboBx.TabIndex = 11;
            this.teamTwoCmboBx.SelectedIndexChanged += new System.EventHandler(this.TeamTwoCmboBx_SelectedIndexChanged);
            // 
            // teamOneCmboBx
            // 
            this.teamOneCmboBx.FormattingEnabled = true;
            this.teamOneCmboBx.Items.AddRange(new object[] {
            "Argentia",
            "Australia",
            "England",
            "France",
            "New Zealand",
            "South Africa"});
            this.teamOneCmboBx.Location = new System.Drawing.Point(97, 322);
            this.teamOneCmboBx.Name = "teamOneCmboBx";
            this.teamOneCmboBx.Size = new System.Drawing.Size(121, 21);
            this.teamOneCmboBx.TabIndex = 10;
            this.teamOneCmboBx.SelectedIndexChanged += new System.EventHandler(this.TeamOneCmboBx_SelectedIndexChanged);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(304, 349);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(75, 23);
            this.newGameBtn.TabIndex = 9;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // invalidLbl
            // 
            this.invalidLbl.AutoSize = true;
            this.invalidLbl.ForeColor = System.Drawing.Color.Red;
            this.invalidLbl.Location = new System.Drawing.Point(265, 405);
            this.invalidLbl.Name = "invalidLbl";
            this.invalidLbl.Size = new System.Drawing.Size(154, 13);
            this.invalidLbl.TabIndex = 17;
            this.invalidLbl.Text = "* Can not select the same team";
            this.invalidLbl.Visible = false;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 452);
            this.Controls.Add(this.invalidLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamTwoSrtWinPicBx);
            this.Controls.Add(this.teamOneSrtWinPicBx);
            this.Controls.Add(this.teamTwoCmboBx);
            this.Controls.Add(this.teamOneCmboBx);
            this.Controls.Add(this.newGameBtn);
            this.Name = "StartWindow";
            this.Text = "StartWindow";
            this.Load += new System.EventHandler(this.StartWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamTwoSrtWinPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneSrtWinPicBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox teamTwoSrtWinPicBx;
        private System.Windows.Forms.PictureBox teamOneSrtWinPicBx;
        private System.Windows.Forms.ComboBox teamTwoCmboBx;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Label invalidLbl;
        private System.Windows.Forms.ComboBox teamOneCmboBx;
    }
}