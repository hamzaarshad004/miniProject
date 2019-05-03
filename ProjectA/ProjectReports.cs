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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProjectA
{
    public partial class ProjectReports : Form
    {

        List<ProjectReport> projectReports = new List<ProjectReport>();
        public ProjectReports()
        {
            InitializeComponent();
        }

        private void lblGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void ProjectReports_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(AddProject.conStr);
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT Id FROM Project", con);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> Members_RegNo = new List<string>();
                List<string> Members_Name = new List<string>();
                List<int> Advisor_IDs = new List<int>();
                List<string> AdvisorRoles = new List<string>();


                while (reader.Read())
                {
                    if (con.State == ConnectionState.Open)
                    {

                        Members_Name.Clear();
                        Members_RegNo.Clear();
                        Advisor_IDs.Clear();
                        AdvisorRoles.Clear();

                        ProjectReport projectReport = new ProjectReport();

                        string fetch1 = "SELECT Title, StudentId FROM Project P JOIN GroupProject GP on P.Id = GP.ProjectId JOIN GroupStudent GS on GP.GroupId = GS.GroupId WHERE P.Id = '" + Convert.ToInt32(reader["Id"]) + "' group by StudentId, Title";
                        SqlCommand cmd1 = new SqlCommand(fetch1, con);
                        SqlDataReader StudentIds = cmd1.ExecuteReader();


                        while (StudentIds.Read())
                        {
                            projectReport.P_Title = Convert.ToString(StudentIds["Title"]);

                            string fetch3 = "SELECT RegistrationNo, FirstName, LastName FROM Student JOIN Person ON Student.Id = Person.Id WHERE Student.Id = '" + Convert.ToInt32(StudentIds["StudentId"]) + "'";
                            SqlCommand cmd3 = new SqlCommand(fetch3, con);
                            SqlDataReader StudentData = cmd3.ExecuteReader();

                            if (StudentData.Read())
                            {
                                Members_Name.Add(Convert.ToString(StudentData["FirstName"]) + " " + Convert.ToString(StudentData["LastName"]));
                                Members_RegNo.Add(Convert.ToString(StudentData["RegistrationNo"]));
                            }
                        }

                        if (Members_Name.Count == 1)
                        {
                            projectReport.Student_1_Name = Members_Name[0];
                            projectReport.Student_1_RegNo = Members_RegNo[0];
                        }
                        else if (Members_Name.Count == 2)
                        {
                            projectReport.Student_1_Name = Members_Name[0];
                            projectReport.Student_1_RegNo = Members_RegNo[0];
                            projectReport.Student_2_Name = Members_Name[1];
                            projectReport.Student_2_RegNo = Members_RegNo[1];
                        }
                        else if (Members_Name.Count == 3)
                        {
                            projectReport.Student_1_Name = Members_Name[0];
                            projectReport.Student_1_RegNo = Members_RegNo[0];
                            projectReport.Student_2_Name = Members_Name[1];
                            projectReport.Student_2_RegNo = Members_RegNo[1];
                            projectReport.Student_3_Name = Members_Name[2];
                            projectReport.Student_3_RegNo = Members_RegNo[2];
                        }
                        else if (Members_Name.Count == 4)
                        {
                            projectReport.Student_1_Name = Members_Name[0];
                            projectReport.Student_1_RegNo = Members_RegNo[0];
                            projectReport.Student_2_Name = Members_Name[1];
                            projectReport.Student_2_RegNo = Members_RegNo[1];
                            projectReport.Student_3_Name = Members_Name[2];
                            projectReport.Student_3_RegNo = Members_RegNo[2];
                            projectReport.Student_4_Name = Members_Name[3];
                            projectReport.Student_4_RegNo = Members_RegNo[3];
                        }

                        string fetch2 = "SELECT AdvisorId, Value FROM ProjectAdvisor PA JOIN Lookup L ON PA.AdvisorRole = L.Id WHERE PA.ProjectId = '" + Convert.ToInt32(reader["Id"]) + "'";
                        SqlCommand cmd2 = new SqlCommand(fetch2, con);
                        SqlDataReader AdvisorIDs = cmd2.ExecuteReader();

                        while (AdvisorIDs.Read())
                        {
                            Advisor_IDs.Add(Convert.ToInt32(AdvisorIDs["AdvisorId"]));
                            AdvisorRoles.Add(Convert.ToString(AdvisorIDs["Value"]));
                        }

                        if (Advisor_IDs.Count == 1)
                        {
                            projectReport.Advisor_1_Id = Advisor_IDs[0];
                            projectReport.Advisor_1_Role = AdvisorRoles[0];
                        }
                        else if (Advisor_IDs.Count == 2)
                        {
                            projectReport.Advisor_1_Id = Advisor_IDs[0];
                            projectReport.Advisor_1_Role = AdvisorRoles[0];
                            projectReport.Advisor_2_Id = Advisor_IDs[1];
                            projectReport.Advisor_2_Role = AdvisorRoles[1];
                        }
                        else if (Advisor_IDs.Count == 3)
                        {
                            projectReport.Advisor_1_Id = Advisor_IDs[0];
                            projectReport.Advisor_1_Role = AdvisorRoles[0];
                            projectReport.Advisor_2_Id = Advisor_IDs[1];
                            projectReport.Advisor_2_Role = AdvisorRoles[1];
                            projectReport.Advisor_3_Id = Advisor_IDs[2];
                            projectReport.Advisor_3_Role = AdvisorRoles[2];

                        }

                        if (projectReport.P_Title != null)
                        {
                            projectReports.Add(projectReport);
                        }
                    }
                }

                setGrid();
            }

        

            
            catch
            {
                MessageBox.Show("Some Error Occured");
            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfPTable table = new PdfPTable(15);
            table.AddCell("Title");
            table.AddCell("Advisor_1_Id");
            table.AddCell("Advisor_1_Role");
            table.AddCell("Advisor_2_Id");
            table.AddCell("Advisor_2_Role");
            table.AddCell("Advisor_3_Id");
            table.AddCell("Advisor_3_Role");
            table.AddCell("Student_1_Name");
            table.AddCell("Student_1_RegNo");
            table.AddCell("Student_2_Name");
            table.AddCell("Student_2_RegNo");
            table.AddCell("Student_3_Name");
            table.AddCell("Student_3_RegNo");
            table.AddCell("Student_4_Name");
            table.AddCell("Student_4_RegNo");

            foreach (ProjectReport p in projectReports)
            {
                table.AddCell(p.P_Title);
                table.AddCell(Convert.ToString(p.Advisor_1_Id));
                table.AddCell(p.Advisor_1_Role);
                table.AddCell(Convert.ToString(p.Advisor_2_Id));
                table.AddCell(p.Advisor_2_Role);
                table.AddCell(Convert.ToString(p.Advisor_3_Id));
                table.AddCell(p.Advisor_3_Role);
                table.AddCell(p.Student_1_Name);
                table.AddCell(p.Student_1_RegNo);
                table.AddCell(p.Student_2_Name);
                table.AddCell(p.Student_2_RegNo);
                table.AddCell(p.Student_3_Name);
                table.AddCell(p.Student_3_RegNo);
                table.AddCell(p.Student_4_Name);
                table.AddCell(p.Student_4_RegNo);

            }

            SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4.Rotate());


                try
                {
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    document.Add(table);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    document.Close();
                }
                MessageBox.Show("Report saved successfully");
            }
        }

        private void setGrid()
        {
            BindingSource S = new BindingSource();
            S.DataSource = projectReports;
            dgvReport.DataSource = S;

            dgvReport.AllowUserToAddRows = false;
        }
    }
}
