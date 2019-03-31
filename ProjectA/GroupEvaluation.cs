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
    public partial class GroupEvaluation : Form
    {

        List<GroupEval> GroupEvals = new List<GroupEval>();

        public GroupEvaluation()
        {
            InitializeComponent();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                string fetch = "SELECT Id FROM [dbo].[Group]";
                SqlCommand cmd = new SqlCommand(fetch, con);
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    cmbGroupId.Items.Add(reader["Id"]);
                }
            }

            setGrid();
        }

        private void cmbGroupId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                string fetch = "SELECT Name FROM Evaluation WHERE Id NOT IN (SELECT EvaluationId FROM GroupEvaluation WHERE GroupId = '" + Convert.ToInt32(cmbGroupId.Text) + "')";

                SqlCommand cmd = new SqlCommand(fetch, con);
                SqlDataReader reader = cmd.ExecuteReader();

                cmbEvalId.Items.Clear();

                while (reader.Read())
                {
                    cmbEvalId.Items.Add(reader["Name"]);
                }
            }
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbGroupId.Text) && !string.IsNullOrWhiteSpace(cmbEvalId.Text) && !string.IsNullOrWhiteSpace(txtObtainMarks.Text))
            {
                try
                {
                    SqlConnection con = new SqlConnection(AddProject.conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string Insert = "INSERT INTO GroupEvaluation(GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES ('" + Convert.ToInt32(cmbGroupId.Text) + "', (SELECT Id FROM Evaluation WHERE Name = '" + Convert.ToString(cmbEvalId.Text) + "'), '" + Convert.ToInt32(txtObtainMarks.Text) + "', '" + Convert.ToDateTime(dtEvalDate.Value) + "')";
                        SqlCommand cmd = new SqlCommand(Insert, con);
                        cmd.ExecuteNonQuery();
                    }

                    setGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some Error Occured" + ex);
                }
            }
            else
            {
                MessageBox.Show("Input Data");
            }
        }

        private void setGrid()
        {
            GroupEval.ShowGroupEvals();
            GroupEvals = GroupEval.groupEvals;
            BindingSource s = new BindingSource();
            s.DataSource = GroupEvals;
            dgvGroupEvals.DataSource = s;
        }
    }
}
