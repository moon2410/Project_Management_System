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
    public partial class StudentmyProjects : Form
    {
        string username = "username";
        public StudentmyProjects()
        {
            InitializeComponent();
        }
        public StudentmyProjects(string username)
        {
            this.username = username;
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDeshBoard rg = new StudentDeshBoard();
            rg.Show();
        }

        private void LogOut_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage rg = new LoginPage();
            rg.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage rg = new LoginPage();
            rg.Show();
        }

        private void Fac_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFacultyListShow rg = new StudentFacultyListShow();
            rg.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFacultyListShow rg = new StudentFacultyListShow();
            rg.Show();
        }

        private void Camp_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTsk rg = new StudentTsk();
            rg.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTsk rg = new StudentTsk();
            rg.Show();
        }

        private void Course_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAllProjects rg = new StudentAllProjects();
            rg.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAllProjects rg = new StudentAllProjects();
            rg.Show();
        }

        private void Home_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDeshBoard rg = new StudentDeshBoard(username);
            rg.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage rg = new LoginPage();
            rg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentProjectSubmit rg = new StudentProjectSubmit();
            rg.Show();
        }

        private void facultyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFacultyListShow rg = new StudentFacultyListShow();
            rg.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTsk rg = new StudentTsk();
            rg.Show();
        }

        private void myProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentmyProjects rg = new StudentmyProjects();
            rg.Show();
        }

        private void allProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAllProjects rg = new StudentAllProjects();
            rg.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentProfileEdit rg = new StudentProfileEdit();
            rg.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChangePass rg = new StudentChangePass();
            rg.Show();
        }

        private void StudentmyProjects_Load(object sender, EventArgs e)
        {

        }
    }
}
