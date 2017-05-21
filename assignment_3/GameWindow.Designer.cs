namespace assignment_3
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            this.teamTwoPlyrSlt = new System.Windows.Forms.ComboBox();
            this.teamOnePlyrSlt = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.teamTwoScoreLbl = new System.Windows.Forms.Label();
            this.timerLbl = new System.Windows.Forms.Label();
            this.teamOneScoreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.t2DropBtn = new System.Windows.Forms.Button();
            this.t2PenBtn = new System.Windows.Forms.Button();
            this.t2ConvertBtn = new System.Windows.Forms.Button();
            this.t2TryBtn = new System.Windows.Forms.Button();
            this.t1DropBtn = new System.Windows.Forms.Button();
            this.t1PenBtn = new System.Windows.Forms.Button();
            this.t1ConvertBtn = new System.Windows.Forms.Button();
            this.t1TryBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teamOneGmeWinPicBx = new System.Windows.Forms.PictureBox();
            this.teamTwoGmeWinPicBx = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneGmeWinPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamTwoGmeWinPicBx)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamTwoPlyrSlt
            // 
            this.teamTwoPlyrSlt.FormattingEnabled = true;
            this.teamTwoPlyrSlt.Location = new System.Drawing.Point(587, 405);
            this.teamTwoPlyrSlt.Name = "teamTwoPlyrSlt";
            this.teamTwoPlyrSlt.Size = new System.Drawing.Size(121, 21);
            this.teamTwoPlyrSlt.TabIndex = 52;
            this.teamTwoPlyrSlt.Text = "Team Two Players";
            this.teamTwoPlyrSlt.SelectedIndexChanged += new System.EventHandler(this.TeamTwoPlyrSlt_SelectedIndexChanged);
            // 
            // teamOnePlyrSlt
            // 
            this.teamOnePlyrSlt.FormattingEnabled = true;
            this.teamOnePlyrSlt.Location = new System.Drawing.Point(125, 405);
            this.teamOnePlyrSlt.Name = "teamOnePlyrSlt";
            this.teamOnePlyrSlt.Size = new System.Drawing.Size(121, 21);
            this.teamOnePlyrSlt.TabIndex = 51;
            this.teamOnePlyrSlt.Text = "Team One Players";
            this.teamOnePlyrSlt.SelectedIndexChanged += new System.EventHandler(this.TeamOnePlyrSlt_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(81, 446);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(669, 160);
            this.listBox1.TabIndex = 50;
            // 
            // teamTwoScoreLbl
            // 
            this.teamTwoScoreLbl.AutoSize = true;
            this.teamTwoScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.teamTwoScoreLbl.Location = new System.Drawing.Point(517, 284);
            this.teamTwoScoreLbl.Name = "teamTwoScoreLbl";
            this.teamTwoScoreLbl.Size = new System.Drawing.Size(18, 20);
            this.teamTwoScoreLbl.TabIndex = 49;
            this.teamTwoScoreLbl.Text = "0";
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timerLbl.Location = new System.Drawing.Point(391, 330);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(49, 20);
            this.timerLbl.TabIndex = 48;
            this.timerLbl.Text = "00:00";
            // 
            // teamOneScoreLbl
            // 
            this.teamOneScoreLbl.AutoSize = true;
            this.teamOneScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.teamOneScoreLbl.Location = new System.Drawing.Point(294, 284);
            this.teamOneScoreLbl.Name = "teamOneScoreLbl";
            this.teamOneScoreLbl.Size = new System.Drawing.Size(18, 20);
            this.teamOneScoreLbl.TabIndex = 47;
            this.teamOneScoreLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(389, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Score";
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(469, 373);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(75, 23);
            this.endBtn.TabIndex = 45;
            this.endBtn.Text = "End";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(378, 373);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 44;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(287, 373);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 43;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // t2DropBtn
            // 
            this.t2DropBtn.Location = new System.Drawing.Point(610, 332);
            this.t2DropBtn.Name = "t2DropBtn";
            this.t2DropBtn.Size = new System.Drawing.Size(75, 23);
            this.t2DropBtn.TabIndex = 42;
            this.t2DropBtn.Text = "Drop Kick";
            this.t2DropBtn.UseVisualStyleBackColor = true;
            this.t2DropBtn.Click += new System.EventHandler(this.TeamTwoDropBtn_Click);
            // 
            // t2PenBtn
            // 
            this.t2PenBtn.Location = new System.Drawing.Point(610, 303);
            this.t2PenBtn.Name = "t2PenBtn";
            this.t2PenBtn.Size = new System.Drawing.Size(75, 23);
            this.t2PenBtn.TabIndex = 41;
            this.t2PenBtn.Text = "Penalty";
            this.t2PenBtn.UseVisualStyleBackColor = true;
            this.t2PenBtn.Click += new System.EventHandler(this.TeamTwoPenBtn_Click);
            // 
            // t2ConvertBtn
            // 
            this.t2ConvertBtn.Location = new System.Drawing.Point(610, 274);
            this.t2ConvertBtn.Name = "t2ConvertBtn";
            this.t2ConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.t2ConvertBtn.TabIndex = 40;
            this.t2ConvertBtn.Text = "Conversion";
            this.t2ConvertBtn.UseVisualStyleBackColor = true;
            this.t2ConvertBtn.Click += new System.EventHandler(this.TeamTwoConvertBtn_Click);
            // 
            // t2TryBtn
            // 
            this.t2TryBtn.Location = new System.Drawing.Point(610, 245);
            this.t2TryBtn.Name = "t2TryBtn";
            this.t2TryBtn.Size = new System.Drawing.Size(75, 23);
            this.t2TryBtn.TabIndex = 39;
            this.t2TryBtn.Text = "Try";
            this.t2TryBtn.UseVisualStyleBackColor = true;
            this.t2TryBtn.Click += new System.EventHandler(this.TeamTwoTryBtn_Click);
            // 
            // t1DropBtn
            // 
            this.t1DropBtn.Location = new System.Drawing.Point(148, 330);
            this.t1DropBtn.Name = "t1DropBtn";
            this.t1DropBtn.Size = new System.Drawing.Size(75, 23);
            this.t1DropBtn.TabIndex = 38;
            this.t1DropBtn.Text = "Drop Kick";
            this.t1DropBtn.UseVisualStyleBackColor = true;
            this.t1DropBtn.Click += new System.EventHandler(this.TeamOneDropBtn_Click);
            // 
            // t1PenBtn
            // 
            this.t1PenBtn.Location = new System.Drawing.Point(148, 301);
            this.t1PenBtn.Name = "t1PenBtn";
            this.t1PenBtn.Size = new System.Drawing.Size(75, 23);
            this.t1PenBtn.TabIndex = 37;
            this.t1PenBtn.Text = "Penalty";
            this.t1PenBtn.UseVisualStyleBackColor = true;
            this.t1PenBtn.Click += new System.EventHandler(this.TeamOnePenBtn_Click);
            // 
            // t1ConvertBtn
            // 
            this.t1ConvertBtn.Location = new System.Drawing.Point(148, 272);
            this.t1ConvertBtn.Name = "t1ConvertBtn";
            this.t1ConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.t1ConvertBtn.TabIndex = 36;
            this.t1ConvertBtn.Text = "Conversion";
            this.t1ConvertBtn.UseVisualStyleBackColor = true;
            this.t1ConvertBtn.Click += new System.EventHandler(this.TeamOneConvertBtn_Click);
            // 
            // t1TryBtn
            // 
            this.t1TryBtn.Location = new System.Drawing.Point(148, 243);
            this.t1TryBtn.Name = "t1TryBtn";
            this.t1TryBtn.Size = new System.Drawing.Size(75, 23);
            this.t1TryBtn.TabIndex = 35;
            this.t1TryBtn.Text = "Try";
            this.t1TryBtn.UseVisualStyleBackColor = true;
            this.t1TryBtn.Click += new System.EventHandler(this.TeamOneTryBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(320, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "The home of rugby statistics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(348, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "RugInfo";
            // 
            // teamOneGmeWinPicBx
            // 
            this.teamOneGmeWinPicBx.Location = new System.Drawing.Point(81, 99);
            this.teamOneGmeWinPicBx.Name = "teamOneGmeWinPicBx";
            this.teamOneGmeWinPicBx.Size = new System.Drawing.Size(208, 130);
            this.teamOneGmeWinPicBx.TabIndex = 32;
            this.teamOneGmeWinPicBx.TabStop = false;
            // 
            // teamTwoGmeWinPicBx
            // 
            this.teamTwoGmeWinPicBx.Location = new System.Drawing.Point(542, 99);
            this.teamTwoGmeWinPicBx.Name = "teamTwoGmeWinPicBx";
            this.teamTwoGmeWinPicBx.Size = new System.Drawing.Size(208, 130);
            this.teamTwoGmeWinPicBx.TabIndex = 31;
            this.teamTwoGmeWinPicBx.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 614);
            this.Controls.Add(this.teamTwoPlyrSlt);
            this.Controls.Add(this.teamOnePlyrSlt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.teamTwoScoreLbl);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.teamOneScoreLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.t2DropBtn);
            this.Controls.Add(this.t2PenBtn);
            this.Controls.Add(this.t2ConvertBtn);
            this.Controls.Add(this.t2TryBtn);
            this.Controls.Add(this.t1DropBtn);
            this.Controls.Add(this.t1PenBtn);
            this.Controls.Add(this.t1ConvertBtn);
            this.Controls.Add(this.t1TryBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamOneGmeWinPicBx);
            this.Controls.Add(this.teamTwoGmeWinPicBx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamOneGmeWinPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamTwoGmeWinPicBx)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox teamTwoPlyrSlt;
        private System.Windows.Forms.ComboBox teamOnePlyrSlt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label teamTwoScoreLbl;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Label teamOneScoreLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button t2DropBtn;
        private System.Windows.Forms.Button t2PenBtn;
        private System.Windows.Forms.Button t2ConvertBtn;
        private System.Windows.Forms.Button t2TryBtn;
        private System.Windows.Forms.Button t1DropBtn;
        private System.Windows.Forms.Button t1PenBtn;
        private System.Windows.Forms.Button t1ConvertBtn;
        private System.Windows.Forms.Button t1TryBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox teamOneGmeWinPicBx;
        private System.Windows.Forms.PictureBox teamTwoGmeWinPicBx;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}