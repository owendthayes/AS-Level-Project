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
    public partial class NewPlayer : MasterForm
    {
        Player thisPlayer = new Player();
        List<Player> players = new List<Player>();

        bool replay, bFormNameOpen;
        int[] dummyArray;
        bool numbertrue = false, regpassvis = false, logpassvis = false; //these are used for viewing password.

        bool help1Met = false, help2Met = false, help3Met = false, help4Met = false, help5Met = false, help6Met = false, noQuestions;
        //these are the requirements for registering an account, user can't register until these are all true.

        public NewPlayer()
        {
            InitializeComponent();
            readFileToList();

            HelpMetTimer.Start(); //this checks if the requirements have been met.
            btnRegister.Enabled = false; 

            lblPassHelp1.ForeColor = Color.Red;
            lblPassHelp2.ForeColor = Color.Red;
            lblPassHelp3.ForeColor = Color.Red;
            lblPassHelp4.ForeColor = Color.Red;
            lblPassHelp5.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool nameUsed = false;

            foreach (Player Player in players)
            {
                string PlayerLowTrim, RegLowTrim;

                PlayerLowTrim = Player.Name.Trim();
                PlayerLowTrim = PlayerLowTrim.ToLower();

                RegLowTrim = txtRegName.Text.Trim();
                RegLowTrim = RegLowTrim.ToLower();

                if (Player.Name.Trim() == txtRegName.Text.Trim() || Player.Name.ToLower() == txtRegName.Text.ToLower() || PlayerLowTrim == RegLowTrim)
                {//check if the username has been used, cant be the same even if its different case or has spaces.
                    nameUsed = true;
                }
            }

            if (txtRegName.Text != string.Empty && txtRegPass.Text == txtConfirmPass.Text && nameUsed == false)
            {//if the username is valid.
                thisPlayer.Name = txtRegName.Text;
                thisPlayer.Password = txtRegPass.Text;

                if (txtRegName.Text == "admin")
                {
                    thisPlayer.Admin = true;
                }
                players.Add(thisPlayer); //add the current player object to the list
                Stream sw;
                BinaryFormatter bf = new BinaryFormatter();

                try
                {
                    sw = File.OpenWrite("Players.bin"); //using openwrite will append to the file rather than overwriting
                    bf.Serialize(sw, players);
                    sw.Close();
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                readFileToList();

                if (thisPlayer.Admin == true)
                {
                    Form Form1 = new AddQuestions(thisPlayer, noQuestions);
                    Form1.Show();
                    this.Close();
                }
                else
                {
                    Form Form1 = new EasyHard(thisPlayer, dummyArray, replay);
                    Form1.Show(); //move on to difficulty with the newly created player.
                    this.Close();
                }
            }
            else
            {
                if (txtRegPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Check you have correctly confirmed your password and that each box has been completed.");
                }
                //give an appropraite error message to the user based on what is wrong with their information.
                if (nameUsed == true)
                {
                    MessageBox.Show("This username has already been used.");
                }
            }
        }

        private void readFileToList()
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                sr = File.OpenRead("Players.bin");
                players = (List<Player>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are no users, you must create an admin account");
                txtRegName.Text = "admin";
                btnLeaderboard.Enabled = false;
                help6Met = true;
                lblPassHelp5.ForeColor = Color.LimeGreen;
                txtRegName.Enabled = false;
                txtLoginName.Enabled = false;
                txtLoginPassword.Enabled = false;
            }
        }

        private void imgRegAva1_Click(object sender, EventArgs e) //visually show the user which avatar they have used.
        {
            thisPlayer.Avatar = imgRegAva1.Image;
            imgRegAva1.BorderStyle = BorderStyle.Fixed3D;

            imgRegAva2.BorderStyle = BorderStyle.None;
            imgRegAva3.BorderStyle = BorderStyle.None;

            help4Met = true;
            lblPassHelp4.ForeColor = Color.LimeGreen;
        }

        private void imgRegAva2_Click(object sender, EventArgs e)
        {
            thisPlayer.Avatar = imgRegAva2.Image;
            imgRegAva2.BorderStyle = BorderStyle.Fixed3D;

            imgRegAva1.BorderStyle = BorderStyle.None;
            imgRegAva3.BorderStyle = BorderStyle.None;

            help4Met = true;
            lblPassHelp4.ForeColor = Color.LimeGreen;
        }

        private void imgRegAva3_Click(object sender, EventArgs e)
        {
            thisPlayer.Avatar = imgRegAva3.Image;
            imgRegAva3.BorderStyle = BorderStyle.Fixed3D;

            imgRegAva1.BorderStyle = BorderStyle.None;
            imgRegAva2.BorderStyle = BorderStyle.None;

            help4Met = true;
            lblPassHelp4.ForeColor = Color.LimeGreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool foundFlag = false;
            readFileToList();
            foreach (Player thisPlayer in players)
            {
                if (thisPlayer.Name == txtLoginName.Text) //if the player's username exists.
                {
                    foundFlag = true;

                    if (thisPlayer.Password == txtLoginPassword.Text) //if the password for that account is true.
                    {                       
                        if (thisPlayer.Admin == true) //if the player is an admin
                        {
                            Form Form1 = new AddQuestions(thisPlayer, noQuestions); //open the admin facility instead of difficulty.
                            Form1.Show();
                            this.Close();
                        }
                        else
                        {
                            Form Form1 = new EasyHard(thisPlayer, dummyArray, replay); //create instance of Form1 and pass it the object thisPlayer
                            Form1.Show();
                            this.Close(); //open the difficulty form as normal
                        }
                    }
                    else
                        MessageBox.Show("Incorrect Password");
                }
            }
            if (foundFlag == false)
                MessageBox.Show("User does not exist");
        }

        private void NewPlayer_Load(object sender, EventArgs e)
        {

        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtRegPass.Text == txtConfirmPass.Text && txtRegPass.Text != "")
            {
                lblPassHelp3.ForeColor = Color.LimeGreen;
                help3Met = true; //check that the password and confirm password box match.
            }
            else
            {
                lblPassHelp3.ForeColor = Color.Red;
                help3Met = false;
            }

            foreach (char character in txtRegPass.Text)
            {
                if (character >= '0' && character <= '9') //check that the password has at least 1 number.
                {
                    numbertrue = true;
                }
                else
                {
                    numbertrue = false;

                }
                if (numbertrue == true)
                {
                    lblPassHelp2.ForeColor = Color.LimeGreen;
                    help2Met = true;
                }
                else
                {
                    lblPassHelp2.ForeColor = Color.Red;
                    help2Met = false;
                }
            }

            if (txtRegPass.TextLength >= 5) //check if password is 5 or more characters
            {
                lblPassHelp1.ForeColor = Color.LimeGreen;
                help1Met = true;
            }
            else
            {
                lblPassHelp1.ForeColor = Color.Red;
                help1Met = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserInfoBackround_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblPassHelp3_Click(object sender, EventArgs e)
        {

        }

        private void lblPassHelp2_Click(object sender, EventArgs e)
        {

        }

        private void txtRegPass_TextChanged(object sender, EventArgs e)
        {
            numbertrue = false;
            if (txtRegPass.Text == txtConfirmPass.Text && txtRegPass.Text != "")
            {
                lblPassHelp3.ForeColor = Color.LimeGreen;
                help3Met = true;
            }
            else
            {
                lblPassHelp3.ForeColor = Color.Red;
                help3Met = false;
            }

            foreach (char character in txtRegPass.Text)
            {
                if (character >= '0' && character <= '9' && txtRegPass.Text != "") //THIS WAS FIXED DURING TESTING!
                {
                    numbertrue = true;
                }
                else
                {
                    numbertrue = false;
                }
            }

            if (numbertrue == true)
            {
                lblPassHelp2.ForeColor = Color.LimeGreen;
                help2Met = true;
            }                                   //THIS WAS FIXED DURING TESTING!
            else
            {
                lblPassHelp2.ForeColor = Color.Red;
                help2Met = false;
            }

            if (txtRegPass.TextLength >= 5)
            {
                lblPassHelp1.ForeColor = Color.LimeGreen;
                help1Met = true;
            }
            else
            {
                lblPassHelp1.ForeColor = Color.Red;
                help1Met = false;
            }
        }

        private void HelpMetTimer_Tick(object sender, EventArgs e)
        {
            if (txtLoginName.Text != null && txtLoginPassword.Text != null && txtLoginName.Text != "" && txtLoginPassword.Text != "")
            {//user cant press login button if no information is entered.
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }

            if (help1Met == true && help2Met == true && help3Met == true && help4Met == true && help5Met == true && help6Met == true)
            {//user cant register their account until all requirements are met.
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
            if (txtRegName.Text == "admin" && txtRegName.Enabled == false)
            {
                label4.ForeColor = Color.LimeGreen;
                help6Met = true;
            }
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBlankTimer_Tick(object sender, EventArgs e)
        {

        }

        private void txtRegName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //user cant put spaces in username
                e.SuppressKeyPress = true;
        }

        private void txtRegPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //no spaces in password
                e.SuppressKeyPress = true;
        }

        private void txtConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //no spaces in confirm password.
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

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.gle/vRq5TQFr5oT7w1ii9");
        }

        private void btnComplex_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://1drv.ms/w/s!AgCkHTYkGPeuizdEQAkJ6udewNoS?e=M56FAF");
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
        }

        private void btnViewPassLog_Click(object sender, EventArgs e)
        {
            if (logpassvis == false) //let the user view the password they have entered.
            {
                txtLoginPassword.UseSystemPasswordChar = false;
                logpassvis = true;
                btnViewPassLog.Text = "Hide";
            }
            else //let the user hide the password again if they wish.
            {
                txtLoginPassword.UseSystemPasswordChar = true;
                logpassvis = false;
                btnViewPassLog.Text = "Show";
            }
        }

        private void btnViewPassReg_Click(object sender, EventArgs e)
        {
            if (regpassvis == false) //let the user view the password they have entered.
            {
                txtRegPass.UseSystemPasswordChar = false;
                txtConfirmPass.UseSystemPasswordChar = false;
                regpassvis = true;
                btnViewPassReg.Text = "Hide";
            }
            else //let them hide it again if they wish.
            {
                txtRegPass.UseSystemPasswordChar = true;
                txtConfirmPass.UseSystemPasswordChar = true;
                regpassvis = false;
                btnViewPassReg.Text = "Show";
            }         
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            Form Form1 = new Leaderboard();
            Form1.Show();
        }

        private void txtRegName_TextChanged(object sender, EventArgs e)
        {            
            if (txtRegName.Text != "") //username cant be blank
            {
                lblPassHelp5.ForeColor = Color.LimeGreen;
                help5Met = true;
            }
            else
            {
                lblPassHelp5.ForeColor = Color.Red;
                help5Met = false;
            }

            if(txtRegName.TextLength >= 3) //username must be 3 or more characters.
            {
                help6Met = true;
                label4.ForeColor = Color.LimeGreen;
            }
            else
            {
                if (txtRegName.Text == "admin")
                {
                    label4.ForeColor = Color.LimeGreen;
                    help6Met = true;
                }
                else
                {
                    help6Met = false;
                    label4.ForeColor = Color.Red;
                }
            }
        }

        private void AvatarCheck_Tick(object sender, EventArgs e)
        {
            if (thisPlayer.Avatar == null) //user must choose an avatar.
            {
                btnRegister.Enabled = false;
            } 
        }

        private void lblPassHelp1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTimer_Tick(object sender, EventArgs e)
        {
                      
        }
    }
}
