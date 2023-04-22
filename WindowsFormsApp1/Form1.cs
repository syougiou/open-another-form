﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// aboutフォームを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            //親フォームの中心に表示
            form2.StartPosition = FormStartPosition.CenterParent;
            form2.ShowDialog(this);
            form2.Dispose();
        }
    }
}
