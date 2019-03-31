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
    public partial class CreateGroup : Form
    {
        public string conStr = "Data Source=DESKTOP-P69CV50;Initial Catalog=ProjectA;Integrated Security=True";
        List<Student> students = new List<Student>();
        List<Student> Selectedstudents = new List<Student>();
        List<String> Status = new List<string>();
        public static int check1 = 0;
        int check = 0;
        public static int Mode = 0;
        public static int GroupId;

        public CreateGroup()
        {
            InitializeComponent();
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (Mode == 0)
            {
                if (con.State == ConnectionState.Open)
                {
                    string Insert = "INSERT INTO [dbo].[Group](Created_On) VALUES ('" + Convert.ToDateTime(mcCreationDate.Value) + "')";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT @@IDENTITY";
                    GroupId = Convert.ToInt32(cmd.ExecuteScalar());

                    for (int i = 0; i < check; i++)
                    {
                        Insert = "INSERT INTO GroupStudent(GroupId, StudentId, Status, AssignmentDate) VALUES ('" + GroupId + "', (SELECT Id FROM Student WHERE RegistrationNo = '" + Selectedstudents[i].Registration_Number1 + "'), (SELECT Id FROM Lookup WHERE Lookup.Value = '" + Status[i] + "'), '"+ Convert.ToDateTime(mcCreationDate.Value) +"' )";
                        cmd.CommandText = Insert;
                        cmd.ExecuteNonQuery();
                    }

                    check = 0;

                    Status.Clear();
                    Selectedstudents.Clear();
                    setGrid();

                    MessageBox.Show("Succesfully Created");
                }
            }
            else
            {
                for (int i = 0; i < check; i++)
                {
                    string Insert = "INSERT INTO GroupStudent(GroupId, StudentId, Status, AssignmentDate) VALUES ('" + GroupId + "', (SELECT Id FROM Student WHERE RegistrationNo = '" + Selectedstudents[i].Registration_Number1 + "'), (SELECT Id FROM Lookup WHERE Lookup.Value = '" + Status[i] + "'), '" + Convert.ToDateTime(mcCreationDate.Value) + "' )";
                    SqlCommand cmd = new SqlCommand(Insert, con);
                    cmd.ExecuteNonQuery();
                }

                check = 0;

                Status.Clear();
                Selectedstudents.Clear();
                setGrid();

                MessageBox.Show("Succesfully Updated");

                Mode = 0;

                Show_Groups SG = new Show_Groups();
                SG.Show();
                this.Hide();
            }
            

        }

        private void lblAssignStudents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Show_Groups MG = new Show_Groups();
            MG.Show();
        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string fetch = "SELECT RegistrationNo FROM Student WHERE Id NOT IN (SELECT StudentId FROM GroupStudent)";
                SqlCommand cmd = new SqlCommand(fetch, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student s = new Student();
                    s.Registration_Number1 = Convert.ToString(reader["RegistrationNo"]);

                    students.Add(s);
                }

                foreach (Student s in students)
                {
                    cmbRegNo.Items.Add(s.Registration_Number1);
                }

                dgvSelectedStudents.Columns.Add("Id", "Sr#");
                dgvSelectedStudents.Columns.Add("RegNo", "Registration No");
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mode == 0)
                {
                    check1 = 0;
                }
                if (check1 < 4)
                {
                    Selectedstudents.Add(students[cmbRegNo.SelectedIndex]);
                    Status.Add(cmbStatus.Text);
                    check++;

                    students.RemoveAt(cmbRegNo.SelectedIndex);

                    cmbRegNo.Items.Clear();

                    foreach (Student s in students)
                    {
                        cmbRegNo.Items.Add(s.Registration_Number1);
                    }

                    check1++;
                }
                else
                {
                    MessageBox.Show("4 Students Already Added");
                }

                setGrid();
            }
            catch
            {
                MessageBox.Show("Select a Reg No");
            }
            
        }

        private void setGrid()
        {
            dgvSelectedStudents.Rows.Clear();
            int id = 1;

            foreach (Student student in Selectedstudents)
            {
                dgvSelectedStudents.Rows.Add(id, student.Registration_Number1);
                id++;
            }
        }
    }
}
