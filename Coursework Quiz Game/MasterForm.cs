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
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
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
                } //user asked to confirm that they want to quit, if they confirm then the whole quiz closes.
        }

        private void imgAvatar_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayScore_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        { 

        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new HelpForm();
            Form1.Show();
        }
    }
}
