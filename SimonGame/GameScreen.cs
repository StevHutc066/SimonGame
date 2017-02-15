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


        private void ComputerTurn()
        {
            // Adds a random color to the color list
            float rand = rnd.Next(0,4);
            if (rand == 0)
            {
                Form1.computerPattern.Add(Color.Red);
            }else if (rand == 1)
            {
                Form1.computerPattern.Add(Color.Red);
            }
            else if (rand == 2)
            {
                Form1.computerPattern.Add(Color.Red);
            }
            else if (rand == 3)
            {
                Form1.computerPattern.Add(Color.Red);
            }
        }

        private void compareMethod()
        {
            for(int i = 0; i < Form1.computerPattern.Count; i++)
            {
                if(Form1.playerPattern[i] == Form1.computerPattern[i])
                {

                }
            }

        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            // Draws the buttons on-screen
            buttonDraw();
            
            // Clears past variables
            Form1.computerPattern.Clear();
            guess = 0;

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

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonDraw()
        {
            
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0,0,400, 400);
            circlePath.AddEllipse(150,150,100,100);
            greenButton.Region = new Region(circlePath);           
            //redButton.Region = new Region(newPath);
            //yellowButton.Region = new Region(circlePath);
            //blueButton.Region = new Region(circlePath);

        }

        public void GameOver()
        {
            Thread.Sleep(2000);
            Form form = base.FindForm();
            form.Controls.Remove(this);
            GameOverScreen gos = new GameOverScreen();
            form.Controls.Add(gos);
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            Form1.player[0].Play();
            Form1.playerPattern.Add(Color.Green);
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            Form1.player[1].Play();
            Form1.playerPattern.Add(Color.Red);
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            Form1.player[2].Play();
            Form1.playerPattern.Add(Color.Yellow);
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            Form1.player[3].Play();
            Form1.playerPattern.Add(Color.Blue);
        }
    }
}
