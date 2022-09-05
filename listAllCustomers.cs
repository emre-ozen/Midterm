using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Midterm
{
    public partial class listAllCustomers : Form
    {
        public listAllCustomers()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listAllCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(ClsVariables.connectionString))
                {
                    cnn.Open();
                    if (cnn.State != ConnectionState.Open)
                        throw new Exception("Connection is broken");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select customerId,name,surname,birthDate from customers";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dtRecord = new DataTable();
                    adapter.Fill(dtRecord);
                    dGrdView.DataSource = dtRecord;

                    dGrdView.Columns["customerId"].HeaderText = "Customer Number";
                    dGrdView.Columns["name"].HeaderText = "Name";
                    dGrdView.Columns["surname"].HeaderText = "Surname";
                    dGrdView.Columns["birthDate"].HeaderText = "Birth Date";


                    dGrdView.AllowUserToAddRows = false;
                    dGrdView.AllowUserToDeleteRows = false;
                    dGrdView.AllowUserToOrderColumns = true;
                    dGrdView.ReadOnly = true;
                    dGrdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dGrdView.MultiSelect = false;
                    dGrdView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    dGrdView.AllowUserToResizeColumns = false;
                    dGrdView.ColumnHeadersHeightSizeMode =
                        DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    dGrdView.AllowUserToResizeRows = true;
                    dGrdView.RowHeadersWidthSizeMode =
                        DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                    // Set the selection background color for all the cells.
                    dGrdView.DefaultCellStyle.SelectionBackColor = Color.White;
                    dGrdView.DefaultCellStyle.SelectionForeColor = Color.Black;

                    // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                    // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                    dGrdView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                    // Set the background color for all rows and for alternating rows. 
                    // The value for alternating rows overrides the value for all rows. 
                    dGrdView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    dGrdView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                    cnn.Close();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }

        }
    }
}
