using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonGame
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            // Tells player what length the pattern got to through label
            patternLengthLabel.Text = "Your pattern lenth was: " + Form1.computerPattern.Count;
        }

        private void mainScreenButton_Click_1(object sender, EventArgs e)
        {
            // Goes back to MainScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
        }
    }
}
