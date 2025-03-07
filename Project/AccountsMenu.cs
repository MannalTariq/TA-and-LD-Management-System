using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AccountsMenu : Form
    {
        public string TableUser { get; set; }
        public AccountsMenu()
        {
            InitializeComponent();
        }

        private void backfromaddaccount_Click(object sender, EventArgs e)
        {
            AdminView form = new AdminView();
            form.TableUser = TableUser;
            form.Show();
            this.Hide();
        }

        private void TA_Click(object sender, EventArgs e)
        {
            AddTAAccount addAccount = new AddTAAccount();
            addAccount.TableUser = TableUser;
            addAccount.navigator = "AccountsMenu";
            addAccount.Show();
            this.Hide();
        }

        private void LD_Click(object sender, EventArgs e)
        {
            AddLDAccount addAccount = new AddLDAccount();
            addAccount.TableUser = TableUser;
            addAccount.navigator = "AccountsMenu";
            addAccount.Show();
            this.Hide();
        }
        private void Int_Click(object sender, EventArgs e)
        {
            AddInstructorAccount addAccount = new AddInstructorAccount();
            addAccount.TableUser = TableUser;
            addAccount.navigator = "AccountsMenu";
            addAccount.Show();
            this.Hide();
        }

        private void AccountsMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
