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
    public partial class LD_Salary : Form
    {
        public string TableUser { get; set; }
        public int LD_ID { get; set; }

        public LD_Salary()
        {
            InitializeComponent();
        }

        public void LD_Salary_Load(object sender, EventArgs e)
        {
            salary_generate();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void salary_generate()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "exec LDsal '" + LD_ID + "'";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            string teacherquery = "Select LD_ID FROM Lab_Demonstrator WHERE Username = " + "'" + TableUser + "'";

            SqlCommand commandT = new SqlCommand(teacherquery, connection);
            SqlDataReader LDreader = commandT.ExecuteReader();

            if (LDreader.Read())
            {

                LD_ID = Convert.ToInt32(LDreader["LD_ID"]);

            }
            else
            {

                MessageBox.Show("LD ID not found.");

            }

            LDreader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backToLDView_Click(object sender, EventArgs e)
        {
            LDView ld = new LDView();
            ld.LD_ID = LD_ID;
            ld.TableUser = TableUser;
            ld.LoadLDDetails();
            ld.Show();
            this.Hide();
        }

        private void generate_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int count = Convert.ToInt32(selectedRow.Cells["Number of Tasks Completed"].Value);
                decimal amount = Convert.ToDecimal(selectedRow.Cells["Amount"].Value);

                //  MessageBox.Show($"Count: {count}, Amount: {amount}");

                // Calculate salary
                decimal salary = count * amount;

                // Display the result
                label3.Text = $"Salary: {salary:C}";
            }
            else
            {
                MessageBox.Show("Please select a row From the List.");
            }



        }
    }
}
