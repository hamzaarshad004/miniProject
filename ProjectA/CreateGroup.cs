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
        public CreateGroup()
        {
            InitializeComponent();
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string Insert = "INSERT INTO [dbo].[Group](Created_On) VALUES ('" +Convert.ToDateTime(mcCreationDate.Value) + "')";
                SqlCommand cmd = new SqlCommand(Insert,con);
                cmd.ExecuteNonQuery();
            }

        }

        private void lblAssignStudents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Show_Groups MG = new Show_Groups();
            MG.Show();
        }
    }
}
