using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ASM2.DB
{
    public partial class AdminDashboard : Form
    {
        SqlConnection conn;
        public AdminDashboard()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=LibraryManagement1;Integrated Security=True;");
        }
        public AdminDashboard(string username)
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=LibraryManagement1;Integrated Security=True;");
            MessageBox.Show("Welcome" + username);
        }
        public void GetAuthors()
        {
            string query = "select author_id, author_name from Authors";

            DataTable table = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

            dataAdapter.Fill(table);

            cbBookAuthor.DataSource = table;

            cbBookAuthor.DisplayMember = "author_name";

            cbBookAuthor.ValueMember = "author_id";
        }
        public void GetCategories()
        {
            string query = "select category_id, category_name from Categories";

            DataTable table = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

            dataAdapter.Fill(table);

            cbBookCategory.DataSource = table;

            cbBookCategory.DisplayMember = "category_name";

            cbBookCategory.ValueMember = "category_id";
        }
        public void GetPublishers()

        {

            string query = "select publisher_id, publisher_name from Publishers";

            DataTable table = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

            dataAdapter.Fill(table);

            cbBookPublisher.DataSource = table;

            cbBookPublisher.DisplayMember = "publisher name";

            cbBookPublisher.ValueMember = "publisher_id";

        }
        public void GetBooks()
        {
            string query = "select book_id, book_name from Books";

            DataTable table = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

            dataAdapter.Fill(table);

            cbTicketBook.DataSource = table;

            cbTicketBook.DisplayMember = "book_name";

            cbTicketBook.ValueMember = "book_id";
        }
        public void GetBorrowers()
        {
     
            string query = "SELECT borrower_id, borrower_name FROM Borrowers";

            DataTable table = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

            dataAdapter.Fill(table);

            cbTicketBorrower.DataSource = table;

            cbTicketBorrower.DisplayMember = "borrower_name";

            cbTicketBorrower.ValueMember = "borrower_id";
        }

        public void FillDataBooks()
        {
            string query = "SELECT * FROM Books";

            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=LibraryManagement1;Integrated Security=True;"))
            {
                SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                ad.Fill(dataTable);
            }

            dgvBooks.DataSource = dataTable;
        }

        public void ClearDataBooks()
        {
            txtBookID.Text = "";

            txtBookName.Text = "";

            cbBookAuthor.Text = "";

            cbBookCategory.Text = "";

            cbBookPublisher.Text = "";
        }
        public void FillDataBorrowers()
        {
            string query = "select * from Borrowers";

            DataTable dataTable = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);

            sqlDataAdapter.Fill(dataTable);

            dgvBorrower.DataSource = dataTable;
        }
        public void ClearDataBorrowers()
        {
            txtBorrowerID.Text = "";

            txtBorrowerName.Text = "";

            txtBorrowerAddress.Text = "";

            txtBorrowerEmail.Text = "";

            txtBorrowerPhone.Text = "";
        }


        public void FillDataTickets()
        {
            string query = "select * from Tickets"; 
            
            DataTable dataTable = new DataTable();

            SqlDataAdapter ad = new SqlDataAdapter(query, conn);

            ad.Fill(dataTable);

            dgvTicket.DataSource = dataTable;
        }
        public void ClearDataTickets()
        {
            txtTicketID.Text = "";

            cbTicketBook.Text = "";

            cbTicketBorrower.Text = "";
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            string name = txtBookName.Text;
            string authorID = cbBookAuthor.SelectedValue.ToString();
            string categoryID = cbBookCategory.SelectedValue.ToString();
            string publisherID = cbBookPublisher.SelectedValue.ToString();
            DateTime publishingData = dtpBookPublishingDate.Value;

            string insert = "insert into Books (book_name, author_id, category_id, publisher_id, publishing_data) values (@book_name, @author_id, @category_id, @publisher_id, @publishing_data)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@book_name", SqlDbType.VarChar);
            cmd.Parameters["@book_name"].Value = name;
            cmd.Parameters.Add("@author_id", SqlDbType.Int);
            cmd.Parameters["@author_id"].Value = authorID;
            cmd.Parameters.Add("@category_id", SqlDbType.Int);
            cmd.Parameters["@category_id"].Value = categoryID;
            cmd.Parameters.Add("@publisher_id", SqlDbType.Int);
            cmd.Parameters["@publisher_id"].Value = publisherID;
            cmd.Parameters.Add("@publishing_data", SqlDbType.DateTime);
            cmd.Parameters["@publishing_data"].Value = publishingData;
            cmd.ExecuteNonQuery();
            FillDataBooks();
            ClearDataBooks();
            conn.Close();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        
        private void AdminDashboard_Load_1(object sender, EventArgs e)
        {
            GetAuthors();

            GetCategories();

            GetPublishers();

            GetBooks();

            GetBorrowers();


            FillDataBooks();

            FillDataTickets();

            FillDataBorrowers();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBooks.Rows[e.RowIndex];

                txtBookID.Text = row.Cells["book_id"].Value.ToString();

                txtBookName.Text = row.Cells["book_name"].Value.ToString();

                cbBookAuthor.SelectedValue = row.Cells["author_icl.Value.ToString()"];

                cbBookCategory.SelectedValue = row.Cells["category_id"].Value.ToString();

                cbBookPublisher.SelectedValue = row.Cells["publisher_id"].Value.ToString();

                dtpBookPublishingDate.Value = (DateTime)row.Cells["publishing_date"].Value;
            }
        }

        private void btnBookClearData_Click(object sender, EventArgs e)
        {
            ClearDataBooks();
        }

        private void btnBorrowerClearData_Click(object sender, EventArgs e)
        {
            ClearDataBorrowers();
        }

        private void btnTicketClearData_Click(object sender, EventArgs e)
        {
            ClearDataTickets();
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            string name = txtBookName.Text;
            string authorID = cbBookAuthor.SelectedValue.ToString();
            string categoryID = cbBookCategory.SelectedValue.ToString();
            string publisherID = cbBookPublisher.SelectedValue.ToString();
            DateTime publishingDate = dtpBookPublishingDate.Value;

            string insert = "insert into Books (book_name, author_id, category_id, publisher_id, publishing_date) values (@book_name, @author_id, @category_id, @publisher_id, @publishing_date)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@book_name", SqlDbType.VarChar);
            cmd.Parameters["@book_name"].Value = name;
            cmd.Parameters.Add("@author_id", SqlDbType.Int);
            cmd.Parameters["@author_id"].Value = authorID;
            cmd.Parameters.Add("@category_id", SqlDbType.Int);
            cmd.Parameters["@category_id"].Value = categoryID;
            cmd.Parameters.Add("@publisher_id", SqlDbType.Int);
            cmd.Parameters["@publisher_id"].Value = publisherID;
            cmd.Parameters.Add("@publishing_date", SqlDbType.DateTime);
            cmd.Parameters["@publishing_date"].Value = publishingDate;
            cmd.ExecuteNonQuery();
            FillDataBooks();
            ClearDataBooks();
            conn.Close();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "delete from Books where book_id = @book_id";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@book_id", SqlDbType.Int);
                cmd.Parameters["@book_id"].Value = txtBookID.Text;
                cmd.ExecuteNonQuery();
                FillDataBooks();
                ClearDataBooks();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                conn.Close();
            }
        }
        private void btnBorrowerAdd_Click(object sender, EventArgs e)
        {
            string borrowerName = txtBorrowerName.Text;

            string borrowerAddress = txtBorrowerAddress.Text;

            string borrowerPhone = txtBorrowerPhone.Text;

            string borrowerEmail = txtBorrowerEmail.Text;

            DateTime DOB = dtpBorrowerDOB.Value;

            string insert = "insert into Borrowers (borrower_name, borrower_address, borrower_phone, borrower_email, borrower_DOB) values(@borrower_name, @borrower_address, @borrower_phone, @borrower_email, @borrower_DOB)";

            conn.Close();

            SqlCommand cmd=new SqlCommand(insert, conn);

            cmd.Parameters.Add("@borrower_name", SqlDbType.VarChar); cmd.Parameters["@borrower_name"].Value=borrowerName;

            cmd.Parameters.Add("@borrower_address", SqlDbType.VarChar);

            cmd.Parameters["@borrower_address"].Value = borrowerAddress;
            cmd.Parameters.Add("@borrower_phone", SqlDbType.VarChar);
            cmd.Parameters["@borrower_phone"].Value = borrowerPhone;

            cmd.Parameters.Add("@borrower_email", SqlDbType.VarChar);
            cmd.Parameters["@borrower_email"].Value=borrowerEmail;
            cmd.Parameters.Add("@borrower_DOB", SqlDbType.VarChar);
            cmd.Parameters["@borrower DOB"].Value = DOB;
            cmd.ExecuteNonQuery();

            FillDataBorrowers();

            ClearDataBorrowers();
            conn.Close();

            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void dgvBorrower_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBorrower.Rows[e.RowIndex];

                txtBorrowerID.Text = row.Cells["borrower_id"].Value.ToString();

                txtBorrowerName.Text = row.Cells["borrower name"].Value.ToString();

                txtBorrowerAddress.Text=row.Cells["borrower_address"].Value.ToString();

                txtBorrowerPhone.Text = row.Cells["borrower_phone"].Value.ToString();

                txtBorrowerEmail.Text = row.Cells["borrower email"].Value.ToString();

                dtpBookPublishingDate.Value = (DateTime)row.Cells["borrower_DOB"].Value;
            }

          
        }

        private void btnBorrowerUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string update = "update Borrowers set borrower_name = @borrower_name, borrower_address = @borrower_address, borrower_phone = @borrower_phone, borrower_email = @borrower_email, borrower_DOB = @borrower_DOB where borrower id @borrower_id";



                conn.Open();

                SqlCommand cmd=new SqlCommand(update, conn);

                cmd.Parameters.Add("@borrower_id", SqlDbType.Int);

                cmd.Parameters["@borrower id"].Value=txtBorrowerID.Text;

                cmd.Parameters.Add("@borrower_name", SqlDbType.VarChar);

                cmd.Parameters["@borrower_name"].Value = txtBorrowerName.Text;

                cmd.Parameters.Add("@borrower address", SqlDbType.VarChar);

                cmd.Parameters["@borrower_address"].Value = txtBorrowerAddress.Text;

                cmd.Parameters.Add("@borrower_phone", SqlDbType.VarChar);

                cmd.Parameters["@borrower_phone"].Value = txtBorrowerPhone.Text;

                cmd.Parameters.Add("@borrower_email", SqlDbType.VarChar);

                cmd.Parameters["@borrower email"].Value = txtBorrowerEmail.Text;

                cmd.Parameters.Add("@borrower_DOB", SqlDbType.VarChar);

                cmd.Parameters["@borrower_DOB"].Value=dtpBorrowerDOB.Value;
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    FillDataBorrowers();

                    ClearDataBorrowers();

                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);

                    conn.Close();
                }

            }

        }

        private void btnBorrowerDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();

                string delete="delete from Borrowers where borrower_id =@borrower_id";

                SqlCommand cmd = new SqlCommand(delete, conn);

                cmd.Parameters.Add("@borrower_id", SqlDbType.Int);

                cmd.Parameters["@borrower_id"].Value = txtBorrowerID.Text;

                cmd.ExecuteNonQuery();

                FillDataBorrowers();

                ClearDataBorrowers();

                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);

                conn.Close();
            }



        }

        private void btnTicketAdd_Click(object sender, EventArgs e)
        {
            string bookID=cbTicketBook.SelectedValue.ToString();

            string borrowerID=cbTicketBorrower.SelectedValue.ToString();

            DateTime borrowerDate = dtpBorrowDate.Value;

            DateTime returnDate = dtpReturnDate.Value;

            string insert = "insert into Tickets (book_id, borrower_id, borrow_date, return_date) values (@book_id, @borrower_@borrow_date, @return_date)";

            conn.Close();

            SqlCommand cmd = new SqlCommand(insert, conn);

            cmd.Parameters.Add("@book_id", SqlDbType.Int); cmd.Parameters["@book_id"].Value=bookID;

            cmd.Parameters.Add("@borrower_id", SqlDbType.Int);

            cmd.Parameters["@borrower_id"].Value = borrowerID;

            cmd.Parameters.Add("@borrow_date", SqlDbType.VarChar);

            cmd.Parameters["@borrow_date"].Value = borrowerDate;

            cmd.Parameters.Add("@return_date", SqlDbType.VarChar);

            cmd.Parameters["@return_date"].Value=returnDate;

            cmd.ExecuteNonQuery();

            FillDataTickets();

            ClearDataTickets();

            conn.Close();

            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void dgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvTicket.Rows[e.RowIndex];

                txtTicketID.Text=row.Cells["ticket id"].Value.ToString();

                cbTicketBook.SelectedValue=row.Cells["book_id"].Value.ToString();

                cbTicketBorrower.SelectedValue=row.Cells["borrower_id"].Value.ToString();

                dtpBorrowDate.Value = (DateTime)row.Cells["borrow_date"].Value;

                dtpReturnDate.Value = (DateTime)row.Cells["return_date"].Value;
            }

        }

        private void btnTicketUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update="update Tickets set book_id= @book_id, borrower_id = @borrower_id, borrow_date= @borrow_date,return date @return_date where ticket_id @ticket_id";

                conn.Close();

                SqlCommand cmd = new SqlCommand(update, conn); cmd.Parameters.Add("@ticket_id", SqlDbType.Int);

                cmd.Parameters["@ticket_id"].Value=txtTicketID.Text;

                cmd.Parameters.Add("@book_id", SqlDbType.Int);

                cmd.Parameters["@book_id"].Value=int.Parse(cbTicketBook.SelectedValue.ToString()); ;

                cmd.Parameters.Add("@borrower_id", SqlDbType.Int);

                cmd.Parameters["@borrower_id"].Value = int.Parse(cbTicketBorrower.SelectedValue.ToString()); ; ;

                cmd.Parameters.Add("@borrow_date", SqlDbType.VarChar);

                cmd.Parameters["@borrow_date"].Value = dtpBorrowDate.Value;

                cmd.Parameters.Add("@return_date", SqlDbType.VarChar);

                cmd.Parameters["@return_date"].Value=dtpReturnDate.Value;
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {

                    FillDataTickets();

                    ClearDataTickets();

                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);

                    conn.Close();
                }
            } 
        }

        private void btnTicketDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();

                string delete = "delete from Tickets where ticket_id =@ticket_id";

                SqlCommand cmd = new SqlCommand(delete, conn); cmd.Parameters.Add("@ticket_id", SqlDbType.Int);

                cmd.Parameters["@ticket_id"].Value = txtTicketID.Text;

                cmd.ExecuteNonQuery();

                FillDataTickets();

                ClearDataTickets();

                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);

                conn.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
