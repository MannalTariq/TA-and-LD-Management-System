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
    public partial class DeleteAttendance : Form
    {

        public string TableUser { get; set; }
        public int L_ID { get; set; }
        public int LD_ID { get; set; }
        public int LSec_ID { get; set; }
        public DeleteAttendance()
        {
            InitializeComponent();
        }

        private void DeleteAttendance_Load(object sender, EventArgs e)
        {
            LoadAttendance();
            delete();
            AttendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAttendance()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = " exec ldattendance " + LD_ID + " , " + LSec_ID;
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            AttendanceGrid.DataSource = dataTable;

            string Cquery = "Select ID FROM Teacher WHERE Username = " + "'" + TableUser + "' AND typ = 'Lab Instructor'";

            SqlCommand commandT = new SqlCommand(Cquery, connection);
            SqlDataReader Creader = commandT.ExecuteReader();

            if (Creader.Read())
            {
                L_ID = Convert.ToInt32(Creader["ID"]);
            }
            else
            {
                MessageBox.Show("L_ID not found.");
                return;
            }

            Creader.Close();
            connection.Close();
        }


        private void delete()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string datee = d.Text;
            // SET Attendance = @Att WHERE LD_ID = @LD_ID AND LSec_ID = @LSec_ID AND ADate = @currDate

            string query = "DeleteAttendance";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure; 

            command.Parameters.AddWithValue("@LD_ID", LD_ID);
            command.Parameters.AddWithValue("@LSec_ID", LSec_ID);
            command.Parameters.AddWithValue("@currDate", datee);  

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Attendance a = new Attendance();
                a.TableUser = TableUser;
                a.LD_ID = L_ID;
                a.LSec_ID = LSec_ID;
                a.L_ID = L_ID;
                a.Show();
                this.Hide();
            }
        }

        private void backfromcreateaccount_Click(object sender, EventArgs e)
        {
            Attendance a = new Attendance();
            a.TableUser = TableUser;
            a.LD_ID = L_ID;
            a.LSec_ID = LSec_ID;
            a.L_ID = L_ID;
            a.Show();
            this.Hide();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            delete();
        }
    }
}
