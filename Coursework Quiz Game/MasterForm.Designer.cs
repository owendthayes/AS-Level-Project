namespace Coursework_Quiz_Game
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.lblDisplayScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblDisplayUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.UserInfoBackround = new System.Windows.Forms.PictureBox();
            this.lblDisplayHighscore = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Purple;
            this.pictureBox1.Location = new System.Drawing.Point(13, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1247, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maths Quiz!";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(1190, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 70);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackColor = System.Drawing.Color.Purple;
            this.imgAvatar.Location = new System.Drawing.Point(1170, 591);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(90, 90);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAvatar.TabIndex = 33;
            this.imgAvatar.TabStop = false;
            this.imgAvatar.Click += new System.EventHandler(this.imgAvatar_Click);
            // 
            // lblDisplayScore
            // 
            this.lblDisplayScore.AutoSize = true;
            this.lblDisplayScore.BackColor = System.Drawing.Color.Purple;
            this.lblDisplayScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDisplayScore.ForeColor = System.Drawing.Color.White;
            this.lblDisplayScore.Location = new System.Drawing.Point(964, 603);
            this.lblDisplayScore.Name = "lblDisplayScore";
            this.lblDisplayScore.Size = new System.Drawing.Size(75, 25);
            this.lblDisplayScore.TabIndex = 32;
            this.lblDisplayScore.Text = "Score: ";
            this.lblDisplayScore.Click += new System.EventHandler(this.lblDisplayScore_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Purple;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(1072, 603);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(64, 25);
            this.lblScore.TabIndex = 31;
            this.lblScore.Text = "Score";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblDisplayUsername
            // 
            this.lblDisplayUsername.AutoSize = true;
            this.lblDisplayUsername.BackColor = System.Drawing.Color.Purple;
            this.lblDisplayUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDisplayUsername.ForeColor = System.Drawing.Color.White;
            this.lblDisplayUsername.Location = new System.Drawing.Point(964, 558);
            this.lblDisplayUsername.Name = "lblDisplayUsername";
            this.lblDisplayUsername.Size = new System.Drawing.Size(113, 25);
            this.lblDisplayUsername.TabIndex = 30;
            this.lblDisplayUsername.Text = "Username: ";
            this.lblDisplayUsername.Click += new System.EventHandler(this.lblDisplayUsername_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Purple;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(1072, 558);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 25);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "User";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // UserInfoBackround
            // 
            this.UserInfoBackround.BackColor = System.Drawing.Color.Purple;
            this.UserInfoBackround.Location = new System.Drawing.Point(948, 546);
            this.UserInfoBackround.Name = "UserInfoBackround";
            this.UserInfoBackround.Size = new System.Drawing.Size(324, 150);
            this.UserInfoBackround.TabIndex = 34;
            this.UserInfoBackround.TabStop = false;
            this.UserInfoBackround.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblDisplayHighscore
            // 
            this.lblDisplayHighscore.AutoSize = true;
            this.lblDisplayHighscore.BackColor = System.Drawing.Color.Purple;
            this.lblDisplayHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDisplayHighscore.ForeColor = System.Drawing.Color.White;
            this.lblDisplayHighscore.Location = new System.Drawing.Point(964, 643);
            this.lblDisplayHighscore.Name = "lblDisplayHighscore";
            this.lblDisplayHighscore.Size = new System.Drawing.Size(106, 25);
            this.lblDisplayHighscore.TabIndex = 36;
            this.lblDisplayHighscore.Text = "Highscore:";
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.BackColor = System.Drawing.Color.Purple;
            this.lblHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHighscore.ForeColor = System.Drawing.Color.White;
            this.lblHighscore.Location = new System.Drawing.Point(1072, 643);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(97, 25);
            this.lblHighscore.TabIndex = 35;
            this.lblHighscore.Text = "highscore";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(710, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(513, 495);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(513, 495);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Purple;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1110, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDisplayHighscore);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.imgAvatar);
            this.Controls.Add(this.lblDisplayScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDisplayUsername);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.UserInfoBackround);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maths Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoBackround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.PictureBox imgAvatar;
        public System.Windows.Forms.Label lblDisplayScore;
        public System.Windows.Forms.Label lblScore;
        public System.Windows.Forms.Label lblDisplayUsername;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.PictureBox UserInfoBackround;
        public System.Windows.Forms.Label lblDisplayHighscore;
        public System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}