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
    public partial class TADetails : Form
    {
        public string TableUser { get; set; }
        public string navigator { get; set; }
        public TADetails()
        {
            InitializeComponent();
        }

        private void AddTA_Click(object sender, EventArgs e)
        {
            AddTAAccount form = new AddTAAccount();
            form.navigator = "TADetails";
            form.TableUser = TableUser; 
            form.Show();
            this.Hide();
        }
        private void TADetails_Load(object sender, EventArgs e)
        {
            LoadTADetails();
            IntDet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadTADetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT TA_Id,concat(FName,LName) as Name,Email,Phone,DOB FROM Teacher_Assistant";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            IntDet.DataSource = dataTable;

            connection.Close();
        }
        private void backfromaddaccount_Click(object sender, EventArgs e)
        {
            AdminView add = new AdminView();
            add.TableUser = TableUser;
            add.Show();
            this.Hide();
        }

        private void UpdateTA_Click(object sender, EventArgs e)
        {
            UpdateTA form = new UpdateTA();
            form.TableUser = TableUser;
            form.Show();
            this.Hide();
        }

        private void DeleteTA_Click(object sender, EventArgs e)
        {
            DeleteTA del = new DeleteTA();
            del.TableUser = TableUser;
            del.Show();
            this.Hide();
        }
    }
}
