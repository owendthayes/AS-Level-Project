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
    public partial class Finish : MasterForm
    {
        Player thisPlayer;
        List<Player> players = new List<Player>();

        int[] dummyArray;
        bool replay;

        public Finish(Player ThisPlayer, int[] DummyArray, bool Replay)
        {
            InitializeComponent();
            
            thisPlayer = ThisPlayer;
            dummyArray = DummyArray;        //the player object, dummy array (for randomisation) and replay value are passed through
            replay = Replay;

            lblName.Text = thisPlayer.Name;
            lblScore.Text = Convert.ToString(thisPlayer.Score);
            imgAvatar.Image = thisPlayer.Avatar;        //player information is shown in the bottom right.
            lblHighscore.Text = thisPlayer.Highscore;

            lblCongrats.Text = "Well done " + ThisPlayer.Name + ", you completed the quiz with a score of " + ThisPlayer.Score;
            imgFinishAvatar.Image = ThisPlayer.Avatar;      //user is told that they completed the quiz and what their score is, their avatar is shown.

            if (Convert.ToInt16(thisPlayer.Score) >= Convert.ToInt16(thisPlayer.Highscore)) //if the user has beaten their high score
            {
                lblBeatHighscore.Text = "Nice! Your new highscore is  " + thisPlayer.Highscore + ", Good job!\nYou have unlocked the BlockJumper mini game!";
                thisPlayer.Highscore = thisPlayer.Score;
                lblHighscore.Text = thisPlayer.Highscore;   //they are told they have beaten their highscore, the minigame is unlocked
                btnGame.Enabled = true;                     //their highscore property is updated

                Stream sr;
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    sr = File.OpenRead("Players.bin");
                    players = (List<Player>)bf.Deserialize(sr); //the player binary file is read to a list.
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                foreach (Player Player in players)
                {
                    if (Player.Name == thisPlayer.Name) //current player is found from the binary file using their username
                    {
                        Stream sw;
                        BinaryFormatter cf = new BinaryFormatter();
                        Player.Highscore = thisPlayer.Highscore; //player's highscore is updated.

                        try
                        {
                            sw = File.OpenWrite("Players.bin");
                            cf.Serialize(sw, players);          //the player's new highscore is saved to the binary file.
                            sw.Close();
                        }
                        catch (SerializationException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
            else if (Convert.ToInt16(thisPlayer.Score) < Convert.ToInt16(thisPlayer.Highscore)) //if player does not beat their high score.
                lblBeatHighscore.Text = "You did not beat your previous highscore of " + thisPlayer.Highscore + " better luck next time!";
        }

        private void lblCongrats_Click(object sender, EventArgs e)
        {

        }

        private void imgFinishAvatar_Click(object sender, EventArgs e)
        {

        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReplay_Click_1(object sender, EventArgs e)
        {
            thisPlayer.Score = "0";
            replay = true;              //player's score is set to 0 when replaying, replay value is set to true 
                                        //this replay value is used in the randomisation of the first easy question.
            Form Form1 = new EasyHard(thisPlayer, dummyArray, replay);          
            this.Close();   //the difficulty form is opened again and the finish screen is closed.
            Form1.Show();           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";
            string title = "Log out";                               //user is asked to confirm if they wish to log out with a message box.
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form Form1 = new NewPlayer();
                this.Close();       //login form is opened again without passing player object
                Form1.Show();       //player can register or log in again.
            }
        }

        private void lblBeatHighscore_Click(object sender, EventArgs e)
        {

        }

        private void Finish_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();   //help form is opened on top of finish screen
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            Form Form1 = new Leaderboard();
            Form1.Show();   //leaderboard form is opened on top of finish screen.
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Form Form1 = new BlockJumper();
            Form1.Show();   //BlockJumper game is opened on top of finish screen.
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

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.gle/vRq5TQFr5oT7w1ii9");
        }
    }
}
