namespace Midterm
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool closingPending = false;
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closingPending) return;
            if (MessageBox.Show("Do you really want to close it ?", "COnfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                closingPending = true;

            }
        }

        private void addUpdateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUpdateCustomer ac=new addUpdateCustomer();
            this.Hide();
            ac.ShowDialog();
            this.Show();
        }

        private void listAllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listAllCustomers ac = new listAllCustomers();
            this.Hide();
            ac.ShowDialog();
            this.Show();

        }

        private void customersHvingTheirBirthdaysTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Birthdays bd = new Birthdays();
            this.Hide();
            bd.ShowDialog();
            this.Show();

        }
    }
}