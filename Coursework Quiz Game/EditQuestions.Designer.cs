namespace Coursework_Quiz_Game
{
    partial class EditQuestions
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnNextQ = new System.Windows.Forms.Button();
            this.btnPrevQ = new System.Windows.Forms.Button();
            this.btnSaveQ = new System.Windows.Forms.Button();
            this.btnDelQ = new System.Windows.Forms.Button();
            this.lblAddNewTxtBoxQuestion = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clkValidQue = new System.Windows.Forms.Timer(this.components);
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
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(421, 254);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(65, 17);
            this.lblQuestion.TabIndex = 57;
            this.lblQuestion.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(546, 254);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(248, 20);
            this.txtQuestion.TabIndex = 58;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.BackColor = System.Drawing.Color.Purple;
            this.lblAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAns.ForeColor = System.Drawing.Color.White;
            this.lblAns.Location = new System.Drawing.Point(421, 304);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(104, 17);
            this.lblAns.TabIndex = 59;
            this.lblAns.Text = "Correct Answer";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(546, 303);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(248, 20);
            this.txtAns.TabIndex = 60;
            this.txtAns.TextChanged += new System.EventHandler(this.txtAns_TextChanged);
            this.txtAns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAns_KeyDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Purple;
            this.pictureBox5.Location = new System.Drawing.Point(406, 225);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(429, 137);
            this.pictureBox5.TabIndex = 61;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btnNextQ
            // 
            this.btnNextQ.BackColor = System.Drawing.Color.Purple;
            this.btnNextQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNextQ.Location = new System.Drawing.Point(776, 392);
            this.btnNextQ.Name = "btnNextQ";
            this.btnNextQ.Size = new System.Drawing.Size(127, 79);
            this.btnNextQ.TabIndex = 62;
            this.btnNextQ.Text = "Next";
            this.btnNextQ.UseVisualStyleBackColor = false;
            this.btnNextQ.Click += new System.EventHandler(this.btnNextQ_Click);
            // 
            // btnPrevQ
            // 
            this.btnPrevQ.BackColor = System.Drawing.Color.Purple;
            this.btnPrevQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPrevQ.Location = new System.Drawing.Point(377, 392);
            this.btnPrevQ.Name = "btnPrevQ";
            this.btnPrevQ.Size = new System.Drawing.Size(127, 79);
            this.btnPrevQ.TabIndex = 63;
            this.btnPrevQ.Text = "Previous";
            this.btnPrevQ.UseVisualStyleBackColor = false;
            this.btnPrevQ.Click += new System.EventHandler(this.btnPrevQ_Click);
            // 
            // btnSaveQ
            // 
            this.btnSaveQ.BackColor = System.Drawing.Color.Purple;
            this.btnSaveQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSaveQ.Location = new System.Drawing.Point(643, 392);
            this.btnSaveQ.Name = "btnSaveQ";
            this.btnSaveQ.Size = new System.Drawing.Size(127, 79);
            this.btnSaveQ.TabIndex = 64;
            this.btnSaveQ.Text = "Save";
            this.btnSaveQ.UseVisualStyleBackColor = false;
            this.btnSaveQ.Click += new System.EventHandler(this.btnSaveQ_Click);
            // 
            // btnDelQ
            // 
            this.btnDelQ.BackColor = System.Drawing.Color.Purple;
            this.btnDelQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDelQ.Location = new System.Drawing.Point(510, 392);
            this.btnDelQ.Name = "btnDelQ";
            this.btnDelQ.Size = new System.Drawing.Size(127, 79);
            this.btnDelQ.TabIndex = 65;
            this.btnDelQ.Text = "Delete";
            this.btnDelQ.UseVisualStyleBackColor = false;
            this.btnDelQ.Click += new System.EventHandler(this.btnDelQ_Click);
            // 
            // lblAddNewTxtBoxQuestion
            // 
            this.lblAddNewTxtBoxQuestion.AutoSize = true;
            this.lblAddNewTxtBoxQuestion.BackColor = System.Drawing.Color.Purple;
            this.lblAddNewTxtBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAddNewTxtBoxQuestion.ForeColor = System.Drawing.Color.White;
            this.lblAddNewTxtBoxQuestion.Location = new System.Drawing.Point(457, 186);
            this.lblAddNewTxtBoxQuestion.Name = "lblAddNewTxtBoxQuestion";
            this.lblAddNewTxtBoxQuestion.Size = new System.Drawing.Size(291, 25);
            this.lblAddNewTxtBoxQuestion.TabIndex = 66;
            this.lblAddNewTxtBoxQuestion.Text = "View, Edit and Delete Questions";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Purple;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button8.Location = new System.Drawing.Point(13, 558);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 123);
            this.button8.TabIndex = 67;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(410, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 152);
            this.label2.TabIndex = 68;
            this.label2.Text = "You can only change the question OR answer, not both at the same time.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // EditQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lblAddNewTxtBoxQuestion);
            this.Controls.Add(this.btnDelQ);
            this.Controls.Add(this.btnSaveQ);
            this.Controls.Add(this.btnPrevQ);
            this.Controls.Add(this.btnNextQ);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.pictureBox5);
            this.Name = "EditQuestions";
            this.Text = "EditQuestions";
            this.Load += new System.EventHandler(this.EditQuestions_Load);
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.UserInfoBackround, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblDisplayUsername, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.lblDisplayScore, 0);
            this.Controls.SetChildIndex(this.imgAvatar, 0);
            this.Controls.SetChildIndex(this.lblHighscore, 0);
            this.Controls.SetChildIndex(this.lblDisplayHighscore, 0);
            this.Controls.SetChildIndex(this.txtQuestion, 0);
            this.Controls.SetChildIndex(this.lblQuestion, 0);
            this.Controls.SetChildIndex(this.lblAns, 0);
            this.Controls.SetChildIndex(this.txtAns, 0);
            this.Controls.SetChildIndex(this.btnNextQ, 0);
            this.Controls.SetChildIndex(this.btnPrevQ, 0);
            this.Controls.SetChildIndex(this.btnSaveQ, 0);
            this.Controls.SetChildIndex(this.btnDelQ, 0);
            this.Controls.SetChildIndex(this.lblAddNewTxtBoxQuestion, 0);
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

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnNextQ;
        private System.Windows.Forms.Button btnPrevQ;
        private System.Windows.Forms.Button btnSaveQ;
        private System.Windows.Forms.Button btnDelQ;
        private System.Windows.Forms.Label lblAddNewTxtBoxQuestion;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer clkValidQue;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}