﻿using Guna.UI2.WinForms;
using System;
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
    public partial class Placsart : UserControl
    {
        public Placsart()
        {
            InitializeComponent();
            
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Placsart_Load(object sender, EventArgs e)
        {
            foreach(Control control in panel1.Controls)
            {              
                if (control is Guna2CustomCheckBox)
                {
                    Guna2CustomCheckBox checkBox = (Guna2CustomCheckBox)control;
                    Global.checklist.Add(checkBox);
                }
            }            
        }
    }
}
