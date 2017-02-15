﻿using System;
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
        public static List<Color> computerPattern = new List<Color>();
        public static List<Color> playerPattern = new List<Color>();
        public static SoundPlayer[] player = new SoundPlayer[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }
    }
}