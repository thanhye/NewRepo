namespace ASM2.DB
{
    partial class BorrowerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.btnBookClearData = new System.Windows.Forms.Button();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.dtpBookPublishingDate = new System.Windows.Forms.DateTimePicker();
            this.cbBookCategory = new System.Windows.Forms.ComboBox();
            this.cbBookPublisher = new System.Windows.Forms.ComboBox();
            this.cbBookAuthor = new System.Windows.Forms.ComboBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblListOfBooks = new System.Windows.Forms.Label();
            this.dtgBooks = new System.Windows.Forms.DataGridView();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPublishingDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lbl_Name_t1 = new System.Windows.Forms.Label();
            this.lblID_t1 = new System.Windows.Forms.Label();
            this.tabPageTicket = new System.Windows.Forms.TabPage();
            this.cbTicketBook = new System.Windows.Forms.ComboBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.lblListOfTicket = new System.Windows.Forms.Label();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.btnTicketClearData = new System.Windows.Forms.Button();
            this.btnTicketUpdate = new System.Windows.Forms.Button();
            this.btnTicketDelete = new System.Windows.Forms.Button();
            this.btnTicketAdd = new System.Windows.Forms.Button();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.cbTicketBorrower = new System.Windows.Forms.ComboBox();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lbBorrower = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvBooks.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBooks)).BeginInit();
            this.tabPageTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.Controls.Add(this.tabPageBook);
            this.dgvBooks.Controls.Add(this.tabPageTicket);
            this.dgvBooks.Location = new System.Drawing.Point(1, 0);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectedIndex = 0;
            this.dgvBooks.Size = new System.Drawing.Size(892, 582);
            this.dgvBooks.TabIndex = 0;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.btnBookClearData);
            this.tabPageBook.Controls.Add(this.btnBookUpdate);
            this.tabPageBook.Controls.Add(this.btnBookDelete);
            this.tabPageBook.Controls.Add(this.btnBookAdd);
            this.tabPageBook.Controls.Add(this.dtpBookPublishingDate);
            this.tabPageBook.Controls.Add(this.cbBookCategory);
            this.tabPageBook.Controls.Add(this.cbBookPublisher);
            this.tabPageBook.Controls.Add(this.cbBookAuthor);
            this.tabPageBook.Controls.Add(this.txtBookName);
            this.tabPageBook.Controls.Add(this.txtBookID);
            this.tabPageBook.Controls.Add(this.lblListOfBooks);
            this.tabPageBook.Controls.Add(this.dtgBooks);
            this.tabPageBook.Controls.Add(this.lblPublisher);
            this.tabPageBook.Controls.Add(this.lblPublishingDate);
            this.tabPageBook.Controls.Add(this.lblCategory);
            this.tabPageBook.Controls.Add(this.lblAuthor);
            this.tabPageBook.Controls.Add(this.lbl_Name_t1);
            this.tabPageBook.Controls.Add(this.lblID_t1);
            this.tabPageBook.Location = new System.Drawing.Point(4, 25);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(884, 553);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Book";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // btnBookClearData
            // 
            this.btnBookClearData.Location = new System.Drawing.Point(651, 249);
            this.btnBookClearData.Name = "btnBookClearData";
            this.btnBookClearData.Size = new System.Drawing.Size(94, 45);
            this.btnBookClearData.TabIndex = 37;
            this.btnBookClearData.Text = "Clear Data";
            this.btnBookClearData.UseVisualStyleBackColor = true;
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(651, 184);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(94, 45);
            this.btnBookUpdate.TabIndex = 36;
            this.btnBookUpdate.Text = "Update";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(510, 249);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(94, 45);
            this.btnBookDelete.TabIndex = 35;
            this.btnBookDelete.Text = "Delete";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(510, 184);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(94, 45);
            this.btnBookAdd.TabIndex = 34;
            this.btnBookAdd.Text = "Add";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // dtpBookPublishingDate
            // 
            this.dtpBookPublishingDate.Location = new System.Drawing.Point(583, 135);
            this.dtpBookPublishingDate.Name = "dtpBookPublishingDate";
            this.dtpBookPublishingDate.Size = new System.Drawing.Size(242, 22);
            this.dtpBookPublishingDate.TabIndex = 33;
            // 
            // cbBookCategory
            // 
            this.cbBookCategory.FormattingEnabled = true;
            this.cbBookCategory.Location = new System.Drawing.Point(160, 223);
            this.cbBookCategory.Name = "cbBookCategory";
            this.cbBookCategory.Size = new System.Drawing.Size(242, 24);
            this.cbBookCategory.TabIndex = 32;
            // 
            // cbBookPublisher
            // 
            this.cbBookPublisher.FormattingEnabled = true;
            this.cbBookPublisher.Location = new System.Drawing.Point(583, 87);
            this.cbBookPublisher.Name = "cbBookPublisher";
            this.cbBookPublisher.Size = new System.Drawing.Size(242, 24);
            this.cbBookPublisher.TabIndex = 31;
            // 
            // cbBookAuthor
            // 
            this.cbBookAuthor.FormattingEnabled = true;
            this.cbBookAuthor.Location = new System.Drawing.Point(160, 184);
            this.cbBookAuthor.Name = "cbBookAuthor";
            this.cbBookAuthor.Size = new System.Drawing.Size(242, 24);
            this.cbBookAuthor.TabIndex = 30;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(160, 124);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(242, 31);
            this.txtBookName.TabIndex = 29;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(160, 80);
            this.txtBookID.Multiline = true;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(242, 31);
            this.txtBookID.TabIndex = 28;
            // 
            // lblListOfBooks
            // 
            this.lblListOfBooks.AutoSize = true;
            this.lblListOfBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfBooks.Location = new System.Drawing.Point(337, 309);
            this.lblListOfBooks.Name = "lblListOfBooks";
            this.lblListOfBooks.Size = new System.Drawing.Size(195, 32);
            this.lblListOfBooks.TabIndex = 26;
            this.lblListOfBooks.Text = "List Of Books";
            // 
            // dtgBooks
            // 
            this.dtgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBooks.Location = new System.Drawing.Point(65, 344);
            this.dtgBooks.Name = "dtgBooks";
            this.dtgBooks.RowHeadersWidth = 51;
            this.dtgBooks.RowTemplate.Height = 24;
            this.dtgBooks.Size = new System.Drawing.Size(760, 191);
            this.dtgBooks.TabIndex = 25;
            this.dtgBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListOfBooks_CellContentClick);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(439, 87);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(93, 25);
            this.lblPublisher.TabIndex = 24;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblPublishingDate
            // 
            this.lblPublishingDate.AutoSize = true;
            this.lblPublishingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishingDate.Location = new System.Drawing.Point(439, 133);
            this.lblPublishingDate.Name = "lblPublishingDate";
            this.lblPublishingDate.Size = new System.Drawing.Size(148, 25);
            this.lblPublishingDate.TabIndex = 23;
            this.lblPublishingDate.Text = "Publishing Date";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(60, 223);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 22;
            this.lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(60, 184);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(70, 25);
            this.lblAuthor.TabIndex = 21;
            this.lblAuthor.Text = "Author";
            // 
            // lbl_Name_t1
            // 
            this.lbl_Name_t1.AutoSize = true;
            this.lbl_Name_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_t1.Location = new System.Drawing.Point(60, 133);
            this.lbl_Name_t1.Name = "lbl_Name_t1";
            this.lbl_Name_t1.Size = new System.Drawing.Size(64, 25);
            this.lbl_Name_t1.TabIndex = 20;
            this.lbl_Name_t1.Text = "Name";
            // 
            // lblID_t1
            // 
            this.lblID_t1.AutoSize = true;
            this.lblID_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_t1.Location = new System.Drawing.Point(60, 87);
            this.lblID_t1.Name = "lblID_t1";
            this.lblID_t1.Size = new System.Drawing.Size(31, 25);
            this.lblID_t1.TabIndex = 19;
            this.lblID_t1.Text = "ID";
            // 
            // tabPageTicket
            // 
            this.tabPageTicket.Controls.Add(this.cbTicketBook);
            this.tabPageTicket.Controls.Add(this.dtpBorrowDate);
            this.tabPageTicket.Controls.Add(this.lblListOfTicket);
            this.tabPageTicket.Controls.Add(this.dgvTicket);
            this.tabPageTicket.Controls.Add(this.btnTicketClearData);
            this.tabPageTicket.Controls.Add(this.btnTicketUpdate);
            this.tabPageTicket.Controls.Add(this.btnTicketDelete);
            this.tabPageTicket.Controls.Add(this.btnTicketAdd);
            this.tabPageTicket.Controls.Add(this.dtpReturnDate);
            this.tabPageTicket.Controls.Add(this.cbTicketBorrower);
            this.tabPageTicket.Controls.Add(this.txtTicketID);
            this.tabPageTicket.Controls.Add(this.lblBorrowDate);
            this.tabPageTicket.Controls.Add(this.lblReturnDate);
            this.tabPageTicket.Controls.Add(this.lbBorrower);
            this.tabPageTicket.Controls.Add(this.lblBook);
            this.tabPageTicket.Controls.Add(this.lblID);
            this.tabPageTicket.Location = new System.Drawing.Point(4, 25);
            this.tabPageTicket.Name = "tabPageTicket";
            this.tabPageTicket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTicket.Size = new System.Drawing.Size(884, 553);
            this.tabPageTicket.TabIndex = 1;
            this.tabPageTicket.Text = "Ticket";
            this.tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // cbTicketBook
            // 
            this.cbTicketBook.FormattingEnabled = true;
            this.cbTicketBook.Location = new System.Drawing.Point(152, 116);
            this.cbTicketBook.Name = "cbTicketBook";
            this.cbTicketBook.Size = new System.Drawing.Size(242, 24);
            this.cbTicketBook.TabIndex = 75;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(594, 52);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(242, 22);
            this.dtpBorrowDate.TabIndex = 74;
            // 
            // lblListOfTicket
            // 
            this.lblListOfTicket.AutoSize = true;
            this.lblListOfTicket.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfTicket.Location = new System.Drawing.Point(362, 284);
            this.lblListOfTicket.Name = "lblListOfTicket";
            this.lblListOfTicket.Size = new System.Drawing.Size(167, 31);
            this.lblListOfTicket.TabIndex = 73;
            this.lblListOfTicket.Text = "List Of Ticket";
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(83, 318);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 24;
            this.dgvTicket.Size = new System.Drawing.Size(753, 189);
            this.dgvTicket.TabIndex = 72;
            this.dgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellContentClick);
            // 
            // btnTicketClearData
            // 
            this.btnTicketClearData.Location = new System.Drawing.Point(661, 236);
            this.btnTicketClearData.Name = "btnTicketClearData";
            this.btnTicketClearData.Size = new System.Drawing.Size(94, 45);
            this.btnTicketClearData.TabIndex = 71;
            this.btnTicketClearData.Text = "Clear Data";
            this.btnTicketClearData.UseVisualStyleBackColor = true;
            // 
            // btnTicketUpdate
            // 
            this.btnTicketUpdate.Location = new System.Drawing.Point(661, 164);
            this.btnTicketUpdate.Name = "btnTicketUpdate";
            this.btnTicketUpdate.Size = new System.Drawing.Size(94, 45);
            this.btnTicketUpdate.TabIndex = 70;
            this.btnTicketUpdate.Text = "Update";
            this.btnTicketUpdate.UseVisualStyleBackColor = true;
            // 
            // btnTicketDelete
            // 
            this.btnTicketDelete.Location = new System.Drawing.Point(520, 236);
            this.btnTicketDelete.Name = "btnTicketDelete";
            this.btnTicketDelete.Size = new System.Drawing.Size(94, 45);
            this.btnTicketDelete.TabIndex = 69;
            this.btnTicketDelete.Text = "Delete";
            this.btnTicketDelete.UseVisualStyleBackColor = true;
            // 
            // btnTicketAdd
            // 
            this.btnTicketAdd.Location = new System.Drawing.Point(520, 167);
            this.btnTicketAdd.Name = "btnTicketAdd";
            this.btnTicketAdd.Size = new System.Drawing.Size(94, 45);
            this.btnTicketAdd.TabIndex = 68;
            this.btnTicketAdd.Text = "Add";
            this.btnTicketAdd.UseVisualStyleBackColor = true;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(594, 118);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(242, 22);
            this.dtpReturnDate.TabIndex = 67;
            // 
            // cbTicketBorrower
            // 
            this.cbTicketBorrower.FormattingEnabled = true;
            this.cbTicketBorrower.Location = new System.Drawing.Point(152, 167);
            this.cbTicketBorrower.Name = "cbTicketBorrower";
            this.cbTicketBorrower.Size = new System.Drawing.Size(242, 24);
            this.cbTicketBorrower.TabIndex = 66;
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(152, 46);
            this.txtTicketID.Multiline = true;
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(242, 31);
            this.txtTicketID.TabIndex = 64;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowDate.Location = new System.Drawing.Point(440, 52);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(119, 25);
            this.lblBorrowDate.TabIndex = 63;
            this.lblBorrowDate.Text = "Borrow Date";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(440, 116);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(115, 25);
            this.lblReturnDate.TabIndex = 62;
            this.lblReturnDate.Text = "Return Date";
            // 
            // lbBorrower
            // 
            this.lbBorrower.AutoSize = true;
            this.lbBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrower.Location = new System.Drawing.Point(48, 167);
            this.lbBorrower.Name = "lbBorrower";
            this.lbBorrower.Size = new System.Drawing.Size(90, 25);
            this.lbBorrower.TabIndex = 61;
            this.lbBorrower.Text = "Borrower";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(48, 116);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(57, 25);
            this.lblBook.TabIndex = 60;
            this.lblBook.Text = "Book";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(48, 52);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 25);
            this.lblID.TabIndex = 59;
            this.lblID.Text = "ID\r\n";
            // 
            // BorrowerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 579);
            this.Controls.Add(this.dgvBooks);
            this.Name = "BorrowerDashboard";
            this.Text = "Borrower";
            this.Load += new System.EventHandler(this.BorrowerDashboard_Load);
            this.dgvBooks.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBooks)).EndInit();
            this.tabPageTicket.ResumeLayout(false);
            this.tabPageTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dgvBooks;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.TabPage tabPageTicket;
        private System.Windows.Forms.Button btnBookClearData;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.DateTimePicker dtpBookPublishingDate;
        private System.Windows.Forms.ComboBox cbBookCategory;
        private System.Windows.Forms.ComboBox cbBookPublisher;
        private System.Windows.Forms.ComboBox cbBookAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblListOfBooks;
        private System.Windows.Forms.DataGridView dtgBooks;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPublishingDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lbl_Name_t1;
        private System.Windows.Forms.Label lblID_t1;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblListOfTicket;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Button btnTicketClearData;
        private System.Windows.Forms.Button btnTicketUpdate;
        private System.Windows.Forms.Button btnTicketDelete;
        private System.Windows.Forms.Button btnTicketAdd;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.ComboBox cbTicketBorrower;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lbBorrower;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbTicketBook;
    }
}