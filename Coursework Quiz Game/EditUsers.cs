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
    public partial class EditUsers : MasterForm
    {
        List<Player> listPlayers = new List<Player>();
        Player CurrentPlayer;
        Player[] PlayersArray;

        Player thisPlayer;
        int pIndex, qIndex;
        bool ValidSave = false, noQuestions, noEdit;

        Stream sr;
        BinaryFormatter bf = new BinaryFormatter();

        public EditUsers(Player ThisPlayer, int pindex, int qIndex)
        {
            InitializeComponent();
            PlayersArray = readPlayersToList(); //reads players binary file to a list

            thisPlayer = ThisPlayer;
            pIndex = pindex;

            clkValidU.Start();

            lblName.Text = thisPlayer.Name;     //sets information in bottom right to be the players information
            lblScore.Text = thisPlayer.Score;
            imgAvatar.Image = thisPlayer.Avatar;
            lblHighscore.Text = thisPlayer.Highscore;

            CurrentPlayer = PlayersArray[pIndex];               //sets an object for the current question we are looking at
                                                                    //index is used when pressing the next or previous button.

            txtUsernameEdit.Text = CurrentPlayer.Name;          
            txtPasswordEdit.Text = CurrentPlayer.Password;      //the current Player we are looking at is displayed in the  
            txtHighscoreEdit.Text = CurrentPlayer.Highscore;    //text boxes on the form, check box used for admin property
            chkAdmin.Checked = CurrentPlayer.Admin;

            if (CurrentPlayer.Name == thisPlayer.Name || CurrentPlayer.Name == "admin") //this means that the original admin account cant be changed (also account of admin that is currently logged in)
            {                                                                           //highscore is the only property here that can be changed.
                noEdit = true;
                //Account also cant be deleted to give some protection to original admin.
            }
            else
            {
                noEdit = false; //other accounts can be changed and deleted.
            }

            if (CurrentPlayer.Name == "admin")
            {
                txtPasswordEdit.UseSystemPasswordChar = true;
            }
            else
            {
                txtPasswordEdit.UseSystemPasswordChar = false;
            }

            if (noEdit == true)
            {
                btnDelQ.Enabled = false;
                btnSaveQ.Enabled = false;
                chkAdmin.Enabled = false;
                txtUsernameEdit.Enabled = false;
                txtPasswordEdit.Enabled = false;
            }
            
            else
            {
                btnDelQ.Enabled = true;
                btnSaveQ.Enabled = true;
                chkAdmin.Enabled = true;
                txtUsernameEdit.Enabled = true;
                txtHighscoreEdit.Enabled = true;
            }
        }

        private Player[] readPlayersToList()    //reads players binary file to a list
        {
            Player[] PlayersArray = null;
            try
            {
                sr = File.OpenRead("Players.bin");
                listPlayers = (List<Player>)bf.Deserialize(sr);
                PlayersArray = listPlayers.ToArray();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return PlayersArray;
        }

        private void btnNextQ_Click(object sender, EventArgs e)
        {
            try
            {
                pIndex = pIndex + 1;                        //the next button will add 1 to the index so that the next object in the
                CurrentPlayer = PlayersArray[pIndex];       //list is chosen to be displayed, text boxes are updated to show new
                                                            //current player
                txtUsernameEdit.Text = CurrentPlayer.Name;
                txtPasswordEdit.Text = CurrentPlayer.Password;
                txtHighscoreEdit.Text = CurrentPlayer.Highscore;
                chkAdmin.Checked = CurrentPlayer.Admin;                
            }
            catch (Exception)
            {
                MessageBox.Show("No more players.");        //if the user tries to go to the next player when there are no more
                pIndex = pIndex - 1;
            }                                               //the error is caught and tells them there are no more player

            if (CurrentPlayer.Name == thisPlayer.Name || CurrentPlayer.Name == "admin") //this means that the original admin account cant be changed (also account of admin that is currently logged in)
            {                                                                           //highscore is the only property here that can be changed.
                noEdit = true;                
                //Account also cant be deleted to give some protection to original admin.
            }
            else
            {
                noEdit = false; //other accounts can be changed and deleted.

            }

            if (CurrentPlayer.Name == "admin")
            {
                txtPasswordEdit.UseSystemPasswordChar = true;
            }
            else
            {
                txtPasswordEdit.UseSystemPasswordChar = false;
            }

            if (noEdit == true)
            {
                btnDelQ.Enabled = false;
                btnSaveQ.Enabled = false;
                chkAdmin.Enabled = false;
                txtUsernameEdit.Enabled = false;
                txtPasswordEdit.Enabled = false;
            }

            else
            {
                btnDelQ.Enabled = true;
                btnSaveQ.Enabled = true;
                chkAdmin.Enabled = true;
                txtUsernameEdit.Enabled = true;
                txtHighscoreEdit.Enabled = true;
            }
        }

        private void btnPrevQ_Click(object sender, EventArgs e)
        {
            try
            {
                pIndex = pIndex - 1;                            //this is the same as the code for the next player button
                CurrentPlayer = PlayersArray[pIndex];           //but the index decreases instead of increases so the player
                                                                //chosen from the list is the previous one
                txtUsernameEdit.Text = CurrentPlayer.Name;
                txtPasswordEdit.Text = CurrentPlayer.Password;
                txtHighscoreEdit.Text = CurrentPlayer.Highscore;
                chkAdmin.Checked = CurrentPlayer.Admin;               
            }
            catch (Exception)
            {
                MessageBox.Show("No more players.");            //if the user tries to go to the next player when there are no more
                pIndex = pIndex + 1;
            }                                                   //the error is caught and tells them there are no more questions

            if (CurrentPlayer.Name == thisPlayer.Name || CurrentPlayer.Name == "admin") //this means that the original admin account cant be changed (also account of admin that is currently logged in)
            {                                                                           //highscore is the only property here that can be changed.
                noEdit = true;
                if (CurrentPlayer.Name == "admin")
                {
                    txtPasswordEdit.UseSystemPasswordChar = true;
                }
                //Account also cant be deleted to give some protection to original admin.
            }
            else
            {
                noEdit = false; //other accounts can be changed and deleted.
                txtPasswordEdit.UseSystemPasswordChar = false;
            }

            if (CurrentPlayer.Name == "admin")
            {
                txtPasswordEdit.UseSystemPasswordChar = true;
            }
            else
            {
                txtPasswordEdit.UseSystemPasswordChar = false;
            }

            if (noEdit == true)
            {
                btnDelQ.Enabled = false;
                btnSaveQ.Enabled = false;
                chkAdmin.Enabled = false;
                txtUsernameEdit.Enabled = false;
                txtPasswordEdit.Enabled = false;
            }

            else
            {
                btnDelQ.Enabled = true;
                btnSaveQ.Enabled = true;
                chkAdmin.Enabled = true;
                txtUsernameEdit.Enabled = true;
                txtHighscoreEdit.Enabled = true;
            }
        }

        private void Save()
        {
            if (ValidSave == true)
            {
                if (txtUsernameEdit.Text != CurrentPlayer.Name) //if the username has been changed.
                {
                    Stream sr;
                    BinaryFormatter bf = new BinaryFormatter();
                    try
                    {
                        sr = File.OpenRead("Players.bin");
                        listPlayers = (List<Player>)bf.Deserialize(sr); //player file read to a list
                        sr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    foreach (Player Player in listPlayers)
                    {
                        if (Player.Password == CurrentPlayer.Password)  //the player is found using the password which has not changed
                        {                                               //so we know which player object to change in the list.
                            Stream sw;
                            BinaryFormatter cf = new BinaryFormatter(); //the new player that has been edited is changed to reflect the edit
                            Player.Name = txtUsernameEdit.Text.Trim();  //the player is trimmed so there are no extra spaces at the start and end
                            try
                            {
                                sw = File.OpenWrite("Players.bin");
                                cf.Serialize(sw, listPlayers);          //all the players including the edited one are rewritten to the binary file
                                sw.Close();                             //which in essence is saving the edited question back into the file
                                MessageBox.Show("Changes Saved.");
                                PlayersArray = listPlayers.ToArray();
                            }
                            catch (SerializationException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }

                if (txtPasswordEdit.Text != CurrentPlayer.Password)     //if the password has been changed
                {
                    Stream sr;
                    BinaryFormatter bf = new BinaryFormatter();
                    try
                    {
                        sr = File.OpenRead("Players.bin");
                        listPlayers = (List<Player>)bf.Deserialize(sr); //player file read to a list
                        sr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    foreach (Player Player in listPlayers)
                    {
                        if (Player.Name == CurrentPlayer.Name)      //player is found using the username which has not been changed
                        {                                           //users are unable to have to same name.
                            Stream sw;
                            BinaryFormatter cf = new BinaryFormatter();
                            Player.Password = txtPasswordEdit.Text.Trim();  //the new player that has been edited is changed to reflect the edit
                            try                                             //the player is trimmed so there are no extra spaces at the start and end
                            {
                                sw = File.OpenWrite("Players.bin");
                                cf.Serialize(sw, listPlayers);                  //all the players including the edited one are rewritten to the binary file
                                sw.Close();                                     //which in essence is saving the edited question back into the file
                                MessageBox.Show("Changes Saved.");
                                PlayersArray = listPlayers.ToArray();
                            }
                            catch (SerializationException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }

                }

                if (txtHighscoreEdit.Text != CurrentPlayer.Highscore) //if the high score has been changed.
                {
                    Stream sr;
                    BinaryFormatter bf = new BinaryFormatter();         //player file read to a list
                    try
                    {
                        sr = File.OpenRead("Players.bin");
                        listPlayers = (List<Player>)bf.Deserialize(sr);
                        sr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    foreach (Player Player in listPlayers)
                    {
                        if (Player.Name == CurrentPlayer.Name)      //player is found using the username which has not been changed
                        {                                           //users are unable to have to same name.
                            Stream sw;
                            BinaryFormatter cf = new BinaryFormatter();
                            Player.Highscore = txtHighscoreEdit.Text.Trim();        //the new player that has been edited is changed to reflect the edit
                            try                                                     //the player is trimmed so there are no extra spaces at the start and end
                            {
                                sw = File.OpenWrite("Players.bin");
                                cf.Serialize(sw, listPlayers);                      //all the players including the edited one are rewritten to the binary file
                                sw.Close();                                         //which in essence is saving the edited question back into the file
                                MessageBox.Show("Changes Saved.");
                                PlayersArray = listPlayers.ToArray();
                            }
                            catch (SerializationException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }

                if (chkAdmin.Checked != CurrentPlayer.Admin)    //if user gains or loses admin abilities.
                {
                    Stream sr;
                    BinaryFormatter bf = new BinaryFormatter(); //player file read to a list
                    try
                    {
                        sr = File.OpenRead("Players.bin");
                        listPlayers = (List<Player>)bf.Deserialize(sr);
                        sr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    foreach (Player Player in listPlayers)
                    {
                        if (Player.Name == CurrentPlayer.Name)       //player is found using the username which has not been changed
                        {                                           //users are unable to have to same name.
                            Stream sw;
                            BinaryFormatter cf = new BinaryFormatter();
                            Player.Admin = chkAdmin.Checked;
                            try
                            {
                                sw = File.OpenWrite("Players.bin");
                                cf.Serialize(sw, listPlayers);
                                sw.Close();                         //all the players including the edited one are rewritten to the binary file
                                MessageBox.Show("Changes Saved.");  //which in essence is saving the edited question back into the file
                                PlayersArray = listPlayers.ToArray();
                            }
                            catch (SerializationException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                lblName.Text = thisPlayer.Name;
                lblHighscore.Text = thisPlayer.Highscore;
            }
            else
            {
                MessageBox.Show("Username has already been used.");
            }
        }
        private void btnSaveQ_Click(object sender, EventArgs e)
        {
            ValidSave = false;
            foreach (Player player in PlayersArray)
            {
                string UsernameTrimLow, PlayerTrimLow;

                UsernameTrimLow = txtUsernameEdit.Text.Trim();
                UsernameTrimLow = UsernameTrimLow.ToLower();
                PlayerTrimLow = player.Name.Trim();
                PlayerTrimLow = PlayerTrimLow.ToLower();

                if (UsernameTrimLow == PlayerTrimLow && player.Name != CurrentPlayer.Name)
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
            Form Form1 = new EditUsers(thisPlayer, pIndex, qIndex);
            Form1.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)  //the edit users form is closed and user is brought back to admin form
        {
            Form Form1 = new AddQuestions(thisPlayer, noQuestions); //create instance of Form1 and pass it the object thisPlayer
            Form1.Show();
            this.Close();
        }

        private void btnDelQ_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this User?";  //A message box will appear asking the user to confirm
            string title = "Delete User";                                   //that they want to delete the player.
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                listPlayers.Remove(CurrentPlayer);                          //Current players object is removed from the list of all players
                Stream sw;
                BinaryFormatter cf = new BinaryFormatter();
                try
                {
                    sw = File.OpenWrite("Players.bin");
                    cf.Serialize(sw, listPlayers);
                    sw.Close();                         //The list without the current player is then rewritten to the file
                    MessageBox.Show("User Deleted.");
                    PlayersArray = listPlayers.ToArray();   //The array is then updated to use this new list
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                pIndex = 0;
                Form Form1 = new EditUsers(thisPlayer, pIndex, qIndex);     //the form is opened and closed so that the text
                Form1.Show();                               //boxes dont show the player that was just
                this.Close();                               //deleted.
            }
            
        }

        private void clkValidU_Tick(object sender, EventArgs e)
        {
            if (txtUsernameEdit.Text != null & txtUsernameEdit.Text != "" && txtPasswordEdit.Text != null && txtPasswordEdit.Text != "" && txtHighscoreEdit.Text != null && txtHighscoreEdit.Text != "")
            {
                btnSaveQ.Enabled = true;
            }
            else
                btnSaveQ.Enabled = false;            
        }

        private void txtUsernameEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtUsernameEdit.Text == " ")
            {
                txtUsernameEdit.Text = null;
            }


            if (txtUsernameEdit.Text != CurrentPlayer.Name)
            {
                txtPasswordEdit.Enabled = false;
                txtHighscoreEdit.Enabled = false;
                chkAdmin.Enabled = false;
            }
            else
            {
                txtPasswordEdit.Enabled = true;
                txtHighscoreEdit.Enabled = true;
                chkAdmin.Enabled = true;
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

        private void txtPasswordEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordEdit.Text == " ")
            {
                txtPasswordEdit.Text = null;
            }

            if (txtPasswordEdit.Text != CurrentPlayer.Password)
            {
                txtUsernameEdit.Enabled = false;
            }
            else
            {
                txtUsernameEdit.Enabled = true;
            }
        }

        private void txtHighscoreEdit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(txtHighscoreEdit.Text);
            }
            catch
            {
                txtHighscoreEdit.Text = null;
            }

            if (txtHighscoreEdit.Text != CurrentPlayer.Highscore)
            {
                txtUsernameEdit.Enabled = false;
            }
            else
            {
                txtUsernameEdit.Enabled = true;
            }
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked != CurrentPlayer.Admin)
            {
                txtUsernameEdit.Enabled = false;
            }
            else
            {
                txtUsernameEdit.Enabled = true;
            }
        }

        private void txtUsernameEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
        }

        private void txtPasswordEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
        }

        private void txtHighscoreEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.SuppressKeyPress = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
        }

        private void txtUsernameEdit_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
    }
}

