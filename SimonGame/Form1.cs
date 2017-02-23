//Program: Simon Game
//Created by Steven Hutchinson
//Date: Feb 17, 2017
//Desc: A pattern memory game based on colours
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SimonGame
{
    public partial class Form1 : Form
    {
        // A list of the colors
        public static List<int> computerPattern = new List<int>();
        public static List<int> playerPattern = new List<int>();
        public static List<Button> buttonList = new List<Button>();
        public static SoundPlayer[] player = new SoundPlayer[5];
        public static int guessIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Opens MainScreen
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }
    }
}
