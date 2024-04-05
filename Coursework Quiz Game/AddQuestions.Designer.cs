namespace Coursework_Quiz_Game
{
    partial class AddQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestions));
            this.lblAddQuestion = new System.Windows.Forms.Label();
            this.lblAddCorrectAnswer = new System.Windows.Forms.Label();
            this.txtAddQuestion = new System.Windows.Forms.TextBox();
            this.txtAddCorrectAns = new System.Windows.Forms.TextBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lblAddNewTxtBoxQuestion = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.btnEditQuestions = new System.Windows.Forms.Button();
            this.btnCityJumper = new System.Windows.Forms.Button();
            this.clkValidQue = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddQuestion
            // 
            this.lblAddQuestion.AutoSize = true;
            this.lblAddQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddQuestion.ForeColor = System.Drawing.Color.White;
            this.lblAddQuestion.Location = new System.Drawing.Point(171, 277);
            this.lblAddQuestion.Name = "lblAddQuestion";
            this.lblAddQuestion.Size = new System.Drawing.Size(65, 17);
            this.lblAddQuestion.TabIndex = 36;
            this.lblAddQuestion.Text = "Question";
            // 
            // lblAddCorrectAnswer
            // 
            this.lblAddCorrectAnswer.AutoSize = true;
            this.lblAddCorrectAnswer.BackColor = System.Drawing.Color.Purple;
            this.lblAddCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddCorrectAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAddCorrectAnswer.Location = new System.Drawing.Point(171, 318);
            this.lblAddCorrectAnswer.Name = "lblAddCorrectAnswer";
            this.lblAddCorrectAnswer.Size = new System.Drawing.Size(104, 17);
            this.lblAddCorrectAnswer.TabIndex = 41;
            this.lblAddCorrectAnswer.Text = "Correct Answer";
            this.lblAddCorrectAnswer.Click += new System.EventHandler(this.lblAddCorrectAnswer_Click);
            // 
            // txtAddQuestion
            // 
            this.txtAddQuestion.Location = new System.Drawing.Point(330, 277);
            this.txtAddQuestion.Name = "txtAddQuestion";
            this.txtAddQuestion.Size = new System.Drawing.Size(248, 20);
            this.txtAddQuestion.TabIndex = 43;
            // 
            // txtAddCorrectAns
            // 
            this.txtAddCorrectAns.Location = new System.Drawing.Point(330, 317);
            this.txtAddCorrectAns.Name = "txtAddCorrectAns";
            this.txtAddCorrectAns.Size = new System.Drawing.Size(248, 20);
            this.txtAddCorrectAns.TabIndex = 48;
            this.txtAddCorrectAns.TextChanged += new System.EventHandler(this.txtAddCorrectAns_TextChanged);
            this.txtAddCorrectAns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddCorrectAns_KeyDown);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.Purple;
            this.btnAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuestion.Location = new System.Drawing.Point(490, 374);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(88, 69);
            this.btnAddQuestion.TabIndex = 49;
            this.btnAddQuestion.Text = "Add New Question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // lblAddNewTxtBoxQuestion
            // 
            this.lblAddNewTxtBoxQuestion.AutoSize = true;
            this.lblAddNewTxtBoxQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblAddNewTxtBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAddNewTxtBoxQuestion.ForeColor = System.Drawing.Color.White;
            this.lblAddNewTxtBoxQuestion.Location = new System.Drawing.Point(92, 200);
            this.lblAddNewTxtBoxQuestion.Name = "lblAddNewTxtBoxQuestion";
            this.lblAddNewTxtBoxQuestion.Size = new System.Drawing.Size(203, 25);
            this.lblAddNewTxtBoxQuestion.TabIndex = 50;
            this.lblAddNewTxtBoxQuestion.Text = "Add a New Question?";
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.Purple;
            this.btnBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBackToLogin.Location = new System.Drawing.Point(585, 558);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(175, 123);
            this.btnBackToLogin.TabIndex = 51;
            this.btnBackToLogin.Text = "Back to Login";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Purple;
            this.pictureBox3.Location = new System.Drawing.Point(75, 186);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(546, 273);
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BackColor = System.Drawing.Color.Purple;
            this.btnStartQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStartQuiz.Location = new System.Drawing.Point(766, 558);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(173, 123);
            this.btnStartQuiz.TabIndex = 53;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Purple;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.Location = new System.Drawing.Point(1190, 269);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 62);
            this.btnLogout.TabIndex = 55;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Add a Text Box based question to the quiz.";
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
            this.btnHelp.TabIndex = 57;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.BackColor = System.Drawing.Color.Purple;
            this.btnEditUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEditUsers.Location = new System.Drawing.Point(627, 329);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(250, 130);
            this.btnEditUsers.TabIndex = 58;
            this.btnEditUsers.Text = "Edit Users";
            this.btnEditUsers.UseVisualStyleBackColor = false;
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // btnEditQuestions
            // 
            this.btnEditQuestions.BackColor = System.Drawing.Color.Purple;
            this.btnEditQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEditQuestions.Location = new System.Drawing.Point(627, 186);
            this.btnEditQuestions.Name = "btnEditQuestions";
            this.btnEditQuestions.Size = new System.Drawing.Size(250, 130);
            this.btnEditQuestions.TabIndex = 59;
            this.btnEditQuestions.Text = "Edit Questions";
            this.btnEditQuestions.UseVisualStyleBackColor = false;
            this.btnEditQuestions.Click += new System.EventHandler(this.btnEditQuestions_Click);
            // 
            // btnCityJumper
            // 
            this.btnCityJumper.BackColor = System.Drawing.Color.Purple;
            this.btnCityJumper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCityJumper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCityJumper.Location = new System.Drawing.Point(404, 558);
            this.btnCityJumper.Name = "btnCityJumper";
            this.btnCityJumper.Size = new System.Drawing.Size(175, 123);
            this.btnCityJumper.TabIndex = 60;
            this.btnCityJumper.Text = "BlockJumper";
            this.btnCityJumper.UseVisualStyleBackColor = false;
            this.btnCityJumper.Click += new System.EventHandler(this.btnCityJumper_Click);
            // 
            // clkValidQue
            // 
            this.clkValidQue.Interval = 10;
            this.clkValidQue.Tick += new System.EventHandler(this.clkValidQue_Tick);
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
            this.toolStrip1.TabIndex = 61;
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
            // AddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCityJumper);
            this.Controls.Add(this.btnEditQuestions);
            this.Controls.Add(this.btnEditUsers);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.lblAddNewTxtBoxQuestion);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.txtAddCorrectAns);
            this.Controls.Add(this.txtAddQuestion);
            this.Controls.Add(this.lblAddCorrectAnswer);
            this.Controls.Add(this.lblAddQuestion);
            this.Controls.Add(this.pictureBox3);
            this.Name = "AddQuestions";
            this.Text = "AddQuestions";
            this.Load += new System.EventHandler(this.AddQuestions_Load);
            this.Controls.SetChildIndex(this.UserInfoBackround, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.lblDisplayHighscore, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblDisplayUsername, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblDisplayScore, 0);
            this.Controls.SetChildIndex(this.imgAvatar, 0);
            this.Controls.SetChildIndex(this.lblAddQuestion, 0);
            this.Controls.SetChildIndex(this.lblAddCorrectAnswer, 0);
            this.Controls.SetChildIndex(this.txtAddQuestion, 0);
            this.Controls.SetChildIndex(this.txtAddCorrectAns, 0);
            this.Controls.SetChildIndex(this.btnAddQuestion, 0);
            this.Controls.SetChildIndex(this.lblAddNewTxtBoxQuestion, 0);
            this.Controls.SetChildIndex(this.btnBackToLogin, 0);
            this.Controls.SetChildIndex(this.btnStartQuiz, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.btnEditUsers, 0);
            this.Controls.SetChildIndex(this.btnEditQuestions, 0);
            this.Controls.SetChildIndex(this.btnCityJumper, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddQuestion;
        private System.Windows.Forms.Label lblAddCorrectAnswer;
        private System.Windows.Forms.TextBox txtAddQuestion;
        private System.Windows.Forms.TextBox txtAddCorrectAns;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblAddNewTxtBoxQuestion;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button btnEditQuestions;
        private System.Windows.Forms.Button btnCityJumper;
        private System.Windows.Forms.Timer clkValidQue;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}