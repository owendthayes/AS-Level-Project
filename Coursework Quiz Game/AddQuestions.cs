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
    public partial class AddQuestions : MasterForm
    {
        

        Questions newQuestion = new Questions();
        List<Questions> listQuestions = new List<Questions>();

        Player thisPlayer;
        bool replay;
        int[] dummyArray;
        int pIndex, qIndex;
        bool noQuestions;

        Stream sr;
        BinaryFormatter bf = new BinaryFormatter();

        public AddQuestions(Player ThisPlayer, bool NoQuestions)
        {
            InitializeComponent();
            ReadQuestionToList();

            thisPlayer = ThisPlayer;
            noQuestions = NoQuestions;

            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score;
            imgAvatar.Image = thisPlayer.Avatar;
            lblHighscore.Text = thisPlayer.Highscore;

            clkValidQue.Start();
            btnAddQuestion.Enabled = false;

            try
            {
                sr = File.OpenRead("Questions.bin");
                listQuestions = (List<Questions>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception)
            {
                noQuestions = true;
            }

            if (thisPlayer.Admin == false)
            {
                btnEditQuestions.Enabled = false;
                btnEditUsers.Enabled = false;
                btnCityJumper.Enabled = false;
                btnStartQuiz.Enabled = false;
            }
                
            if (noQuestions == true)
            {
                MessageBox.Show("There are no questions, you must add some now");
                btnEditQuestions.Enabled = false;
                btnEditUsers.Enabled = false;
                btnCityJumper.Enabled = false;
                btnStartQuiz.Enabled = false;
            }           
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            bool QUsed = false;
            noQuestions = false;

            foreach (Questions Question in listQuestions)
            {
                string QuestionLowTrim, AddQLowTrim;

                QuestionLowTrim = Question.Question.Trim();
                QuestionLowTrim = QuestionLowTrim.ToLower();

                AddQLowTrim = txtAddQuestion.Text.Trim();
                AddQLowTrim = AddQLowTrim.ToLower();

                if (Question.Question.Trim() == txtAddQuestion.Text.Trim() || Question.Question.ToLower() == txtAddQuestion.Text.ToLower() || QuestionLowTrim == AddQLowTrim)
                {
                    QUsed = true;
                }
            }

                newQuestion.Question = txtAddQuestion.Text;             //setting an object for the new question so it can
                newQuestion.CorrectAnswer = txtAddCorrectAns.Text;      //be added to the list and file easily.

            if (QUsed == false)
            {
                listQuestions.Add(newQuestion);

                Stream sw;
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    sw = File.OpenWrite("Questions.bin");           //opening the questions binary file and writing it to
                    bf.Serialize(sw, listQuestions);                //a list so we can add to it.
                    sw.Close();

                    MessageBox.Show("Question Added!");
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Form Form1 = new AddQuestions(thisPlayer, noQuestions);
                this.Close();
                Form1.Show();
            }
            else
                MessageBox.Show("This question has already been used");  
        }

        private void AddQuestions_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Form Form1 = new NewPlayer();
            this.Close();
            Form1.Show();
        }

        private void ReadQuestionToList()
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                sr = File.OpenRead("Questions.bin");                    //opening the questions binary file and writing it to
                listQuestions = (List<Questions>)bf.Deserialize(sr);    //a list so we can add to it.
                sr.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            Form Form1 = new EasyHard(thisPlayer, dummyArray, replay);
            this.Close();
            Form1.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void lblAddCorrectAnswer_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
        }

        private void btnEditQuestions_Click(object sender, EventArgs e)
        {
            Form Form1 = new EditQuestions(thisPlayer, qIndex, pIndex);
            Form1.Show();
            this.Close();
        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            Form Form1 = new EditUsers(thisPlayer, pIndex, qIndex);
            Form1.Show();
            this.Close();
        }

        private void btnCityJumper_Click(object sender, EventArgs e)
        {
            Form Form1 = new BlockJumper();
            Form1.Show();
        }

        private void clkValidQue_Tick(object sender, EventArgs e)
        {
            if (txtAddQuestion.Text != null && txtAddQuestion.Text != "" && txtAddCorrectAns.Text != null && txtAddCorrectAns.Text != "")
            {
                btnAddQuestion.Enabled = true;
            }
            else
                btnAddQuestion.Enabled = false;
        }

        private void txtAddCorrectAns_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(txtAddCorrectAns.Text);
            }
            catch (Exception)
            {
                txtAddCorrectAns.Text = null;
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
        }

        private void txtAddCorrectAns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) 
                e.SuppressKeyPress = true;
        }
    }
}
