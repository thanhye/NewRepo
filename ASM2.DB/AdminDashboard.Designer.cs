namespace ASM2.DB
{
    partial class AdminDashboard
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
            System.Windows.Forms.TabPage tabPageBook;
            System.Windows.Forms.TabPage tabPageBorrower;
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
            this.label8 = new System.Windows.Forms.Label();
            this.lblListOfBooks = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPublishingDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lbl_Name_t1 = new System.Windows.Forms.Label();
            this.lblID_t1 = new System.Windows.Forms.Label();
            this.txtBorrowerEmail = new System.Windows.Forms.TextBox();
            this.txtBorrowerPhone = new System.Windows.Forms.TextBox();
            this.txtBorrowerAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvBorrower = new System.Windows.Forms.DataGridView();
            this.btnBorrowerClearData = new System.Windows.Forms.Button();
            this.btnBorrowerUpdate = new System.Windows.Forms.Button();
            this.btnBorrowerDelete = new System.Windows.Forms.Button();
            this.btnBorrowerAdd = new System.Windows.Forms.Button();
            this.dtpBorrowerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtBorrowerName = new System.Windows.Forms.TextBox();
            this.txtBorrowerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lbl_Name_t2 = new System.Windows.Forms.Label();
            this.lbl_ID_t2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lbBorrower = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            tabPageBook = new System.Windows.Forms.TabPage();
            tabPageBorrower = new System.Windows.Forms.TabPage();
            tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            tabPageBorrower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrower)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageBook
            // 
            tabPageBook.Controls.Add(this.btnBookClearData);
            tabPageBook.Controls.Add(this.btnBookUpdate);
            tabPageBook.Controls.Add(this.btnBookDelete);
            tabPageBook.Controls.Add(this.btnBookAdd);
            tabPageBook.Controls.Add(this.dtpBookPublishingDate);
            tabPageBook.Controls.Add(this.cbBookCategory);
            tabPageBook.Controls.Add(this.cbBookPublisher);
            tabPageBook.Controls.Add(this.cbBookAuthor);
            tabPageBook.Controls.Add(this.txtBookName);
            tabPageBook.Controls.Add(this.txtBookID);
            tabPageBook.Controls.Add(this.label8);
            tabPageBook.Controls.Add(this.lblListOfBooks);
            tabPageBook.Controls.Add(this.dgvBooks);
            tabPageBook.Controls.Add(this.lblPublisher);
            tabPageBook.Controls.Add(this.lblPublishingDate);
            tabPageBook.Controls.Add(this.lblCategory);
            tabPageBook.Controls.Add(this.lblAuthor);
            tabPageBook.Controls.Add(this.lbl_Name_t1);
            tabPageBook.Controls.Add(this.lblID_t1);
            tabPageBook.ForeColor = System.Drawing.Color.Black;
            tabPageBook.Location = new System.Drawing.Point(4, 25);
            tabPageBook.Name = "tabPageBook";
            tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            tabPageBook.Size = new System.Drawing.Size(894, 532);
            tabPageBook.TabIndex = 0;
            tabPageBook.Text = "Manage Book";
            tabPageBook.UseVisualStyleBackColor = true;
            // 
            // btnBookClearData
            // 
            this.btnBookClearData.Location = new System.Drawing.Point(661, 246);
            this.btnBookClearData.Name = "btnBookClearData";
            this.btnBookClearData.Size = new System.Drawing.Size(94, 45);
            this.btnBookClearData.TabIndex = 18;
            this.btnBookClearData.Text = "Clear Data";
            this.btnBookClearData.UseVisualStyleBackColor = true;
            this.btnBookClearData.Click += new System.EventHandler(this.btnBookClearData_Click);
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(661, 181);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(94, 45);
            this.btnBookUpdate.TabIndex = 17;
            this.btnBookUpdate.Text = "Update";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(520, 246);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(94, 45);
            this.btnBookDelete.TabIndex = 16;
            this.btnBookDelete.Text = "Delete";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(520, 181);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(94, 45);
            this.btnBookAdd.TabIndex = 15;
            this.btnBookAdd.Text = "Add";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // dtpBookPublishingDate
            // 
            this.dtpBookPublishingDate.Location = new System.Drawing.Point(603, 133);
            this.dtpBookPublishingDate.Name = "dtpBookPublishingDate";
            this.dtpBookPublishingDate.Size = new System.Drawing.Size(242, 22);
            this.dtpBookPublishingDate.TabIndex = 14;
            // 
            // cbBookCategory
            // 
            this.cbBookCategory.FormattingEnabled = true;
            this.cbBookCategory.Location = new System.Drawing.Point(170, 224);
            this.cbBookCategory.Name = "cbBookCategory";
            this.cbBookCategory.Size = new System.Drawing.Size(242, 24);
            this.cbBookCategory.TabIndex = 13;
            // 
            // cbBookPublisher
            // 
            this.cbBookPublisher.FormattingEnabled = true;
            this.cbBookPublisher.Location = new System.Drawing.Point(603, 84);
            this.cbBookPublisher.Name = "cbBookPublisher";
            this.cbBookPublisher.Size = new System.Drawing.Size(242, 24);
            this.cbBookPublisher.TabIndex = 12;
            // 
            // cbBookAuthor
            // 
            this.cbBookAuthor.FormattingEnabled = true;
            this.cbBookAuthor.Location = new System.Drawing.Point(170, 172);
            this.cbBookAuthor.Name = "cbBookAuthor";
            this.cbBookAuthor.Size = new System.Drawing.Size(242, 24);
            this.cbBookAuthor.TabIndex = 11;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(170, 121);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(242, 31);
            this.txtBookName.TabIndex = 10;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(170, 77);
            this.txtBookID.Multiline = true;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(242, 31);
            this.txtBookID.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Book Management";
            // 
            // lblListOfBooks
            // 
            this.lblListOfBooks.AutoSize = true;
            this.lblListOfBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfBooks.Location = new System.Drawing.Point(366, 306);
            this.lblListOfBooks.Name = "lblListOfBooks";
            this.lblListOfBooks.Size = new System.Drawing.Size(195, 32);
            this.lblListOfBooks.TabIndex = 7;
            this.lblListOfBooks.Text = "List Of Books";
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(75, 341);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(760, 191);
            this.dgvBooks.TabIndex = 6;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(449, 84);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(93, 25);
            this.lblPublisher.TabIndex = 5;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblPublishingDate
            // 
            this.lblPublishingDate.AutoSize = true;
            this.lblPublishingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishingDate.Location = new System.Drawing.Point(449, 130);
            this.lblPublishingDate.Name = "lblPublishingDate";
            this.lblPublishingDate.Size = new System.Drawing.Size(148, 25);
            this.lblPublishingDate.TabIndex = 4;
            this.lblPublishingDate.Text = "Publishing Date";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(70, 220);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(68, 171);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(94, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author ID";
            // 
            // lbl_Name_t1
            // 
            this.lbl_Name_t1.AutoSize = true;
            this.lbl_Name_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_t1.Location = new System.Drawing.Point(70, 130);
            this.lbl_Name_t1.Name = "lbl_Name_t1";
            this.lbl_Name_t1.Size = new System.Drawing.Size(64, 25);
            this.lbl_Name_t1.TabIndex = 1;
            this.lbl_Name_t1.Text = "Name";
            // 
            // lblID_t1
            // 
            this.lblID_t1.AutoSize = true;
            this.lblID_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_t1.Location = new System.Drawing.Point(70, 84);
            this.lblID_t1.Name = "lblID_t1";
            this.lblID_t1.Size = new System.Drawing.Size(31, 25);
            this.lblID_t1.TabIndex = 0;
            this.lblID_t1.Text = "ID";
            // 
            // tabPageBorrower
            // 
            tabPageBorrower.Controls.Add(this.txtBorrowerEmail);
            tabPageBorrower.Controls.Add(this.txtBorrowerPhone);
            tabPageBorrower.Controls.Add(this.txtBorrowerAddress);
            tabPageBorrower.Controls.Add(this.label12);
            tabPageBorrower.Controls.Add(this.dgvBorrower);
            tabPageBorrower.Controls.Add(this.btnBorrowerClearData);
            tabPageBorrower.Controls.Add(this.btnBorrowerUpdate);
            tabPageBorrower.Controls.Add(this.btnBorrowerDelete);
            tabPageBorrower.Controls.Add(this.btnBorrowerAdd);
            tabPageBorrower.Controls.Add(this.dtpBorrowerDOB);
            tabPageBorrower.Controls.Add(this.txtBorrowerName);
            tabPageBorrower.Controls.Add(this.txtBorrowerID);
            tabPageBorrower.Controls.Add(this.label1);
            tabPageBorrower.Controls.Add(this.lblEmail);
            tabPageBorrower.Controls.Add(this.lblDOB);
            tabPageBorrower.Controls.Add(this.lblPhone);
            tabPageBorrower.Controls.Add(this.lblAddress);
            tabPageBorrower.Controls.Add(this.lbl_Name_t2);
            tabPageBorrower.Controls.Add(this.lbl_ID_t2);
            tabPageBorrower.Location = new System.Drawing.Point(4, 25);
            tabPageBorrower.Name = "tabPageBorrower";
            tabPageBorrower.Padding = new System.Windows.Forms.Padding(3);
            tabPageBorrower.Size = new System.Drawing.Size(894, 532);
            tabPageBorrower.TabIndex = 1;
            tabPageBorrower.Text = "Manage Borrower";
            tabPageBorrower.UseVisualStyleBackColor = true;
            // 
            // txtBorrowerEmail
            // 
            this.txtBorrowerEmail.Location = new System.Drawing.Point(589, 71);
            this.txtBorrowerEmail.Multiline = true;
            this.txtBorrowerEmail.Name = "txtBorrowerEmail";
            this.txtBorrowerEmail.Size = new System.Drawing.Size(242, 31);
            this.txtBorrowerEmail.TabIndex = 40;
            // 
            // txtBorrowerPhone
            // 
            this.txtBorrowerPhone.Location = new System.Drawing.Point(147, 236);
            this.txtBorrowerPhone.Multiline = true;
            this.txtBorrowerPhone.Name = "txtBorrowerPhone";
            this.txtBorrowerPhone.Size = new System.Drawing.Size(242, 31);
            this.txtBorrowerPhone.TabIndex = 39;
            // 
            // txtBorrowerAddress
            // 
            this.txtBorrowerAddress.Location = new System.Drawing.Point(147, 186);
            this.txtBorrowerAddress.Multiline = true;
            this.txtBorrowerAddress.Name = "txtBorrowerAddress";
            this.txtBorrowerAddress.Size = new System.Drawing.Size(242, 31);
            this.txtBorrowerAddress.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(327, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 31);
            this.label12.TabIndex = 37;
            this.label12.Text = "List Of Borrower";
            // 
            // dgvBorrower
            // 
            this.dgvBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrower.Location = new System.Drawing.Point(78, 343);
            this.dgvBorrower.Name = "dgvBorrower";
            this.dgvBorrower.RowHeadersWidth = 51;
            this.dgvBorrower.RowTemplate.Height = 24;
            this.dgvBorrower.Size = new System.Drawing.Size(753, 189);
            this.dgvBorrower.TabIndex = 36;
            this.dgvBorrower.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrower_CellContentClick);
            // 
            // btnBorrowerClearData
            // 
            this.btnBorrowerClearData.Location = new System.Drawing.Point(656, 243);
            this.btnBorrowerClearData.Name = "btnBorrowerClearData";
            this.btnBorrowerClearData.Size = new System.Drawing.Size(94, 45);
            this.btnBorrowerClearData.TabIndex = 35;
            this.btnBorrowerClearData.Text = "Clear Data";
            this.btnBorrowerClearData.UseVisualStyleBackColor = true;
            this.btnBorrowerClearData.Click += new System.EventHandler(this.btnBorrowerClearData_Click);
            // 
            // btnBorrowerUpdate
            // 
            this.btnBorrowerUpdate.Location = new System.Drawing.Point(656, 189);
            this.btnBorrowerUpdate.Name = "btnBorrowerUpdate";
            this.btnBorrowerUpdate.Size = new System.Drawing.Size(94, 45);
            this.btnBorrowerUpdate.TabIndex = 34;
            this.btnBorrowerUpdate.Text = "Update";
            this.btnBorrowerUpdate.UseVisualStyleBackColor = true;
            this.btnBorrowerUpdate.Click += new System.EventHandler(this.btnBorrowerUpdate_Click);
            // 
            // btnBorrowerDelete
            // 
            this.btnBorrowerDelete.Location = new System.Drawing.Point(515, 243);
            this.btnBorrowerDelete.Name = "btnBorrowerDelete";
            this.btnBorrowerDelete.Size = new System.Drawing.Size(94, 45);
            this.btnBorrowerDelete.TabIndex = 33;
            this.btnBorrowerDelete.Text = "Delete";
            this.btnBorrowerDelete.UseVisualStyleBackColor = true;
            this.btnBorrowerDelete.Click += new System.EventHandler(this.btnBorrowerDelete_Click);
            // 
            // btnBorrowerAdd
            // 
            this.btnBorrowerAdd.Location = new System.Drawing.Point(515, 192);
            this.btnBorrowerAdd.Name = "btnBorrowerAdd";
            this.btnBorrowerAdd.Size = new System.Drawing.Size(94, 45);
            this.btnBorrowerAdd.TabIndex = 32;
            this.btnBorrowerAdd.Text = "Add";
            this.btnBorrowerAdd.UseVisualStyleBackColor = true;
            this.btnBorrowerAdd.Click += new System.EventHandler(this.btnBorrowerAdd_Click);
            // 
            // dtpBorrowerDOB
            // 
            this.dtpBorrowerDOB.Location = new System.Drawing.Point(589, 143);
            this.dtpBorrowerDOB.Name = "dtpBorrowerDOB";
            this.dtpBorrowerDOB.Size = new System.Drawing.Size(242, 22);
            this.dtpBorrowerDOB.TabIndex = 31;
            // 
            // txtBorrowerName
            // 
            this.txtBorrowerName.Location = new System.Drawing.Point(147, 134);
            this.txtBorrowerName.Multiline = true;
            this.txtBorrowerName.Name = "txtBorrowerName";
            this.txtBorrowerName.Size = new System.Drawing.Size(242, 31);
            this.txtBorrowerName.TabIndex = 27;
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.Location = new System.Drawing.Point(147, 71);
            this.txtBorrowerID.Multiline = true;
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.Size = new System.Drawing.Size(242, 31);
            this.txtBorrowerID.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Borrower Management";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(473, 78);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(478, 141);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(55, 25);
            this.lblDOB.TabIndex = 23;
            this.lblDOB.Text = "DOB";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(43, 242);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 25);
            this.lblPhone.TabIndex = 22;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(43, 189);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 25);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Address";
            // 
            // lbl_Name_t2
            // 
            this.lbl_Name_t2.AutoSize = true;
            this.lbl_Name_t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_t2.Location = new System.Drawing.Point(43, 134);
            this.lbl_Name_t2.Name = "lbl_Name_t2";
            this.lbl_Name_t2.Size = new System.Drawing.Size(64, 25);
            this.lbl_Name_t2.TabIndex = 20;
            this.lbl_Name_t2.Text = "Name";
            // 
            // lbl_ID_t2
            // 
            this.lbl_ID_t2.AutoSize = true;
            this.lbl_ID_t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_t2.Location = new System.Drawing.Point(43, 77);
            this.lbl_ID_t2.Name = "lbl_ID_t2";
            this.lbl_ID_t2.Size = new System.Drawing.Size(31, 25);
            this.lbl_ID_t2.TabIndex = 19;
            this.lbl_ID_t2.Text = "ID\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tabPageBook);
            this.tabControl1.Controls.Add(tabPageBorrower);
            this.tabControl1.Controls.Add(this.tabPageTicket);
            this.tabControl1.Location = new System.Drawing.Point(-4, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 561);
            this.tabControl1.TabIndex = 0;
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
            this.tabPageTicket.Controls.Add(this.label4);
            this.tabPageTicket.Controls.Add(this.lblBorrowDate);
            this.tabPageTicket.Controls.Add(this.lblReturnDate);
            this.tabPageTicket.Controls.Add(this.lbBorrower);
            this.tabPageTicket.Controls.Add(this.label14);
            this.tabPageTicket.Controls.Add(this.label15);
            this.tabPageTicket.Location = new System.Drawing.Point(4, 25);
            this.tabPageTicket.Name = "tabPageTicket";
            this.tabPageTicket.Size = new System.Drawing.Size(894, 532);
            this.tabPageTicket.TabIndex = 2;
            this.tabPageTicket.Text = "Manage Ticket";
            this.tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // cbTicketBook
            // 
            this.cbTicketBook.FormattingEnabled = true;
            this.cbTicketBook.Location = new System.Drawing.Point(157, 130);
            this.cbTicketBook.Name = "cbTicketBook";
            this.cbTicketBook.Size = new System.Drawing.Size(242, 24);
            this.cbTicketBook.TabIndex = 59;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(599, 66);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(242, 22);
            this.dtpBorrowDate.TabIndex = 58;
            // 
            // lblListOfTicket
            // 
            this.lblListOfTicket.AutoSize = true;
            this.lblListOfTicket.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfTicket.Location = new System.Drawing.Point(367, 298);
            this.lblListOfTicket.Name = "lblListOfTicket";
            this.lblListOfTicket.Size = new System.Drawing.Size(167, 31);
            this.lblListOfTicket.TabIndex = 56;
            this.lblListOfTicket.Text = "List Of Ticket";
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(88, 332);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 24;
            this.dgvTicket.Size = new System.Drawing.Size(753, 189);
            this.dgvTicket.TabIndex = 55;
            this.dgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellContentClick);
            // 
            // btnTicketClearData
            // 
            this.btnTicketClearData.Location = new System.Drawing.Point(666, 250);
            this.btnTicketClearData.Name = "btnTicketClearData";
            this.btnTicketClearData.Size = new System.Drawing.Size(94, 45);
            this.btnTicketClearData.TabIndex = 54;
            this.btnTicketClearData.Text = "Clear Data";
            this.btnTicketClearData.UseVisualStyleBackColor = true;
            this.btnTicketClearData.Click += new System.EventHandler(this.btnTicketClearData_Click);
            // 
            // btnTicketUpdate
            // 
            this.btnTicketUpdate.Location = new System.Drawing.Point(666, 178);
            this.btnTicketUpdate.Name = "btnTicketUpdate";
            this.btnTicketUpdate.Size = new System.Drawing.Size(94, 45);
            this.btnTicketUpdate.TabIndex = 53;
            this.btnTicketUpdate.Text = "Update";
            this.btnTicketUpdate.UseVisualStyleBackColor = true;
            this.btnTicketUpdate.Click += new System.EventHandler(this.btnTicketUpdate_Click);
            // 
            // btnTicketDelete
            // 
            this.btnTicketDelete.Location = new System.Drawing.Point(525, 250);
            this.btnTicketDelete.Name = "btnTicketDelete";
            this.btnTicketDelete.Size = new System.Drawing.Size(94, 45);
            this.btnTicketDelete.TabIndex = 52;
            this.btnTicketDelete.Text = "Delete";
            this.btnTicketDelete.UseVisualStyleBackColor = true;
            this.btnTicketDelete.Click += new System.EventHandler(this.btnTicketDelete_Click);
            // 
            // btnTicketAdd
            // 
            this.btnTicketAdd.Location = new System.Drawing.Point(525, 181);
            this.btnTicketAdd.Name = "btnTicketAdd";
            this.btnTicketAdd.Size = new System.Drawing.Size(94, 45);
            this.btnTicketAdd.TabIndex = 51;
            this.btnTicketAdd.Text = "Add";
            this.btnTicketAdd.UseVisualStyleBackColor = true;
            this.btnTicketAdd.Click += new System.EventHandler(this.btnTicketAdd_Click);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(599, 132);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(242, 22);
            this.dtpReturnDate.TabIndex = 50;
            // 
            // cbTicketBorrower
            // 
            this.cbTicketBorrower.FormattingEnabled = true;
            this.cbTicketBorrower.Location = new System.Drawing.Point(157, 181);
            this.cbTicketBorrower.Name = "cbTicketBorrower";
            this.cbTicketBorrower.Size = new System.Drawing.Size(242, 24);
            this.cbTicketBorrower.TabIndex = 47;
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(157, 60);
            this.txtTicketID.Multiline = true;
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(242, 31);
            this.txtTicketID.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 31);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ticket Management";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowDate.Location = new System.Drawing.Point(445, 66);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(119, 25);
            this.lblBorrowDate.TabIndex = 43;
            this.lblBorrowDate.Text = "Borrow Date";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(445, 130);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(115, 25);
            this.lblReturnDate.TabIndex = 42;
            this.lblReturnDate.Text = "Return Date";
            // 
            // lbBorrower
            // 
            this.lbBorrower.AutoSize = true;
            this.lbBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrower.Location = new System.Drawing.Point(53, 181);
            this.lbBorrower.Name = "lbBorrower";
            this.lbBorrower.Size = new System.Drawing.Size(90, 25);
            this.lbBorrower.TabIndex = 40;
            this.lbBorrower.Text = "Borrower";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(53, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 25);
            this.label14.TabIndex = 39;
            this.label14.Text = "Book";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 25);
            this.label15.TabIndex = 38;
            this.label15.Text = "ID\r\n";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 571);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminDashboard";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminDashboard_Load_1);
            tabPageBook.ResumeLayout(false);
            tabPageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            tabPageBorrower.ResumeLayout(false);
            tabPageBorrower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrower)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTicket.ResumeLayout(false);
            this.tabPageTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTicket;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblListOfBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPublishingDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lbl_Name_t1;
        private System.Windows.Forms.Label lblID_t1;
        private System.Windows.Forms.Button btnBookClearData;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.DateTimePicker dtpBookPublishingDate;
        private System.Windows.Forms.ComboBox cbBookCategory;
        private System.Windows.Forms.ComboBox cbBookPublisher;
        private System.Windows.Forms.ComboBox cbBookAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvBorrower;
        private System.Windows.Forms.Button btnBorrowerClearData;
        private System.Windows.Forms.Button btnBorrowerUpdate;
        private System.Windows.Forms.Button btnBorrowerDelete;
        private System.Windows.Forms.Button btnBorrowerAdd;
        private System.Windows.Forms.DateTimePicker dtpBorrowerDOB;
        private System.Windows.Forms.TextBox txtBorrowerName;
        private System.Windows.Forms.TextBox txtBorrowerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lbl_Name_t2;
        private System.Windows.Forms.Label lbl_ID_t2;
        private System.Windows.Forms.Label lblListOfTicket;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Button btnTicketClearData;
        private System.Windows.Forms.Button btnTicketUpdate;
        private System.Windows.Forms.Button btnTicketDelete;
        private System.Windows.Forms.Button btnTicketAdd;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.ComboBox cbTicketBorrower;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lbBorrower;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.ComboBox cbTicketBook;
        private System.Windows.Forms.TextBox txtBorrowerPhone;
        private System.Windows.Forms.TextBox txtBorrowerAddress;
        private System.Windows.Forms.TextBox txtBorrowerEmail;
    }
}