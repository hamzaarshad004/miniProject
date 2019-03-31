using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectA
{
    public partial class GroupProject : Form
    {
        public GroupProject()
        {
            InitializeComponent();
        }

        private void setCmbBoxes()
        {
            cmbTitle.Items.Clear();
            cmbGroupId.Items.Clear();

            try
            {
                SqlConnection con = new SqlConnection(AddProject.conStr);
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    string fetch = "SELECT Title FROM Project WHERE Id NOT IN (SELECT ProjectId FROM GroupProject)";
                    SqlCommand cmd = new SqlCommand(fetch, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbTitle.Items.Add(reader["Title"]);
                    }

                    reader.Close();

                    cmd.CommandText = "SELECT Id FROM [dbo].[Group] WHERE Id NOT IN (SELECT GroupId FROM GroupProject)";

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbGroupId.Items.Add(reader["Id"]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Some Error Occured");
            }

           
        }

        private void GroupProject_Load(object sender, EventArgs e)
        {
            setCmbBoxes();
        }

        private void btnAssignProject_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(AddProject.conStr);
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    string Insert = "INSERT INTO GroupProject(ProjectId, GroupId, AssignmentDate) VALUES ((SELECT Id FROM Project WHERE Title = '" + Convert.ToString(cmbTitle.Text) + "'), '" + Convert.ToInt32(cmbGroupId.Text) + "', '" + Convert.ToDateTime(dtAssgmtDate.Value) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Added");
                }

                setCmbBoxes();
            }
            catch
            {
                MessageBox.Show("Some Error Occured");
            }

            
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }
    }
}
