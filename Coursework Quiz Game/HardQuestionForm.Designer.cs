namespace Coursework_Quiz_Game
{
    partial class HardQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardQuestionForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblEnterAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.questionTime = new System.Windows.Forms.Timer(this.components);
            this.lblTimeUp = new System.Windows.Forms.Label();
            this.btnUnpause = new System.Windows.Forms.Button();
            this.msgCorrectAns = new System.Windows.Forms.Label();
            this.msgIncorrectAns = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Purple;
            this.pictureBox2.Location = new System.Drawing.Point(54, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(650, 284);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.BackColor = System.Drawing.Color.Purple;
            this.lblQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNo.Location = new System.Drawing.Point(64, 202);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(181, 25);
            this.lblQuestionNo.TabIndex = 38;
            this.lblQuestionNo.Text = "Question Number 1";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(81, 238);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(225, 25);
            this.lblQuestion.TabIndex = 39;
            this.lblQuestion.Text = "What is 72 divided by 9?";
            // 
            // lblEnterAnswer
            // 
            this.lblEnterAnswer.AutoSize = true;
            this.lblEnterAnswer.BackColor = System.Drawing.Color.Purple;
            this.lblEnterAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEnterAnswer.Location = new System.Drawing.Point(186, 311);
            this.lblEnterAnswer.Name = "lblEnterAnswer";
            this.lblEnterAnswer.Size = new System.Drawing.Size(143, 20);
            this.lblEnterAnswer.TabIndex = 40;
            this.lblEnterAnswer.Text = "Enter answer here:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(277, 332);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(236, 30);
            this.txtAnswer.TabIndex = 41;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.Color.Purple;
            this.btnSubmitAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSubmitAnswer.Location = new System.Drawing.Point(568, 390);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(124, 64);
            this.btnSubmitAnswer.TabIndex = 42;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.Purple;
            this.btnNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNextQuestion.Location = new System.Drawing.Point(945, 416);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(232, 76);
            this.btnNextQuestion.TabIndex = 43;
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
            this.btnHelp.TabIndex = 59;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.AutoSize = true;
            this.lblDisplayTime.BackColor = System.Drawing.Color.Purple;
            this.lblDisplayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDisplayTime.Location = new System.Drawing.Point(857, 45);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(135, 31);
            this.lblDisplayTime.TabIndex = 60;
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
            this.lblTimeLeft.TabIndex = 61;
            this.lblTimeLeft.Text = "30";
            // 
            // questionTime
            // 
            this.questionTime.Interval = 1000;
            this.questionTime.Tick += new System.EventHandler(this.questionTime_Tick);
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
            this.lblTimeUp.TabIndex = 62;
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
            this.btnUnpause.TabIndex = 63;
            this.btnUnpause.Text = "Game Paused\r\nClick here to resume\r\n";
            this.btnUnpause.UseVisualStyleBackColor = false;
            this.btnUnpause.Visible = false;
            this.btnUnpause.Click += new System.EventHandler(this.btnUnpause_Click);
            // 
            // msgCorrectAns
            // 
            this.msgCorrectAns.AutoSize = true;
            this.msgCorrectAns.BackColor = System.Drawing.Color.Purple;
            this.msgCorrectAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgCorrectAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.msgCorrectAns.Location = new System.Drawing.Point(13, 481);
            this.msgCorrectAns.Name = "msgCorrectAns";
            this.msgCorrectAns.Size = new System.Drawing.Size(668, 94);
            this.msgCorrectAns.TabIndex = 64;
            this.msgCorrectAns.Text = "Correct Answer! Well done!\r\nPlease move on to the next question\r\n";
            this.msgCorrectAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgCorrectAns.UseWaitCursor = true;
            this.msgCorrectAns.Visible = false;
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
            this.msgIncorrectAns.TabIndex = 65;
            this.msgIncorrectAns.Text = "Incorrect Answer! Unlucky!\r\nPlease move on to the next question\r\n";
            this.msgIncorrectAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgIncorrectAns.UseWaitCursor = true;
            this.msgIncorrectAns.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Purple;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.Location = new System.Drawing.Point(1190, 269);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 62);
            this.btnLogout.TabIndex = 66;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(85, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "*Answer with numbers e.g. 45*";
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
            this.toolStrip1.TabIndex = 70;
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
            // HardQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnUnpause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.msgIncorrectAns);
            this.Controls.Add(this.msgCorrectAns);
            this.Controls.Add(this.lblTimeUp);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblDisplayTime);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblEnterAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestionNo);
            this.Controls.Add(this.pictureBox2);
            this.Name = "HardQuestionForm";
            this.Text = "HardQuestionForm";
            this.Load += new System.EventHandler(this.HardQuestionForm_Load);
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
            this.Controls.SetChildIndex(this.lblEnterAnswer, 0);
            this.Controls.SetChildIndex(this.txtAnswer, 0);
            this.Controls.SetChildIndex(this.btnSubmitAnswer, 0);
            this.Controls.SetChildIndex(this.btnNextQuestion, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.lblDisplayTime, 0);
            this.Controls.SetChildIndex(this.lblTimeLeft, 0);
            this.Controls.SetChildIndex(this.lblTimeUp, 0);
            this.Controls.SetChildIndex(this.msgCorrectAns, 0);
            this.Controls.SetChildIndex(this.msgIncorrectAns, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnUnpause, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblEnterAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer questionTime;
        private System.Windows.Forms.Label lblTimeUp;
        private System.Windows.Forms.Button btnUnpause;
        private System.Windows.Forms.Label msgCorrectAns;
        private System.Windows.Forms.Label msgIncorrectAns;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}