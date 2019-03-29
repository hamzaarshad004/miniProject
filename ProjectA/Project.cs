using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectA
{
    class Project
    {
        private int Id;
        private string Title;
        private string Description;

        public int Id1 { get => Id; set => Id = value; }
        public string Title1 { get => Title; set => Title = value; }
        public string Description1 { get => Description; set => Description = value; }

        public static List<Project> projects = new List<Project>();

        public static void getProjects()
        {
            projects.Clear();
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string fetch = "SELECT * FROM Project";
                SqlCommand cmd = new SqlCommand(fetch, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Project p = new Project();
                    p.Id1 = Convert.ToInt32(reader["Id"]);
                    p.Title1 = Convert.ToString((reader["Title"]));
                    p.Description1 = Convert.ToString(reader["Description"]);
                    projects.Add(p);
                }
            }
        }
    }
}
