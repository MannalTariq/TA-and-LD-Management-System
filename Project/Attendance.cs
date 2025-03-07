using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class Attendance : Form
    {

        public string TableUser { get; set; }
        public int L_ID { get; set; }
        public int LD_ID { get; set; }
        public int LSec_ID { get; set; }

        public Attendance()
        {
            InitializeComponent();
            SetupDataGridViewColumns();
            AttendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            LoadAttendance();
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


        private void backfromattendance_Click(object sender, EventArgs e)
        {
            AttendanceView adv = new AttendanceView();
            adv.TableUser = TableUser;
            adv.L_ID = L_ID;
            adv.LSec_ID = LSec_ID;
            adv.LD_ID = L_ID;
            adv.Show();
            this.Hide();
        }

        private void AddAttendance_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string datestring = dt.Text;
            char Attendance = attend.Text.FirstOrDefault();

            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "markattendance";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;

                //(LD_ID, LSec_ID, ADate, Attendance, L_ID)
                command.Parameters.AddWithValue("@LD_ID", LD_ID);
                command.Parameters.AddWithValue("@LSec_ID", LSec_ID);
                command.Parameters.AddWithValue("@adate", datestring);
                command.Parameters.AddWithValue("@Attendance", Attendance);
                command.Parameters.AddWithValue("@L_ID", L_ID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Attendance Added");
                        Attendance form = new Attendance();
                        form.TableUser = TableUser;
                        form.L_ID = L_ID;
                        form.LSec_ID = LSec_ID;
                        form.LD_ID = L_ID;
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Adding Attendance Failed");
                    }
            }
        }


        private void SetupDataGridViewColumns()
        {
            DataGridViewButtonColumn updatecol = new DataGridViewButtonColumn();
            updatecol.Name = "Update";
            updatecol.Text = "Update Attendance";
            updatecol.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn deletecol = new DataGridViewButtonColumn();
            deletecol.Name = "Delete";
            deletecol.Text = "Delete Attendance";
            deletecol.UseColumnTextForButtonValue = true;

            AttendanceGrid.Columns.Add(updatecol);
            AttendanceGrid.Columns.Add(deletecol);
        }


     

        private void AttendanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
          
                if (e.ColumnIndex == AttendanceGrid.Columns["Delete"].Index)
                {
                    DeleteAttendance ad = new DeleteAttendance();
                    ad.TableUser = TableUser;
                    ad.LD_ID = LD_ID;
                    ad.LSec_ID = LSec_ID;
                    ad.L_ID = L_ID;
                    ad.Show();
                    this.Hide();
                }

                if (e.ColumnIndex == AttendanceGrid.Columns["Update"].Index)
                {
                    UpdateAttendance ad = new UpdateAttendance();
                    ad.TableUser = TableUser;
                    ad.LD_ID = LD_ID;
                    ad.LSec_ID = LSec_ID;
                    ad.L_ID = L_ID;
                    ad.Show();
                    this.Hide();
                }

                LoadAttendance();
            }
            
        }
    }
}
