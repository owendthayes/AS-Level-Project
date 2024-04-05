using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Coursework_Quiz_Game
{
    [Serializable]
    public class Player
    {
        string name;        //all of the players attributes are being created
        string password;
        string score;
        Image avatar;
        string highscore;
        bool admin;

        public Player()
        {
            name = "";
            password = "";
            score = "0";    //by default they are set to blank
            avatar = null;
            highscore = "0";
            admin = false;
        }

        public Player(string name, string password, int score, Image avatar, string highscore, bool admin)
        {
            Name = name;
            Password = password;
            Avatar = avatar;
            Highscore = highscore;
            Admin = admin;
        }

        public string Name
        {
            get { return name; }    //these are the methods that will be used to get these attributes
            set { name = value; }   //from the player during the runtime of the applicaton.
        }      

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Score
        {
            get { return score; }
            set { score = value; }
        }

        public Image Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public string Highscore
        {
            get { return highscore; }
            set { highscore = value; }
        }

        public bool Admin
        {
            get { return admin; }
            set { admin = value; }
        }
    }
}
