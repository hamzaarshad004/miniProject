using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectA
{
    class Advisor
    {
        private int Id;
        private int Designation;
        private int Salary;
        private string DesignationCategory;

        public int Id1 { get => Id; set => Id = value; }
        public int Designation1 { get => Designation; set => Designation = value; }
        public int Salary1 { get => Salary; set => Salary = value; }
        public string DesignationCategory1 { get => DesignationCategory; set => DesignationCategory = value; }

        public static List<Advisor> Advisors = new List<Advisor>();

        public static void getAdvisors()
        {
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();
            Advisors.Clear();

            if (con.State == ConnectionState.Open)
            {
                string Update = "SELECT * FROM Advisor";
                SqlCommand cmd = new SqlCommand(Update, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Advisor a = new Advisor();
                    a.Id1 = Convert.ToInt32(reader["Id"]);
                    a.Salary = Convert.ToInt32(reader["Salary"]);
                    a.Designation1 = Convert.ToInt32(reader["Designation"]);
                    if (a.Designation1 == 6)
                    {
                        a.DesignationCategory1 = "Professor";
                    }
                    else if (a.Designation1 == 7)
                    {
                        a.DesignationCategory1 = "Associate Professor";
                    }
                    else if (a.Designation1 == 8)
                    {
                        a.DesignationCategory1 = "Assistant Professor";
                    }
                    else if (a.Designation1 == 9)
                    {
                        a.DesignationCategory1 = "Lecturer";
                    }
                    else if (a.Designation1 == 10)
                    {
                        a.DesignationCategory1 = "Industry Professional";
                    }
                    Advisors.Add(a);
                }
            }
        }
    }
}