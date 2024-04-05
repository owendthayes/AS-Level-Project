using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Coursework_Quiz_Game
{
    public partial class HardQuestionForm : MasterForm
    {
        Player thisPlayer;
        string correctAns = "8";
        bool replay;                //values passed from previous form (thisPlayer, replay and dummyArray)
        int[] dummyArray;
        int timeLeft = 30;  //the length of the timer is set here.

        Stream sr;
        BinaryFormatter bf = new BinaryFormatter();

        Questions Question = new Questions();
        List<Questions> listQuestions = new List<Questions>();

        public HardQuestionForm(Player ThisPlayer, int[]DummyArray, bool Replay)
        {
            InitializeComponent();

            thisPlayer = ThisPlayer;
            replay = Replay;
            dummyArray = DummyArray;

            questionTime.Start(); //question timer starts

            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score;   //information in bottom right is updated
            imgAvatar.Image = thisPlayer.Avatar;//to show players information
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
            txtAnswer.Enabled = false;  
            if (txtAnswer.Text.Trim() == correctAns) //checks if answer matches answer stored.
                {                                   
                    msgCorrectAns.Visible = true;
                    thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 10); //10 points added to score
                    lblScore.Text = thisPlayer.Score;
                    txtAnswer.BackColor = Color.LimeGreen; //text box becomes green to show answer is correct.
                    btnSubmitAnswer.Enabled = false;       //user cant keep submitting for more points.
                    btnNextQuestion.Enabled = true;
                }

                else
                {
                    msgIncorrectAns.Visible = true;
                    btnSubmitAnswer.Enabled = false; //player cant keep submitting.
                    txtAnswer.BackColor = Color.Red; //box becomes red to show answer is incorrect.
                    btnNextQuestion.Enabled = true;
                }
            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            Form Form1 = new HardQuestionForm2(thisPlayer, dummyArray, replay); //create instance of Form1 and pass it the object thisPlayer
            this.Close();   //current form is closed, question form 2 is opened.
            Form1.Show();
        }

        private void HardQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
            questionTime.Stop();    //when help is opened, the question timer is paused.    
            btnUnpause.Visible = true; //this is the unpause button for the question.
        }

        private void questionTime_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            lblTimeLeft.Text = Convert.ToString(timeLeft); //the label for the timer is updated to visually show timer.

            if(timeLeft == 0)
            {
                questionTime.Stop(); //timer doesnt keep going down into negative numbers.
                lblTimeUp.Visible = true; //user is told they have run out of time
                btnSubmitAnswer.Enabled = false; //user cant submit answer and has to move on.
                btnNextQuestion.Enabled = true;
            }

            if(timeLeft <= 10) //when there are 10 seconds left, the label changes visually to signify this.
            {
                lblDisplayTime.ForeColor = Color.Yellow;
                lblDisplayTime.BackColor = Color.Red;

                lblTimeLeft.ForeColor = Color.Yellow;
                lblTimeLeft.BackColor = Color.Red;
            }
        }

        private void btnUnpause_Click(object sender, EventArgs e)
        {
            btnUnpause.Visible = false; //the button covers the question so the user cant keep looking at it for an advantage.
            questionTime.Start(); //the timer starts again.

            if (btnNextQuestion.Enabled == true)
            {
                questionTime.Stop();    //if the user has already submitted their answer for the question
            }                           //the timer wont keep ticking when unpause is clicked.
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";   //user is asked to confirm if they wish to log out with a message box.
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form Form1 = new NewPlayer();
                this.Close();   //login form is opened again without passing player object
                Form1.Show();   //player can register or log in again.
            }
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)  
        {
            try
            {
                Convert.ToInt16(txtAnswer.Text);
            }
            catch (Exception)   //if the user enters a letter instead of a number, the answer box is cleared.
            {
                txtAnswer.Text = null;
            }
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)    //the user is unable to enter spaces into the answer box.
                e.SuppressKeyPress = true;
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
