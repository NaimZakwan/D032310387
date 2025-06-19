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
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstoreDatabaseDataSet.Book' table. You can move, or remove it, as needed.
            this.admiralBookstoreDatabaseDataSet.EnforceConstraints = false;
            this.bookTableAdapter.Fill(this.admiralBookstoreDatabaseDataSet.Book);


        }

        private void BookbtnAuthor_Click(object sender, EventArgs e)
        {
            FormAuthor authForm = new FormAuthor();
            authForm.Show();
            this.Hide();
        }

        private void BookbtnStock_Click(object sender, EventArgs e)
        {
            FormStock StockForm = new FormStock();
            StockForm.Show();
            this.Hide();
        }

        private void txtBoxAuthID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPub_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPubDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AdmiralBookstoreDatabase.mdf;Integrated Security=True";

            string isbn = txtBoxAuthID.Text.Trim();         // FIXED: Correct source for ISBN
            string title = txtTitle.Text.Trim();
            string publisher = txtPub.Text.Trim();
            DateTime publishDate;

            // Validate input
            if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(publisher) || !DateTime.TryParse(txtPubDate.Text.Trim(), out publishDate))
            {
                MessageBox.Show("Please enter valid and complete data.");
                return;
            }

            string query = @"
        UPDATE Book
        SET Title = @Title, Publisher = @Publisher, PublishDate = @PublishDate
        WHERE [ISBN-13] = @ISBN13";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ISBN13", isbn);

                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Publisher", publisher);
                command.Parameters.AddWithValue("@PublishDate", publishDate);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book record updated successfully!");
                        this.bookTableAdapter.Fill(this.admiralBookstoreDatabaseDataSet.Book); // Refresh grid
                    }
                    else
                    {
                        MessageBox.Show("No matching ISBN-13 found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
