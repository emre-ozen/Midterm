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
using System.Security.Cryptography;

namespace Midterm
{
    public partial class addUpdateCustomer : Form
    {
        public addUpdateCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 2)
            {
                errP.SetError(txtName, "Name should be min 2 characters!");
                return;
            }
            errP.SetError(txtName, "");


            if (txtSurname.Text.Trim().Length < 2)
            {
                errP.SetError(txtSurname, "Surname should be minimum 2 characters");
                return;
            }
            errP.SetError(txtSurname, "");
            
            if (dtpckBirthDate.Value>= DateTime.Today)
            {
                errP.SetError(dtpckBirthDate, "Date should be less than today");
                return;
            }
            errP.SetError(dtpckBirthDate, "");


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
                    if (txtCustomerId.Text.Trim().Length == 0)
                        cmd.CommandText = "insert into customers(name,surname,birthDate) values(@name,@surname,@birthDate)";
                    else
                    {
                        cmd.CommandText = "update customers set name=@name,surname=@surname,birthDate=@birthDate where customerId=@customerID";
                        cmd.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
                    }
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@birthDate", dtpckBirthDate.Value);
                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        MessageBox.Show("Record Saved/Updated");
                        cmd.Dispose();
                        cnn.Close();
                        txtCustomerId.Clear();
                        txtName.Clear();
                        txtSurname.Clear();
                        dtpckBirthDate.Value = DateTime.Today;
                        txtName.Focus();
                        return;
                    }
                    MessageBox.Show("Customer operation failed!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void txtCustomerId_Leave(object sender, EventArgs e)
        {
            if (txtCustomerId.Text.Trim().Length == 0) return;

            int cid;
            if (Int32.TryParse(txtCustomerId.Text,out cid)!=true)
            {
                errP.SetError(txtCustomerId, "Customer Id must be integer!");
                return;
            }
            errP.SetError(txtCustomerId, "");


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
                    cmd.CommandText = "select * from customers where customerId=@customerID";
                    cmd.Parameters.AddWithValue("@customerId", cid);

                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        txtName.Text = rd["name"].ToString();
                        txtSurname.Text = rd["surname"].ToString();
                        dtpckBirthDate.Value=Convert.ToDateTime(rd["birthDate"]);

                        cmd.Dispose();
                        cnn.Close();

                        return;
                    }
                    MessageBox.Show("Customer with id='"+txtCustomerId.Text+"' not found!");
                    txtName.Clear();
                    txtSurname.Clear();
                    dtpckBirthDate.Value = DateTime.Today;
                    txtCustomerId.Clear();
                    txtCustomerId.Focus();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            //////////////////

        }
    }
}
