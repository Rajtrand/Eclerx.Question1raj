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

namespace Eclerx.Question1raj
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-8V2U4H7\Sqlexpress; Initial Catalog =Eclerx DB; Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "  " )
                MessageBox.Show("please fill mandetory field");
            else if (txtSalary.Text != > 25000)
                MessageBox.Show("Tryagain");
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlCmd = new SqlCommand("newtable", sqlcon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@txtSalary", txtSalary.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EmployeeNO", txtEmployeeNo.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Successfull");
                    clear();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            {
                txtEmployeeNo.Text = txtEmployeeName.Text = txtSalary.Text  = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
