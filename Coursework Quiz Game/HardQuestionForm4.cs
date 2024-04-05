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
    public partial class HardQuestionForm4 : MasterForm
    {
        public static string selectedPicture;   //used to see which picture has been dragged to which.
        public static int correctNo;
        public bool drag1Correct = false;
        public bool drag2Correct = false;   
        public bool drag3Correct = false;

        Player thisPlayer;
        int[] dummyArray;
        bool replay;
        int timeLeft = 30;  //set time limit for question

        public HardQuestionForm4(Player ThisPlayer, int[] DummyArray, bool Replay)
        {
            InitializeComponent();

            lblQuestion.Text = "Drag the words to the correct shapes";
            lblQuestionNo.Text = "Question Number 4";

            questionTime.Start();   //start the timer for the question.

            thisPlayer = ThisPlayer;
            replay = Replay;            //get the values from the other form.
            dummyArray = DummyArray;

            lblName.Text = thisPlayer.Name;
            lblScore.Text = Convert.ToString(thisPlayer.Score);
            imgAvatar.Image = thisPlayer.Avatar;        //show player info in bottom right.
            lblHighscore.Text = thisPlayer.Highscore;

            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }

        private void HardQuestionForm4_Load(object sender, EventArgs e)
        {
            imgDrag1.AllowDrop = true;
            imgDrag2.AllowDrop = true;
            imgDrag3.AllowDrop = true;  //start the form allowing all of the images to be moved.
            imgDrop1.AllowDrop = true;
            imgDrop2.AllowDrop = true;
            imgDrop3.AllowDrop = true;
        }

        private void imgDrop1_Click(object sender, EventArgs e)
        {

        }

        private void imgDrag1_MouseDown(object sender, MouseEventArgs e)
        {
            selectedPicture = imgDrag1.Tag.ToString();
            imgDrag1.DoDragDrop(imgDrag1.Image, DragDropEffects.Copy);
        }

        private void imgDrag2_MouseDown(object sender, MouseEventArgs e)
        {
            selectedPicture = imgDrag2.Tag.ToString();
            imgDrag2.DoDragDrop(imgDrag2.Image, DragDropEffects.Copy);
        }

        private void imgDrag3_MouseDown(object sender, MouseEventArgs e)
        {
            selectedPicture = imgDrag3.Tag.ToString();
            imgDrag3.DoDragDrop(imgDrag3.Image, DragDropEffects.Copy);
        }

        private void imgDrop1_DragDrop(object sender, DragEventArgs e)
        {
            imgDrop1.AllowDrop = false; //there cant be an answer on this image again.
            if (selectedPicture == imgDrop1.Tag.ToString()) //check thast the answer is correct.
            {
                drag1Correct = true;    
                selectedPicture = "";  
            }
        }

        private void imgDrop1_DragEnter(object sender, DragEventArgs e)
        {
            lblBox1Matched.Text = selectedPicture; //show the user what answer they have selected.
            e.Effect = DragDropEffects.Copy;
        }

        private void imgDrop1_DragLeave(object sender, EventArgs e)
        {
            lblBox1Matched.Text = ""; //if they dont let go of the mouse, dont lock this answer.
        }

        private void imgDrop2_DragDrop(object sender, DragEventArgs e)
        {
            imgDrop2.AllowDrop = false; //there cant be an answer on this image again.
            if (selectedPicture == imgDrop2.Tag.ToString()) //check that the answer is correct.
            {
                drag2Correct = true; 
                selectedPicture = "";
            }
        }

        private void imgDrop2_DragEnter(object sender, DragEventArgs e)
        {
            lblBox2Matched.Text = selectedPicture; //show user what answer they have selected.
            e.Effect = DragDropEffects.Copy;
        }

        private void imgDrop2_DragLeave(object sender, EventArgs e)
        {
            lblBox2Matched.Text = ""; //if they dont let go of the mouse, dont lock this answer.
        }

        private void imgDrop3_DragDrop(object sender, DragEventArgs e)
        {
            imgDrop3.AllowDrop = false; //there cant be an answer on this image again.
            if (selectedPicture == imgDrop3.Tag.ToString()) //check that the answer is correct.
            {
                drag3Correct = true;
                selectedPicture = "";
            }
        }

        private void imgDrop3_DragEnter(object sender, DragEventArgs e)
        {
            lblBox3Matched.Text = selectedPicture; //show user what answer they have selected.
            e.Effect = DragDropEffects.Copy;
        }

        private void imgDrop3_DragLeave(object sender, EventArgs e)
        {
            lblBox3Matched.Text = ""; //if they dont let go of the mouse, dont lock this answer.
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            questionTime.Stop();
            btnSubmitAnswer.Enabled = false; //user cant submit again
            if (drag3Correct == true) //visually show user answers are correct/incorrect,
            {
                correctNo += 1;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 10);
                Drop3Correct.BackColor = Color.Green;
            }
            else
                Drop3Correct.BackColor = Color.Red;

            if (drag2Correct == true)
            {
                correctNo += 1;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 10);
                Drop2Correct.BackColor = Color.Green;
            }
            else
                Drop2Correct.BackColor = Color.Red;

            if (drag1Correct == true)
            {
                correctNo += 1;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 10);
                Drop1Correct.BackColor = Color.Green;
            }
            else
                Drop1Correct.BackColor = Color.Red;

            if (correctNo > 3) //this is just to prevent any error that may occur.
            {
                correctNo = 3;
            }

            msgIncorrectAns.Text = (correctNo + " correct answer(s)\nPlease move on to the next question");
            msgIncorrectAns.Visible = true;
            lblScore.Text = thisPlayer.Score; //tell the user how many questions they got correct
            btnNextQuestion.Enabled = true; //the user can move on to the next question.
            btnReset.Enabled = false;

            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Form1 = new Finish(thisPlayer, dummyArray, replay); //pass values through to next form.
            Form1.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form Form1 = new HardQuestionForm4(thisPlayer, dummyArray, replay);
            Form1.Show(); //open and close the form so that the answers are reset.
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
            btnUnpause.Visible = true; //pause the quiz.
            questionTime.Stop();
        }

        private void questionTime_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            lblTimeLeft.Text = Convert.ToString(timeLeft);

            if (timeLeft == 0) //if user runs out of time, stop the timer and they cant answer.
            {
                questionTime.Stop();
                lblTimeUp.Visible = true;
                btnSubmitAnswer.Enabled = false; 
                btnNextQuestion.Enabled = true;
                btnReset.Enabled = false; //cant reset to try again.
            }

            if (timeLeft <= 10) //visually show that theres less time left.
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
                questionTime.Stop(); //if user has already submit, dont start the timer again.
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
                this.Close();   //if user confirms log out, bring them back to login screen.
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
