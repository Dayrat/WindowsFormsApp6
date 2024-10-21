﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.DBContext;

namespace WindowsFormsApp6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Model1 model = new Model1();
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = model.Users.ToList();
        }
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            FormAddUsers form = new FormAddUsers();
            form.ShowDialog();
            dataGridView1.DataSource = model.Users.ToList();
        }
    }
}
