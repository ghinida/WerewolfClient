﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerewolfClient
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
