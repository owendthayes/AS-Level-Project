using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_Quiz_Game
{
    public partial class QuestionForm2 : MasterForm      
    {
        Player thisPlayer;
        int[] dummyArray;
        bool replay;
        int timeLeft = 60;

        public QuestionForm2(Player ThisPlayer, int[] DummyArray, bool Replay)
        {
            InitializeComponent();

            lblQuestion.Text = "What is 10 multiplied by 4?";
            lblQuestionNo.Text = "Question Number 2";

            questionTime.Start();

            rdbAnswer1.Text = "14";
            rdbAnswer2.Text = "40";
            rdbAnswer3.Text = "104";

            thisPlayer = ThisPlayer;
            dummyArray = DummyArray;
            replay = Replay;

            lblName.Text = thisPlayer.Name;
            lblScore.Text = Convert.ToString(thisPlayer.Score);
            imgAvatar.Image = thisPlayer.Avatar;
            lblHighscore.Text = thisPlayer.Highscore;

            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            questionTime.Stop();
            rdbAnswer1.Enabled = false;
            rdbAnswer2.Enabled = false;
            rdbAnswer3.Enabled = false;

            btnNextQuestion.Enabled = true;
            if (rdbAnswer2.Checked == true)
            {
                msgCorrectAns.Visible = true;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 5);
                lblScore.Text = thisPlayer.Score;
                rdbAnswer2.BackColor = Color.Green;
                btnSubmitAnswer.Enabled = false;
            }

            else if (rdbAnswer1.Checked == true)
            {
                msgIncorrectAns.Visible = true;
                btnSubmitAnswer.Enabled = false;
                rdbAnswer1.BackColor = Color.Red;
            }

            else if (rdbAnswer3.Checked == true)
            {
                msgIncorrectAns.Visible = true;
                btnSubmitAnswer.Enabled = false;
                rdbAnswer3.BackColor = Color.Red;
            }

            else
            {
                msgIncorrectAns.Visible = true;
                btnSubmitAnswer.Enabled = false;
            }

            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Form1 = new QuestionForm3(thisPlayer, dummyArray, replay); //create instance of Form1 and pass it the object thisPlayer
            Form1.Location = this.Location;
            Form1.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form Form1 = new NewPlayer();
                this.Close();
                Form1.Show();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
        }

        private void rdbAnswer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAnswer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestionNo_Click(object sender, EventArgs e)
        {

        }

        private void rdbAnswer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void questionTime_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            lblTimeRemaining.Text = Convert.ToString(timeLeft);
            if (timeLeft == 0)
            {
                questionTime.Stop();
                btnSubmitAnswer.Enabled = false;
                btnNextQuestion.Enabled = true;
                lblTimeUp.Visible = true;
            }
            if (timeLeft <= 10)
            {
                lblDisplayTimer.ForeColor = Color.Yellow;
                lblDisplayTimer.BackColor = Color.Red;

                lblTimeRemaining.ForeColor = Color.Yellow;
                lblTimeRemaining.BackColor = Color.Red;
            }
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
            btnUnpause.Visible = true;
            questionTime.Stop();
        }

        private void btnUnpause_Click(object sender, EventArgs e)
        {
            btnUnpause.Visible = false;
            questionTime.Start();

            if (btnNextQuestion.Enabled == true)
            {
                questionTime.Stop();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to quit?";
            string title = "Quit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                SplashScreen obj = (SplashScreen)Application.OpenForms["SplashScreen"];
                obj.Close();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);     //message box appears asking user to confirm
            if (result == DialogResult.Yes)                                     //if they want to log out
            {
                Form Form1 = new NewPlayer();
                this.Close();
                Form1.Show();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
            questionTime.Stop();    //when help is opened, the question timer is paused.    
            btnUnpause.Visible = true; //this is the unpause button for the question.
        }
    }
}
