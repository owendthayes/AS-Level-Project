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
    public partial class QuestionForm4 : MasterForm
    {
        public static string selectedPicture;
        public static int correctNo;
        public bool drag1Correct = false;
        public bool drag2Correct = false;
        public bool drag3Correct = false;

        Player thisPlayer;
        int[] dummyArray;
        bool replay;
        int timeLeft = 60;

        public QuestionForm4(Player ThisPlayer, int[] DummyArray, bool Replay)
        {
            InitializeComponent();

            lblQuestion.Text = "Drag the words to the correct numbers";
            lblQuestionNo.Text = "Question Number 4";

            thisPlayer = ThisPlayer;
            dummyArray = DummyArray;
            replay = Replay;

            questionTime.Start();

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

        private void QuestionForm4_Load(object sender, EventArgs e)
        {
            imgDrag1.AllowDrop = true;
            imgDrag2.AllowDrop = true;
            imgDrag3.AllowDrop = true;
            imgDrop1.AllowDrop = true;
            imgDrop2.AllowDrop = true;
            imgDrop3.AllowDrop = true;
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
            imgDrop1.AllowDrop = false;         
            if (selectedPicture == imgDrop1.Tag.ToString())
            {
                drag1Correct = true;
                selectedPicture = "";            
            }
        }

        private void imgDrop1_DragEnter(object sender, DragEventArgs e)
        {
            lblBox1Matched.Text = selectedPicture;
            e.Effect = DragDropEffects.Copy;            
        }
        private void imgDrop1_DragLeave(object sender, EventArgs e)
        {
            lblBox1Matched.Text = "";
        }

        private void imgDrop2_DragDrop(object sender, DragEventArgs e)
        {
            imgDrop2.AllowDrop = false;
            if (selectedPicture == imgDrop2.Tag.ToString())
            {
                drag2Correct = true;
                selectedPicture = "";
            }
        }

        private void imgDrop2_DragEnter(object sender, DragEventArgs e)
        {
            lblBox2Matched.Text = selectedPicture;
            e.Effect = DragDropEffects.Copy;
        }
        private void imgDrop2_DragLeave(object sender, EventArgs e)
        {
            lblBox2Matched.Text = "";
        }

        private void imgDrop3_DragDrop(object sender, DragEventArgs e)
        {
            imgDrop3.AllowDrop = false;
            if (selectedPicture == imgDrop3.Tag.ToString())
            {
                drag3Correct = true;
                selectedPicture = "";
            }
        }

        private void imgDrop3_DragEnter(object sender, DragEventArgs e)
        {
            lblBox3Matched.Text = selectedPicture;
            e.Effect = DragDropEffects.Copy;
        }
        private void imgDrop3_DragLeave(object sender, EventArgs e)
        {
            lblBox3Matched.Text = "";
        }

        private void imgDrag1_Click(object sender, EventArgs e)
        {

        }

        private void imgDrop3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void imgDrop3_DragEnter_1(object sender, DragEventArgs e)
        {

        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            questionTime.Stop();
            btnSubmitAnswer.Enabled = false;
            if (drag3Correct == true)
            {
                correctNo += 1;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 5);
                Drop3Correct.BackColor = Color.Green;
            }
            else
                Drop3Correct.BackColor = Color.Red;

            if (drag2Correct == true)
            {
                correctNo += 1;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 5);
                Drop2Correct.BackColor = Color.Green;
            }
            else
                Drop2Correct.BackColor = Color.Red;

            if (drag1Correct == true)
            {
                correctNo += 1;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 5);
                Drop1Correct.BackColor = Color.Green;
            }
            else
                Drop1Correct.BackColor = Color.Red;

            if(correctNo > 3)
            {
                correctNo = 3;
            }

            msgIncorrectAns.Text = (correctNo + " correct answer(s)\nPlease move on to the next question");
            msgIncorrectAns.Visible = true;
            lblScore.Text = thisPlayer.Score;
            btnNextQuestion.Enabled = true;
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
            Form Form1 = new Finish(thisPlayer, dummyArray, replay); //create instance of Form1 and pass it the object thisPlayer
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

        private void Drop2Correct_Click(object sender, EventArgs e)
        {

        }

        private void lblBox1Matched_Click(object sender, EventArgs e)
        {

        }

        private void Drop3Correct_Click(object sender, EventArgs e)
        {

        }

        private void Drop1Correct_Click(object sender, EventArgs e)
        {

        }

        private void lblBox2Matched_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form Form1 = new QuestionForm4(thisPlayer, dummyArray, replay);
            Form1.Show();
            this.Close();
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
                btnReset.Enabled = false;
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
