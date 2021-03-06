﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AddStudent AS = new AddStudent();
            AS.Show();
            AddAdvisor AD = new AddAdvisor();
            AD.Show();
            AddProject AP = new AddProject();
            AP.Show();
            //MakeGroups MG = new MakeGroups();
            //MG.Show();
            CreateGroup CG = new CreateGroup();
            //CG.Show();
            AddEvaluation AE = new AddEvaluation();
            AE.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent AS = new AddStudent();
            AS.Show();
        }

        private void btnAdvisors_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAdvisor AA = new AddAdvisor();
            AA.Show();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProject AP = new AddProject();
            AP.Show();
        }

        private void btnEvaluations_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEvaluation AE = new AddEvaluation();
            AE.Show();
        }

        private void btnAssgnProject_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupProject GP = new GroupProject();
            GP.Show();
        }

        private void btnEvalGroups_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupEvaluation GE = new GroupEvaluation();
            GE.Show();
        }

        private void btnAssgnAdvisor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignAdvisors AA = new AssignAdvisors();
            AA.Show();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateGroup CG = new CreateGroup();
            CG.Show();
        }

        private void btnProjectReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectReports PR = new ProjectReports();
            PR.Show();
        }
    }
}
