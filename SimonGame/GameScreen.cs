using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SimonGame
{
    public partial class GameScreen : UserControl
    {
        public int guess;
        public Random rnd = new Random();

        public GameScreen()
        {
            InitializeComponent();
        }

        private void buttonDraw()
        {
            // Changes the shape of the green button
            GraphicsPath gPath = new GraphicsPath();
            gPath.AddEllipse(0,0,400, 400);
            gPath.AddEllipse(150,150,100,100);
            greenButton.Region = new Region(gPath);

            // Changes the shape of the red button
            GraphicsPath gPath2 = new GraphicsPath();
            gPath2.AddEllipse(-200, 0, 400, 400);
            gPath2.AddEllipse(-50, 150,100,100);
            redButton.Region = new Region(gPath2);

            // Changes the shape of the yellow button
            GraphicsPath gPath3 = new GraphicsPath();
            gPath3.AddEllipse(0,-200,400,400);
            gPath3.AddEllipse(150, -50, 100, 100);
            yellowButton.Region = new Region(gPath3);

            // Changes the shape of the blue button
            GraphicsPath gPath4 = new GraphicsPath();
            gPath4.AddEllipse(-200,-200,400,400);
            gPath4.AddEllipse(-50, -50, 100, 100);
            blueButton.Region = new Region(gPath4);
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            // Draws the buttons on-screen
            buttonDraw();
            
            // Clears past variables
            Form1.computerPattern.Clear();
            Form1.playerPattern.Clear();
            guess = 0;
            Form1.guessIndex = 0;

            // Refreshes the screen
            Refresh();

            // Second delay before start
            Thread.Sleep(1000);

            // Adds sounds into the global player
            Form1.player[0] = new SoundPlayer(SimonGame.Properties.Resources.green);
            Form1.player[1] = new SoundPlayer(SimonGame.Properties.Resources.red);
            Form1.player[2] = new SoundPlayer(SimonGame.Properties.Resources.yellow);
            Form1.player[3] = new SoundPlayer(SimonGame.Properties.Resources.blue);
            Form1.player[4] = new SoundPlayer(SimonGame.Properties.Resources.mistake);

            // Computer picks a color
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            // Adds a random color to the color list
            int rand = rnd.Next(0,4);

            Form1.computerPattern.Add(rand);

            buttonLightMethod();
            
        }

        private void buttonLightMethod()
        {
            // Refreshes the screen
            Refresh();

            for (int i = 0; i < Form1.computerPattern.Count; i++)
            {
                int color = Form1.computerPattern[i];
                switch (color)
                {
                    case 0:

                        greenButton.BackColor = Color.GreenYellow;
                        Form1.player[0].Play();
                        Refresh();
                        Thread.Sleep(1000);
                        greenButton.BackColor = Color.ForestGreen;
                        break;
                    case 1:

                        redButton.BackColor = Color.Red;
                        Form1.player[1].Play();
                        Refresh();
                        Thread.Sleep(1000);
                        redButton.BackColor = Color.DarkRed;
                        break;
                    case 2:

                        yellowButton.BackColor = Color.Yellow;
                        Form1.player[2].Play();
                        Refresh();
                        Thread.Sleep(1000);
                        yellowButton.BackColor = Color.Goldenrod;
                        break;
                    case 3:

                        blueButton.BackColor = Color.DodgerBlue;
                        Form1.player[3].Play();
                        Refresh();
                        Thread.Sleep(1000);
                        blueButton.BackColor = Color.DarkBlue;
                        break;
                }
            }
            
            Refresh();
        }

        // TODO fix the light up
        private void compareMethod()
        {
            if (Form1.guessIndex == Form1.playerPattern.Count)
            {
                Form1.guessIndex = 0;
                ComputerTurn();
            }
            if (Form1.computerPattern[Form1.guessIndex] != Form1.playerPattern[Form1.guessIndex])
            {
                GameOver();
            }
            else
            {
                ComputerTurn();
            }
            
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void GameOver()
        {
            Thread.Sleep(1200);
            Form form = base.FindForm();
            form.Controls.Remove(this);
            GameOverScreen gos = new GameOverScreen();
            form.Controls.Add(gos);
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            Form1.player[0].Play();
            Form1.playerPattern.Add(0);
            compareMethod();
            Form1.guessIndex++;
            
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            Form1.player[1].Play();
            Form1.playerPattern.Add(1);
            compareMethod();
            Form1.guessIndex++;
            
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            Form1.player[2].Play();
            Form1.playerPattern.Add(2);
            compareMethod();
            Form1.guessIndex++;
            
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            Form1.player[3].Play();
            Form1.playerPattern.Add(3);
            compareMethod();
            Form1.guessIndex++;
            
        }
    }
}
