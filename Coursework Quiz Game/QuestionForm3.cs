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
    public partial class QuestionForm3 : MasterForm
    {
        Player thisPlayer;
        int NumberCorrect = 0, timeLeft = 60;
        int[] dummyArray;
        bool replay;

        public QuestionForm3(Player ThisPlayer, int[] DummyArray, bool Replay)
        {           
            InitializeComponent();

            lblQuestion.Text = "Select the correct word for each of the definitions.";
            lblQuestionNo.Text = "Question Number 3";

            questionTime.Start();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Form1 = new QuestionForm4(thisPlayer, dummyArray, replay); //create instance of Form1 and pass it the object thisPlayer
            Form1.Location = this.Location;
            Form1.Show();
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            questionTime.Stop();
            cmbBox1.Enabled = false;
            cmbBox2.Enabled = false;
            cmbBox3.Enabled = false;
            cmbBox4.Enabled = false;

            if (cmbBox3.Text == "Subtraction")
            {
                cmbBox3.BackColor = Color.Green;
                cmbBox3.ForeColor = Color.Green;
                lblSubtractQ.ForeColor = Color.Green;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 5);
                lblScore.Text = thisPlayer.Score;
                NumberCorrect = NumberCorrect + 1;
            }
            else
                lblSubtractQ.ForeColor = Color.Red;

            if (cmbBox2.Text == "Addition")
            {
                cmbBox2.BackColor = Color.Green;
                cmbBox2.ForeColor = Color.Green;
                lblAdditionQ.ForeColor = Color.Green;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 5);
                lblScore.Text = thisPlayer.Score;
                NumberCorrect = NumberCorrect + 1;
            }
            else
                lblAdditionQ.ForeColor = Color.Red;

            if (cmbBox1.Text == "Multiplication")
            {
                cmbBox1.BackColor = Color.Green;
                cmbBox1.ForeColor = Color.Green;
                lblMutliplicationQ.ForeColor = Color.Green;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 5);
                lblScore.Text = thisPlayer.Score;
                NumberCorrect = NumberCorrect + 1;
            }
            else
                lblMutliplicationQ.ForeColor = Color.Red;

            if (cmbBox4.Text == "Division")
            {
                cmbBox4.BackColor = Color.Green;
                cmbBox4.ForeColor = Color.Green;
                lblDivisionQ.ForeColor = Color.Green;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 5);
                lblScore.Text = thisPlayer.Score;
                NumberCorrect = NumberCorrect + 1;
            }
            else
                lblDivisionQ.ForeColor = Color.Red;

            msgIncorrectAns.Text = (NumberCorrect + " questions correct.\nPlease move on to the next question");
            msgIncorrectAns.Visible = true;
            btnSubmitAnswer.Enabled = false;
            btnNextQuestion.Enabled = true;

            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
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
            questionTime.Stop();
            btnUnpause.Visible = true;
        }

        private void btnUnpause_Click(object sender, EventArgs e)
        {
            questionTime.Start();
            btnUnpause.Visible = false;

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

        private void QuestionForm3_Load(object sender, EventArgs e)
        {

        }
    }    
}
