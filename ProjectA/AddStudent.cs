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
    public partial class AddStudent : Form
    {

        public string conStr = "Data Source=DESKTOP-P69CV50;Initial Catalog=ProjectA;Integrated Security=True";
        public static int Mode = 0; // 0 For Add, 1 For Edit
        public int StudentID;
        public int GroupId;
        List<Student> GetStudents = new List<Student>();

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                AddStudent.Mode = 1;
                StudentID = Student.students[e.RowIndex].ID1;
                Student S = Student.students[e.RowIndex];
                txtFirstName.Text = S.FirstName1;
                txtLastName.Text = S.LastName1;
                txtRegNo.Text = S.Registration_Number1;
                txtEmail.Text = S.Email1;
                txtContact.Text = S.Contact1;
                dtDOB.Value = S.DOB1;
                string gender = S.Gender1;
                if (gender == "Male")
                {
                    cmbGender.SelectedIndex = 0;
                }
                else
                {
                    cmbGender.SelectedIndex = 1;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                try
                {
                    SqlConnection con = new SqlConnection(AddProject.conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        int Id = Student.students[e.RowIndex].ID1;
                        string Delete_Group = "DELETE FROM GroupStudent WHERE StudentId = '" + Id + "'";
                        SqlCommand sql = new SqlCommand(Delete_Group, con);
                        sql.ExecuteNonQuery();
                        string Delete_Student = "DELETE FROM Student WHERE Id = '" + Id + "'";
                        SqlCommand connection = new SqlCommand(Delete_Student, con);
                        connection.ExecuteNonQuery();
                        string Delete = "DELETE FROM Person WHERE Id = '" + Id + "'";
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

        public AddStudent()
        {
            InitializeComponent();
        }


        private void AddStudent_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            setGrid();
        }
            
                
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (!string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrWhiteSpace(txtLastName.Text) && !string.IsNullOrWhiteSpace(txtContact.Text) && !string.IsNullOrWhiteSpace(txtRegNo.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (Mode == 0)
                {
                    try
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            string Insert;
                            if (cmbGender.SelectedIndex == 0)
                            {
                                Insert = "INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + Convert.ToString(txtFirstName.Text) + "', '" + Convert.ToString(txtLastName.Text) + "','" + Convert.ToString(txtContact.Text) + "', '" + Convert.ToString(txtEmail.Text) + "','" + Convert.ToDateTime(dtDOB.Value) + "', '" + 1 + "')";
                            }
                            else
                            {
                                Insert = "INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + Convert.ToString(txtFirstName.Text) + "', '" + Convert.ToString(txtLastName.Text) + "','" + Convert.ToString(txtContact.Text) + "', '" + Convert.ToString(txtEmail.Text) + "','" + Convert.ToDateTime(dtDOB.Value) + "', '" + 2 + "')";
                            }
                            int ID;
                            SqlCommand cmd = new SqlCommand(Insert, con);
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "SELECT @@IDENTITY";
                            ID = Convert.ToInt32(cmd.ExecuteScalar());
                            string StudentInsert = "INSERT INTO Student(Id, RegistrationNo) VALUES('" + ID + "','" + Convert.ToString(txtRegNo.Text) + "')";
                            SqlCommand sqlCommand = new SqlCommand(StudentInsert, con);
                            sqlCommand.ExecuteNonQuery();

                            setGrid();
                            setNull();
                        }

                        MessageBox.Show("Data Succesfully Inserted");
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
                        if (con.State == ConnectionState.Open)
                        {
                            string Update;
                            if (cmbGender.SelectedIndex == 0)
                            {
                                Update = "UPDATE Person SET FirstName = '" + Convert.ToString(txtFirstName.Text) + "', LastName = '" + Convert.ToString(txtLastName.Text) + "', Contact = '" + Convert.ToString(txtContact.Text) + "', Email = '" + Convert.ToString(txtEmail.Text) + "', DateOfBirth = '" + Convert.ToDateTime(dtDOB.Value) + "', Gender = '" + 1 + "' WHERE ID = '" + StudentID + "'";
                            }
                            else
                            {
                                Update = "UPDATE Person SET FirstName = '" + Convert.ToString(txtFirstName.Text) + "', LastName = '" + Convert.ToString(txtLastName.Text) + "', Contact = '" + Convert.ToString(txtContact.Text) + "', Email = '" + Convert.ToString(txtEmail.Text) + "', DateOfBirth = '" + Convert.ToDateTime(dtDOB.Value) + "', Gender = '" + 2 + "' WHERE ID = '" + StudentID + "'";
                            }
                            string Update_Student = "UPDATE Student SET RegistrationNo = '" + Convert.ToString(txtRegNo.Text) + "' WHERE Id = '" + StudentID + "'";
                            SqlCommand cmd = new SqlCommand(Update, con);
                            cmd.ExecuteNonQuery();
                            SqlCommand sqlCommand = new SqlCommand(Update_Student, con);
                            sqlCommand.ExecuteNonQuery();
                        }

                        setGrid();
                        setNull();
                        AddStudent.Mode = 0;
                        MessageBox.Show("Succesfully Updated");
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

        private void setNull()
        {
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtEmail.Text = null;
            txtContact.Text = null;
            txtRegNo.Text = null;
        }

        /*private void lblViewAdded_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ShowStudents SS = new ShowStudents();
            SS.Show();
        }*/

        public void setGrid()
        {
                Student.ShowStudents();
                GetStudents = Student.students;
                BindingSource s = new BindingSource();
                s.DataSource = GetStudents;
                dgvStudents.DataSource = s;
            /*else
            {
                Student.ShowStudents(id, 1);
                GetStudents = Student.students;
                BindingSource s = new BindingSource();
                s.DataSource = GetStudents;
                dgvStudents.DataSource = s;
            }*/
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void lblBack_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }
    }
}
