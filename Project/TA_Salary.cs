using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class TA_Salary : Form
    {
        public string TableUser { get; set; }
        public int TA_ID { get; set; }

        public TA_Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            salary_generate();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void salary_generate()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "exec TAsal '" + TA_ID + "'";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            string teacherquery = "Select TA_ID FROM Teacher_Assistant WHERE Username = " + "'" + TableUser + "'";

            SqlCommand commandT = new SqlCommand(teacherquery, connection);
            SqlDataReader TAreader = commandT.ExecuteReader();

            if (TAreader.Read())
            {

                TA_ID = Convert.ToInt32(TAreader["TA_ID"]);

            }
            else
            {

                MessageBox.Show("TA ID not found.");

            }

            TAreader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void generate_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve values from the selected row
                int count = Convert.ToInt32(selectedRow.Cells["Number of Tasks Completed"].Value);
                decimal amount = Convert.ToDecimal(selectedRow.Cells["Amount"].Value);

              //  MessageBox.Show($"Count: {count}, Amount: {amount}");

                // Calculate salary
                decimal salary = count * amount;

                // Display the result
                salaryLabel.Text = $"Salary: {salary:C}";
            }
            else
            {
                MessageBox.Show("Please select a row from the List.");
            }


        }

        private void backToTAView_Click(object sender, EventArgs e)
        {
            TAView ta = new TAView();
            ta.TA_ID = TA_ID;
            ta.TableUser = TableUser;
            ta.LoadTADetails();
            ta.Show();
            this.Hide();

        }
    }
}
