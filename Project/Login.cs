using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class LoginForm : Form
    {
        public string TableUserId { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string uname = Username.Text;
            string pass = Password.Text;


            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlDataReader adminreader; 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string adminquery = "Select * FROM Admins WHERE Username = '" + uname + "' AND Pasword = '" + pass + "'";
            SqlCommand commandA = new SqlCommand(adminquery, connection);
            adminreader = commandA.ExecuteReader();

            TableUserId = uname;
            if (adminreader.Read())
            {
                MessageBox.Show("Admin " + uname + " Login Successful");
                AdminView adview = new AdminView();
                adview.TableUser = TableUserId;
                adview.Show();
                this.Hide();
            }
            else
            {
                adminreader.Close();
                SqlDataReader TAreader;
                string TAquery = "Select * FROM Teacher_Assistant WHERE Username = '" + uname + "' AND Pasword = '" + pass + "'";
                SqlCommand commandTA = new SqlCommand(TAquery, connection);
                TAreader = commandTA.ExecuteReader();
                TableUserId = uname;
                if (TAreader.Read())
                {
                    MessageBox.Show("Teacher Assistant " + uname + "Login Successful");
                    TAView taview = new TAView();
                    taview.TableUser = TableUserId;
                    taview.Show();
                    this.Hide();
                }
                else
                {
                    TAreader.Close();
                    SqlDataReader LDreader;
                    string LDquery = "Select * FROM Lab_Demonstrator WHERE Username = '" + uname + "' AND Pasword = '" + pass + "'";
                    SqlCommand commandLD = new SqlCommand(LDquery, connection);
                    LDreader = commandLD.ExecuteReader();
                    TableUserId = uname;
                    if (LDreader.Read())
                    {
                        MessageBox.Show("Lab Demonstrator " + uname + " Login Successful");

                        LDView ldview = new LDView();
                        ldview.TableUser = TableUserId;
                        ldview.Show();
                        this.Hide();

                    }
                    else
                    {
                        LDreader.Close();
                        string Cquery = "Select * FROM Teacher WHERE Username = '" + uname + "' AND Pasword = '" + pass + "' AND typ = 'Course Instructor'";
                        SqlCommand commandC = new SqlCommand(Cquery, connection);
                        SqlDataReader Creader = commandC.ExecuteReader();
                        TableUserId = uname;
                        if (Creader.Read())
                        {
                            MessageBox.Show("Course Instructor "+ uname + " Login Successful");

                            CourseInstructorView cview = new CourseInstructorView();
                            cview.TableUser = TableUserId;
                            cview.Show();
                            this.Hide();

                        }
                        else
                        {
                            Creader.Close();
                            string Lquery = "Select * FROM Teacher WHERE Username = '" + uname + "' AND Pasword = '" + pass + "' AND typ = 'Lab Instructor'";
                            SqlCommand commandL = new SqlCommand(Lquery, connection);
                            SqlDataReader Lreader = commandL.ExecuteReader();
                            TableUserId = uname;
                            if (Lreader.Read())
                            {
                                MessageBox.Show("Lab Instructor "+ uname + " Login Successful");

                                LabInstructorView lview = new LabInstructorView();
                                lview.TableUser = TableUserId;
                                lview.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Login Failed");
                            }
                        }
                    }

                }
            }
            
            connection.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
