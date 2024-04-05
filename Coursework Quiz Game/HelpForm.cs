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
    public partial class HelpForm : MasterForm
    {
        string TextHelpVid;
        string ButtonHelpVid;
        string ComboHelpVid;
        string DragHelpVid; //these are the image file paths for the help gifs.
        string LoginHelpVid;
        string RegHelpVid;
        string DiffHelpVid;
        string AddHelpVid;

        bool bFormNameOpen;

        public HelpForm() //this is where all the file paths for the gifs are found.
        {
            InitializeComponent();

            TextHelpVid = Application.StartupPath;
            TextHelpVid = TextHelpVid.Remove((Convert.ToInt16(TextHelpVid.Length) - 9));
            TextHelpVid += "Images\\TextHelpGif.gif";

            ButtonHelpVid = Application.StartupPath;
            ButtonHelpVid = ButtonHelpVid.Remove((Convert.ToInt16(ButtonHelpVid.Length) - 9));
            ButtonHelpVid += "Images\\ButtonHelpGif.gif";

            ComboHelpVid = Application.StartupPath;
            ComboHelpVid = ComboHelpVid.Remove((Convert.ToInt16(ComboHelpVid.Length) - 9));
            ComboHelpVid += "Images\\ComboHelpGif.gif";

            DragHelpVid = Application.StartupPath;
            DragHelpVid = DragHelpVid.Remove((Convert.ToInt16(DragHelpVid.Length) - 9));
            DragHelpVid += "Images\\DragHelpGif.gif";

            LoginHelpVid = Application.StartupPath;
            LoginHelpVid = LoginHelpVid.Remove((Convert.ToInt16(LoginHelpVid.Length) - 9));
            LoginHelpVid += "Images\\LoginHelpGif.gif";

            RegHelpVid = Application.StartupPath;
            RegHelpVid = RegHelpVid.Remove((Convert.ToInt16(RegHelpVid.Length) - 9));
            RegHelpVid += "Images\\RegisterHelpGif.gif";

            DiffHelpVid = Application.StartupPath;
            DiffHelpVid = DiffHelpVid.Remove((Convert.ToInt16(DiffHelpVid.Length) - 9));
            DiffHelpVid += "Images\\DiffHelpGif.gif";

            AddHelpVid = Application.StartupPath;
            AddHelpVid = AddHelpVid.Remove((Convert.ToInt16(AddHelpVid.Length) - 9));
            AddHelpVid += "Images\\AddHelpGif.gif";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTxtHelp_Click(object sender, EventArgs e) //set the appropriate gif and text for what button is clicked.
        {
            imgHelpVideo.Image = Image.FromFile(TextHelpVid);
            lblExtraHelp.Text = "When answering a Text Box question, enter your answer in the space provided then hit 'submit' a box will pop up on the screen and tell you if you got the question right. \nThe text box will change colour based on if you got the answer right or wrong.";
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            imgHelpVideo.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imgHelpVideo.Image = Image.FromFile(ButtonHelpVid);
            lblExtraHelp.Text = "When answering a button question like this, click on the answer you want to choose and then hit submit.\nYour answer will turn either red or green depending if you got the question correct.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imgHelpVideo.Image = Image.FromFile(ComboHelpVid);
            lblExtraHelp.Text = "Click on an arrow beside a text box to see the possible answers, select the answer you think is right for each question.\nWhen you have entered an answer for easch question, hit submit.\nEach correct answer will turn green and each incorrect answer red.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imgHelpVideo.Image = Image.FromFile(DragHelpVid);
            lblExtraHelp.Text = "Click and hold on a term on the left and drag it over to an answer on the right.\nYour selected answer for each example will be shown beside each answer.\nWhen you hit submit, correct answers will turn green and incorrect will turn red.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imgHelpVideo.Image = Image.FromFile(LoginHelpVid);
            lblExtraHelp.Text = "Enter your username and password then hit login and you will be taken to the difficulty screen.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            imgHelpVideo.Image = Image.FromFile(RegHelpVid);
            lblExtraHelp.Text = "Enter a username and password that you want to use, then choose an avatar from the 3 choices.\nWhen you have done all this you can hit register to create your account.\nMake sure you meet the requirements for your username and password.\nThe requirements will be written below the boxes and will turn green when they have been met.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            imgHelpVideo.Image = Image.FromFile(DiffHelpVid);
            lblExtraHelp.Text = "Click either Easy or Hard to choose the difficulty of the quiz you will play.\nBe sure to read the extra info about each difficulty!";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            imgHelpVideo.Image = Image.FromFile(AddHelpVid);
            lblExtraHelp.Text = "Enter the actual question in the Question box, and the answer in the Answer box.\nThen his add question.\nYou can add as many questions as you like.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close(); 
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
                FormCollection fc = Application.OpenForms;

                foreach (Form frm in fc)
                {
                    //iterate through
                    if (frm.Name == "NewPlayer")
                    {
                        bFormNameOpen = true;
                    }
                }

                if (bFormNameOpen == true)
                {
                    MessageBox.Show("You are not logged into an account!");
                }
                else
                {
                    Form Form1 = new NewPlayer();
                    this.Close();
                    Form1.Show();
                }
            }
        }
    }
}
