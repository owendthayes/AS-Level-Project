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
    public partial class Leaderboard : MasterForm
    {
        Player thisPlayer = new Player();
        List<Player> players = new List<Player>();

        bool bFormNameOpen;
      
        public Leaderboard()
        {
            InitializeComponent();
            readFileToList();

            foreach (Player player in players)
            {
                if (Convert.ToInt16(player.Highscore) >= Convert.ToInt16(lbl1Score.Text)) //set the places.
                {
                    lbl5Score.Text = lbl4Score.Text; //if the current player being checked has a higher
                    lbl4Score.Text = lbl3Score.Text; //highscore than the one in first, they are made first
                    lbl3Score.Text = lbl2Score.Text; //the rest of the names are shifted down by 1, this 
                    lbl2Score.Text = lbl1Score.Text; //keeps going until every player has been checked.
                    lbl1Score.Text = player.Highscore;

                    lblFifthPlace.Text = lblFourthPlace.Text;
                    lblFourthPlace.Text = lblThirdPlace.Text;
                    lblThirdPlace.Text = lblRealSecondPlace.Text;
                    lblRealSecondPlace.Text = lblFirstPlace.Text;
                    lblFirstPlace.Text = player.Name;

                    imgFirstPic.Image = player.Avatar;
                    lblFirstPic.Text = ("Top scoring player " + player.Name);
                }

                else if (Convert.ToInt16(player.Highscore) >= Convert.ToInt16(lbl2Score.Text))
                {
                    lbl5Score.Text = lbl4Score.Text;
                    lbl4Score.Text = lbl3Score.Text;
                    lbl3Score.Text = lbl2Score.Text;
                    lbl2Score.Text = player.Highscore;

                    lblFifthPlace.Text = lblFourthPlace.Text;
                    lblFourthPlace.Text = lblThirdPlace.Text;
                    lblThirdPlace.Text = lblRealSecondPlace.Text;
                    lblRealSecondPlace.Text = player.Name;
                }

                else if (Convert.ToInt16(player.Highscore) >= Convert.ToInt16(lbl3Score.Text))
                {
                    lbl5Score.Text = lbl4Score.Text;
                    lbl4Score.Text = lbl3Score.Text;
                    lbl3Score.Text = player.Highscore;

                    lblFifthPlace.Text = lblFourthPlace.Text;
                    lblFourthPlace.Text = lblThirdPlace.Text;
                    lblThirdPlace.Text = player.Name;
                }

                else if (Convert.ToInt16(player.Highscore) >= Convert.ToInt16(lbl4Score.Text))
                {
                    lbl5Score.Text = lbl4Score.Text;
                    lbl4Score.Text = player.Highscore;

                    lblFifthPlace.Text = lblFourthPlace.Text;
                    lblFourthPlace.Text = player.Name;
                }

                else if (Convert.ToInt16(player.Highscore) >= Convert.ToInt16(lbl5Score.Text))
                {
                    lbl5Score.Text = player.Highscore;

                    lblFifthPlace.Text = player.Name;
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
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
