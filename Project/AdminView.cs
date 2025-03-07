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
    public partial class AdminView : Form
    {
        public string TableUser { get; set; }
        public AdminView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAdminDetails();
            AdminDetailsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InstructorDetails_Click(object sender, EventArgs e)
        {
            InstructorDetails intDetails = new InstructorDetails();
            intDetails.TableUser = TableUser;
            intDetails.Show();
            this.Hide();    

        }

        private void TADetails_Click(object sender, EventArgs e)
        {
            TADetails TADetails = new TADetails();
            TADetails.TableUser = TableUser;
            TADetails.Show();
            this.Hide();
        }

        private void LDDetails_Click(object sender, EventArgs e)
        {
            LDDetails Details = new LDDetails();
            Details.TableUser = TableUser;
            Details.Show();
            this.Hide();
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            AccountsMenu add = new AccountsMenu();
            add.TableUser = TableUser;
            add.Show();
            this.Hide();
        }

        private void LoadAdminDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
           SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT concat(FName,LName) as Name,Email,Phone FROM Admins where username = '" + TableUser + "'";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            AdminDetailsTable.DataSource = dataTable;

            connection.Close();
        }

        private void AdminDetailsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }
    }
}
