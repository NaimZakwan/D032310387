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
using System.Xml.Linq;

namespace d032310387_real
{
    public partial class FormAuthor : Form
    {
        public FormAuthor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAuthor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstoreDatabaseDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.admiralBookstoreDatabaseDataSet.Author);

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            FormBook bookForm = new FormBook();  
            bookForm.Show();                    
            this.Hide();                        
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormStock StockForm = new FormStock();
            StockForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string authorID = txtBoxAuthID.Text.Trim();
            string name = txtBoxName.Text.Trim();
            string birthYear = txtBoxBirth.Text.Trim();

            // Adjust connection string as needed
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AdmiralBookstoreDatabase.mdf;Integrated Security=True";

            string query = "INSERT INTO Author (AuthorID, Name, BirthYear) VALUES (@AuthorID, @Name, @BirthYear)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AuthorID", authorID);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@BirthYear", birthYear);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Author added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Optionally refresh the data grid
            this.authorTableAdapter.Fill(this.admiralBookstoreDatabaseDataSet.Author);
        }

        private void txtBoxAuthID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
