namespace Coursework_Quiz_Game
{
    partial class QuestionForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm2));
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.rdbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rdbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rdbAnswer3 = new System.Windows.Forms.RadioButton();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblDisplayTimer = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.questionTime = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblTimeUp = new System.Windows.Forms.Label();
            this.btnUnpause = new System.Windows.Forms.Button();
            this.msgIncorrectAns = new System.Windows.Forms.Label();
            this.msgCorrectAns = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.BackColor = System.Drawing.Color.Purple;
            this.lblQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuestionNo.Location = new System.Drawing.Point(63, 193);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(165, 25);
            this.lblQuestionNo.TabIndex = 24;
            this.lblQuestionNo.Text = "Question Number";
            this.lblQuestionNo.Click += new System.EventHandler(this.lblQuestionNo_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuestion.Location = new System.Drawing.Point(63, 227);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(91, 25);
            this.lblQuestion.TabIndex = 25;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.Color.Purple;
            this.btnSubmitAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSubmitAnswer.Location = new System.Drawing.Point(422, 366);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(140, 61);
            this.btnSubmitAnswer.TabIndex = 26;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // rdbAnswer1
            // 
            this.rdbAnswer1.AutoSize = true;
            this.rdbAnswer1.BackColor = System.Drawing.Color.Purple;
            this.rdbAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rdbAnswer1.Location = new System.Drawing.Point(212, 261);
            this.rdbAnswer1.Name = "rdbAnswer1";
            this.rdbAnswer1.Size = new System.Drawing.Size(140, 29);
            this.rdbAnswer1.TabIndex = 27;
            this.rdbAnswer1.TabStop = true;
            this.rdbAnswer1.Text = "radioButton1";
            this.rdbAnswer1.UseVisualStyleBackColor = false;
            this.rdbAnswer1.CheckedChanged += new System.EventHandler(this.rdbAnswer1_CheckedChanged);
            // 
            // rdbAnswer2
            // 
            this.rdbAnswer2.AutoSize = true;
            this.rdbAnswer2.BackColor = System.Drawing.Color.Purple;
            this.rdbAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rdbAnswer2.Location = new System.Drawing.Point(212, 290);
            this.rdbAnswer2.Name = "rdbAnswer2";
            this.rdbAnswer2.Size = new System.Drawing.Size(140, 29);
            this.rdbAnswer2.TabIndex = 28;
            this.rdbAnswer2.TabStop = true;
            this.rdbAnswer2.Text = "radioButton2";
            this.rdbAnswer2.UseVisualStyleBackColor = false;
            this.rdbAnswer2.CheckedChanged += new System.EventHandler(this.rdbAnswer2_CheckedChanged);
            // 
            // rdbAnswer3
            // 
            this.rdbAnswer3.AutoSize = true;
            this.rdbAnswer3.BackColor = System.Drawing.Color.Purple;
            this.rdbAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rdbAnswer3.Location = new System.Drawing.Point(212, 319);
            this.rdbAnswer3.Name = "rdbAnswer3";
            this.rdbAnswer3.Size = new System.Drawing.Size(140, 29);
            this.rdbAnswer3.TabIndex = 29;
            this.rdbAnswer3.TabStop = true;
            this.rdbAnswer3.Text = "radioButton3";
            this.rdbAnswer3.UseVisualStyleBackColor = false;
            this.rdbAnswer3.CheckedChanged += new System.EventHandler(this.rdbAnswer3_CheckedChanged);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.Purple;
            this.btnNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNextQuestion.Location = new System.Drawing.Point(980, 418);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(197, 74);
            this.btnNextQuestion.TabIndex = 30;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Purple;
            this.pictureBox2.Location = new System.Drawing.Point(50, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 232);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Purple;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.Location = new System.Drawing.Point(1190, 269);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 62);
            this.btnLogout.TabIndex = 39;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblDisplayTimer
            // 
            this.lblDisplayTimer.AutoSize = true;
            this.lblDisplayTimer.BackColor = System.Drawing.Color.Purple;
            this.lblDisplayTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDisplayTimer.Location = new System.Drawing.Point(907, 67);
            this.lblDisplayTimer.Name = "lblDisplayTimer";
            this.lblDisplayTimer.Size = new System.Drawing.Size(135, 31);
            this.lblDisplayTimer.TabIndex = 59;
            this.lblDisplayTimer.Text = "Time Left:";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.BackColor = System.Drawing.Color.Purple;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTimeRemaining.Location = new System.Drawing.Point(1048, 67);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(44, 31);
            this.lblTimeRemaining.TabIndex = 60;
            this.lblTimeRemaining.Text = "60";
            // 
            // questionTime
            // 
            this.questionTime.Interval = 1000;
            this.questionTime.Tick += new System.EventHandler(this.questionTime_Tick);
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
            this.btnHelp.TabIndex = 61;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // lblTimeUp
            // 
            this.lblTimeUp.AutoSize = true;
            this.lblTimeUp.BackColor = System.Drawing.Color.Purple;
            this.lblTimeUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTimeUp.Location = new System.Drawing.Point(12, 481);
            this.lblTimeUp.Name = "lblTimeUp";
            this.lblTimeUp.Size = new System.Drawing.Size(679, 94);
            this.lblTimeUp.TabIndex = 63;
            this.lblTimeUp.Text = "Time Up!\r\nPlease move on to the next question!";
            this.lblTimeUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimeUp.UseWaitCursor = true;
            this.lblTimeUp.Visible = false;
            // 
            // btnUnpause
            // 
            this.btnUnpause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUnpause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnUnpause.Location = new System.Drawing.Point(12, 117);
            this.btnUnpause.Name = "btnUnpause";
            this.btnUnpause.Size = new System.Drawing.Size(1248, 458);
            this.btnUnpause.TabIndex = 64;
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
            this.msgIncorrectAns.Location = new System.Drawing.Point(12, 481);
            this.msgIncorrectAns.Name = "msgIncorrectAns";
            this.msgIncorrectAns.Size = new System.Drawing.Size(668, 94);
            this.msgIncorrectAns.TabIndex = 66;
            this.msgIncorrectAns.Text = "Incorrect Answer! Unlucky!\r\nPlease move on to the next question\r\n";
            this.msgIncorrectAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgIncorrectAns.UseWaitCursor = true;
            this.msgIncorrectAns.Visible = false;
            // 
            // msgCorrectAns
            // 
            this.msgCorrectAns.AutoSize = true;
            this.msgCorrectAns.BackColor = System.Drawing.Color.Purple;
            this.msgCorrectAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgCorrectAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.msgCorrectAns.Location = new System.Drawing.Point(12, 481);
            this.msgCorrectAns.Name = "msgCorrectAns";
            this.msgCorrectAns.Size = new System.Drawing.Size(668, 94);
            this.msgCorrectAns.TabIndex = 67;
            this.msgCorrectAns.Text = "Correct Answer! Well done!\r\nPlease move on to the next question\r\n";
            this.msgCorrectAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgCorrectAns.UseWaitCursor = true;
            this.msgCorrectAns.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Purple;
            this.pictureBox5.Location = new System.Drawing.Point(49, 175);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(529, 266);
            this.pictureBox5.TabIndex = 68;
            this.pictureBox5.TabStop = false;
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
            this.toolStrip1.TabIndex = 71;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // QuestionForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnUnpause);
            this.Controls.Add(this.rdbAnswer3);
            this.Controls.Add(this.rdbAnswer2);
            this.Controls.Add(this.rdbAnswer1);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestionNo);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.msgCorrectAns);
            this.Controls.Add(this.msgIncorrectAns);
            this.Controls.Add(this.lblTimeUp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblDisplayTimer);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnNextQuestion);
            this.Name = "QuestionForm2";
            this.Text = "QuestionForm2";
            this.Controls.SetChildIndex(this.btnNextQuestion, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.lblDisplayTimer, 0);
            this.Controls.SetChildIndex(this.lblTimeRemaining, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.lblTimeUp, 0);
            this.Controls.SetChildIndex(this.msgIncorrectAns, 0);
            this.Controls.SetChildIndex(this.msgCorrectAns, 0);
            this.Controls.SetChildIndex(this.UserInfoBackround, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblDisplayUsername, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblDisplayScore, 0);
            this.Controls.SetChildIndex(this.imgAvatar, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.lblDisplayHighscore, 0);
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.lblQuestionNo, 0);
            this.Controls.SetChildIndex(this.lblQuestion, 0);
            this.Controls.SetChildIndex(this.btnSubmitAnswer, 0);
            this.Controls.SetChildIndex(this.rdbAnswer1, 0);
            this.Controls.SetChildIndex(this.rdbAnswer2, 0);
            this.Controls.SetChildIndex(this.rdbAnswer3, 0);
            this.Controls.SetChildIndex(this.btnUnpause, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.RadioButton rdbAnswer1;
        private System.Windows.Forms.RadioButton rdbAnswer2;
        private System.Windows.Forms.RadioButton rdbAnswer3;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblDisplayTimer;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Timer questionTime;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblTimeUp;
        private System.Windows.Forms.Button btnUnpause;
        private System.Windows.Forms.Label msgIncorrectAns;
        private System.Windows.Forms.Label msgCorrectAns;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}