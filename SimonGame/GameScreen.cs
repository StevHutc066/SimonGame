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


            //TODO: Use Switch statement after working
            //switch (rand)
            //{
            //    case 1:
            //        Console.WriteLine("Case 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Case 2");
            //        break;
            //    default:
            //        Console.WriteLine("Default case");
            //        break;
            //}
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            buttonDraw();
            Form1.computerPattern.Clear();
            guess = 0;
            Refresh();
            Thread.Sleep(1500);
            
            
    }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            ComputerTurn();
        }

        private void buttonDraw()
        {
            
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0,0,400, 400);
            circlePath.AddEllipse(150,150,100,100);

            GraphicsPath newPath = new GraphicsPath();
            newPath.AddEllipse
            greenButton.Region = new Region(circlePath);
            redButton.Region = new Region(circlePath);
            yellowButton.Region = new Region(circlePath);
            blueButton.Region = new Region(circlePath);

        }

        public void GameOver()
        {
            Thread.Sleep(2000);
            Form form = base.FindForm();
            form.Controls.Remove(this);
            GameOverScreen gos = new GameOverScreen();
            form.Controls.Add(gos);
        }
    }
}
