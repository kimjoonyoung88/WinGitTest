﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Text = "버튼클릭";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Text = "추가버튼클릭테스트추가";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "ClickClickMe";
        }
    }
}
