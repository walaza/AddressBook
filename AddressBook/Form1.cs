using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AddressBook
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		static AddressData db;

		protected static AddressData Address
		{
			get
			{
				if (db == null)
					db = new AddressData();
				return db;
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			string fileName = string.Format("{0}//data.dat", Application.StartupPath);
			if (File.Exists(fileName))
				Address.AddressBook.ReadXml(fileName);
			addressBookBindingSource.DataSource = Address.AddressBook;
			panel1.Enabled = false;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			panel1.Enabled = true;
			txtMobile.Focus();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				panel1.Enabled = true;
				Address.AddressBook.AddAddressBookRow(Address.AddressBook.NewAddressBookRow());
				addressBookBindingSource.MoveLast();
				txtMobile.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Address.AddressBook.RejectChanges();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				addressBookBindingSource.EndEdit();
				Address.AddressBook.AcceptChanges();
				Address.AddressBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
				panel1.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Address.AddressBook.RejectChanges();
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				if (MessageBox.Show("Are you sure want to delete this contact?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					addressBookBindingSource.RemoveCurrent();
			}
		}

		private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!string.IsNullOrEmpty(txtSearch.Text))
			{
				var query = from s in Address.AddressBook
							where s.MobileNumber == txtSearch.Text || s.FullName.Contains(txtSearch.Text) || s.LastName == txtSearch.Text || s.EmailAddress == txtSearch.Text || s.WorkNumber == txtSearch.Text
							select s;
				dataGridView1.DataSource = query.ToList();
			}
			else
				dataGridView1.DataSource = addressBookBindingSource;
		}
	}
}
