namespace Coursework_Quiz_Game
{
    partial class EditUsers
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblAddNewTxtBoxQuestion = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHighscoreEdit = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.txtUsernameEdit = new System.Windows.Forms.TextBox();
            this.txtPasswordEdit = new System.Windows.Forms.TextBox();
            this.txtHighscoreEdit = new System.Windows.Forms.TextBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.btnDelQ = new System.Windows.Forms.Button();
            this.btnSaveQ = new System.Windows.Forms.Button();
            this.btnPrevQ = new System.Windows.Forms.Button();
            this.btnNextQ = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clkValidU = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Purple;
            this.pictureBox5.Location = new System.Drawing.Point(417, 230);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(429, 166);
            this.pictureBox5.TabIndex = 62;
            this.pictureBox5.TabStop = false;
            // 
            // lblAddNewTxtBoxQuestion
            // 
            this.lblAddNewTxtBoxQuestion.AutoSize = true;
            this.lblAddNewTxtBoxQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblAddNewTxtBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAddNewTxtBoxQuestion.ForeColor = System.Drawing.Color.White;
            this.lblAddNewTxtBoxQuestion.Location = new System.Drawing.Point(501, 190);
            this.lblAddNewTxtBoxQuestion.Name = "lblAddNewTxtBoxQuestion";
            this.lblAddNewTxtBoxQuestion.Size = new System.Drawing.Size(253, 25);
            this.lblAddNewTxtBoxQuestion.TabIndex = 67;
            this.lblAddNewTxtBoxQuestion.Text = "View, Edit and Delete Users";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Purple;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(442, 258);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 68;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Purple;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(442, 293);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 69;
            this.lblPassword.Text = "Password";
            // 
            // lblHighscoreEdit
            // 
            this.lblHighscoreEdit.AutoSize = true;
            this.lblHighscoreEdit.BackColor = System.Drawing.Color.Purple;
            this.lblHighscoreEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHighscoreEdit.ForeColor = System.Drawing.Color.White;
            this.lblHighscoreEdit.Location = new System.Drawing.Point(442, 325);
            this.lblHighscoreEdit.Name = "lblHighscoreEdit";
            this.lblHighscoreEdit.Size = new System.Drawing.Size(72, 17);
            this.lblHighscoreEdit.TabIndex = 70;
            this.lblHighscoreEdit.Text = "Highscore";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Purple;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(442, 359);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(55, 17);
            this.lblAdmin.TabIndex = 71;
            this.lblAdmin.Text = "Admin?";
            // 
            // txtUsernameEdit
            // 
            this.txtUsernameEdit.Location = new System.Drawing.Point(539, 257);
            this.txtUsernameEdit.Name = "txtUsernameEdit";
            this.txtUsernameEdit.Size = new System.Drawing.Size(248, 20);
            this.txtUsernameEdit.TabIndex = 72;
            this.txtUsernameEdit.TextChanged += new System.EventHandler(this.txtUsernameEdit_TextChanged);
            this.txtUsernameEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsernameEdit_KeyDown);
            this.txtUsernameEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsernameEdit_KeyUp);
            // 
            // txtPasswordEdit
            // 
            this.txtPasswordEdit.Location = new System.Drawing.Point(539, 292);
            this.txtPasswordEdit.Name = "txtPasswordEdit";
            this.txtPasswordEdit.Size = new System.Drawing.Size(248, 20);
            this.txtPasswordEdit.TabIndex = 73;
            this.txtPasswordEdit.TextChanged += new System.EventHandler(this.txtPasswordEdit_TextChanged);
            this.txtPasswordEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordEdit_KeyDown);
            // 
            // txtHighscoreEdit
            // 
            this.txtHighscoreEdit.Location = new System.Drawing.Point(539, 324);
            this.txtHighscoreEdit.Name = "txtHighscoreEdit";
            this.txtHighscoreEdit.Size = new System.Drawing.Size(248, 20);
            this.txtHighscoreEdit.TabIndex = 74;
            this.txtHighscoreEdit.TextChanged += new System.EventHandler(this.txtHighscoreEdit_TextChanged);
            this.txtHighscoreEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHighscoreEdit_KeyDown);
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(539, 359);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(188, 17);
            this.chkAdmin.TabIndex = 75;
            this.chkAdmin.Text = "Check box to make user an Admin";
            this.chkAdmin.UseVisualStyleBackColor = true;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.chkAdmin_CheckedChanged);
            // 
            // btnDelQ
            // 
            this.btnDelQ.BackColor = System.Drawing.Color.Purple;
            this.btnDelQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDelQ.Location = new System.Drawing.Point(517, 411);
            this.btnDelQ.Name = "btnDelQ";
            this.btnDelQ.Size = new System.Drawing.Size(127, 79);
            this.btnDelQ.TabIndex = 79;
            this.btnDelQ.Text = "Delete";
            this.btnDelQ.UseVisualStyleBackColor = false;
            this.btnDelQ.Click += new System.EventHandler(this.btnDelQ_Click);
            // 
            // btnSaveQ
            // 
            this.btnSaveQ.BackColor = System.Drawing.Color.Purple;
            this.btnSaveQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSaveQ.Location = new System.Drawing.Point(650, 411);
            this.btnSaveQ.Name = "btnSaveQ";
            this.btnSaveQ.Size = new System.Drawing.Size(127, 79);
            this.btnSaveQ.TabIndex = 78;
            this.btnSaveQ.Text = "Save";
            this.btnSaveQ.UseVisualStyleBackColor = false;
            this.btnSaveQ.Click += new System.EventHandler(this.btnSaveQ_Click);
            // 
            // btnPrevQ
            // 
            this.btnPrevQ.BackColor = System.Drawing.Color.Purple;
            this.btnPrevQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPrevQ.Location = new System.Drawing.Point(384, 411);
            this.btnPrevQ.Name = "btnPrevQ";
            this.btnPrevQ.Size = new System.Drawing.Size(127, 79);
            this.btnPrevQ.TabIndex = 77;
            this.btnPrevQ.Text = "Previous";
            this.btnPrevQ.UseVisualStyleBackColor = false;
            this.btnPrevQ.Click += new System.EventHandler(this.btnPrevQ_Click);
            // 
            // btnNextQ
            // 
            this.btnNextQ.BackColor = System.Drawing.Color.Purple;
            this.btnNextQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNextQ.Location = new System.Drawing.Point(783, 411);
            this.btnNextQ.Name = "btnNextQ";
            this.btnNextQ.Size = new System.Drawing.Size(127, 79);
            this.btnNextQ.TabIndex = 76;
            this.btnNextQ.Text = "Next";
            this.btnNextQ.UseVisualStyleBackColor = false;
            this.btnNextQ.Click += new System.EventHandler(this.btnNextQ_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Purple;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button8.Location = new System.Drawing.Point(12, 559);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 123);
            this.button8.TabIndex = 80;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(370, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 158);
            this.label2.TabIndex = 81;
            this.label2.Text = "Username can\'t be changed at the same time as another property!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clkValidU
            // 
            this.clkValidU.Interval = 10;
            this.clkValidU.Tick += new System.EventHandler(this.clkValidU_Tick);
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
            this.toolStrip1.TabIndex = 82;
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
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnDelQ);
            this.Controls.Add(this.btnSaveQ);
            this.Controls.Add(this.btnPrevQ);
            this.Controls.Add(this.btnNextQ);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.txtHighscoreEdit);
            this.Controls.Add(this.txtPasswordEdit);
            this.Controls.Add(this.txtUsernameEdit);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblHighscoreEdit);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblAddNewTxtBoxQuestion);
            this.Controls.Add(this.pictureBox5);
            this.Name = "EditUsers";
            this.Text = "EditUsers";
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.lblAddNewTxtBoxQuestion, 0);
            this.Controls.SetChildIndex(this.lblUsername, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.lblHighscoreEdit, 0);
            this.Controls.SetChildIndex(this.lblAdmin, 0);
            this.Controls.SetChildIndex(this.UserInfoBackround, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblDisplayUsername, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblDisplayScore, 0);
            this.Controls.SetChildIndex(this.imgAvatar, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.lblDisplayHighscore, 0);
            this.Controls.SetChildIndex(this.txtUsernameEdit, 0);
            this.Controls.SetChildIndex(this.txtPasswordEdit, 0);
            this.Controls.SetChildIndex(this.txtHighscoreEdit, 0);
            this.Controls.SetChildIndex(this.chkAdmin, 0);
            this.Controls.SetChildIndex(this.btnNextQ, 0);
            this.Controls.SetChildIndex(this.btnPrevQ, 0);
            this.Controls.SetChildIndex(this.btnSaveQ, 0);
            this.Controls.SetChildIndex(this.btnDelQ, 0);
            this.Controls.SetChildIndex(this.button8, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblAddNewTxtBoxQuestion;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblHighscoreEdit;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TextBox txtUsernameEdit;
        private System.Windows.Forms.TextBox txtPasswordEdit;
        private System.Windows.Forms.TextBox txtHighscoreEdit;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Button btnDelQ;
        private System.Windows.Forms.Button btnSaveQ;
        private System.Windows.Forms.Button btnPrevQ;
        private System.Windows.Forms.Button btnNextQ;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer clkValidU;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}