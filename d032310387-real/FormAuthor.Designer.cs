namespace d032310387_real
{
    partial class FormAuthor
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.txtBoxAuthID = new System.Windows.Forms.TextBox();
            this.txtBoxBirth = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblAuthID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.admiralBookstoreDatabaseDataSet = new d032310387_real.AdmiralBookstoreDatabaseDataSet();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new d032310387_real.AdmiralBookstoreDatabaseDataSetTableAdapters.AuthorTableAdapter();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(212, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.Location = new System.Drawing.Point(346, 345);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(94, 44);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnUpdt
            // 
            this.btnUpdt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdt.Location = new System.Drawing.Point(482, 345);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(94, 44);
            this.btnUpdt.TabIndex = 2;
            this.btnUpdt.Text = "Update";
            this.btnUpdt.UseVisualStyleBackColor = false;
            // 
            // txtBoxAuthID
            // 
            this.txtBoxAuthID.Location = new System.Drawing.Point(358, 229);
            this.txtBoxAuthID.Name = "txtBoxAuthID";
            this.txtBoxAuthID.Size = new System.Drawing.Size(138, 20);
            this.txtBoxAuthID.TabIndex = 3;
            this.txtBoxAuthID.TextChanged += new System.EventHandler(this.txtBoxAuthID_TextChanged);
            // 
            // txtBoxBirth
            // 
            this.txtBoxBirth.Location = new System.Drawing.Point(358, 306);
            this.txtBoxBirth.Name = "txtBoxBirth";
            this.txtBoxBirth.Size = new System.Drawing.Size(138, 20);
            this.txtBoxBirth.TabIndex = 4;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(358, 268);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(138, 20);
            this.txtBoxName.TabIndex = 5;
            // 
            // lblAuthID
            // 
            this.lblAuthID.AutoSize = true;
            this.lblAuthID.Location = new System.Drawing.Point(286, 232);
            this.lblAuthID.Name = "lblAuthID";
            this.lblAuthID.Size = new System.Drawing.Size(49, 13);
            this.lblAuthID.TabIndex = 6;
            this.lblAuthID.Text = "AuthorID";
            this.lblAuthID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(286, 275);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(286, 309);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(53, 13);
            this.lblBirth.TabIndex = 8;
            this.lblBirth.Text = "Birth Year";
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.AutoGenerateColumns = false;
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthYearDataGridViewTextBoxColumn});
            this.dataGridViewAuthor.DataSource = this.authorBindingSource;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(145, 34);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.RowHeadersWidth = 45;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(508, 173);
            this.dataGridViewAuthor.TabIndex = 9;
            // 
            // admiralBookstoreDatabaseDataSet
            // 
            this.admiralBookstoreDatabaseDataSet.DataSetName = "AdmiralBookstoreDatabaseDataSet";
            this.admiralBookstoreDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.admiralBookstoreDatabaseDataSet;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 110;
            // 
            // birthYearDataGridViewTextBoxColumn
            // 
            this.birthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.HeaderText = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthYearDataGridViewTextBoxColumn.Name = "birthYearDataGridViewTextBoxColumn";
            this.birthYearDataGridViewTextBoxColumn.Width = 110;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(671, 366);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(90, 23);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Form Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(671, 406);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(90, 23);
            this.btnStock.TabIndex = 11;
            this.btnStock.Text = "Form Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // FormAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dataGridViewAuthor);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAuthID);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxBirth);
            this.Controls.Add(this.txtBoxAuthID);
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormAuthor";
            this.Text = "FormAuthor";
            this.Load += new System.EventHandler(this.FormAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.TextBox txtBoxAuthID;
        private System.Windows.Forms.TextBox txtBoxBirth;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblAuthID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.DataGridView dataGridViewAuthor;
        private AdmiralBookstoreDatabaseDataSet admiralBookstoreDatabaseDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private AdmiralBookstoreDatabaseDataSetTableAdapters.AuthorTableAdapter authorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnStock;
    }
}