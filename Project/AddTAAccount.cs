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
    public partial class AddTAAccount : Form
    {
        public string TableUser { get; set; }
        public string navigator {get;set;}
        public AddTAAccount()
        {
            InitializeComponent();
        }


        private void AddTAAccount_Load(object sender, EventArgs e)
        {

        }

        private void backfromcreateaccount_Click(object sender, EventArgs e)
        {
            if (navigator == "AccountsMenu")
            {
                AccountsMenu add = new AccountsMenu();
                add.TableUser = TableUser;
                add.Show();
                this.Hide();
            }
            else if (navigator == "TADetails")
            {
                TADetails details = new TADetails();
                details.TableUser = TableUser;
                details.Show();
                this.Hide();
            }
        }

        //private void CreateTA_Click(object sender, EventArgs e)
        //{
        //    string FName = FirstName.Text;
        //    string LName = LastName.Text;
        //    string mail = Email.Text;
        //    string contact = Phone.Text;
        //    string uname = Username.Text;
        //    string pass = Password.Text;
        //    string dob = dateofbirth.Text;
        //    string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
        //    SqlConnection con = new SqlConnection(connectionString);
        //    con.Open();
        //    string query = "INSERT INTO Teacher_Assistant (FName, LName, Email, phone, DOB,Username,Pasword) VALUES('" + FName + "','" + LName + "','" + mail + "','" + contact + "','" + dob + "','" + uname + "','" + pass + "')";
        //    SqlCommand command = new SqlCommand(query, con);

        //    int rowsaffected = command.ExecuteNonQuery();
        //    if (rowsaffected > 0)
        //    {
        //        MessageBox.Show("Teacher Assistant Added :" + FName + " " + LName);
        //        TADetails form4 = new TADetails();
        //        form4.TableUser = TableUser;
        //        form4.Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Sign Up Failed");
        //    }
        //    con.Close();
        //}




        private void CreateTA_Click(object sender, EventArgs e)
        {
            string FName = FirstName.Text;
            string LName = LastName.Text;
            string mail = Email.Text;
            string contact = Phone.Text;
            string uname = Username.Text;
            string pass = Password.Text;
            string dob = dateofbirth.Text;

            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Use the stored procedure directly without EXEC
                string query = "InsertTeacherAssistant";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters
                command.Parameters.AddWithValue("@FName", FName);
                command.Parameters.AddWithValue("@LName", LName);
                command.Parameters.AddWithValue("@Email", mail);
                command.Parameters.AddWithValue("@Phone", contact);
                command.Parameters.AddWithValue("@DOB", dob);
                command.Parameters.AddWithValue("@Username", uname);
                command.Parameters.AddWithValue("@Pasword", pass);

                // Execute the stored procedure
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Teacher Assistant Added: " + FName + " " + LName);
                    TADetails form4 = new TADetails();
                    form4.TableUser = TableUser;
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sign Up Failed");
                }
            }
        }


    }
}
