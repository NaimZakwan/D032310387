namespace d032310387_real
{
    partial class FormBook
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.lblPubDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPubDate = new System.Windows.Forms.TextBox();
            this.txtBoxAuthID = new System.Windows.Forms.TextBox();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BookbtnStock = new System.Windows.Forms.Button();
            this.BookbtnAuthor = new System.Windows.Forms.Button();
            this.admiralBookstoreDatabaseDataSet = new d032310387_real.AdmiralBookstoreDatabaseDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new d032310387_real.AdmiralBookstoreDatabaseDataSetTableAdapters.BookTableAdapter();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPub = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AutoGenerateColumns = false;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBN13DataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.publishDateDataGridViewTextBoxColumn});
            this.dataGridViewBook.DataSource = this.bookBindingSource;
            this.dataGridViewBook.Location = new System.Drawing.Point(146, 48);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 45;
            this.dataGridViewBook.Size = new System.Drawing.Size(513, 173);
            this.dataGridViewBook.TabIndex = 19;
            // 
            // lblPubDate
            // 
            this.lblPubDate.AutoSize = true;
            this.lblPubDate.Location = new System.Drawing.Point(287, 323);
            this.lblPubDate.Name = "lblPubDate";
            this.lblPubDate.Size = new System.Drawing.Size(67, 13);
            this.lblPubDate.TabIndex = 18;
            this.lblPubDate.Text = "Publish Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(287, 276);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Title";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(287, 246);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(47, 13);
            this.lblISBN.TabIndex = 16;
            this.lblISBN.Text = "ISBN-13";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(359, 269);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(138, 20);
            this.txtTitle.TabIndex = 15;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtPubDate
            // 
            this.txtPubDate.Location = new System.Drawing.Point(359, 320);
            this.txtPubDate.Name = "txtPubDate";
            this.txtPubDate.Size = new System.Drawing.Size(138, 20);
            this.txtPubDate.TabIndex = 14;
            this.txtPubDate.TextChanged += new System.EventHandler(this.txtPubDate_TextChanged);
            // 
            // txtBoxAuthID
            // 
            this.txtBoxAuthID.Location = new System.Drawing.Point(359, 243);
            this.txtBoxAuthID.Name = "txtBoxAuthID";
            this.txtBoxAuthID.Size = new System.Drawing.Size(138, 20);
            this.txtBoxAuthID.TabIndex = 13;
            this.txtBoxAuthID.TextChanged += new System.EventHandler(this.txtBoxAuthID_TextChanged);
            // 
            // btnUpdt
            // 
            this.btnUpdt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdt.Location = new System.Drawing.Point(483, 359);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(94, 44);
            this.btnUpdt.TabIndex = 12;
            this.btnUpdt.Text = "Update";
            this.btnUpdt.UseVisualStyleBackColor = false;
            this.btnUpdt.Click += new System.EventHandler(this.btnUpdt_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.Location = new System.Drawing.Point(347, 359);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(94, 44);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(213, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 44);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // BookbtnStock
            // 
            this.BookbtnStock.Location = new System.Drawing.Point(671, 399);
            this.BookbtnStock.Name = "BookbtnStock";
            this.BookbtnStock.Size = new System.Drawing.Size(90, 23);
            this.BookbtnStock.TabIndex = 21;
            this.BookbtnStock.Text = "Form Stock";
            this.BookbtnStock.UseVisualStyleBackColor = true;
            this.BookbtnStock.Click += new System.EventHandler(this.BookbtnStock_Click);
            // 
            // BookbtnAuthor
            // 
            this.BookbtnAuthor.Location = new System.Drawing.Point(671, 359);
            this.BookbtnAuthor.Name = "BookbtnAuthor";
            this.BookbtnAuthor.Size = new System.Drawing.Size(90, 23);
            this.BookbtnAuthor.TabIndex = 20;
            this.BookbtnAuthor.Text = "Form Author";
            this.BookbtnAuthor.UseVisualStyleBackColor = true;
            this.BookbtnAuthor.Click += new System.EventHandler(this.BookbtnAuthor_Click);
            // 
            // admiralBookstoreDatabaseDataSet
            // 
            this.admiralBookstoreDatabaseDataSet.DataSetName = "AdmiralBookstoreDatabaseDataSet";
            this.admiralBookstoreDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.admiralBookstoreDatabaseDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            this.iSBN13DataGridViewTextBoxColumn.Width = 110;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 110;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 110;
            // 
            // publishDateDataGridViewTextBoxColumn
            // 
            this.publishDateDataGridViewTextBoxColumn.DataPropertyName = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.HeaderText = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publishDateDataGridViewTextBoxColumn.Name = "publishDateDataGridViewTextBoxColumn";
            this.publishDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(287, 301);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(50, 13);
            this.lblPublisher.TabIndex = 23;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtPub
            // 
            this.txtPub.Location = new System.Drawing.Point(359, 294);
            this.txtPub.Name = "txtPub";
            this.txtPub.Size = new System.Drawing.Size(138, 20);
            this.txtPub.TabIndex = 22;
            this.txtPub.TextChanged += new System.EventHandler(this.txtPub_TextChanged);
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.txtPub);
            this.Controls.Add(this.BookbtnStock);
            this.Controls.Add(this.BookbtnAuthor);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.lblPubDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtPubDate);
            this.Controls.Add(this.txtBoxAuthID);
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormBook";
            this.Text = "FormBook";
            this.Load += new System.EventHandler(this.FormBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Label lblPubDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPubDate;
        private System.Windows.Forms.TextBox txtBoxAuthID;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BookbtnStock;
        private System.Windows.Forms.Button BookbtnAuthor;
        private AdmiralBookstoreDatabaseDataSet admiralBookstoreDatabaseDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private AdmiralBookstoreDatabaseDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtPub;
    }
}