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
    public partial class HardQuestionForm2 : MasterForm
    {
        Player thisPlayer;
        bool replay;
        int[] dummyArray;
        int timeLeft = 30;  //length of question timer set here

        public HardQuestionForm2(Player ThisPlayer, int[] DummyArray, bool Replay)
        {
            InitializeComponent();

            thisPlayer = ThisPlayer;
            replay = Replay;            //values passed from other form are recieved.
            dummyArray = DummyArray;

            questionTime.Start();   //timer for question starts.

            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score;   //information in bottom right is set to show
            imgAvatar.Image = thisPlayer.Avatar;//players information here.
            lblHighscore.Text = thisPlayer.Highscore;

            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            questionTime.Stop(); //timer wont keep ticking when user submits answer
            btnNextQuestion.Enabled = true;

            rdbAnswer1.Enabled = false;
            rdbAnswer2.Enabled = false; //user cant keep selecting answers after they have submitted.
            rdbAnswer3.Enabled = false;

            if (rdbAnswer2.Checked == true) //this is the correct answer
            {
                msgCorrectAns.Visible = true;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 10); //10 points added to score.
                lblScore.Text = thisPlayer.Score;
                rdbAnswer2.BackColor = Color.Green; //visually shown their answer is correct.
                btnSubmitAnswer.Enabled = false; //user cant keep submitting for more points.
            }

            else if (rdbAnswer1.Checked == true)
            {
                msgIncorrectAns.Visible = true;
                btnSubmitAnswer.Enabled = false; //cant keep submitting
                rdbAnswer1.BackColor = Color.Red; //visually shown answer is incorrect.
            }

            else if (rdbAnswer3.Checked == true)
            {
                msgIncorrectAns.Visible = true; 
                btnSubmitAnswer.Enabled = false; //cant keep submitting
                rdbAnswer3.BackColor = Color.Red; //visually shown answer is incorrect.
            }
            else
            {
                msgIncorrectAns.Visible = true; //if user hits submit without selecting an answer
                btnSubmitAnswer.Enabled = false; //the question is marked wrong.
            }

            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            Form Form1 = new HardQuestionForm3(thisPlayer, dummyArray, replay); //next question is opened, values are passed through.
            this.Close();
            Form1.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
            btnUnpause.Visible = true; //unpause button is shown.
            questionTime.Stop(); //question timer is paused.
        }

        private void questionTime_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            lblTimeLeft.Text = Convert.ToString(timeLeft); //timer visually updated.

            if (timeLeft == 0)
            {
                questionTime.Stop(); //timer doesnt keep ticking into negative numbers.
                lblTimeUp.Visible = true;
                btnSubmitAnswer.Enabled = false; //cant submit when time is up, have to move on.
                btnNextQuestion.Enabled = true;
            }

            if (timeLeft <= 10) //if there are 10 seconds left, time is changed to signify this.
            {
                lblDisplayTime.ForeColor = Color.Yellow;
                lblDisplayTime.BackColor = Color.Red;

                lblTimeLeft.ForeColor = Color.Yellow;
                lblTimeLeft.BackColor = Color.Red;
            }
        }

        private void btnUnpause_Click(object sender, EventArgs e)
        {
            btnUnpause.Visible = false;
            questionTime.Start();

            if (btnNextQuestion.Enabled == true)
            {
                questionTime.Stop(); //timer wont keep ticking if user has already submitted their answer.
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";   //user asked to confirm if they want to log out
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form Form1 = new NewPlayer();
                this.Close();   //login form opened again, so player can login or register.
                Form1.Show();   
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
