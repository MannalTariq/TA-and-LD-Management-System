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
    public partial class LDDetails : Form
    {
        public string TableUser { get; set; }
        public LDDetails()
        {
            InitializeComponent();
        }

        private void IntDet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LDDetails_Load(object sender, EventArgs e)
        {
            LoadLDDetails();
            IntDet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadLDDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            // string connectionString = "Data Source=EMAN-PC\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT LD_Id,concat(FName,LName) as Name,Email,Phone,DOB FROM Lab_Demonstrator";
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

        private void AddLD_Click(object sender, EventArgs e)
        {
            AddLDAccount form = new AddLDAccount();
            form.navigator = "LDDetails";
            form.TableUser = TableUser;
            form.Show();
            this.Hide();
        }

        private void UpdateLD_Click(object sender, EventArgs e)
        {
            UpdateLD form = new UpdateLD();
            form.TableUser = TableUser;
            form.Show();
            this.Hide();
        }

        private void DeleteLD_Click(object sender, EventArgs e)
        {
            DeleteLD form = new DeleteLD();
            form.TableUser = TableUser;
            form.Show();
            this.Hide();
        }
    }
}
