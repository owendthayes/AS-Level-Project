namespace Coursework_Quiz_Game
{
    partial class EasyHard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyHard));
            this.btnEasyMode = new System.Windows.Forms.Button();
            this.btnHardMode = new System.Windows.Forms.Button();
            this.lblEasyHard = new System.Windows.Forms.Label();
            this.lblEasy1 = new System.Windows.Forms.Label();
            this.lblEasy2 = new System.Windows.Forms.Label();
            this.lblEasy3 = new System.Windows.Forms.Label();
            this.lblHard1 = new System.Windows.Forms.Label();
            this.lblHard2 = new System.Windows.Forms.Label();
            this.lblHard3 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUnlockHard = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEasyMode
            // 
            this.btnEasyMode.BackColor = System.Drawing.Color.Purple;
            this.btnEasyMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEasyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnEasyMode.Location = new System.Drawing.Point(286, 279);
            this.btnEasyMode.Name = "btnEasyMode";
            this.btnEasyMode.Size = new System.Drawing.Size(298, 165);
            this.btnEasyMode.TabIndex = 37;
            this.btnEasyMode.Text = "Easy";
            this.btnEasyMode.UseVisualStyleBackColor = false;
            this.btnEasyMode.Click += new System.EventHandler(this.btnEasyMode_Click);
            this.btnEasyMode.MouseEnter += new System.EventHandler(this.btnEasyMode_MouseEnter);
            this.btnEasyMode.MouseLeave += new System.EventHandler(this.btnEasyMode_MouseLeave);
            this.btnEasyMode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEasyMode_MouseMove);
            // 
            // btnHardMode
            // 
            this.btnHardMode.BackColor = System.Drawing.Color.Purple;
            this.btnHardMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHardMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnHardMode.Location = new System.Drawing.Point(721, 279);
            this.btnHardMode.Name = "btnHardMode";
            this.btnHardMode.Size = new System.Drawing.Size(298, 165);
            this.btnHardMode.TabIndex = 38;
            this.btnHardMode.Text = "Hard";
            this.btnHardMode.UseVisualStyleBackColor = false;
            this.btnHardMode.Click += new System.EventHandler(this.btnHardMode_Click);
            this.btnHardMode.MouseEnter += new System.EventHandler(this.btnHardMode_MouseEnter);
            this.btnHardMode.MouseLeave += new System.EventHandler(this.btnHardMode_MouseLeave);
            // 
            // lblEasyHard
            // 
            this.lblEasyHard.AutoSize = true;
            this.lblEasyHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEasyHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblEasyHard.ForeColor = System.Drawing.Color.White;
            this.lblEasyHard.Location = new System.Drawing.Point(12, 141);
            this.lblEasyHard.Name = "lblEasyHard";
            this.lblEasyHard.Size = new System.Drawing.Size(631, 31);
            this.lblEasyHard.TabIndex = 39;
            this.lblEasyHard.Text = "Chose which difficulty you would like the quiz to be.";
            // 
            // lblEasy1
            // 
            this.lblEasy1.AutoSize = true;
            this.lblEasy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEasy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblEasy1.ForeColor = System.Drawing.Color.White;
            this.lblEasy1.Location = new System.Drawing.Point(283, 447);
            this.lblEasy1.Name = "lblEasy1";
            this.lblEasy1.Size = new System.Drawing.Size(398, 31);
            this.lblEasy1.TabIndex = 40;
            this.lblEasy1.Text = "-Correct answers worth 5 points";
            this.lblEasy1.Visible = false;
            // 
            // lblEasy2
            // 
            this.lblEasy2.AutoSize = true;
            this.lblEasy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEasy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblEasy2.ForeColor = System.Drawing.Color.White;
            this.lblEasy2.Location = new System.Drawing.Point(283, 481);
            this.lblEasy2.Name = "lblEasy2";
            this.lblEasy2.Size = new System.Drawing.Size(224, 31);
            this.lblEasy2.TabIndex = 41;
            this.lblEasy2.Text = "-Easier questions";
            this.lblEasy2.Visible = false;
            // 
            // lblEasy3
            // 
            this.lblEasy3.AutoSize = true;
            this.lblEasy3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEasy3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblEasy3.ForeColor = System.Drawing.Color.White;
            this.lblEasy3.Location = new System.Drawing.Point(283, 512);
            this.lblEasy3.Name = "lblEasy3";
            this.lblEasy3.Size = new System.Drawing.Size(375, 31);
            this.lblEasy3.TabIndex = 42;
            this.lblEasy3.Text = "-1 minute to answer questions";
            this.lblEasy3.Visible = false;
            // 
            // lblHard1
            // 
            this.lblHard1.AutoSize = true;
            this.lblHard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblHard1.ForeColor = System.Drawing.Color.White;
            this.lblHard1.Location = new System.Drawing.Point(718, 447);
            this.lblHard1.Name = "lblHard1";
            this.lblHard1.Size = new System.Drawing.Size(413, 31);
            this.lblHard1.TabIndex = 43;
            this.lblHard1.Text = "-Correct answers worth 10 points";
            this.lblHard1.Visible = false;
            // 
            // lblHard2
            // 
            this.lblHard2.AutoSize = true;
            this.lblHard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblHard2.ForeColor = System.Drawing.Color.White;
            this.lblHard2.Location = new System.Drawing.Point(718, 481);
            this.lblHard2.Name = "lblHard2";
            this.lblHard2.Size = new System.Drawing.Size(230, 31);
            this.lblHard2.TabIndex = 44;
            this.lblHard2.Text = "-Harder questions";
            this.lblHard2.Visible = false;
            // 
            // lblHard3
            // 
            this.lblHard3.AutoSize = true;
            this.lblHard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblHard3.ForeColor = System.Drawing.Color.White;
            this.lblHard3.Location = new System.Drawing.Point(718, 512);
            this.lblHard3.Name = "lblHard3";
            this.lblHard3.Size = new System.Drawing.Size(411, 31);
            this.lblHard3.TabIndex = 54;
            this.lblHard3.Text = "-30 seconds to answer questions";
            this.lblHard3.Visible = false;
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
            this.btnHelp.TabIndex = 58;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Purple;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.Location = new System.Drawing.Point(1190, 269);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 62);
            this.btnLogout.TabIndex = 67;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUnlockHard
            // 
            this.lblUnlockHard.AutoSize = true;
            this.lblUnlockHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUnlockHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblUnlockHard.ForeColor = System.Drawing.Color.White;
            this.lblUnlockHard.Location = new System.Drawing.Point(633, 251);
            this.lblUnlockHard.Name = "lblUnlockHard";
            this.lblUnlockHard.Size = new System.Drawing.Size(474, 25);
            this.lblUnlockHard.TabIndex = 68;
            this.lblUnlockHard.Text = "You must finish easy mode once to unlock hard mode";
            this.lblUnlockHard.Visible = false;
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
            this.toolStrip1.TabIndex = 69;
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
            // EasyHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblUnlockHard);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblHard3);
            this.Controls.Add(this.lblHard2);
            this.Controls.Add(this.lblHard1);
            this.Controls.Add(this.lblEasy3);
            this.Controls.Add(this.lblEasy2);
            this.Controls.Add(this.lblEasy1);
            this.Controls.Add(this.lblEasyHard);
            this.Controls.Add(this.btnHardMode);
            this.Controls.Add(this.btnEasyMode);
            this.Name = "EasyHard";
            this.Text = "EasyHard";
            this.Load += new System.EventHandler(this.EasyHard_Load);
            this.Controls.SetChildIndex(this.btnEasyMode, 0);
            this.Controls.SetChildIndex(this.btnHardMode, 0);
            this.Controls.SetChildIndex(this.UserInfoBackround, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblDisplayUsername, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblDisplayScore, 0);
            this.Controls.SetChildIndex(this.imgAvatar, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.lblDisplayHighscore, 0);
            this.Controls.SetChildIndex(this.lblEasyHard, 0);
            this.Controls.SetChildIndex(this.lblEasy1, 0);
            this.Controls.SetChildIndex(this.lblEasy2, 0);
            this.Controls.SetChildIndex(this.lblEasy3, 0);
            this.Controls.SetChildIndex(this.lblHard1, 0);
            this.Controls.SetChildIndex(this.lblHard2, 0);
            this.Controls.SetChildIndex(this.lblHard3, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.lblUnlockHard, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEasyMode;
        private System.Windows.Forms.Button btnHardMode;
        public System.Windows.Forms.Label lblEasyHard;
        public System.Windows.Forms.Label lblEasy1;
        public System.Windows.Forms.Label lblEasy2;
        public System.Windows.Forms.Label lblEasy3;
        public System.Windows.Forms.Label lblHard1;
        public System.Windows.Forms.Label lblHard2;
        public System.Windows.Forms.Label lblHard3;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Label lblUnlockHard;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}