﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetsiBere.Model;

namespace VetsiBere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameManager.Insatance.Write();
        }
    }
}
