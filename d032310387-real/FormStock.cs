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

namespace d032310387_real
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstoreDatabaseDataSet.Stock' table. You can move, or remove it, as needed.
            this.admiralBookstoreDatabaseDataSet.EnforceConstraints = false;
            this.stockTableAdapter.Fill(this.admiralBookstoreDatabaseDataSet.Stock);


        }

        private void StockbtnAuthor_Click(object sender, EventArgs e)
        {
            FormAuthor authForm = new FormAuthor();
            authForm.Show();
            this.Hide();
        }

        private void StockbtnBook_Click(object sender, EventArgs e)
        {
            FormBook bookForm = new FormBook();
            bookForm.Show();
            this.Hide();
        }







        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxAuthID.Text))
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AdmiralBookstoreDatabase.mdf;Integrated Security=True";

                string query = "DELETE FROM Stock WHERE StockID = @StockID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", txtBoxAuthID.Text.Trim());

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock record deleted successfully.");
                            // Refresh the grid
                            this.stockTableAdapter.Fill(this.admiralBookstoreDatabaseDataSet.Stock);
                        }
                        else
                        {
                            MessageBox.Show("No matching StockID found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a StockID to delete.");
            }
        }


        private void txtBoxAuthID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {

        }
    }
}
