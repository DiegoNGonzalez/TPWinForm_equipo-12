﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2
{
    public partial class FormAddModImg : Form
    {
        public FormAddModImg()
        {
            InitializeComponent();
        }
        public FormAddModImg(string UrlImg)
        {
            InitializeComponent();
            txtAddModImg.Text = UrlImg;
        }
    }
}