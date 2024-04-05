namespace Coursework_Quiz_Game
{
    partial class QuestionForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm3));
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.cmbBox1 = new System.Windows.Forms.ComboBox();
            this.lblMutliplicationQ = new System.Windows.Forms.Label();
            this.cmbBox2 = new System.Windows.Forms.ComboBox();
            this.cmbBox3 = new System.Windows.Forms.ComboBox();
            this.cmbBox4 = new System.Windows.Forms.ComboBox();
            this.lblAdditionQ = new System.Windows.Forms.Label();
            this.lblSubtractQ = new System.Windows.Forms.Label();
            this.lblDivisionQ = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblDisplayTimer = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.questionTime = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblTimeUp = new System.Windows.Forms.Label();
            this.btnUnpause = new System.Windows.Forms.Button();
            this.msgIncorrectAns = new System.Windows.Forms.Label();
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
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.BackColor = System.Drawing.Color.Purple;
            this.lblQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuestionNo.Location = new System.Drawing.Point(76, 192);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(165, 25);
            this.lblQuestionNo.TabIndex = 37;
            this.lblQuestionNo.Text = "Question Number";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuestion.Location = new System.Drawing.Point(86, 219);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(91, 25);
            this.lblQuestion.TabIndex = 38;
            this.lblQuestion.Text = "Question";
            // 
            // cmbBox1
            // 
            this.cmbBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbBox1.FormattingEnabled = true;
            this.cmbBox1.Items.AddRange(new object[] {
            "Multiplication",
            "Addition",
            "Subtraction",
            "Division"});
            this.cmbBox1.Location = new System.Drawing.Point(70, 338);
            this.cmbBox1.Name = "cmbBox1";
            this.cmbBox1.Size = new System.Drawing.Size(121, 33);
            this.cmbBox1.TabIndex = 40;
            this.cmbBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMutliplicationQ
            // 
            this.lblMutliplicationQ.AutoSize = true;
            this.lblMutliplicationQ.BackColor = System.Drawing.Color.Purple;
            this.lblMutliplicationQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMutliplicationQ.Location = new System.Drawing.Point(197, 341);
            this.lblMutliplicationQ.Name = "lblMutliplicationQ";
            this.lblMutliplicationQ.Size = new System.Drawing.Size(644, 25);
            this.lblMutliplicationQ.TabIndex = 41;
            this.lblMutliplicationQ.Text = "Is when you times a number by another number for the product of the two.";
            // 
            // cmbBox2
            // 
            this.cmbBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbBox2.FormattingEnabled = true;
            this.cmbBox2.Items.AddRange(new object[] {
            "Multiplication",
            "Addition",
            "Subtraction",
            "Division"});
            this.cmbBox2.Location = new System.Drawing.Point(70, 381);
            this.cmbBox2.Name = "cmbBox2";
            this.cmbBox2.Size = new System.Drawing.Size(121, 33);
            this.cmbBox2.TabIndex = 42;
            // 
            // cmbBox3
            // 
            this.cmbBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbBox3.FormattingEnabled = true;
            this.cmbBox3.Items.AddRange(new object[] {
            "Multiplication",
            "Addition",
            "Subtraction",
            "Division"});
            this.cmbBox3.Location = new System.Drawing.Point(70, 247);
            this.cmbBox3.Name = "cmbBox3";
            this.cmbBox3.Size = new System.Drawing.Size(121, 33);
            this.cmbBox3.TabIndex = 43;
            // 
            // cmbBox4
            // 
            this.cmbBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbBox4.FormattingEnabled = true;
            this.cmbBox4.Items.AddRange(new object[] {
            "Multiplication",
            "Addition",
            "Subtraction",
            "Division"});
            this.cmbBox4.Location = new System.Drawing.Point(70, 293);
            this.cmbBox4.Name = "cmbBox4";
            this.cmbBox4.Size = new System.Drawing.Size(121, 33);
            this.cmbBox4.TabIndex = 44;
            // 
            // lblAdditionQ
            // 
            this.lblAdditionQ.AutoSize = true;
            this.lblAdditionQ.BackColor = System.Drawing.Color.Purple;
            this.lblAdditionQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAdditionQ.Location = new System.Drawing.Point(197, 384);
            this.lblAdditionQ.Name = "lblAdditionQ";
            this.lblAdditionQ.Size = new System.Drawing.Size(504, 25);
            this.lblAdditionQ.TabIndex = 45;
            this.lblAdditionQ.Text = "Is when two numbers are joined together for a larger total.";
            // 
            // lblSubtractQ
            // 
            this.lblSubtractQ.AutoSize = true;
            this.lblSubtractQ.BackColor = System.Drawing.Color.Purple;
            this.lblSubtractQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSubtractQ.ForeColor = System.Drawing.Color.White;
            this.lblSubtractQ.Location = new System.Drawing.Point(197, 250);
            this.lblSubtractQ.Name = "lblSubtractQ";
            this.lblSubtractQ.Size = new System.Drawing.Size(534, 25);
            this.lblSubtractQ.TabIndex = 46;
            this.lblSubtractQ.Text = "Is the method of finding the difference between two numbers.";
            // 
            // lblDivisionQ
            // 
            this.lblDivisionQ.AutoSize = true;
            this.lblDivisionQ.BackColor = System.Drawing.Color.Purple;
            this.lblDivisionQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDivisionQ.Location = new System.Drawing.Point(197, 296);
            this.lblDivisionQ.Name = "lblDivisionQ";
            this.lblDivisionQ.Size = new System.Drawing.Size(644, 25);
            this.lblDivisionQ.TabIndex = 47;
            this.lblDivisionQ.Text = "Is used when finding how many times another number can fit into another.";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.Purple;
            this.btnNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNextQuestion.Location = new System.Drawing.Point(969, 423);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(208, 69);
            this.btnNextQuestion.TabIndex = 48;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.Color.Purple;
            this.btnSubmitAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSubmitAnswer.Location = new System.Drawing.Point(718, 422);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(147, 71);
            this.btnSubmitAnswer.TabIndex = 49;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Purple;
            this.pictureBox2.Location = new System.Drawing.Point(54, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(822, 319);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Purple;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.Location = new System.Drawing.Point(1190, 269);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 62);
            this.btnLogout.TabIndex = 51;
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
            this.lblDisplayTimer.TabIndex = 60;
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
            this.lblTimeRemaining.TabIndex = 61;
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
            this.btnHelp.Location = new System.Drawing.Point(1190, 192);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(70, 70);
            this.btnHelp.TabIndex = 62;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // lblTimeUp
            // 
            this.lblTimeUp.AutoSize = true;
            this.lblTimeUp.BackColor = System.Drawing.Color.Purple;
            this.lblTimeUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTimeUp.Location = new System.Drawing.Point(25, 534);
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
            this.msgIncorrectAns.Location = new System.Drawing.Point(24, 534);
            this.msgIncorrectAns.Name = "msgIncorrectAns";
            this.msgIncorrectAns.Size = new System.Drawing.Size(668, 94);
            this.msgIncorrectAns.TabIndex = 66;
            this.msgIncorrectAns.Text = "Incorrect Answer! Unlucky!\r\nPlease move on to the next question\r\n";
            this.msgIncorrectAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgIncorrectAns.UseWaitCursor = true;
            this.msgIncorrectAns.Visible = false;
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
            // QuestionForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.btnUnpause);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msgIncorrectAns);
            this.Controls.Add(this.lblTimeUp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblDisplayTimer);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.lblDivisionQ);
            this.Controls.Add(this.lblSubtractQ);
            this.Controls.Add(this.lblAdditionQ);
            this.Controls.Add(this.cmbBox4);
            this.Controls.Add(this.cmbBox3);
            this.Controls.Add(this.cmbBox2);
            this.Controls.Add(this.lblMutliplicationQ);
            this.Controls.Add(this.cmbBox1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestionNo);
            this.Controls.Add(this.pictureBox2);
            this.Name = "QuestionForm3";
            this.Text = "QuestionForm3";
            this.Load += new System.EventHandler(this.QuestionForm3_Load);
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
            this.Controls.SetChildIndex(this.lblMutliplicationQ, 0);
            this.Controls.SetChildIndex(this.cmbBox2, 0);
            this.Controls.SetChildIndex(this.cmbBox3, 0);
            this.Controls.SetChildIndex(this.cmbBox4, 0);
            this.Controls.SetChildIndex(this.lblAdditionQ, 0);
            this.Controls.SetChildIndex(this.lblSubtractQ, 0);
            this.Controls.SetChildIndex(this.lblDivisionQ, 0);
            this.Controls.SetChildIndex(this.btnNextQuestion, 0);
            this.Controls.SetChildIndex(this.btnSubmitAnswer, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.lblDisplayTimer, 0);
            this.Controls.SetChildIndex(this.lblTimeRemaining, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.lblTimeUp, 0);
            this.Controls.SetChildIndex(this.msgIncorrectAns, 0);
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
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ComboBox cmbBox1;
        private System.Windows.Forms.Label lblMutliplicationQ;
        private System.Windows.Forms.ComboBox cmbBox2;
        private System.Windows.Forms.ComboBox cmbBox3;
        private System.Windows.Forms.ComboBox cmbBox4;
        private System.Windows.Forms.Label lblAdditionQ;
        private System.Windows.Forms.Label lblSubtractQ;
        private System.Windows.Forms.Label lblDivisionQ;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblDisplayTimer;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Timer questionTime;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblTimeUp;
        private System.Windows.Forms.Button btnUnpause;
        private System.Windows.Forms.Label msgIncorrectAns;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}