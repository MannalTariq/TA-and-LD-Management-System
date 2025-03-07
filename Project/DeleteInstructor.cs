using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class DeleteInstructor : Form
    {
        public string TableUser { get; set; }
        public DeleteInstructor()
        {
            InitializeComponent();
        }

        private void DeletaInt_Click(object sender, EventArgs e)
        {
            string FName = FirstName.Text;
            string LName = LastName.Text;
            string uname = Username.Text;
            //string connectionString = "Data Source=EMAN-PC\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True; Encrypt = false";
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT typ FROM Teacher WHERE FName = '" + FName + "' and LName = '" + LName + "' and username = '" + uname + "';";
            SqlCommand command = new SqlCommand(query, con);

            object t = command.ExecuteScalar();
            if (t != null && t != DBNull.Value)
            {
                string type = t.ToString();
                if(type == "Lab Insturctor" || type == "lab instructor" || type == "Lab instructor" || type == "lab Instructor")
                {
                    string idquery = "SELECT id FROM Teacher WHERE FName = '" + FName + "' and LName = '" + LName + "' and username = '" + uname + "' and typ = '" + type + "';";
                    SqlCommand idl = new SqlCommand(idquery, con);
                    object i = idl.ExecuteScalar();
                    if (i != null && i != DBNull.Value)
                    {
                        int id = Convert.ToInt32(i);
                        string deleteQuery = "DELETE FROM Lab_Instructor WHERE L_ID = " + id + ";";
                        SqlCommand deleteCommand = new SqlCommand(deleteQuery, con);
                        int rowsDeleted = deleteCommand.ExecuteNonQuery();

                        if (rowsDeleted > 0)
                        {
                            MessageBox.Show("Record deleted from Lab_Instructor");
                        }
                    }
                }
                else if (type == "Course Instructor" || type == "course instructor" || type == "Course instructor" || type == "course Instructor")
                {
                    string idquery2 = "SELECT id FROM Teacher WHERE FName = '" + FName + "' and LName = '" + LName + "' and username = '" + uname + "' and typ = '" + type + "';";
                    SqlCommand idc = new SqlCommand(idquery2, con);
                    object i2 = idc.ExecuteScalar();
                    if (i2 != null && i2 != DBNull.Value)
                    {
                        int id2 = Convert.ToInt32(i2);
                        string deleteQuery2 = "DELETE FROM Course_Instructor WHERE C_ID = " + id2 + ";";
                        SqlCommand deleteCommand2 = new SqlCommand(deleteQuery2, con);
                        int rowsDeleted2 = deleteCommand2.ExecuteNonQuery();

                        if (rowsDeleted2 > 0)
                        {
                            MessageBox.Show("Record deleted from Course_Instructor");
                        }
                    }
                }
            }

            string del = "DELETE FROM Teacher WHERE FName = '" + FName + "' and LName = '" + LName + "' and username = '" + uname + "';";
            SqlCommand delcommand = new SqlCommand(del, con);
            int de = delcommand.ExecuteNonQuery();
            if (de > 0)
            {
                MessageBox.Show("Instructor Deleted :" + FName + " " + LName);
                InstructorDetails form4 = new InstructorDetails();
                form4.TableUser = TableUser;
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Deletion Failed");
            }

            con.Close();
        }

        private void DeleteInstructor_Load(object sender, EventArgs e)
        {

        }

        private void backfromcreateaccount_Click(object sender, EventArgs e)
        {
            InstructorDetails frm = new InstructorDetails();
            frm.TableUser = TableUser;  
            frm.Show();
            this.Hide();
        }
    }
}
