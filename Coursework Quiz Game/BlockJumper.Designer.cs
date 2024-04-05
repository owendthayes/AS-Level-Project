namespace Coursework_Quiz_Game
{
    partial class BlockJumper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockJumper));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.boxLow3 = new System.Windows.Forms.PictureBox();
            this.boxLow2 = new System.Windows.Forms.PictureBox();
            this.boxLow1 = new System.Windows.Forms.PictureBox();
            this.boxHigh3 = new System.Windows.Forms.PictureBox();
            this.boxHigh2 = new System.Windows.Forms.PictureBox();
            this.boxHigh1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.playerRunning = new System.Windows.Forms.PictureBox();
            this.playerJumping = new System.Windows.Forms.PictureBox();
            this.playerSliding = new System.Windows.Forms.PictureBox();
            this.clkPlayerRun = new System.Windows.Forms.Timer(this.components);
            this.clkAction = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.blockSpawner = new System.Windows.Forms.Timer(this.components);
            this.boxMover = new System.Windows.Forms.Timer(this.components);
            this.boxHighPass = new System.Windows.Forms.PictureBox();
            this.boxLowPass = new System.Windows.Forms.PictureBox();
            this.clkSpeedUp = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHigh3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHigh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHigh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRunning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerJumping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSliding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHighPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block Jumper";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Purple;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(859, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(13, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(589, 346);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(12, 362);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(592, 64);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // boxLow3
            // 
            this.boxLow3.BackColor = System.Drawing.Color.Black;
            this.boxLow3.Location = new System.Drawing.Point(472, 315);
            this.boxLow3.Name = "boxLow3";
            this.boxLow3.Size = new System.Drawing.Size(100, 50);
            this.boxLow3.TabIndex = 4;
            this.boxLow3.TabStop = false;
            this.boxLow3.Visible = false;
            // 
            // boxLow2
            // 
            this.boxLow2.BackColor = System.Drawing.Color.Black;
            this.boxLow2.Location = new System.Drawing.Point(318, 315);
            this.boxLow2.Name = "boxLow2";
            this.boxLow2.Size = new System.Drawing.Size(100, 50);
            this.boxLow2.TabIndex = 5;
            this.boxLow2.TabStop = false;
            this.boxLow2.Visible = false;
            // 
            // boxLow1
            // 
            this.boxLow1.BackColor = System.Drawing.Color.Black;
            this.boxLow1.Location = new System.Drawing.Point(146, 315);
            this.boxLow1.Name = "boxLow1";
            this.boxLow1.Size = new System.Drawing.Size(100, 50);
            this.boxLow1.TabIndex = 6;
            this.boxLow1.TabStop = false;
            this.boxLow1.Visible = false;
            // 
            // boxHigh3
            // 
            this.boxHigh3.BackColor = System.Drawing.Color.Black;
            this.boxHigh3.Location = new System.Drawing.Point(472, 80);
            this.boxHigh3.Name = "boxHigh3";
            this.boxHigh3.Size = new System.Drawing.Size(100, 229);
            this.boxHigh3.TabIndex = 7;
            this.boxHigh3.TabStop = false;
            this.boxHigh3.Visible = false;
            // 
            // boxHigh2
            // 
            this.boxHigh2.BackColor = System.Drawing.Color.Black;
            this.boxHigh2.Location = new System.Drawing.Point(318, 80);
            this.boxHigh2.Name = "boxHigh2";
            this.boxHigh2.Size = new System.Drawing.Size(100, 229);
            this.boxHigh2.TabIndex = 8;
            this.boxHigh2.TabStop = false;
            this.boxHigh2.Visible = false;
            // 
            // boxHigh1
            // 
            this.boxHigh1.BackColor = System.Drawing.Color.Black;
            this.boxHigh1.Location = new System.Drawing.Point(146, 80);
            this.boxHigh1.Name = "boxHigh1";
            this.boxHigh1.Size = new System.Drawing.Size(100, 229);
            this.boxHigh1.TabIndex = 9;
            this.boxHigh1.TabStop = false;
            this.boxHigh1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(608, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Instructions";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(608, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 306);
            this.label3.TabIndex = 11;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Red;
            this.pictureBox4.Location = new System.Drawing.Point(146, 362);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 28);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // playerRunning
            // 
            this.playerRunning.ErrorImage = null;
            this.playerRunning.Image = ((System.Drawing.Image)(resources.GetObject("playerRunning.Image")));
            this.playerRunning.InitialImage = null;
            this.playerRunning.Location = new System.Drawing.Point(42, 287);
            this.playerRunning.Name = "playerRunning";
            this.playerRunning.Size = new System.Drawing.Size(61, 73);
            this.playerRunning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerRunning.TabIndex = 13;
            this.playerRunning.TabStop = false;
            this.playerRunning.Click += new System.EventHandler(this.playerRunning_Click);
            // 
            // playerJumping
            // 
            this.playerJumping.Image = ((System.Drawing.Image)(resources.GetObject("playerJumping.Image")));
            this.playerJumping.Location = new System.Drawing.Point(79, 199);
            this.playerJumping.Name = "playerJumping";
            this.playerJumping.Size = new System.Drawing.Size(61, 73);
            this.playerJumping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerJumping.TabIndex = 14;
            this.playerJumping.TabStop = false;
            this.playerJumping.Visible = false;
            // 
            // playerSliding
            // 
            this.playerSliding.Image = ((System.Drawing.Image)(resources.GetObject("playerSliding.Image")));
            this.playerSliding.Location = new System.Drawing.Point(40, 305);
            this.playerSliding.Name = "playerSliding";
            this.playerSliding.Size = new System.Drawing.Size(100, 55);
            this.playerSliding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerSliding.TabIndex = 15;
            this.playerSliding.TabStop = false;
            this.playerSliding.Visible = false;
            // 
            // clkPlayerRun
            // 
            this.clkPlayerRun.Interval = 250;
            this.clkPlayerRun.Tick += new System.EventHandler(this.clkPlayerRun_Tick);
            // 
            // clkAction
            // 
            this.clkAction.Interval = 250;
            this.clkAction.Tick += new System.EventHandler(this.clkAction_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Purple;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(22, 90);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(115, 31);
            this.lblScore.TabIndex = 16;
            this.lblScore.Text = "Score: 0";
            // 
            // blockSpawner
            // 
            this.blockSpawner.Tick += new System.EventHandler(this.blockSpawner_Tick);
            // 
            // boxMover
            // 
            this.boxMover.Interval = 500;
            this.boxMover.Tick += new System.EventHandler(this.boxMover_Tick);
            // 
            // boxHighPass
            // 
            this.boxHighPass.BackColor = System.Drawing.Color.Black;
            this.boxHighPass.Location = new System.Drawing.Point(-64, 80);
            this.boxHighPass.Name = "boxHighPass";
            this.boxHighPass.Size = new System.Drawing.Size(100, 229);
            this.boxHighPass.TabIndex = 18;
            this.boxHighPass.TabStop = false;
            this.boxHighPass.Visible = false;
            // 
            // boxLowPass
            // 
            this.boxLowPass.BackColor = System.Drawing.Color.Black;
            this.boxLowPass.Location = new System.Drawing.Point(-64, 315);
            this.boxLowPass.Name = "boxLowPass";
            this.boxLowPass.Size = new System.Drawing.Size(100, 50);
            this.boxLowPass.TabIndex = 17;
            this.boxLowPass.TabStop = false;
            this.boxLowPass.Visible = false;
            // 
            // clkSpeedUp
            // 
            this.clkSpeedUp.Interval = 1000;
            this.clkSpeedUp.Tick += new System.EventHandler(this.clkSpeedUp_Tick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(607, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 74);
            this.label4.TabIndex = 19;
            this.label4.Text = "Replay";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Purple;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(739, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 74);
            this.label5.TabIndex = 20;
            this.label5.Text = "Back";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox5.Location = new System.Drawing.Point(-66, 80);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(78, 332);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFinish.ForeColor = System.Drawing.Color.White;
            this.lblFinish.Location = new System.Drawing.Point(192, 143);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(498, 141);
            this.lblFinish.TabIndex = 22;
            this.lblFinish.Text = "You got hit, Game Over!\r\nYour score was: \r\n";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinish.Visible = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.Purple;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(22, 121);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(194, 31);
            this.lblSpeed.TabIndex = 23;
            this.lblSpeed.Text = "Speed: Normal";
            this.lblSpeed.Click += new System.EventHandler(this.lblSpeed_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Purple;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(341, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 120);
            this.label6.TabIndex = 24;
            this.label6.Text = "Start Game";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BlockJumper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.boxHighPass);
            this.Controls.Add(this.boxLowPass);
            this.Controls.Add(this.playerRunning);
            this.Controls.Add(this.playerSliding);
            this.Controls.Add(this.playerJumping);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxHigh1);
            this.Controls.Add(this.boxHigh2);
            this.Controls.Add(this.boxHigh3);
            this.Controls.Add(this.boxLow1);
            this.Controls.Add(this.boxLow2);
            this.Controls.Add(this.boxLow3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "BlockJumper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlockJumper";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlockJumper_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHigh3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHigh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHigh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRunning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerJumping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSliding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHighPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox boxLow3;
        private System.Windows.Forms.PictureBox boxLow2;
        private System.Windows.Forms.PictureBox boxLow1;
        private System.Windows.Forms.PictureBox boxHigh3;
        private System.Windows.Forms.PictureBox boxHigh2;
        private System.Windows.Forms.PictureBox boxHigh1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox playerRunning;
        private System.Windows.Forms.PictureBox playerJumping;
        private System.Windows.Forms.PictureBox playerSliding;
        private System.Windows.Forms.Timer clkPlayerRun;
        private System.Windows.Forms.Timer clkAction;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer blockSpawner;
        private System.Windows.Forms.Timer boxMover;
        private System.Windows.Forms.PictureBox boxHighPass;
        private System.Windows.Forms.PictureBox boxLowPass;
        private System.Windows.Forms.Timer clkSpeedUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label6;
    }
}