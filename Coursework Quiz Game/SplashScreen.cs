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
    public partial class SplashScreen : Form
    {
        int timeLeft = 3; //this is how long the splashscreen shows for.

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void pgbLoadingBar_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;              

            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1; //a loading bar will move across the splashscreen.
            }

            else
            {
                timer1.Stop();

                Form Form2 = new NewPlayer();
                Form2.Show(); //when the bar is full, open the login form.
                this.Hide();
            }
        }
    }
}  
 

