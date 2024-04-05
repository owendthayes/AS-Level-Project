namespace Coursework_Quiz_Game
{
    partial class HardQuestionForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardQuestionForm3));
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblRangeQ = new System.Windows.Forms.Label();
            this.lblMedianQ = new System.Windows.Forms.Label();
            this.lblMeanQ = new System.Windows.Forms.Label();
            this.cmbBox4 = new System.Windows.Forms.ComboBox();
            this.cmbBox3 = new System.Windows.Forms.ComboBox();
            this.cmbBox2 = new System.Windows.Forms.ComboBox();
            this.lblModeQ = new System.Windows.Forms.Label();
            this.cmbBox1 = new System.Windows.Forms.ComboBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblTimeUp = new System.Windows.Forms.Label();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.questionTime = new System.Windows.Forms.Timer(this.components);
            this.btnUnpause = new System.Windows.Forms.Button();
            this.msgIncorrectAns = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.Color.Purple;
            this.btnSubmitAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSubmitAnswer.Location = new System.Drawing.Point(599, 385);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(123, 66);
            this.btnSubmitAnswer.TabIndex = 64;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblRangeQ
            // 
            this.lblRangeQ.AutoSize = true;
            this.lblRangeQ.BackColor = System.Drawing.Color.Purple;
            this.lblRangeQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangeQ.Location = new System.Drawing.Point(206, 278);
            this.lblRangeQ.Name = "lblRangeQ";
            this.lblRangeQ.Size = new System.Drawing.Size(464, 25);
            this.lblRangeQ.TabIndex = 63;
            this.lblRangeQ.Text = "The distance between the highest and lowest values";
            this.lblRangeQ.Click += new System.EventHandler(this.lblRangeQ_Click);
            // 
            // lblMedianQ
            // 
            this.lblMedianQ.AutoSize = true;
            this.lblMedianQ.BackColor = System.Drawing.Color.Purple;
            this.lblMedianQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedianQ.ForeColor = System.Drawing.Color.White;
            this.lblMedianQ.Location = new System.Drawing.Point(209, 233);
            this.lblMedianQ.Name = "lblMedianQ";
            this.lblMedianQ.Size = new System.Drawing.Size(342, 25);
            this.lblMedianQ.TabIndex = 62;
            this.lblMedianQ.Text = "Is the middle value in a set of numbers";
            // 
            // lblMeanQ
            // 
            this.lblMeanQ.AutoSize = true;
            this.lblMeanQ.BackColor = System.Drawing.Color.Purple;
            this.lblMeanQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeanQ.Location = new System.Drawing.Point(211, 375);
            this.lblMeanQ.Name = "lblMeanQ";
            this.lblMeanQ.Size = new System.Drawing.Size(343, 25);
            this.lblMeanQ.TabIndex = 61;
            this.lblMeanQ.Text = "the average value for a set of numbers";
            // 
            // cmbBox4
            // 
            this.cmbBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox4.FormattingEnabled = true;
            this.cmbBox4.Items.AddRange(new object[] {
            "Mean",
            "Median",
            "Mode",
            "Range"});
            this.cmbBox4.Location = new System.Drawing.Point(63, 278);
            this.cmbBox4.Name = "cmbBox4";
            this.cmbBox4.Size = new System.Drawing.Size(121, 33);
            this.cmbBox4.TabIndex = 60;
            // 
            // cmbBox3
            // 
            this.cmbBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox3.FormattingEnabled = true;
            this.cmbBox3.Items.AddRange(new object[] {
            "Mean",
            "Median",
            "Mode",
            "Range"});
            this.cmbBox3.Location = new System.Drawing.Point(62, 231);
            this.cmbBox3.Name = "cmbBox3";
            this.cmbBox3.Size = new System.Drawing.Size(121, 33);
            this.cmbBox3.TabIndex = 59;
            // 
            // cmbBox2
            // 
            this.cmbBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox2.FormattingEnabled = true;
            this.cmbBox2.Items.AddRange(new object[] {
            "Mean",
            "Median",
            "Mode",
            "Range"});
            this.cmbBox2.Location = new System.Drawing.Point(63, 373);
            this.cmbBox2.Name = "cmbBox2";
            this.cmbBox2.Size = new System.Drawing.Size(121, 33);
            this.cmbBox2.TabIndex = 58;
            // 
            // lblModeQ
            // 
            this.lblModeQ.AutoSize = true;
            this.lblModeQ.BackColor = System.Drawing.Color.Purple;
            this.lblModeQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeQ.Location = new System.Drawing.Point(208, 325);
            this.lblModeQ.Name = "lblModeQ";
            this.lblModeQ.Size = new System.Drawing.Size(293, 25);
            this.lblModeQ.TabIndex = 57;
            this.lblModeQ.Text = "The most popular/frequent value";
            // 
            // cmbBox1
            // 
            this.cmbBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox1.FormattingEnabled = true;
            this.cmbBox1.Items.AddRange(new object[] {
            "Mean",
            "Median",
            "Mode",
            "Range"});
            this.cmbBox1.Location = new System.Drawing.Point(62, 324);
            this.cmbBox1.Name = "cmbBox1";
            this.cmbBox1.Size = new System.Drawing.Size(121, 33);
            this.cmbBox1.TabIndex = 56;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(58, 196);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(399, 25);
            this.lblQuestion.TabIndex = 55;
            this.lblQuestion.Text = "Match the terms to the appropriate definitions";
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.BackColor = System.Drawing.Color.Purple;
            this.lblQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNo.Location = new System.Drawing.Point(54, 168);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(181, 25);
            this.lblQuestionNo.TabIndex = 54;
            this.lblQuestionNo.Text = "Question Number 3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Purple;
            this.pictureBox2.Location = new System.Drawing.Point(42, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(695, 305);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.Purple;
            this.btnNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNextQuestion.Location = new System.Drawing.Point(958, 420);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(219, 72);
            this.btnNextQuestion.TabIndex = 66;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Purple;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Location = new System.Drawing.Point(1190, 193);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(70, 70);
            this.btnHelp.TabIndex = 67;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblTimeUp
            // 
            this.lblTimeUp.AutoSize = true;
            this.lblTimeUp.BackColor = System.Drawing.Color.Purple;
            this.lblTimeUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTimeUp.Location = new System.Drawing.Point(2, 481);
            this.lblTimeUp.Name = "lblTimeUp";
            this.lblTimeUp.Size = new System.Drawing.Size(679, 94);
            this.lblTimeUp.TabIndex = 68;
            this.lblTimeUp.Text = "Time Up!\r\nPlease move on to the next question!";
            this.lblTimeUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimeUp.UseWaitCursor = true;
            this.lblTimeUp.Visible = false;
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.AutoSize = true;
            this.lblDisplayTime.BackColor = System.Drawing.Color.Purple;
            this.lblDisplayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDisplayTime.Location = new System.Drawing.Point(857, 45);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(135, 31);
            this.lblDisplayTime.TabIndex = 69;
            this.lblDisplayTime.Text = "Time Left:";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.BackColor = System.Drawing.Color.Purple;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTimeLeft.Location = new System.Drawing.Point(1003, 45);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(44, 31);
            this.lblTimeLeft.TabIndex = 70;
            this.lblTimeLeft.Text = "30";
            // 
            // questionTime
            // 
            this.questionTime.Interval = 1000;
            this.questionTime.Tick += new System.EventHandler(this.questionTime_Tick);
            // 
            // btnUnpause
            // 
            this.btnUnpause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUnpause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnUnpause.Location = new System.Drawing.Point(12, 117);
            this.btnUnpause.Name = "btnUnpause";
            this.btnUnpause.Size = new System.Drawing.Size(1248, 458);
            this.btnUnpause.TabIndex = 71;
            this.btnUnpause.Text = "Game Paused\r\nClick here to resume\r\n";
            this.btnUnpause.UseVisualStyleBackColor = false;
            this.btnUnpause.Visible = false;
            this.btnUnpause.Click += new System.EventHandler(this.btnUnpause_Click);
            // 
            // msgIncorrectAns
            // 
            this.msgIncorrectAns.AutoSize = true;
            this.msgIncorrectAns.BackColor = System.Drawing.Color.Purple;
            this.msgIncorrectAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgIncorrectAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.msgIncorrectAns.Location = new System.Drawing.Point(13, 481);
            this.msgIncorrectAns.Name = "msgIncorrectAns";
            this.msgIncorrectAns.Size = new System.Drawing.Size(668, 94);
            this.msgIncorrectAns.TabIndex = 72;
            this.msgIncorrectAns.Text = "Incorrect Answer! Unlucky!\r\nPlease move on to the next question\r\n";
            this.msgIncorrectAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgIncorrectAns.UseWaitCursor = true;
            this.msgIncorrectAns.Visible = false;
            this.msgIncorrectAns.Click += new System.EventHandler(this.msgIncorrectAns_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Purple;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.Location = new System.Drawing.Point(1190, 269);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 62);
            this.btnLogout.TabIndex = 73;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1272, 25);
            this.toolStrip1.TabIndex = 74;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // HardQuestionForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.btnUnpause);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.msgIncorrectAns);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblDisplayTime);
            this.Controls.Add(this.lblTimeUp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.lblRangeQ);
            this.Controls.Add(this.lblMedianQ);
            this.Controls.Add(this.lblMeanQ);
            this.Controls.Add(this.cmbBox4);
            this.Controls.Add(this.cmbBox3);
            this.Controls.Add(this.cmbBox2);
            this.Controls.Add(this.lblModeQ);
            this.Controls.Add(this.cmbBox1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestionNo);
            this.Controls.Add(this.pictureBox2);
            this.Name = "HardQuestionForm3";
            this.Text = "HardQuestionForm3";
            this.Controls.SetChildIndex(this.UserInfoBackround, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblDisplayUsername, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblDisplayScore, 0);
            this.Controls.SetChildIndex(this.imgAvatar, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.lblDisplayHighscore, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.lblQuestionNo, 0);
            this.Controls.SetChildIndex(this.lblQuestion, 0);
            this.Controls.SetChildIndex(this.cmbBox1, 0);
            this.Controls.SetChildIndex(this.lblModeQ, 0);
            this.Controls.SetChildIndex(this.cmbBox2, 0);
            this.Controls.SetChildIndex(this.cmbBox3, 0);
            this.Controls.SetChildIndex(this.cmbBox4, 0);
            this.Controls.SetChildIndex(this.lblMeanQ, 0);
            this.Controls.SetChildIndex(this.lblMedianQ, 0);
            this.Controls.SetChildIndex(this.lblRangeQ, 0);
            this.Controls.SetChildIndex(this.btnSubmitAnswer, 0);
            this.Controls.SetChildIndex(this.btnNextQuestion, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.lblTimeUp, 0);
            this.Controls.SetChildIndex(this.lblDisplayTime, 0);
            this.Controls.SetChildIndex(this.lblTimeLeft, 0);
            this.Controls.SetChildIndex(this.msgIncorrectAns, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.btnUnpause, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblRangeQ;
        private System.Windows.Forms.Label lblMedianQ;
        private System.Windows.Forms.Label lblMeanQ;
        private System.Windows.Forms.ComboBox cmbBox4;
        private System.Windows.Forms.ComboBox cmbBox3;
        private System.Windows.Forms.ComboBox cmbBox2;
        private System.Windows.Forms.Label lblModeQ;
        private System.Windows.Forms.ComboBox cmbBox1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblTimeUp;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer questionTime;
        private System.Windows.Forms.Button btnUnpause;
        private System.Windows.Forms.Label msgIncorrectAns;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}