﻿using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UsersWindow newWindow = new UsersWindow();
            newWindow.Show();
        }

        private void btnScenes_Click(object sender, EventArgs e)
        {

        }

        private void btnFigures_Click(object sender, EventArgs e)
        {

        }
    }
}
