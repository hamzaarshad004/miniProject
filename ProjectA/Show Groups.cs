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
        public Show_Groups()
        {
            InitializeComponent();
        }

        private void Show_Groups_Load(object sender, EventArgs e)
        {
            Groups.ShowGroups();
            groups = Groups.groups1;
            BindingSource s = new BindingSource();
            s.DataSource = groups;
            dgvGroups.DataSource = s;
        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = Groups.groups1[e.RowIndex].GroupID;
                if (Groups.checkNumberOfStudents(id) < 4)
                {
                    MakeGroups MG = new MakeGroups();
                    MG.Show();
                }
                else
                {
                    MessageBox.Show("4 Students already added");
                }
            }
            else if (e.ColumnIndex == 1)
            {

            }
        }
    }
}
