namespace d032310387_real
{
    partial class FormStock
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
            this.StockbtnBook = new System.Windows.Forms.Button();
            this.StockbtnAuthor = new System.Windows.Forms.Button();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecordedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admiralBookstoreDatabaseDataSet = new d032310387_real.AdmiralBookstoreDatabaseDataSet();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthID = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxBirth = new System.Windows.Forms.TextBox();
            this.txtBoxAuthID = new System.Windows.Forms.TextBox();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.stockTableAdapter = new d032310387_real.AdmiralBookstoreDatabaseDataSetTableAdapters.StockTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StockbtnBook
            // 
            this.StockbtnBook.Location = new System.Drawing.Point(648, 389);
            this.StockbtnBook.Name = "StockbtnBook";
            this.StockbtnBook.Size = new System.Drawing.Size(90, 23);
            this.StockbtnBook.TabIndex = 33;
            this.StockbtnBook.Text = "Form Book";
            this.StockbtnBook.UseVisualStyleBackColor = true;
            this.StockbtnBook.Click += new System.EventHandler(this.StockbtnBook_Click);
            // 
            // StockbtnAuthor
            // 
            this.StockbtnAuthor.Location = new System.Drawing.Point(648, 349);
            this.StockbtnAuthor.Name = "StockbtnAuthor";
            this.StockbtnAuthor.Size = new System.Drawing.Size(90, 23);
            this.StockbtnAuthor.TabIndex = 32;
            this.StockbtnAuthor.Text = "Form Author";
            this.StockbtnAuthor.UseVisualStyleBackColor = true;
            this.StockbtnAuthor.Click += new System.EventHandler(this.StockbtnAuthor_Click);
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AutoGenerateColumns = false;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.authorIDDataGridViewTextBoxColumn,
            this.iSBN13DataGridViewTextBoxColumn,
            this.quantityInStockDataGridViewTextBoxColumn,
            this.dateRecordedDataGridViewTextBoxColumn});
            this.dataGridViewBook.DataSource = this.stockBindingSource;
            this.dataGridViewBook.Location = new System.Drawing.Point(123, 38);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 45;
            this.dataGridViewBook.Size = new System.Drawing.Size(599, 173);
            this.dataGridViewBook.TabIndex = 31;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            this.iSBN13DataGridViewTextBoxColumn.Width = 110;
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            this.quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            this.quantityInStockDataGridViewTextBoxColumn.Width = 110;
            // 
            // dateRecordedDataGridViewTextBoxColumn
            // 
            this.dateRecordedDataGridViewTextBoxColumn.DataPropertyName = "DateRecorded";
            this.dateRecordedDataGridViewTextBoxColumn.HeaderText = "DateRecorded";
            this.dateRecordedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateRecordedDataGridViewTextBoxColumn.Name = "dateRecordedDataGridViewTextBoxColumn";
            this.dateRecordedDataGridViewTextBoxColumn.Width = 110;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.admiralBookstoreDatabaseDataSet;
            // 
            // admiralBookstoreDatabaseDataSet
            // 
            this.admiralBookstoreDatabaseDataSet.DataSetName = "AdmiralBookstoreDatabaseDataSet";
            this.admiralBookstoreDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(264, 291);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(47, 13);
            this.lblBirth.TabIndex = 30;
            this.lblBirth.Text = "ISBN-13";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(264, 266);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 13);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "AuthorID";
            // 
            // lblAuthID
            // 
            this.lblAuthID.AutoSize = true;
            this.lblAuthID.Location = new System.Drawing.Point(264, 236);
            this.lblAuthID.Name = "lblAuthID";
            this.lblAuthID.Size = new System.Drawing.Size(46, 13);
            this.lblAuthID.TabIndex = 28;
            this.lblAuthID.Text = "StockID";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(336, 259);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(138, 20);
            this.txtBoxName.TabIndex = 27;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // txtBoxBirth
            // 
            this.txtBoxBirth.Location = new System.Drawing.Point(336, 288);
            this.txtBoxBirth.Name = "txtBoxBirth";
            this.txtBoxBirth.Size = new System.Drawing.Size(138, 20);
            this.txtBoxBirth.TabIndex = 26;
            this.txtBoxBirth.TextChanged += new System.EventHandler(this.txtBoxBirth_TextChanged);
            // 
            // txtBoxAuthID
            // 
            this.txtBoxAuthID.Location = new System.Drawing.Point(336, 233);
            this.txtBoxAuthID.Name = "txtBoxAuthID";
            this.txtBoxAuthID.Size = new System.Drawing.Size(138, 20);
            this.txtBoxAuthID.TabIndex = 25;
            this.txtBoxAuthID.TextChanged += new System.EventHandler(this.txtBoxAuthID_TextChanged);
            // 
            // btnUpdt
            // 
            this.btnUpdt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdt.Location = new System.Drawing.Point(466, 368);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(94, 44);
            this.btnUpdt.TabIndex = 24;
            this.btnUpdt.Text = "Update";
            this.btnUpdt.UseVisualStyleBackColor = false;
            this.btnUpdt.Click += new System.EventHandler(this.btnUpdt_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.Location = new System.Drawing.Point(330, 368);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(94, 44);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(196, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 44);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Date Recorded";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Quantity in Stock";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(336, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 34;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.StockbtnBook);
            this.Controls.Add(this.StockbtnAuthor);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAuthID);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxBirth);
            this.Controls.Add(this.txtBoxAuthID);
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StockbtnBook;
        private System.Windows.Forms.Button StockbtnAuthor;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthID;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxBirth;
        private System.Windows.Forms.TextBox txtBoxAuthID;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private AdmiralBookstoreDatabaseDataSet admiralBookstoreDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private AdmiralBookstoreDatabaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecordedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}