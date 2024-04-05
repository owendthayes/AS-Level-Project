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
    public partial class EditQuestions : MasterForm
    {
        List<Questions> listQuestions = new List<Questions>();
        Questions CurrentQuestion;
        Questions[] QuestionsArray;
        Player thisPlayer;

        int qIndex, pIndex;
        bool ValidSave, noQuestions;

        Stream sr;
        BinaryFormatter bf = new BinaryFormatter();

        public EditQuestions(Player ThisPlayer, int qindex, int pindex)
        {
            InitializeComponent();
            QuestionsArray = readQuestionsToList();     //reads question binary file to a list

            thisPlayer = ThisPlayer;
            qIndex = qindex;           

            clkValidQue.Start();

            lblName.Text = thisPlayer.Name;     //sets information in bottom right to be the players information
            lblScore.Text = thisPlayer.Score;
            imgAvatar.Image = thisPlayer.Avatar;
            lblHighscore.Text = thisPlayer.Highscore;

            CurrentQuestion = QuestionsArray[qIndex];       //sets an object for the current question we are looking at
                                                            //index is used when pressing the next or previous button.
            txtQuestion.Text = CurrentQuestion.Question;    //the current question we are looking at is displayed in the 
            txtAns.Text = CurrentQuestion.CorrectAnswer;    //text boxes on the form.

        }

        private Questions[] readQuestionsToList()       //questions binary file is read to a list
        {
            Questions[] QuestionsArray = null;
            try
            {
                sr = File.OpenRead("Questions.bin");
                listQuestions = (List<Questions>)bf.Deserialize(sr);
                QuestionsArray = listQuestions.ToArray();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return QuestionsArray;
        }

        private void btnNextQ_Click(object sender, EventArgs e)
        {
            try
            {
                qIndex = qIndex + 1;
                CurrentQuestion = QuestionsArray[qIndex];
                                                                    //the next button will add 1 to the index so that the next object in the
                txtQuestion.Text = CurrentQuestion.Question;        //list is chosen to be displayed, text boxes are updated to show new
                txtAns.Text = CurrentQuestion.CorrectAnswer;        //current question
            }
            catch (Exception)
            {
                MessageBox.Show("No more questions.");              //if the user tries to go to the next question when there are no more
                qIndex = qIndex - 1;
            }                                                       //the error is caught and tells them there are no more questions
        }

        private void EditQuestions_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevQ_Click(object sender, EventArgs e)
        {
            try
            {
                qIndex = qIndex - 1;
                CurrentQuestion = QuestionsArray[qIndex];
                                                                //this is the same as the code for the next question button
                txtQuestion.Text = CurrentQuestion.Question;    //but the index decreases instead of increases so the question
                txtAns.Text = CurrentQuestion.CorrectAnswer;    //chosen from the list is the previous one
            }
            catch (Exception)
            {
                MessageBox.Show("No more questions.");          //if the user tries to go to the next question when there are no more
                qIndex = qIndex + 1;
            }                                                   //the error is caught and tells them there are no more questions
        }

        private void btnSaveQ_Click(object sender, EventArgs e)
        {
            ValidSave = false;
            foreach (Questions Question in QuestionsArray)
            {
                string QuestionTrimLow, ExistingQTrimLow;

                QuestionTrimLow = txtQuestion.Text.Trim();
                QuestionTrimLow = QuestionTrimLow.ToLower();
                ExistingQTrimLow = Question.Question.Trim();
                ExistingQTrimLow = ExistingQTrimLow.ToLower();

                if (QuestionTrimLow == ExistingQTrimLow && Question.Question != CurrentQuestion.Question)
                {
                    ValidSave = false;
                    break;
                }
                else
                {
                    ValidSave = true;
                }
            }
            Save();
            Form Form1 = new EditQuestions(thisPlayer, pIndex, qIndex);
            this.Close();
            Form1.Show();
        }
        
        private void Save()
        {
            if (ValidSave == true)
            {
                if (txtQuestion.Text != CurrentQuestion.Question)   //if the question has been changed.
                {
                    Stream sr;
                    BinaryFormatter bf = new BinaryFormatter();
                    try
                    {
                        sr = File.OpenRead("Questions.bin");
                        listQuestions = (List<Questions>)bf.Deserialize(sr);    //questions file is read to a list
                        sr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    foreach (Questions Question in listQuestions)
                    {
                        if (Question.CorrectAnswer == CurrentQuestion.CorrectAnswer)    //the question is found using the correct answer which has not changed
                        {                                                               //so we know which question object to change in the list.
                            Stream sw;
                            BinaryFormatter cf = new BinaryFormatter();     //the new question that has been edited is changed to reflect the edit
                            Question.Question = txtQuestion.Text.Trim();    //the question is trimmed so there are no extra spaces at the start and end
                            try
                            {
                                sw = File.OpenWrite("Questions.bin");
                                cf.Serialize(sw, listQuestions);
                                sw.Close();                                 //all the questions including the edited one are rewritten to the binary file
                                MessageBox.Show("Changes Saved.");          //which in essence is saving the edited question back into the file
                                QuestionsArray = listQuestions.ToArray();
                            }
                            catch (SerializationException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }

                if (txtAns.Text != CurrentQuestion.CorrectAnswer)       //if the answer has been changed
                {
                    Stream sr;
                    BinaryFormatter bf = new BinaryFormatter();
                    try
                    {
                        sr = File.OpenRead("Questions.bin");
                        listQuestions = (List<Questions>)bf.Deserialize(sr);    //questions file is read to a list
                        sr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    foreach (Questions Question in listQuestions)
                    {
                        if (Question.Question == CurrentQuestion.Question)  //the question is found using actual question which has not changed
                        {                                                   //so we know which question object to change in the list.
                            Stream sw;
                            BinaryFormatter cf = new BinaryFormatter();     //the new question that has been edited is changed to reflect the edit
                            Question.CorrectAnswer = txtAns.Text.Trim();    //the question is trimmed so there are no extra spaces at the start and end
                            try
                            {
                                sw = File.OpenWrite("Questions.bin");
                                cf.Serialize(sw, listQuestions);
                                sw.Close();                                 //all the questions including the edited one are rewritten to the binary file
                                MessageBox.Show("Changes Saved.");          //which in essence is saving the edited question back into the file
                                QuestionsArray = listQuestions.ToArray();
                            }
                            catch (SerializationException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }
            }
            else
                MessageBox.Show("Question has already been used");    
        }    

        private void button8_Click(object sender, EventArgs e)  //the edit questions form is closed and user is brought back to admin form
        {
            Form Form1 = new AddQuestions(thisPlayer, noQuestions); //create instance of Form1 and pass it the object thisPlayer
            Form1.Show();
            this.Close();
        }

        private void btnDelQ_Click(object sender, EventArgs e)  
        {
            string message = "Are you sure you want to delete this question?";
            string title = "Delete Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;            //A message box will appear asking the user to confirm
            DialogResult result = MessageBox.Show(message, title, buttons); //that they want to delete the question.
            if (result == DialogResult.Yes)
            {
                listQuestions.Remove(CurrentQuestion);              //Current question object is removed from the list of all questions
                Stream sw;                                      
                BinaryFormatter cf = new BinaryFormatter();
                try
                {
                    sw = File.OpenWrite("Questions.bin");       //The list without the current question is then rewritten to the file
                    cf.Serialize(sw, listQuestions);
                    sw.Close();
                    MessageBox.Show("Question Deleted.");       
                    QuestionsArray = listQuestions.ToArray();   //The array is then updated to use this new list
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                qIndex = 0;
                Form Form1 = new EditQuestions(thisPlayer, qIndex, pIndex);     //the form is opened and closed so that the text
                Form1.Show();                                   //boxes dont show the question that was just
                this.Close();                                   //deleted
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clkValidQue_Tick(object sender, EventArgs e)
        {
            if (txtQuestion != null && txtQuestion.Text != "" && txtAns.Text != null && txtAns.Text != "")
            {
                btnSaveQ.Enabled = true;
            }
            else
                btnSaveQ.Enabled = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void txtAns_TextChanged(object sender, EventArgs e)
        {
            if (txtAns.Text != CurrentQuestion.CorrectAnswer)
            {
                txtQuestion.Enabled = false;
            }
            else
            {
                txtQuestion.Enabled = true;
            }

            try
            {
                Convert.ToInt16(txtAns.Text);
            }
            catch (Exception)
            {
                txtAns.Text = null;
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

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            if (txtQuestion.Text == " ")
            {
                txtQuestion.Text = null;
            }

            if (txtQuestion.Text != CurrentQuestion.Question)
            {
                txtAns.Enabled = false;
            }
            else
            {
                txtAns.Enabled = true;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
        }

        private void txtAns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
        }
    }
}

