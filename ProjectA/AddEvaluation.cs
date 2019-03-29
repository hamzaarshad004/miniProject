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
    public partial class AddEvaluation : Form
    {
        List<Evaluation> evaluations = new List<Evaluation>();
        int Mode = 0, Id; // 0 For Add, 1 For Edit

        public AddEvaluation()
        {
            InitializeComponent();
        }

        public void setGrid()
        {
            Evaluation.getEvaluations();
            evaluations = Evaluation.Evaluations;
            BindingSource s = new BindingSource();
            s.DataSource = evaluations;
            dgvEvaluations.DataSource = s;
        }

        private void dgvEvaluations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Id = Evaluation.Evaluations[e.RowIndex].Id1;
                Evaluation evaluation = Evaluation.Evaluations[e.RowIndex];
                txtName.Text = evaluation.Name1;
                txtMarks.Text = evaluation.TotalMarks1.ToString();
                txtWeightage.Text = evaluation.TotalWeightage1.ToString();

                Mode = 1;
            }
            else if(e.ColumnIndex == 1)
            {
                Id = Evaluation.Evaluations[e.RowIndex].Id1;
                string Delete = "DELETE FROM GroupEvaluation WHERE EvaluationId = '" + Id + "'";
                string Delete_Group_Evaluation = "DELETE FROM Evaluation WHERE Id = '" + Id + "'";
                try
                {
                    SqlConnection con = new SqlConnection(AddProject.conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(Delete_Group_Evaluation, con);
                        cmd.ExecuteNonQuery();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(Delete, con);
                        cmd.ExecuteNonQuery();
                    }
                    setGrid();

                    MessageBox.Show("Succesfully Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
               
            }
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void setNull()
        {
            txtMarks.Text = null;
            txtName.Text = null;
            txtWeightage.Text = null;
        }

        private void AddEvaluation_Load(object sender, EventArgs e)
        {
            setGrid();
        }

        private void btnAddEvalutation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtMarks.Text) && !string.IsNullOrWhiteSpace(txtWeightage.Text))
            {
                SqlConnection con = new SqlConnection(AddProject.conStr);
                con.Open();
                if (Mode == 0)
                {
                    try
                    {
                        string Insert = "INSERT INTO Evaluation(Name, TotalMarks, TotalWeightage) VALUES ('" + Convert.ToString(txtName.Text) + "', '" + Convert.ToString(txtMarks.Text) + "', '" + Convert.ToString(txtWeightage.Text) + "')";
                        SqlCommand cmd = new SqlCommand(Insert, con);
                        cmd.ExecuteNonQuery();
                        setGrid();

                        MessageBox.Show("Data Succefully Inserted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex);
                    }

                }
                else if (Mode == 1)
                {
                    try
                    {
                        string Update = "UPDATE Evaluation SET Name = '" + Convert.ToString(txtName.Text) + "', TotalMarks = '" + Convert.ToString(txtMarks.Text) + "', TotalWeightage = '" + Convert.ToString(txtWeightage.Text) + "' WHERE Id = '" + Id + "'";
                        SqlCommand cmd = new SqlCommand(Update, con);
                        cmd.ExecuteNonQuery();

                        Mode = 0;
                        setGrid();
                        setNull();

                        MessageBox.Show("Data Inserted Succesfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Enter some Data");
            }
            
        }
    }
}
