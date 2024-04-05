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
    public partial class QuestionForm : MasterForm
    {
        Stream sr;
        BinaryFormatter bf = new BinaryFormatter();
        Player thisPlayer; //identifier for an object of type CurrentPlayer

        Questions Question = new Questions();
        List<Questions> listQuestions = new List<Questions>();

        public int[] dummyArray;
        bool replay;     
        int noQuestionsUsed, timeLeft = 60;
        bool nextFlag = false;        
            
        public QuestionForm(Player ThisPlayer, int[]DummyArray, bool Replay)
        {           
            InitializeComponent();

            thisPlayer = ThisPlayer; //this player identifier is now set to equal the object that was passed in as a parameter

            ReadQuestionToList();
            dummyArray = DummyArray;    //the dummy array is set to be the array that has been passed through if the player is replaying the quiz.
            dummyArray = getRandomQuestion(dummyArray, Replay);


            DummyArray = dummyArray;

            questionTime.Start(); //the timer for the question starts

            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score;
            imgAvatar.Image = thisPlayer.Avatar;    //the player's information is shown in the bottom right corner of the window.
            lblHighscore.Text = thisPlayer.Highscore;

            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore)) //if the player beats their highscore during runtime, it is displayed on the player information.
            {
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }

        private void ReadQuestionToList()
        {
            try
            {
                sr = File.OpenRead("Questions.bin");
                listQuestions = (List<Questions>)bf.Deserialize(sr);    //all questions are read into a list from the questions.bin file.
                sr.Close();              
            }
            catch (Exception)
            {
                bool noQuestions = true;
                Form Form1 = new AddQuestions(thisPlayer, noQuestions); //if the questions.bin file can't be found, the user is taken to the addquestions from with limited access so they can add questions
                Form1.Show();          
                this.Close();                            
            }
        }

        private int[] getRandomQuestion(int[] dummyArray, bool replay)
        {
            noQuestionsUsed = 0;
            int ListLength = listQuestions.Count;

            if (replay == false) //if this is the user's first time playing the quiz, a new dummy array needs to be made that shows no questions have been used.
            {
                dummyArray = new int[ListLength];   //the dummy array is created and filled with 0's for each question to show it has not been used.
                for (int i = 0; i < ListLength; i++)
                    dummyArray[i] = 0;
            }

            Random rnd = new Random();

            try
            {
                int randomElement = rnd.Next(ListLength);
                do
                {
                    randomElement = rnd.Next(ListLength);   //This do while loop will make the system generate a new random number if the number generated corresponds to a question that has already been used.

                } while (dummyArray[randomElement] == 1);

                if (dummyArray[randomElement] == 0)
                {
                    Question = listQuestions[randomElement];
                    lblQuestion.Text = Question.Question;   //if the question has not been used, it is displayed on the question screen

                    dummyArray[randomElement] = 1;  //this question is set to used in the dummyarray
                }

                foreach (int number in dummyArray)
                {
                    if (number == 1)
                    {
                        noQuestionsUsed++; //a running total of how many questions have been used is taken
                    }
                    if (noQuestionsUsed == ListLength)
                    {
                        MessageBox.Show("This is the last question we have, after this you may see some questions you have already answered!");
                        foreach (Questions Question in listQuestions)   //if all the questions other than the current have been used, the user is told that questions may repeat.
                        {
                            for (int a = 0; a < ListLength; a++)
                            {
                                dummyArray[a] = 0;  //all questions in the dummy array are set to unused again.
                            }
                        }
                    }
                }
            }
            catch
            {

            }
            
            return dummyArray;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            questionTime.Stop();
            txtAnswer.Enabled = false;
            txtAnswer.ForeColor = Color.White;
            if (txtAnswer.Text.Trim() == Question.CorrectAnswer)
            {
                msgCorrectAns.Visible = true;
                thisPlayer.Score = Convert.ToString(Convert.ToInt16(thisPlayer.Score) + 5);
                lblScore.Text = thisPlayer.Score;
                txtAnswer.BackColor = Color.LimeGreen;
                btnSubmitAnswer.Enabled = false;
                btnNextQuestion.Enabled = true;                     //the user's answer is checked against the answer stored in the questions.bin file with the corresponding question
            }                                                       //if the answers are the same then the user is given 5 points, the answer box turns green and is disabled,  
                                                                    //The submit answer button is disabled and the next question button is enabled.
            else
            {
                msgIncorrectAns.Visible = true;
                btnSubmitAnswer.Enabled = false;
                txtAnswer.BackColor = Color.Red;
                btnNextQuestion.Enabled = true;
            }
            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore))
            {
                thisPlayer.Highscore = thisPlayer.Score;    //if the player has beaten their highscore, the users info in the bottom corner is updated to show this for each question
                lblHighscore.Text = thisPlayer.Highscore;
            }
        }           
                    
        private void rdbAnswer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void rdbAnswer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAnswer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            nextFlag = true;     
        }

        private void NextQuestion(int[] dummyArray, bool nextFlag)
        {
            if(nextFlag == true)
            {
                Form Form1 = new QuestionForm2(thisPlayer, dummyArray, replay); //create instance of Form1 and pass it the object thisPlayer
                this.Close();
                Form1.Show();
            }           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";       //a message box appears asking the user to confirm their choice
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form Form1 = new NewPlayer();   //if the user confirms their choice, they are taken to the login/register form.
                this.Close();
                Form1.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextQuestion(dummyArray, nextFlag);
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();    //if the user clicks the help button, the form opens and the quiz is paused until they click unpause
            Form1.Show();
            btnUnpause.Visible = true;
            questionTime.Stop();
        }

        private void btnUnpause_Click(object sender, EventArgs e)
        {
            btnUnpause.Visible = false; //when unpause is clicked, the unpause button is hidden and the timer is started again.
            questionTime.Start();        

            if (btnNextQuestion.Enabled == true)    //if the user has already run out of time or answered the question, the timer stays paused.
            {
                questionTime.Stop();  
            }
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(txtAnswer.Text);    //this code stops the user from being able to enter letters into the text box (the answer will always be numbers)
            }
            catch(Exception)
            {
                txtAnswer.Text = null;
            }
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;  //the user is not able to enter a space into the answer box
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to quit?";  //if the exit button on the bar on the top is pressed they are asked to confirm their choice.
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
            lblTimeRemaining.Text = Convert.ToString(timeLeft); //if the user runs out of time, their answer is counted wrong and they are not able to submit an answer
            if (timeLeft == 0)
            {
                questionTime.Stop();
                btnSubmitAnswer.Enabled = false;
                btnNextQuestion.Enabled = true;
                lblTimeUp.Visible = true;
            }
            if (timeLeft <= 10)
            {
                lblDisplayTimer.ForeColor = Color.Yellow;   //when the user only has 10 seconds left, the timer changes colour to signify that they are close to running out of time.
                lblDisplayTimer.BackColor = Color.Red;

                lblTimeRemaining.ForeColor = Color.Yellow;
                lblTimeRemaining.BackColor = Color.Red;
            }
        }
    }

}

