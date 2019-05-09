namespace AddressBook
{
	partial class Form1
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
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Search = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.addressData = new AddressBook.AddressData();
			this.addressBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addressBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.addressBookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.addressBookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.addressBookBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtWork = new System.Windows.Forms.TextBox();
			this.txtMobile = new System.Windows.Forms.TextBox();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.workNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource4)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(77, 434);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(96, 34);
			this.btnEdit.TabIndex = 11;
			this.btnEdit.Text = "Edit Contact";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(198, 434);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(97, 34);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Add Contact";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(324, 434);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(110, 34);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Delete Contact";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(466, 434);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(110, 34);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Save Contact";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.workNumberDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.addressBookBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(24, 261);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(552, 150);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
			// 
			// Search
			// 
			this.Search.AutoSize = true;
			this.Search.Location = new System.Drawing.Point(21, 222);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(57, 17);
			this.Search.TabIndex = 16;
			this.Search.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(143, 222);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(392, 22);
			this.txtSearch.TabIndex = 17;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
			// 
			// addressData
			// 
			this.addressData.DataSetName = "AddressData";
			this.addressData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// addressBookBindingSource
			// 
			this.addressBookBindingSource.DataMember = "AddressBook";
			this.addressBookBindingSource.DataSource = this.addressData;
			// 
			// addressBookBindingSource1
			// 
			this.addressBookBindingSource1.DataMember = "AddressBook";
			this.addressBookBindingSource1.DataSource = this.addressData;
			// 
			// addressBookBindingSource2
			// 
			this.addressBookBindingSource2.DataMember = "AddressBook";
			this.addressBookBindingSource2.DataSource = this.addressData;
			// 
			// addressBookBindingSource3
			// 
			this.addressBookBindingSource3.DataMember = "AddressBook";
			this.addressBookBindingSource3.DataSource = this.addressData;
			// 
			// addressBookBindingSource4
			// 
			this.addressBookBindingSource4.DataMember = "AddressBook";
			this.addressBookBindingSource4.DataSource = this.addressData;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.txtSurname);
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Controls.Add(this.txtWork);
			this.panel1.Controls.Add(this.txtMobile);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(799, 205);
			this.panel1.TabIndex = 18;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 17);
			this.label5.TabIndex = 20;
			this.label5.Text = "Work Number:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 17);
			this.label4.TabIndex = 19;
			this.label4.Text = "Mobile Number:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 17);
			this.label3.TabIndex = 18;
			this.label3.Text = "Email Address:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Last Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 17);
			this.label1.TabIndex = 16;
			this.label1.Text = "First Name:";
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "FullName", true));
			this.txtName.Location = new System.Drawing.Point(143, 9);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(192, 22);
			this.txtName.TabIndex = 15;
			// 
			// txtSurname
			// 
			this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "LastName", true));
			this.txtSurname.Location = new System.Drawing.Point(143, 48);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(192, 22);
			this.txtSurname.TabIndex = 14;
			// 
			// txtEmail
			// 
			this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "EmailAddress", true));
			this.txtEmail.Location = new System.Drawing.Point(143, 88);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(192, 22);
			this.txtEmail.TabIndex = 13;
			// 
			// txtWork
			// 
			this.txtWork.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "WorkNumber", true));
			this.txtWork.Location = new System.Drawing.Point(143, 172);
			this.txtWork.Name = "txtWork";
			this.txtWork.Size = new System.Drawing.Size(192, 22);
			this.txtWork.TabIndex = 12;
			// 
			// txtMobile
			// 
			this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "MobileNumber", true));
			this.txtMobile.Location = new System.Drawing.Point(143, 131);
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.Size = new System.Drawing.Size(192, 22);
			this.txtMobile.TabIndex = 11;
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			// 
			// emailAddressDataGridViewTextBoxColumn
			// 
			this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
			this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
			this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
			// 
			// mobileNumberDataGridViewTextBoxColumn
			// 
			this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
			this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
			this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
			// 
			// workNumberDataGridViewTextBoxColumn
			// 
			this.workNumberDataGridViewTextBoxColumn.DataPropertyName = "WorkNumber";
			this.workNumberDataGridViewTextBoxColumn.HeaderText = "WorkNumber";
			this.workNumberDataGridViewTextBoxColumn.Name = "workNumberDataGridViewTextBoxColumn";
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 480);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.Search);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnEdit);
			this.Name = "Form1";
			this.Text = "Address Book";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource4)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label Search;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.BindingSource addressBookBindingSource;
		private AddressData addressData;
		private System.Windows.Forms.BindingSource addressBookBindingSource1;
		private System.Windows.Forms.BindingSource addressBookBindingSource2;
		private System.Windows.Forms.BindingSource addressBookBindingSource3;
		private System.Windows.Forms.BindingSource addressBookBindingSource4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtWork;
		private System.Windows.Forms.TextBox txtMobile;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn workNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
	}
}

