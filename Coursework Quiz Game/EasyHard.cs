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
    public partial class EasyHard : MasterForm 
    {
        Player thisPlayer;
        List<Player> players = new List<Player>();
        bool replay;
        int[] dummyArray;

        public EasyHard(Player ThisPlayer, int[]DummyArray, bool Replay)
        {
            InitializeComponent();

            thisPlayer = ThisPlayer; //this player identifier is now set to equal the object that was passed in as a parameter 
            replay = Replay;         //the replay variable that tells the program if the code is being replayed or not
            dummyArray = DummyArray; //the dummy array is used for the randomisation of the first question, has to be passed.

            lblName.Text = thisPlayer.Name;             //setting the information in the bottom right corner
            lblScore.Text = thisPlayer.Score;           //to be the player's information
            imgAvatar.Image = thisPlayer.Avatar;
            lblHighscore.Text = thisPlayer.Highscore;

            if (replay == true)
            {
                btnHardMode.Enabled = true;
                lblUnlockHard.Visible = false;
            }
            else
            {
                btnHardMode.Enabled = false;
                lblUnlockHard.Visible = true;
            }
        }

        private void EasyHard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEasyMode_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btnHardMode_MouseEnter(object sender, EventArgs e)
        {
            lblHard1.Visible = true;
            lblHard2.Visible = true;    //this shows information about hard mode when the button is moused over
            lblHard3.Visible = true;
        }

        private void btnEasyMode_MouseEnter(object sender, EventArgs e)
        {
            lblEasy1.Visible = true;
            lblEasy2.Visible = true;    //this shows information about easy mode when the button is moused over
            lblEasy3.Visible = true;
        }

        private void btnEasyMode_MouseLeave(object sender, EventArgs e)
        {
            lblEasy1.Visible = false;
            lblEasy2.Visible = false;   //the information is hidden again when the mouse leaves the button
            lblEasy3.Visible = false;
        }

        private void btnHardMode_MouseLeave(object sender, EventArgs e)
        {
            lblHard1.Visible = false;
            lblHard2.Visible = false;   //the information is hidden again when the mouse leaves the button
            lblHard3.Visible = false;
        }

        private void btnEasyMode_Click(object sender, EventArgs e)
        {
            Form Form1 = new QuestionForm(thisPlayer, dummyArray, replay);
            try
            {
                this.Close(); //the difficulty form is closed and the easy mode quiz is started 
                Form1.Show();            
            }
            catch (Exception)
            {
            }    
        }

        private void btnHardMode_Click(object sender, EventArgs e)
        {
            Form Form1 = new HardQuestionForm(thisPlayer, dummyArray, replay);
            this.Close();       //the difficulty form is closed and the hard mode quiz is started 
            Form1.Show();
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();    //the help form is opened but the other one stays open, this is so information on the original
            Form1.Show();                   //one isnt changed and the player object, dummy array and replay values dont need to be passed
        }                                   //this allows for the help form to be opened from any form easily.

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {                                           //user is asked to confirm if they want to log out
                Form Form1 = new NewPlayer();   
                this.Close();
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
        }
    }
}
