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
    public partial class BlockJumper : Form
    {
        int runState = 1, jumpState = 1, slideState = 1, RandomNo, distance = 0, score = 0;
        bool doingAction = false;
        double Speed = 0, actionTime = 10;
        string blockType = "";

        string runState1, runState2, runState3, runState4;
        string jumpState1, jumpState2;   
        string slideState1, slideState2;

        Random random = new Random();

        public BlockJumper()
        {
            InitializeComponent();

            //RUNNING ANIMATION FRAMES
            runState1 = Application.StartupPath;
            runState1 = runState1.Remove((Convert.ToInt16(runState1.Length) - 9));
            runState1 += "Images\\playerRun1.png";

            runState2 = Application.StartupPath;
            runState2 = runState1.Remove((Convert.ToInt16(runState2.Length) - 9));
            runState2 += "Images\\playerRun2.png";

            runState3 = Application.StartupPath;
            runState3 = runState1.Remove((Convert.ToInt16(runState3.Length) - 9));
            runState3 += "Images\\playerRun3.png";

            runState4 = Application.StartupPath;
            runState4 = runState1.Remove((Convert.ToInt16(runState4.Length) - 9));
            runState4 += "Images\\playerRun2.png";

            //JUMPING ANIMATION FRAMES
            jumpState1 = Application.StartupPath;
            jumpState1 = runState1.Remove((Convert.ToInt16(jumpState1.Length) - 9));
            jumpState1 += "Images\\playerjump1.png";

            jumpState2 = Application.StartupPath;
            jumpState2 = runState1.Remove((Convert.ToInt16(jumpState2.Length) - 9));
            jumpState2 += "Images\\playerjump2.png";

            //SLIDING ANIMATION FRAMES
            slideState1 = Application.StartupPath;
            slideState1 = runState1.Remove((Convert.ToInt16(slideState1.Length) - 9));
            slideState1 += "Images\\playerslide1.png";

            slideState2 = Application.StartupPath;
            slideState2 = runState1.Remove((Convert.ToInt16(slideState2.Length) - 9));
            slideState2 += "Images\\playerslide2.png";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            clkPlayerRun.Start();
            clkAction.Start();          //this label is actually the button that says "start game"
            clkSpeedUp.Start();
            blockSpawner.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playerRunning_Click(object sender, EventArgs e)
        {

        }

        private void clkPlayerRun_Tick(object sender, EventArgs e)
        {
            if (runState == 1)
            {                                                       //this clock changes the image used for the animated character
                playerRunning.Image = Image.FromFile(runState2);    //so it is animated
                runState = runState + 1;
            }
            else if (runState == 2)
            {
                playerRunning.Image = Image.FromFile(runState3);
                runState = runState + 1;
            }
            else if (runState == 3)
            {
                playerRunning.Image = Image.FromFile(runState4);
                runState = runState + 1;
            }
            else if (runState == 4)
            {
                playerRunning.Image = Image.FromFile(runState1);
                runState = 1;
            }
        }

        private void BlockJumper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 38)   //this checks if the down arrow key has been pressed
            {                           
                if (doingAction == false)
                {
                    playerRunning.Visible = false;      //the player images of sliding and running are invisible
                    playerSliding.Visible = false;
                    playerJumping.Visible = true;       //the jumping player is visible so it looks like he is jumping

                    clkAction.Start();
                    doingAction = true;     //this is used so the player has a cooldown between actions
                }               
             }
             if (e.KeyValue == 40)
             {
                if (doingAction == false)
                {
                    playerRunning.Visible = false;      //the player images of running and jumping are invisible
                    playerJumping.Visible = false;
                    playerSliding.Visible = true;       //the sliding player is visible so it looks like he is sliding

                    clkAction.Start();
                    doingAction = true;     //this is also used so the player has a cooldown between actions    
                }                              
            }                   
       }

        private void clkAction_Tick(object sender, EventArgs e)
        {
            actionTime = actionTime - 1;

            //JUMPING ANIMATIONS
            if (jumpState == 1)
            {
                playerJumping.Image = Image.FromFile(jumpState2);
                jumpState = 2;
            }
            else if (jumpState == 2)                    //this is the same as the running animations but it only takes place when the
            {                                           //character is jumping or sliding so these actions are animated
                playerJumping.Image = Image.FromFile(jumpState1);
                jumpState = 1;
            }

            //SLIDING ANIMATIONS
            if (slideState == 1)
            {
                playerSliding.Image = Image.FromFile(slideState2);
                slideState = 2;
            }
            else if (slideState == 2)
            {
                playerSliding.Image = Image.FromFile(slideState1);
                slideState = 1;
            }
            if (actionTime == 0)
            {
                playerSliding.Visible = false;
                playerJumping.Visible = false;
                playerRunning.Visible = true;
                actionTime = 10;
                doingAction = false;
            }
        }       

        private void blockSpawner_Tick(object sender, EventArgs e)
        {
            RandomNo = random.Next(2);      //this will choose either a high or low block for the player to avoid

            if (RandomNo == 0)
            {
                blockType = "high";         

                boxHigh3.Visible = true;    //this spawns a high block if the number for high is chosen
                boxMover.Start();           //this starts the code that moves the block closer to the player
            }

            else if (RandomNo == 1)
            {
                blockType = "low";          

                boxLow3.Visible = true;     //this spawns a low block if the number for low is chosen
                boxMover.Start();           //this starts the code that moves the block closer to the player
            }   
            blockSpawner.Stop();
        }

        private void boxMover_Tick(object sender, EventArgs e)
        {
            if (blockType == "high")
            {
                if (distance == 0)
                {
                    boxHigh3.Visible = true;
                    boxHigh2.Visible = false;
                    boxHigh1.Visible = false;
                    boxHighPass.Visible = false;
                }
                if (distance == 1)
                {
                    boxHigh2.Visible = true;
                    boxHigh3.Visible = false;           //this code moves the block closer to the character
                    boxHigh1.Visible = false;           //this is done by using multiple picture boxes that
                }                                       //turn visible and invisible based on where the
                if (distance == 2)                      //the block should be in relation to the player
                {
                    boxHigh1.Visible = true;
                    boxHigh2.Visible = false;
                    boxHigh3.Visible = false;
                    boxHighPass.Visible = false;
                }
                if (distance == 3)
                {
                    if (playerSliding.Visible == true)
                    {
                        boxHigh1.Visible = false;               //this checks if the player is doin the correct action when a high block is coming
                        boxHighPass.Visible = true;             //towards them, if they are then a point is added to their score
                        score += 1;
                        lblScore.Text = ("Score: " + score);                        
                    }
                    else
                    {
                        boxMover.Stop();
                        blockSpawner.Stop();                    //if they are doing the wrong action, the game is over.
                        lblFinish.Text = lblFinish.Text + score;
                        lblFinish.Visible = true;
                    }                       
                }
                if (distance == 4)
                {
                    boxHighPass.Visible = false;        //this is when the block is past the player, this doesnt really matter 
                                                        //functionally it just makes the game look nicer.
                    blockSpawner.Start();
                    boxMover.Start();
                    distance = -1;
                }
                distance = distance + 1;
            }
            else
            {
                if (distance == 0)
                {
                    boxLow3.Visible = true;
                    boxLow2.Visible = false;
                    boxLow1.Visible = false;            //this is the same as the code above for when the block is high
                    boxLowPass.Visible = false;         //but this is when the block that spawns is low
                }
                if (distance == 1)
                {
                    boxLow2.Visible = true;
                    boxLow3.Visible = false;
                    boxLow1.Visible = false;
                    boxLowPass.Visible = false;
                }
                if (distance == 2)
                {
                    boxLow1.Visible = true;
                    boxLow2.Visible = false;
                    boxLow3.Visible = false;
                    boxLowPass.Visible = false;
                }
                if(distance == 3)
                {
                    if (playerJumping.Visible == true)
                    {
                        boxLow1.Visible = false;
                        boxLowPass.Visible = true;          //if the player jumps over the block, a point is added.
                        score += 1;
                        lblScore.Text = ("Score: " + score);
                    }
                    else
                    {
                        boxMover.Stop();
                        blockSpawner.Stop();
                        lblFinish.Text = lblFinish.Text + score;
                        lblFinish.Visible = true;
                    }                        
                }
                if (distance == 4)
                {
                    boxLowPass.Visible = false;

                    blockSpawner.Start();
                    boxMover.Start();
                    distance = -1;
                }
                distance = distance + 1;
            }          
        }

        private void clkSpeedUp_Tick(object sender, EventArgs e)
        {
            if (score == 0)
            {
                boxMover.Interval = 1000;                   //this code will check if the users score is at a certain amount
                clkAction.Interval = 250;                   //so that the speed of the blocks moving will increase and the
                lblSpeed.Text = "Speed: Normal";            //game will get harder.
            }
            else if (score == 5)
            {
                boxMover.Interval = 500;
                lblSpeed.Text = "Speed: Fast";
            }
            else if (score == 15)
            {
                boxMover.Interval = 250;
                clkAction.Interval = 110;                   //i also had to decrease the time of the cooldown between actions
                lblSpeed.Text = "Speed: Way too fast!";     //so the player would still be able to perform a new action when             
            }                                               //a new block has spawned
            else if (score == 30)
            {
                boxMover.Interval = 210;
                clkAction.Interval = 100;
                lblSpeed.Text = "Speed: Insanity!!";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form Form1 = new BlockJumper();             //this is the replay button, it just opens the form again so it is restarted
            Form1.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();                               //this label is the quit button so that the minigame is closed.
        }

        private void lblSpeed_Click(object sender, EventArgs e)
        {

        }
    }
}
