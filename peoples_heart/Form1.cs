﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using peoples_heart.Resources;


namespace peoples_heart
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        textToSpeech ts = new textToSpeech();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new Form2().Show(this);
           
        }

        private void metroButton1_MouseHover(object sender, EventArgs e)
        {
            ts.speak((sender as Button).Text);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new Form3(this).Show(this);

        }

        private void metroButton2_MouseHover(object sender, EventArgs e)
        {
            ts.speak((sender as Button).Text);
           
          
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
