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
    public partial class Show_Groups : Form
    {
        string conStr = AddProject.conStr;
        List<Groups> groups = new List<Groups>();
        List<Student> students = new List<Student>();
        int Groupid;
        public Show_Groups()
        {
            InitializeComponent();
        }

        private void Show_Groups_Load(object sender, EventArgs e)
        {
            setGrid();
        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = Groups.groups1[e.RowIndex].GroupID;
                if (Groups.checkNumberOfStudents(id) < 4)
                {
                    CreateGroup.check1 = Groups.checkNumberOfStudents(id);
                    CreateGroup.Mode = 1;
                    CreateGroup.GroupId = id;

                    CreateGroup CG = new CreateGroup();
                    CG.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("4 Students already added");
                }
            }
            else if (e.ColumnIndex == 1)
            {
                Groupid = Groups.groups1[e.RowIndex].GroupID;
                setGrid1();
            }
        }

        private void setGrid()
        {
            Groups.ShowGroups();
            groups = Groups.groups1;
            BindingSource s = new BindingSource();
            s.DataSource = groups;
            dgvGroups.DataSource = s;
        }

        private void setGrid1()
        {
            Student.ShowStudents(Groupid, 1);
            students = Student.students;
            BindingSource S = new BindingSource();
            S.DataSource = students;
            dgvViewStudents.DataSource = S;
        }

        private void dgvViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SqlConnection con = new SqlConnection(AddProject.conStr);
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int id = students[e.RowIndex].ID1;
                    if (students[e.RowIndex].Status1 == "Active")
                    {
                        string Update = "UPDATE GroupStudent SET Status = '" + 4 + "' WHERE StudentId = '" + id + "'";
                        SqlCommand cmd = new SqlCommand(Update, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Succesfully Updated");
                        setGrid1();
                    }
                    else
                    {
                        string Update = "UPDATE GroupStudent SET Status = '" + 3 + "' WHERE StudentId = '" + id + "'";
                        SqlCommand cmd = new SqlCommand(Update, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Succesfully Updated");
                        setGrid1();
                    }
                }
            }
        }
    }
}
