namespace Coursework_Quiz_Game
{
    partial class QuestionForm4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm4));
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.imgDrag1 = new System.Windows.Forms.PictureBox();
            this.imgDrag2 = new System.Windows.Forms.PictureBox();
            this.imgDrag3 = new System.Windows.Forms.PictureBox();
            this.imgDrop1 = new System.Windows.Forms.PictureBox();
            this.imgDrop2 = new System.Windows.Forms.PictureBox();
            this.imgDrop3 = new System.Windows.Forms.PictureBox();
            this.lblBox1Matched = new System.Windows.Forms.Label();
            this.lblBox2Matched = new System.Windows.Forms.Label();
            this.lblBox3Matched = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.Drop3Correct = new System.Windows.Forms.PictureBox();
            this.Drop2Correct = new System.Windows.Forms.PictureBox();
            this.Drop1Correct = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.questionTime = new System.Windows.Forms.Timer(this.components);
            this.lblDisplayTimer = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop3Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop2Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop1Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.BackColor = System.Drawing.Color.Purple;
            this.lblQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuestionNo.Location = new System.Drawing.Point(73, 187);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(165, 25);
            this.lblQuestionNo.TabIndex = 38;
            this.lblQuestionNo.Text = "Question Number";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuestion.Location = new System.Drawing.Point(73, 216);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(91, 25);
            this.lblQuestion.TabIndex = 39;
            this.lblQuestion.Text = "Question";
            // 
            // imgDrag1
            // 
            this.imgDrag1.BackColor = System.Drawing.Color.Purple;
            this.imgDrag1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrag1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.imgDrag1.Image = ((System.Drawing.Image)(resources.GetObject("imgDrag1.Image")));
            this.imgDrag1.Location = new System.Drawing.Point(144, 258);
            this.imgDrag1.Name = "imgDrag1";
            this.imgDrag1.Size = new System.Drawing.Size(114, 34);
            this.imgDrag1.TabIndex = 40;
            this.imgDrag1.TabStop = false;
            this.imgDrag1.Tag = "Fraction";
            this.imgDrag1.Click += new System.EventHandler(this.imgDrag1_Click);
            this.imgDrag1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgDrag1_MouseDown);
            // 
            // imgDrag2
            // 
            this.imgDrag2.BackColor = System.Drawing.Color.Purple;
            this.imgDrag2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrag2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.imgDrag2.Image = ((System.Drawing.Image)(resources.GetObject("imgDrag2.Image")));
            this.imgDrag2.Location = new System.Drawing.Point(148, 314);
            this.imgDrag2.Name = "imgDrag2";
            this.imgDrag2.Size = new System.Drawing.Size(110, 34);
            this.imgDrag2.TabIndex = 41;
            this.imgDrag2.TabStop = false;
            this.imgDrag2.Tag = "Decimal";
            this.imgDrag2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgDrag2_MouseDown);
            // 
            // imgDrag3
            // 
            this.imgDrag3.BackColor = System.Drawing.Color.Purple;
            this.imgDrag3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrag3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.imgDrag3.Image = ((System.Drawing.Image)(resources.GetObject("imgDrag3.Image")));
            this.imgDrag3.Location = new System.Drawing.Point(148, 370);
            this.imgDrag3.Name = "imgDrag3";
            this.imgDrag3.Size = new System.Drawing.Size(106, 36);
            this.imgDrag3.TabIndex = 42;
            this.imgDrag3.TabStop = false;
            this.imgDrag3.Tag = "Integer";
            this.imgDrag3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgDrag3_MouseDown);
            // 
            // imgDrop1
            // 
            this.imgDrop1.BackColor = System.Drawing.Color.Purple;
            this.imgDrop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrop1.Image = ((System.Drawing.Image)(resources.GetObject("imgDrop1.Image")));
            this.imgDrop1.Location = new System.Drawing.Point(487, 312);
            this.imgDrop1.Name = "imgDrop1";
            this.imgDrop1.Size = new System.Drawing.Size(54, 42);
            this.imgDrop1.TabIndex = 43;
            this.imgDrop1.TabStop = false;
            this.imgDrop1.Tag = "Fraction";
            this.imgDrop1.DragDrop += new System.Windows.Forms.DragEventHandler(this.imgDrop1_DragDrop);
            this.imgDrop1.DragEnter += new System.Windows.Forms.DragEventHandler(this.imgDrop1_DragEnter);
            this.imgDrop1.DragLeave += new System.EventHandler(this.imgDrop1_DragLeave);
            // 
            // imgDrop2
            // 
            this.imgDrop2.BackColor = System.Drawing.Color.Purple;
            this.imgDrop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrop2.Image = ((System.Drawing.Image)(resources.GetObject("imgDrop2.Image")));
            this.imgDrop2.Location = new System.Drawing.Point(491, 371);
            this.imgDrop2.Name = "imgDrop2";
            this.imgDrop2.Size = new System.Drawing.Size(66, 35);
            this.imgDrop2.TabIndex = 44;
            this.imgDrop2.TabStop = false;
            this.imgDrop2.Tag = "Decimal";
            this.imgDrop2.DragDrop += new System.Windows.Forms.DragEventHandler(this.imgDrop2_DragDrop);
            this.imgDrop2.DragEnter += new System.Windows.Forms.DragEventHandler(this.imgDrop2_DragEnter);
            this.imgDrop2.DragLeave += new System.EventHandler(this.imgDrop2_DragLeave);
            // 
            // imgDrop3
            // 
            this.imgDrop3.BackColor = System.Drawing.Color.Purple;
            this.imgDrop3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrop3.Image = ((System.Drawing.Image)(resources.GetObject("imgDrop3.Image")));
            this.imgDrop3.Location = new System.Drawing.Point(491, 261);
            this.imgDrop3.Name = "imgDrop3";
            this.imgDrop3.Size = new System.Drawing.Size(35, 31);
            this.imgDrop3.TabIndex = 45;
            this.imgDrop3.TabStop = false;
            this.imgDrop3.Tag = "Integer";
            this.imgDrop3.DragDrop += new System.Windows.Forms.DragEventHandler(this.imgDrop3_DragDrop);
            this.imgDrop3.DragEnter += new System.Windows.Forms.DragEventHandler(this.imgDrop3_DragEnter);
            this.imgDrop3.DragLeave += new System.EventHandler(this.imgDrop3_DragLeave);
            this.imgDrop3.MouseEnter += new System.EventHandler(this.imgDrop3_MouseEnter);
            // 
            // lblBox1Matched
            // 
            this.lblBox1Matched.AutoSize = true;
            this.lblBox1Matched.BackColor = System.Drawing.Color.Purple;
            this.lblBox1Matched.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBox1Matched.Location = new System.Drawing.Point(576, 323);
            this.lblBox1Matched.Name = "lblBox1Matched";
            this.lblBox1Matched.Size = new System.Drawing.Size(0, 25);
            this.lblBox1Matched.TabIndex = 46;
            this.lblBox1Matched.Click += new System.EventHandler(this.lblBox1Matched_Click);
            // 
            // lblBox2Matched
            // 
            this.lblBox2Matched.AutoSize = true;
            this.lblBox2Matched.BackColor = System.Drawing.Color.Purple;
            this.lblBox2Matched.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBox2Matched.Location = new System.Drawing.Point(593, 381);
            this.lblBox2Matched.Name = "lblBox2Matched";
            this.lblBox2Matched.Size = new System.Drawing.Size(0, 25);
            this.lblBox2Matched.TabIndex = 47;
            this.lblBox2Matched.Click += new System.EventHandler(this.lblBox2Matched_Click);
            // 
            // lblBox3Matched
            // 
            this.lblBox3Matched.AutoSize = true;
            this.lblBox3Matched.BackColor = System.Drawing.Color.Purple;
            this.lblBox3Matched.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBox3Matched.Location = new System.Drawing.Point(557, 267);
            this.lblBox3Matched.Name = "lblBox3Matched";
            this.lblBox3Matched.Size = new System.Drawing.Size(0, 25);
            this.lblBox3Matched.TabIndex = 48;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.Color.Purple;
            this.btnSubmitAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSubmitAnswer.Location = new System.Drawing.Point(598, 436);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(137, 82);
            this.btnSubmitAnswer.TabIndex = 50;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // Drop3Correct
            // 
            this.Drop3Correct.BackColor = System.Drawing.Color.Purple;
            this.Drop3Correct.Location = new System.Drawing.Point(469, 249);
            this.Drop3Correct.Name = "Drop3Correct";
            this.Drop3Correct.Size = new System.Drawing.Size(208, 50);
            this.Drop3Correct.TabIndex = 51;
            this.Drop3Correct.TabStop = false;
            this.Drop3Correct.Click += new System.EventHandler(this.Drop3Correct_Click);
            // 
            // Drop2Correct
            // 
            this.Drop2Correct.BackColor = System.Drawing.Color.Purple;
            this.Drop2Correct.Location = new System.Drawing.Point(469, 366);
            this.Drop2Correct.Name = "Drop2Correct";
            this.Drop2Correct.Size = new System.Drawing.Size(208, 50);
            this.Drop2Correct.TabIndex = 52;
            this.Drop2Correct.TabStop = false;
            this.Drop2Correct.Click += new System.EventHandler(this.Drop2Correct_Click);
            // 
            // Drop1Correct
            // 
            this.Drop1Correct.BackColor = System.Drawing.Color.Purple;
            this.Drop1Correct.Location = new System.Drawing.Point(469, 308);
            this.Drop1Correct.Name = "Drop1Correct";
            this.Drop1Correct.Size = new System.Drawing.Size(208, 50);
            this.Drop1Correct.TabIndex = 53;
            this.Drop1Correct.TabStop = false;
            this.Drop1Correct.Click += new System.EventHandler(this.Drop1Correct_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Purple;
            this.pictureBox2.Location = new System.Drawing.Point(57, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(692, 356);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.Purple;
            this.btnNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNextQuestion.Location = new System.Drawing.Point(969, 422);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(208, 70);
            this.btnNextQuestion.TabIndex = 55;
            this.btnNextQuestion.Text = "Finish Quiz";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Purple;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.Location = new System.Drawing.Point(1190, 269);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 62);
            this.btnLogout.TabIndex = 56;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Purple;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(469, 436);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 82);
            this.btnReset.TabIndex = 57;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // questionTime
            // 
            this.questionTime.Interval = 1000;
            this.questionTime.Tick += new System.EventHandler(this.questionTime_Tick);
            // 
            // lblDisplayTimer
            // 
            this.lblDisplayTimer.AutoSize = true;
            this.lblDisplayTimer.BackColor = System.Drawing.Color.Purple;
            this.lblDisplayTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDisplayTimer.Location = new System.Drawing.Point(907, 67);
            this.lblDisplayTimer.Name = "lblDisplayTimer";
            this.lblDisplayTimer.Size = new System.Drawing.Size(135, 31);
            this.lblDisplayTimer.TabIndex = 61;
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
            this.lblTimeRemaining.TabIndex = 62;
            this.lblTimeRemaining.Text = "60";
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
            this.btnHelp.TabIndex = 63;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // lblTimeUp
            // 
            this.lblTimeUp.AutoSize = true;
            this.lblTimeUp.BackColor = System.Drawing.Color.Purple;
            this.lblTimeUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTimeUp.Location = new System.Drawing.Point(13, 546);
            this.lblTimeUp.Name = "lblTimeUp";
            this.lblTimeUp.Size = new System.Drawing.Size(679, 94);
            this.lblTimeUp.TabIndex = 64;
            this.lblTimeUp.Text = "Time Up!\r\nPlease move on to the next question!";
            this.lblTimeUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimeUp.UseWaitCursor = true;
            this.lblTimeUp.Visible = false;
            // 
            // btnUnpause
            // 
            this.btnUnpause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUnpause.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnUnpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnUnpause.Location = new System.Drawing.Point(12, 117);
            this.btnUnpause.Name = "btnUnpause";
            this.btnUnpause.Size = new System.Drawing.Size(1248, 458);
            this.btnUnpause.TabIndex = 65;
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
            this.msgIncorrectAns.Location = new System.Drawing.Point(13, 546);
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
            // QuestionForm4
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
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.lblBox3Matched);
            this.Controls.Add(this.lblBox2Matched);
            this.Controls.Add(this.lblBox1Matched);
            this.Controls.Add(this.imgDrop3);
            this.Controls.Add(this.imgDrop2);
            this.Controls.Add(this.imgDrop1);
            this.Controls.Add(this.imgDrag3);
            this.Controls.Add(this.imgDrag2);
            this.Controls.Add(this.imgDrag1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestionNo);
            this.Controls.Add(this.Drop3Correct);
            this.Controls.Add(this.Drop1Correct);
            this.Controls.Add(this.Drop2Correct);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "QuestionForm4";
            this.Text = "QuestionForm4";
            this.Load += new System.EventHandler(this.QuestionForm4_Load);
            this.Controls.SetChildIndex(this.UserInfoBackround, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.lblDisplayHighscore, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.Drop2Correct, 0);
            this.Controls.SetChildIndex(this.Drop1Correct, 0);
            this.Controls.SetChildIndex(this.Drop3Correct, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblDisplayUsername, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblDisplayScore, 0);
            this.Controls.SetChildIndex(this.imgAvatar, 0);
            this.Controls.SetChildIndex(this.lblQuestionNo, 0);
            this.Controls.SetChildIndex(this.lblQuestion, 0);
            this.Controls.SetChildIndex(this.imgDrag1, 0);
            this.Controls.SetChildIndex(this.imgDrag2, 0);
            this.Controls.SetChildIndex(this.imgDrag3, 0);
            this.Controls.SetChildIndex(this.imgDrop1, 0);
            this.Controls.SetChildIndex(this.imgDrop2, 0);
            this.Controls.SetChildIndex(this.imgDrop3, 0);
            this.Controls.SetChildIndex(this.lblBox1Matched, 0);
            this.Controls.SetChildIndex(this.lblBox2Matched, 0);
            this.Controls.SetChildIndex(this.lblBox3Matched, 0);
            this.Controls.SetChildIndex(this.btnSubmitAnswer, 0);
            this.Controls.SetChildIndex(this.btnNextQuestion, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.lblDisplayTimer, 0);
            this.Controls.SetChildIndex(this.lblTimeRemaining, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.lblTimeUp, 0);
            this.Controls.SetChildIndex(this.msgIncorrectAns, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.btnUnpause, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop3Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop2Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop1Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox imgDrag1;
        private System.Windows.Forms.PictureBox imgDrag2;
        private System.Windows.Forms.PictureBox imgDrag3;
        private System.Windows.Forms.PictureBox imgDrop1;
        private System.Windows.Forms.PictureBox imgDrop2;
        private System.Windows.Forms.PictureBox imgDrop3;
        private System.Windows.Forms.Label lblBox1Matched;
        private System.Windows.Forms.Label lblBox2Matched;
        private System.Windows.Forms.Label lblBox3Matched;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.PictureBox Drop3Correct;
        private System.Windows.Forms.PictureBox Drop2Correct;
        private System.Windows.Forms.PictureBox Drop1Correct;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer questionTime;
        private System.Windows.Forms.Label lblDisplayTimer;
        private System.Windows.Forms.Label lblTimeRemaining;
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