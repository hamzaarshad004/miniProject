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
    public partial class AssignAdvisors : Form
    {
        public AssignAdvisors()
        {
            InitializeComponent();
        }

        private void AssignAdvisors_Load(object sender, EventArgs e)
        {
            setProjectIds();
        }

        private void cmbAdvisorId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbProjectId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();

            cmbAdvisorId.Items.Clear();

            if (con.State == ConnectionState.Open)
            {
                try
                {
                    string fetch = "SELECT Id FROM Advisor WHERE Id NOT IN (SELECT AdvisorId FROM ProjectAdvisor WHERE ProjectId = (SELECT Id FROM Project WHERE Title = '" + Convert.ToString(cmbProjectId.Text) + "'))";
                    SqlCommand cmd = new SqlCommand(fetch, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbAdvisorId.Items.Add(reader["Id"]);
                    }

                    cmbAdvisorRole.Items.Clear();

                    cmbAdvisorRole.Items.Add("Main Advisor");
                    cmbAdvisorRole.Items.Add("Co-Advisror");
                    cmbAdvisorRole.Items.Add("Industry Advisor");

                    string fetch1 = "SELECT Lookup.Value FROM Lookup WHERE Id IN(SELECT AdvisorRole FROM ProjectAdvisor WHERE ProjectId = (SELECT Id FROM Project WHERE Title = '" + Convert.ToString(cmbProjectId.Text) + "'))";
                    SqlCommand cmd1 = new SqlCommand(fetch1, con);

                    reader.Close();

                    SqlDataReader reader1 = cmd1.ExecuteReader();

                    while (reader1.Read())
                    {
                        string Yo = Convert.ToString(reader1["Value"]);
                        cmbAdvisorRole.Items.Remove(Yo);
                    }

                }
                catch
                {
                    MessageBox.Show("Some Error Occured");
                }
                
            }
        }

        private void setProjectIds()
        {
            cmbProjectId.Items.Clear();

            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                try
                {
                    string fetch = "SELECT Title FROM Project WHERE Id NOT IN (SELECT ProjectId FROM ProjectAdvisor  GROUP BY ProjectId HAVING COUNT(AdvisorId) = 3)";
                    SqlCommand cmd = new SqlCommand(fetch, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbProjectId.Items.Add(reader["Title"]);
                    }
                }
                catch
                {
                    MessageBox.Show("Some Error Occured");
                }
               
            }
        }

        private void btnAssignAdvisor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();

            if (con.State == ConnectionState.Open)
            {

                try
                {
                    string Insert = "INSERT INTO ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES ('" + Convert.ToInt32(cmbAdvisorId.Text) + "', (SELECT Id FROM Project WHERE Title = '" + Convert.ToString(cmbProjectId.Text) + "'), (SELECT Lookup.Id FROM Lookup WHERE Lookup.Value = '" + Convert.ToString(cmbAdvisorRole.Text) + "'), '" + Convert.ToDateTime(dtAssignmentDate.Value) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Inserted");
                }
                catch
                {
                    MessageBox.Show("Some Error Occured");
                }
                
            }

            setProjectIds();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }
    }
}
