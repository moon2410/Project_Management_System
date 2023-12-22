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
    public partial class Faculty_TaskBoard : Form
    {
        public Faculty_TaskBoard()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyGroups ads = new FacultyGroups();
            ads.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyGroups ads = new FacultyGroups();
            ads.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facultyListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculty_TaskBoard ads = new Faculty_TaskBoard();
            ads.Show();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyDashboard ads = new FacultyDashboard();
            ads.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyDashboard ads = new FacultyDashboard();
            ads.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyProfileEdit ads = new FacultyProfileEdit();
            ads.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyChangePass ads = new FacultyChangePass();
            ads.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveStudentList ads = new RemoveStudentList();
            ads.Show();
        }

        private void currentStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyStudentist ads = new FacultyStudentist();
            ads.Show();
        }

        private void appliedStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyAppliedStudent ads = new facultyAppliedStudent();
            ads.Show();
        }

        private void Faculty_TaskBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
