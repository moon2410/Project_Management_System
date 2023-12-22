﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class AdminFacultyBoard : Form
    {
        public AdminFacultyBoard()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminStudentBoard ads = new AdminStudentBoard();
            ads.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminStudentBoard ads = new AdminStudentBoard();
            ads.Show();
        }

        private void facultyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFacultyBoard ads = new AdminFacultyBoard();
            ads.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminTasksBoard ads = new AdminTasksBoard();
            ads.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminTasksBoard ads = new AdminTasksBoard();
            ads.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ads = new AdminDashboard();
            ads.Show();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ads = new AdminDashboard();
            ads.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAccount ads = new AdminAccount();
            ads.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAccount ads = new AdminAccount();
            ads.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void AdminFacultyBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
