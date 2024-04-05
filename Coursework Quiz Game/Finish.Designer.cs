namespace Coursework_Quiz_Game
{
    partial class Finish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finish));
            this.lblCongrats = new System.Windows.Forms.Label();
            this.imgFinishAvatar = new System.Windows.Forms.PictureBox();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblBeatHighscore = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFinishAvatar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCongrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCongrats.ForeColor = System.Drawing.Color.White;
            this.lblCongrats.Location = new System.Drawing.Point(68, 181);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(179, 31);
            this.lblCongrats.TabIndex = 35;
            this.lblCongrats.Text = "congrats user";
            this.lblCongrats.Click += new System.EventHandler(this.lblCongrats_Click);
            // 
            // imgFinishAvatar
            // 
            this.imgFinishAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFinishAvatar.Location = new System.Drawing.Point(74, 260);
            this.imgFinishAvatar.Name = "imgFinishAvatar";
            this.imgFinishAvatar.Size = new System.Drawing.Size(289, 273);
            this.imgFinishAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFinishAvatar.TabIndex = 36;
            this.imgFinishAvatar.TabStop = false;
            this.imgFinishAvatar.Click += new System.EventHandler(this.imgFinishAvatar_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.Purple;
            this.btnReplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnReplay.Location = new System.Drawing.Point(650, 373);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(215, 85);
            this.btnReplay.TabIndex = 37;
            this.btnReplay.Text = "Replay Quiz";
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Purple;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(650, 464);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(215, 85);
            this.btnLogout.TabIndex = 38;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblBeatHighscore
            // 
            this.lblBeatHighscore.AutoSize = true;
            this.lblBeatHighscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBeatHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBeatHighscore.ForeColor = System.Drawing.Color.White;
            this.lblBeatHighscore.Location = new System.Drawing.Point(389, 270);
            this.lblBeatHighscore.Name = "lblBeatHighscore";
            this.lblBeatHighscore.Size = new System.Drawing.Size(185, 31);
            this.lblBeatHighscore.TabIndex = 39;
            this.lblBeatHighscore.Text = "beathighscore";
            this.lblBeatHighscore.Click += new System.EventHandler(this.lblBeatHighscore_Click);
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
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.Purple;
            this.btnLeaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLeaderboard.Location = new System.Drawing.Point(429, 373);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(215, 85);
            this.btnLeaderboard.TabIndex = 60;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Purple;
            this.btnGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGame.Enabled = false;
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGame.Location = new System.Drawing.Point(429, 464);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(215, 85);
            this.btnGame.TabIndex = 61;
            this.btnGame.Text = "Block Jumper Game!";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(464, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 50);
            this.label2.TabIndex = 62;
            this.label2.Text = "You must beat or match your previous\r\n highscore to unlock BlockJumper";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.Purple;
            this.btnFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnFeedback.Location = new System.Drawing.Point(871, 373);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(215, 85);
            this.btnFeedback.TabIndex = 76;
            this.btnFeedback.Text = "Leave Feedback Here";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblBeatHighscore);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.imgFinishAvatar);
            this.Controls.Add(this.lblCongrats);
            this.Name = "Finish";
            this.Text = "Finish";
            this.Load += new System.EventHandler(this.Finish_Load);
            this.Controls.SetChildIndex(this.lblCongrats, 0);
            this.Controls.SetChildIndex(this.imgFinishAvatar, 0);
            this.Controls.SetChildIndex(this.btnReplay, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.lblBeatHighscore, 0);
            this.Controls.SetChildIndex(this.UserInfoBackround, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.lblDisplayHighscore, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblDisplayUsername, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblDisplayScore, 0);
            this.Controls.SetChildIndex(this.imgAvatar, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.btnLeaderboard, 0);
            this.Controls.SetChildIndex(this.btnGame, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.btnFeedback, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFinishAvatar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgFinishAvatar;
        public System.Windows.Forms.Label lblCongrats;
        public System.Windows.Forms.Button btnReplay;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Label lblBeatHighscore;
        private System.Windows.Forms.Button btnHelp;
        public System.Windows.Forms.Button btnLeaderboard;
        public System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.Button btnFeedback;
    }
}