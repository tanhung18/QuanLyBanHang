﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void muaBánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCauHinh frmCauHinh = new FrmCauHinh();
            frmCauHinh.MdiParent = this;
            frmCauHinh.Show();

        }
    }
}
