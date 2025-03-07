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
    public partial class InstructorDetails : Form
    {
        public string TableUser { get; set; }
        public InstructorDetails()
        {
            InitializeComponent();
        }

        private void InstructorDetails_Load(object sender, EventArgs e)
        {
            LoadInstructorDetails();
            IntDet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadInstructorDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT concat(FName,LName) as Name,Email,Phone,Salary,Typ FROM Teacher";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            IntDet.DataSource = dataTable;

            connection.Close();
        }
        private void HOME_Click(object sender, EventArgs e)
        {

        }

        private void AddInstructor_Click(object sender, EventArgs e)
        {
            AddInstructorAccount form = new AddInstructorAccount();
            form.navigator = "InstructorDetails";
            form.TableUser = TableUser;
            form.Show();
            this.Hide();
        }

        private void UpdateInstructor_Click(object sender, EventArgs e)
        {
            UpdateInstructor update = new UpdateInstructor();
            update.TableUser = TableUser;
            update.Show();
            this.Hide();
        }

        private void DeleteInstructor_Click(object sender, EventArgs e)
        {
            DeleteInstructor del = new DeleteInstructor();
            del.TableUser = TableUser;
            del.Show();
            this.Hide();
        }

        private void backfrominstructordetails_Click(object sender, EventArgs e)
        {
            AdminView form = new AdminView();
            form.TableUser = TableUser;
            form.Show();
            this.Hide();
        }

        private void IntDet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
