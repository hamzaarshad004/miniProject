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
        int Mode = 0;
        int Check = 0;

        public GroupEvaluation()
        {
            InitializeComponent();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Some Error Occured");
            }
          
        }

        private void cmbGroupId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Check == 0)
            {
                try
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
                catch
                {
                    MessageBox.Show("Some Error Occured");
                }
               
            }
            
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            if (Mode == 0)
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

                            MessageBox.Show("Succesfully Inserted");
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
            else if (Mode == 1)
            {
                if (!string.IsNullOrWhiteSpace(cmbGroupId.Text) && !string.IsNullOrWhiteSpace(cmbEvalId.Text) && !string.IsNullOrWhiteSpace(txtObtainMarks.Text))
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(AddProject.conStr);
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            string Insert = "UPDATE GroupEvaluation SET ObtainedMarks = '" + Convert.ToInt32(txtObtainMarks.Text) + "' WHERE GroupId = '" + Convert.ToInt32(cmbGroupId.Text) + "' AND EvaluationId = (SELECT Id FROM Evaluation WHERE Name = '" + Convert.ToString(cmbEvalId.Text) + "') ";
                            SqlCommand cmd = new SqlCommand(Insert, con);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Succesfully Updated");
                        }

                        setGrid();
                        Mode = 0;
                        Check = 0;

                        cmbGroupId.Enabled = true;
                        cmbEvalId.Enabled = true;
                        dtEvalDate.Enabled = true;
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
            
        }

        private void setGrid()
        {
            GroupEval.ShowGroupEvals();
            GroupEvals = GroupEval.groupEvals;
            BindingSource s = new BindingSource();
            s.DataSource = GroupEvals;
            dgvGroupEvals.DataSource = s;
        }

        private void dgvGroupEvals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Mode = 1;
                Check = 1;
                cmbEvalId.Items.Add(GroupEvals[e.RowIndex].Eval_Name);
                cmbEvalId.Text = Convert.ToString(GroupEvals[e.RowIndex].Eval_Name);
                cmbGroupId.Text = Convert.ToString(GroupEvals[e.RowIndex].Group_Id);
                txtObtainMarks.Text = Convert.ToString(GroupEvals[e.RowIndex].Obtained_Marks);
                dtEvalDate.Value = GroupEvals[e.RowIndex].Eval_Date;

                cmbGroupId.Enabled = false;
                cmbEvalId.Enabled = false;
                dtEvalDate.Enabled = false;
            }
            else if (e.ColumnIndex == 1)
            {
                try
                {
                    SqlConnection con = new SqlConnection(AddProject.conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string Delete = "DELETE FROM GroupEvaluation WHERE GroupId = '" + GroupEvals[e.RowIndex].Group_Id + "' AND EvaluationId = '" + GroupEvals[e.RowIndex].Eval_Id + "'";
                        SqlCommand cmd = new SqlCommand(Delete, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Succesfully Deleted");
                    }

                    setGrid();
                }
                catch
                {
                    MessageBox.Show("Some Error Occured");
                }
               
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
