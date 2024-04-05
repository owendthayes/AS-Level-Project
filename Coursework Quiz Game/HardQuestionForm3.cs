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
    public partial class HardQuestionForm3 : MasterForm
    {
        Player thisPlayer;
        bool replay;
        int[] dummyArray;

        int NumberCorrect = 0, timeLeft = 30;   //time limit set here and variable to tell user how many questions they got right.

        public HardQuestionForm3(Player ThisPlayer, int[] DummyArray, bool Replay)
        {
            InitializeComponent();

            thisPlayer = ThisPlayer;
            replay = Replay;            //values passed from previous form.
            dummyArray = DummyArray;

            questionTime.Start();   //timer for question starts.

            lblName.Text = thisPlayer.Name;
            lblScore.Text = Convert.ToString(thisPlayer.Score);
            imgAvatar.Image = thisPlayer.Avatar;        //info in bottom right set to show info
            lblHighscore.Text = thisPlayer.Highscore;   //about the player.

            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            questionTime.Stop();
            cmbBox1.Enabled = false;
            cmbBox2.Enabled = false;
            cmbBox3.Enabled = false;    //user cant keep selecting answers after they have submit their answer.
            cmbBox4.Enabled = false;

            if (cmbBox3.Text == "Median") //code if first answer is correct.
            {
                cmbBox3.BackColor = Color.Green;
                lblMedianQ.ForeColor = Color.Green;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 10);
                lblScore.Text = thisPlayer.Score;
                NumberCorrect = NumberCorrect + 1; 
            }
            else
                lblMedianQ.ForeColor = Color.Red;   //or if its incorrect.

            if (cmbBox2.Text == "Mean") //code if second answer is correct.
            {
                cmbBox2.BackColor = Color.Green;
                lblMeanQ.ForeColor = Color.Green;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 10);
                lblScore.Text = thisPlayer.Score;
                NumberCorrect = NumberCorrect + 1;
            }
            else
                lblMeanQ.ForeColor = Color.Red; //or if its incorrect.

            if (cmbBox1.Text == "Mode") //code if third answer is correct.
            {
                cmbBox1.BackColor = Color.Green;
                lblModeQ.ForeColor = Color.Green;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 10);
                lblScore.Text = thisPlayer.Score;
                NumberCorrect = NumberCorrect + 1;  
            }
            else
                lblModeQ.ForeColor = Color.Red; //or if its incorrect.

            if (cmbBox4.Text == "Range")    //if fourth answer is correct.
            {
                cmbBox4.BackColor = Color.Green;
                lblRangeQ.ForeColor = Color.Green;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 10);
                lblScore.Text = thisPlayer.Score;
                NumberCorrect = NumberCorrect + 1;
            }
            else
                lblRangeQ.ForeColor = Color.Red;    //or if its incorrect.

            msgIncorrectAns.Text = (NumberCorrect + " questions correct.\nPlease move on to the next question");
            msgIncorrectAns.Visible = true;     
            btnSubmitAnswer.Enabled = false;    //player cant keep submitting, must move on.
            btnNextQuestion.Enabled = true;
            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Form1 = new HardQuestionForm4(thisPlayer, dummyArray, replay); //open the next question form and pass the values
            Form1.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
            btnUnpause.Visible = true;  //open help form, pause the quiz.
            questionTime.Stop();
        }

        private void btnUnpause_Click(object sender, EventArgs e)
        {
            btnUnpause.Visible = false;
            questionTime.Start();   

            if (btnNextQuestion.Enabled == true)
            {
                questionTime.Stop();        //dont unpause the timer if user already submitted
            }
        }

        private void msgIncorrectAns_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form Form1 = new NewPlayer();   //ask user to confirm if they want to log out
                this.Close();                   //if the confirm, open the login form again.
                Form1.Show();
            }
        }

        private void lblRangeQ_Click(object sender, EventArgs e)
        {

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

        private void questionTime_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            lblTimeLeft.Text = Convert.ToString(timeLeft);

            if (timeLeft == 0)
            {
                questionTime.Stop();
                lblTimeUp.Visible = true;       //stop timer when time hits 0, user cant answer now.
                btnSubmitAnswer.Enabled = false;
                btnNextQuestion.Enabled = true;
            }

            if (timeLeft <= 10) //visually change timer to show there is not much time left.
            {
                lblDisplayTime.ForeColor = Color.Yellow;
                lblDisplayTime.BackColor = Color.Red;       
                                                        
                lblTimeLeft.ForeColor = Color.Yellow;   
                lblTimeLeft.BackColor = Color.Red;
            }
        }
    }
}
