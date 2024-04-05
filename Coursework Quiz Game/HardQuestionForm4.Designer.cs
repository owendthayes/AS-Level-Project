namespace Coursework_Quiz_Game
{
    partial class HardQuestionForm4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardQuestionForm4));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblBox3Matched = new System.Windows.Forms.Label();
            this.lblBox2Matched = new System.Windows.Forms.Label();
            this.lblBox1Matched = new System.Windows.Forms.Label();
            this.imgDrop3 = new System.Windows.Forms.PictureBox();
            this.imgDrop2 = new System.Windows.Forms.PictureBox();
            this.imgDrop1 = new System.Windows.Forms.PictureBox();
            this.imgDrag3 = new System.Windows.Forms.PictureBox();
            this.imgDrag2 = new System.Windows.Forms.PictureBox();
            this.imgDrag1 = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.Drop3Correct = new System.Windows.Forms.PictureBox();
            this.Drop1Correct = new System.Windows.Forms.PictureBox();
            this.Drop2Correct = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop3Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop1Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop2Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Purple;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(476, 437);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 82);
            this.btnReset.TabIndex = 75;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.Purple;
            this.btnNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNextQuestion.Location = new System.Drawing.Point(976, 423);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(208, 70);
            this.btnNextQuestion.TabIndex = 74;
            this.btnNextQuestion.Tag = "Trapezium";
            this.btnNextQuestion.Text = "Finish Quiz";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.Color.Purple;
            this.btnSubmitAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSubmitAnswer.Location = new System.Drawing.Point(605, 437);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(137, 82);
            this.btnSubmitAnswer.TabIndex = 69;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblBox3Matched
            // 
            this.lblBox3Matched.AutoSize = true;
            this.lblBox3Matched.BackColor = System.Drawing.Color.Purple;
            this.lblBox3Matched.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBox3Matched.Location = new System.Drawing.Point(564, 268);
            this.lblBox3Matched.Name = "lblBox3Matched";
            this.lblBox3Matched.Size = new System.Drawing.Size(0, 25);
            this.lblBox3Matched.TabIndex = 68;
            // 
            // lblBox2Matched
            // 
            this.lblBox2Matched.AutoSize = true;
            this.lblBox2Matched.BackColor = System.Drawing.Color.Purple;
            this.lblBox2Matched.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBox2Matched.Location = new System.Drawing.Point(600, 398);
            this.lblBox2Matched.Name = "lblBox2Matched";
            this.lblBox2Matched.Size = new System.Drawing.Size(0, 25);
            this.lblBox2Matched.TabIndex = 67;
            // 
            // lblBox1Matched
            // 
            this.lblBox1Matched.AutoSize = true;
            this.lblBox1Matched.BackColor = System.Drawing.Color.Purple;
            this.lblBox1Matched.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBox1Matched.Location = new System.Drawing.Point(583, 324);
            this.lblBox1Matched.Name = "lblBox1Matched";
            this.lblBox1Matched.Size = new System.Drawing.Size(0, 25);
            this.lblBox1Matched.TabIndex = 66;
            // 
            // imgDrop3
            // 
            this.imgDrop3.BackColor = System.Drawing.Color.Purple;
            this.imgDrop3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrop3.Image = ((System.Drawing.Image)(resources.GetObject("imgDrop3.Image")));
            this.imgDrop3.Location = new System.Drawing.Point(498, 238);
            this.imgDrop3.Name = "imgDrop3";
            this.imgDrop3.Size = new System.Drawing.Size(60, 55);
            this.imgDrop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDrop3.TabIndex = 65;
            this.imgDrop3.TabStop = false;
            this.imgDrop3.Tag = "Parallelogram";
            this.imgDrop3.DragDrop += new System.Windows.Forms.DragEventHandler(this.imgDrop3_DragDrop);
            this.imgDrop3.DragEnter += new System.Windows.Forms.DragEventHandler(this.imgDrop3_DragEnter);
            this.imgDrop3.DragLeave += new System.EventHandler(this.imgDrop3_DragLeave);
            // 
            // imgDrop2
            // 
            this.imgDrop2.BackColor = System.Drawing.Color.Purple;
            this.imgDrop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrop2.Image = ((System.Drawing.Image)(resources.GetObject("imgDrop2.Image")));
            this.imgDrop2.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgDrop2.InitialImage")));
            this.imgDrop2.Location = new System.Drawing.Point(494, 378);
            this.imgDrop2.Name = "imgDrop2";
            this.imgDrop2.Size = new System.Drawing.Size(60, 49);
            this.imgDrop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDrop2.TabIndex = 64;
            this.imgDrop2.TabStop = false;
            this.imgDrop2.Tag = "Rhombus";
            this.imgDrop2.DragDrop += new System.Windows.Forms.DragEventHandler(this.imgDrop2_DragDrop);
            this.imgDrop2.DragEnter += new System.Windows.Forms.DragEventHandler(this.imgDrop2_DragEnter);
            this.imgDrop2.DragLeave += new System.EventHandler(this.imgDrop2_DragLeave);
            // 
            // imgDrop1
            // 
            this.imgDrop1.BackColor = System.Drawing.Color.Purple;
            this.imgDrop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrop1.Image = ((System.Drawing.Image)(resources.GetObject("imgDrop1.Image")));
            this.imgDrop1.Location = new System.Drawing.Point(494, 315);
            this.imgDrop1.Name = "imgDrop1";
            this.imgDrop1.Size = new System.Drawing.Size(64, 53);
            this.imgDrop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDrop1.TabIndex = 63;
            this.imgDrop1.TabStop = false;
            this.imgDrop1.Tag = "Trapezium";
            this.imgDrop1.Click += new System.EventHandler(this.imgDrop1_Click);
            this.imgDrop1.DragDrop += new System.Windows.Forms.DragEventHandler(this.imgDrop1_DragDrop);
            this.imgDrop1.DragEnter += new System.Windows.Forms.DragEventHandler(this.imgDrop1_DragEnter);
            this.imgDrop1.DragLeave += new System.EventHandler(this.imgDrop1_DragLeave);
            // 
            // imgDrag3
            // 
            this.imgDrag3.BackColor = System.Drawing.Color.Purple;
            this.imgDrag3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrag3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.imgDrag3.Image = ((System.Drawing.Image)(resources.GetObject("imgDrag3.Image")));
            this.imgDrag3.Location = new System.Drawing.Point(155, 387);
            this.imgDrag3.Name = "imgDrag3";
            this.imgDrag3.Size = new System.Drawing.Size(165, 36);
            this.imgDrag3.TabIndex = 62;
            this.imgDrag3.TabStop = false;
            this.imgDrag3.Tag = "Parallelogram";
            this.imgDrag3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgDrag3_MouseDown);
            // 
            // imgDrag2
            // 
            this.imgDrag2.BackColor = System.Drawing.Color.Purple;
            this.imgDrag2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrag2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.imgDrag2.Image = ((System.Drawing.Image)(resources.GetObject("imgDrag2.Image")));
            this.imgDrag2.Location = new System.Drawing.Point(155, 324);
            this.imgDrag2.Name = "imgDrag2";
            this.imgDrag2.Size = new System.Drawing.Size(112, 34);
            this.imgDrag2.TabIndex = 61;
            this.imgDrag2.TabStop = false;
            this.imgDrag2.Tag = "Rhombus";
            this.imgDrag2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgDrag2_MouseDown);
            // 
            // imgDrag1
            // 
            this.imgDrag1.BackColor = System.Drawing.Color.Purple;
            this.imgDrag1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDrag1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.imgDrag1.Image = ((System.Drawing.Image)(resources.GetObject("imgDrag1.Image")));
            this.imgDrag1.Location = new System.Drawing.Point(151, 259);
            this.imgDrag1.Name = "imgDrag1";
            this.imgDrag1.Size = new System.Drawing.Size(126, 34);
            this.imgDrag1.TabIndex = 60;
            this.imgDrag1.TabStop = false;
            this.imgDrag1.Tag = "Trapezium";
            this.imgDrag1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgDrag1_MouseDown);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuestion.Location = new System.Drawing.Point(80, 217);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(91, 25);
            this.lblQuestion.TabIndex = 59;
            this.lblQuestion.Text = "Question";
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.BackColor = System.Drawing.Color.Purple;
            this.lblQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuestionNo.Location = new System.Drawing.Point(80, 188);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(165, 25);
            this.lblQuestionNo.TabIndex = 58;
            this.lblQuestionNo.Text = "Question Number";
            // 
            // Drop3Correct
            // 
            this.Drop3Correct.BackColor = System.Drawing.Color.Purple;
            this.Drop3Correct.Location = new System.Drawing.Point(476, 229);
            this.Drop3Correct.Name = "Drop3Correct";
            this.Drop3Correct.Size = new System.Drawing.Size(228, 71);
            this.Drop3Correct.TabIndex = 70;
            this.Drop3Correct.TabStop = false;
            // 
            // Drop1Correct
            // 
            this.Drop1Correct.BackColor = System.Drawing.Color.Purple;
            this.Drop1Correct.Location = new System.Drawing.Point(476, 309);
            this.Drop1Correct.Name = "Drop1Correct";
            this.Drop1Correct.Size = new System.Drawing.Size(228, 59);
            this.Drop1Correct.TabIndex = 72;
            this.Drop1Correct.TabStop = false;
            // 
            // Drop2Correct
            // 
            this.Drop2Correct.BackColor = System.Drawing.Color.Purple;
            this.Drop2Correct.Location = new System.Drawing.Point(476, 374);
            this.Drop2Correct.Name = "Drop2Correct";
            this.Drop2Correct.Size = new System.Drawing.Size(228, 59);
            this.Drop2Correct.TabIndex = 71;
            this.Drop2Correct.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Purple;
            this.pictureBox2.Location = new System.Drawing.Point(57, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(697, 355);
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
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
            this.btnHelp.TabIndex = 76;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblTimeUp
            // 
            this.lblTimeUp.AutoSize = true;
            this.lblTimeUp.BackColor = System.Drawing.Color.Purple;
            this.lblTimeUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTimeUp.Location = new System.Drawing.Point(25, 558);
            this.lblTimeUp.Name = "lblTimeUp";
            this.lblTimeUp.Size = new System.Drawing.Size(679, 94);
            this.lblTimeUp.TabIndex = 77;
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
            this.lblDisplayTime.TabIndex = 78;
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
            this.lblTimeLeft.TabIndex = 79;
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
            this.btnUnpause.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUnpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnUnpause.Location = new System.Drawing.Point(12, 117);
            this.btnUnpause.Name = "btnUnpause";
            this.btnUnpause.Size = new System.Drawing.Size(1248, 458);
            this.btnUnpause.TabIndex = 80;
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
            this.msgIncorrectAns.Location = new System.Drawing.Point(25, 558);
            this.msgIncorrectAns.Name = "msgIncorrectAns";
            this.msgIncorrectAns.Size = new System.Drawing.Size(668, 94);
            this.msgIncorrectAns.TabIndex = 81;
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
            this.btnLogout.TabIndex = 82;
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
            this.toolStrip1.TabIndex = 83;
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
            // HardQuestionForm4
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
            this.Controls.Add(this.btnReset);
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
            this.Name = "HardQuestionForm4";
            this.Text = "HardQuestionForm4";
            this.Load += new System.EventHandler(this.HardQuestionForm4_Load);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.Drop2Correct, 0);
            this.Controls.SetChildIndex(this.Drop1Correct, 0);
            this.Controls.SetChildIndex(this.Drop3Correct, 0);
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
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.UserInfoBackround, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblDisplayUsername, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblDisplayScore, 0);
            this.Controls.SetChildIndex(this.imgAvatar, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.lblDisplayHighscore, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop3Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop1Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop2Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblBox3Matched;
        private System.Windows.Forms.Label lblBox2Matched;
        private System.Windows.Forms.Label lblBox1Matched;
        private System.Windows.Forms.PictureBox imgDrop3;
        private System.Windows.Forms.PictureBox imgDrop2;
        private System.Windows.Forms.PictureBox imgDrop1;
        private System.Windows.Forms.PictureBox imgDrag3;
        private System.Windows.Forms.PictureBox imgDrag2;
        private System.Windows.Forms.PictureBox imgDrag1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.PictureBox Drop3Correct;
        private System.Windows.Forms.PictureBox Drop1Correct;
        private System.Windows.Forms.PictureBox Drop2Correct;
        private System.Windows.Forms.PictureBox pictureBox2;
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