﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class EnsglishBuildWordsGameMenu : Form
    {
        public EnsglishBuildWordsGameMenu()
        {
            InitializeComponent();
            // Set form title
            this.Text = "Memory Game for Kids";

            // Set background image
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Title Label
            Label titleLabel = new Label();
            titleLabel.Text = "Welcome to \"Create the Words\"";
            titleLabel.Font = new Font("Arial", 24, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(100, 20);
            this.Controls.Add(titleLabel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Starting/...");
            this.Hide();
            // Create an instance of GameForm
            EnglishBuildWordsGame gameForm = new EnglishBuildWordsGame();
            // Show GameForm
            gameForm.Show();
        }

        private void TitleGame_Click(object sender, EventArgs e)
        {

        }
    }
}