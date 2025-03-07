using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class AddInstructorAccount : Form
    {
        public string navigator { get; set; }
        public string TableUser { get; set; }
        public AddInstructorAccount()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void backfromcreateaccount_Click(object sender, EventArgs e)
        {
            if(navigator == "AccountsMenu")
            {
                AccountsMenu add=new AccountsMenu();
                add.TableUser = TableUser;
                add.Show();
                this.Hide();    
            }
            else if(navigator =="InstructorDetails")
            {
                InstructorDetails details=new InstructorDetails();
                details.TableUser = TableUser;
                details.Show();
                this.Hide();
            }
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }

        private void sal_TextChanged(object sender, EventArgs e)
        {

        }

        private void typ_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateInstructor_Click(object sender, EventArgs e)
        {
            string FName = FirstName.Text;
            string LName = LastName.Text;
            string mail = Email.Text;
            string contact = Phone.Text;
            string uname = Username.Text;
            string pass = Password.Text;
            string salary = sal.Text;
            string type = typ.Text;
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();



            //string query = "INSERT INTO Teacher  (FName, LName, Email, Phone, Salary,Typ, Username, Pasword) VALUES('" + FName + "','" + LName + "','" + mail + "','" + contact + "','" + salary + "','" + type + "','" + uname + "','" + pass + "')";
            //SqlCommand command = new SqlCommand(query, con);


            string query = "InsertCourseInstructor";
            SqlCommand command = new SqlCommand(query, con);
            command.CommandType = CommandType.StoredProcedure;

            // Add parameters
            command.Parameters.AddWithValue("@FName", FName);
            command.Parameters.AddWithValue("@LName", LName);
            command.Parameters.AddWithValue("@Email", mail);
            command.Parameters.AddWithValue("@Phone", contact);
            command.Parameters.AddWithValue("@Salary", salary);
            command.Parameters.AddWithValue("@Typ", type);
            command.Parameters.AddWithValue("@Username", uname);
            command.Parameters.AddWithValue("@Pasword", pass);


            int rowsaffected = command.ExecuteNonQuery();
            if (rowsaffected > 0)
            {
                MessageBox.Show("Instructor Added :" + FName + " " + LName);
                InstructorDetails form4 = new InstructorDetails();
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sign Up Failed");
            }


            if (type == "Lab Insturctor" || type == "lab instructor" || type == "Lab instructor" || type == "lab Instructor")
            {
                string Lidquery = "SELECT ID FROM Teacher WHERE username = '" + uname + "'";
                SqlCommand Lidcommand = new SqlCommand(Lidquery, con);
                object resultL = Lidcommand.ExecuteScalar();

                if (resultL != null)
                {
                    int teacherIDL = Convert.ToInt32(resultL);
                    string query2 = "INSERT INTO Lab_Instructor(L_ID) VALUES (" + teacherIDL + ");";
                    SqlCommand command2 = new SqlCommand(query2, con);

                    int rowsaffected2 = command2.ExecuteNonQuery();
                    if (rowsaffected2 > 0)
                    {
                        MessageBox.Show("Added to Lab Instructor Successfully " + FName + LName);
                    }

                }
                else
                {
                    MessageBox.Show("Adding to Lab instructor Failed");
                }

            }
            else if (type == "Course Instructor" || type == "course instructor" || type == "Course instructor" || type == "course Instructor")
            {
                string idquery = "SELECT ID FROM Teacher WHERE username = '" + uname + "'";
                SqlCommand idcommand = new SqlCommand(idquery, con);
                object result = idcommand.ExecuteScalar();

                if (result != null)
                {
                    int teacherID = Convert.ToInt32(result);
                    string query3 = "INSERT INTO Course_Instructor(C_ID) VALUES (" + teacherID + ");";
                    SqlCommand command3 = new SqlCommand(query3, con);

                    int rowsaffected3 = command3.ExecuteNonQuery();
                    if (rowsaffected3 > 0)
                    {
                        MessageBox.Show("Added to Course Instructor Successfully " + FName + LName);
                    }

                }
                else
                {
                    MessageBox.Show("Adding to Course instructor Failed");
                }


            }

        }
    }
}
