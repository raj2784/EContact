using EContact.EcontactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EContact
{
	public partial class EContact : Form
	{
		public EContact()
		{
			InitializeComponent();
		}
		ContactClass cc = new ContactClass();
		private void EContact_Load(object sender, EventArgs e)
		{
			DataTable dt = cc.Select();
			dgvContactlist.DataSource = dt;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txtboxContactID_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//get value form input field
			cc.FirstName = txtboxFirstName.Text;
			cc.LastName = txtboxLastName.Text;
			cc.Mobile = txtboxMobile.Text;
			cc.Email = txtboxEmail.Text;
			cc.Gender = cmbGender.Text;
			cc.Address = txtboxAddress.Text;

			bool success = cc.Insert(cc);
			if (success == true)
			{
				MessageBox.Show("New contact Successfully Inserted!");
				Clear();
			}
			else
			{
				MessageBox.Show("Failed to Add new contact, Try Again!");
			}
			//loading Data to grid-view
			DataTable dt = cc.Select();
			dgvContactlist.DataSource = dt;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//get update from text boxes
			cc.ContactId = int.Parse(txtboxContactID.Text);
			cc.FirstName = txtboxFirstName.Text;
			cc.LastName = txtboxLastName.Text;
			cc.Mobile = txtboxMobile.Text;
			cc.Email = txtboxEmail.Text;
			cc.Gender = cmbGender.Text;
			cc.Address = txtboxAddress.Text;
			//to update data in DB
			bool success = cc.Update(cc);
			if (success == true)
			{
				MessageBox.Show("Contact has been Updated Successfully!");
				Clear();

			}
			else
			{
				MessageBox.Show("Failed to update Contact. please try again!");
			}
			//loading Data to grid-view
			DataTable dt = cc.Select();
			dgvContactlist.DataSource = dt;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//get contact Id form db
			cc.ContactId = Convert.ToInt32(txtboxContactID.Text);
			bool success = cc.Delete(cc);
			if(success == true)
			{
				MessageBox.Show("Contact Deleted Successfully!");
				Clear();
				//loading Data to grid-view
				DataTable dt = cc.Select();
				dgvContactlist.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Failed to Delete Contact. Please try Again!");
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		// method to clear all field
		public void Clear()
		{
			txtboxContactID.Text = "";
			txtboxFirstName.Text = "";
			txtboxLastName.Text = "";
			txtboxEmail.Text = "";
			cmbGender.Text = "";
			txtboxMobile.Text = "";
			txtboxAddress.Text = "";

		}

		private void dgvContactlist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			// get the data from grid view and load it to  the text box respectively

			int rowIndex = e.RowIndex;
			txtboxContactID.Text = dgvContactlist.Rows[rowIndex].Cells[0].Value.ToString();
			txtboxFirstName.Text = dgvContactlist.Rows[rowIndex].Cells[1].Value.ToString();
			txtboxLastName.Text = dgvContactlist.Rows[rowIndex].Cells[2].Value.ToString();
			txtboxMobile.Text = dgvContactlist.Rows[rowIndex].Cells[3].Value.ToString();
			txtboxEmail.Text = dgvContactlist.Rows[rowIndex].Cells[4].Value.ToString();
			cmbGender.Text = dgvContactlist.Rows[rowIndex].Cells[5].Value.ToString();
			txtboxAddress.Text = dgvContactlist.Rows[rowIndex].Cells[6].Value.ToString();

		}
		static string myconnectionstring = ConfigurationManager.ConnectionStrings["EcontactEntities"].ConnectionString;

		private void dgvContactlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void txtboxSearch_TextChanged(object sender, EventArgs e)
		{
			//Get the value from texbox
			string keyword = txtboxSearch.Text;

			SqlConnection con = new SqlConnection(myconnectionstring);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblContact WHERE FirstName " +
				"LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%'OR Email LIKE '%" + keyword + "%'" +
	          "OR Address LIKE '%" + keyword + "%' OR Gender LIKE '%" + keyword + "%' OR Mobile LIKE '%" + keyword + "%'", con);

			DataTable dt = new DataTable();
			sda.Fill(dt);
			dgvContactlist.DataSource = dt;
		}
	}
}
