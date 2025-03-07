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
    public partial class UpdateInstructor : Form
    {
        public string TableUser { get; set; }
        public UpdateInstructor()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string FName = FirstName.Text;
            string LName = LastName.Text;
            string mail = Email.Text;
            string contact = Phone.Text;
            string uname = Username.Text;
            string pass = Password.Text;
            string salary = sal.Text;
            string type= typ.Text;

            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if(type == "Lab Insturctor" || type == "lab instructor" || type == "Lab instructor" || type == "lab Instructor")
            {
                string Lidquery = "SELECT ID FROM Teacher WHERE username = '" + uname + "'";
                SqlCommand Lidcommand = new SqlCommand(Lidquery, connection);
                object resultL = Lidcommand.ExecuteScalar();

                if (resultL != null)
                {
                    int teacherIDL = Convert.ToInt32(resultL);
                    string query2 = "INSERT INTO Lab_Instructor(L_ID) VALUES (" + teacherIDL + ");";
                    SqlCommand command2 = new SqlCommand(query2, connection);

                    int rowsaffected2 = command2.ExecuteNonQuery();
                    if (rowsaffected2 > 0)
                    {
                        MessageBox.Show("Added to Lab Instructor Successfully " + FName + LName);
                        
                        string deleteQuery = "DELETE FROM Course_Instructor WHERE C_ID = " + teacherIDL + ";";
                        SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                        int rowsDeleted = deleteCommand.ExecuteNonQuery();

                        if (rowsDeleted > 0)
                        {
                            MessageBox.Show("Record deleted from Course_Instructor");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Adding to Course instructor Failed");
                }

            }
            else if(type=="Course Instructor" || type == "course instructor" || type == "Course instructor" || type == "course Instructor")
            {
                string idquery = "SELECT ID FROM Teacher WHERE username = '"+ uname +"'";
                SqlCommand idcommand = new SqlCommand(idquery, connection);
                object result = idcommand.ExecuteScalar();

                if (result != null)
                {
                    int teacherID = Convert.ToInt32(result);
                    string query3 = "INSERT INTO Course_Instructor(C_ID) VALUES (" + teacherID + ");";
                    SqlCommand command3 = new SqlCommand(query3, connection);

                    int rowsaffected3 = command3.ExecuteNonQuery();
                    if (rowsaffected3 > 0)
                    {
                        MessageBox.Show("Added to Course Instructor Successfully " + FName + LName);
                        string deleteQuery2 = "DELETE FROM Lab_Instructor WHERE L_ID = " + teacherID + ";";
                        SqlCommand deleteCommand2 = new SqlCommand(deleteQuery2, connection);
                        int rowsDeleted2 = deleteCommand2.ExecuteNonQuery();

                        if (rowsDeleted2 > 0)
                        {
                            MessageBox.Show("Record deleted from Lab_Instructor");
                        }
                    }
                   
                }
                else
                {
                    MessageBox.Show("Adding to Course instructor Failed");
                }


            }
            string query = "UPDATE Teacher SET FName = '" + FName + "', LName = '" + LName + "', Email = '" + mail + "', Phone = '" + contact + "', Pasword = '" + pass + "', typ = '" + type + "', Salary = '" + salary + "' WHERE username = '" + uname + "'";
            SqlCommand command = new SqlCommand(query, connection);

            int rowsaffected = command.ExecuteNonQuery();
            if (rowsaffected > 0)
            {
                MessageBox.Show("Update Successful " + FName + LName);
                InstructorDetails form4 = new InstructorDetails();
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            connection.Close();
        }

        private void backfromcreateaccount_Click(object sender, EventArgs e)
        {
            InstructorDetails frm = new InstructorDetails();
            frm.TableUser = TableUser;
            frm.Show();
            this.Hide();
        }

        private void UpdateInstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
