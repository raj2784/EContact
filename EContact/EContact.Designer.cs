namespace EContact
{
	partial class EContact
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
			this.lblContactID = new System.Windows.Forms.Label();
			this.txtboxContactID = new System.Windows.Forms.TextBox();
			this.txtboxEmail = new System.Windows.Forms.TextBox();
			this.txtboxMobile = new System.Windows.Forms.TextBox();
			this.txtboxLastName = new System.Windows.Forms.TextBox();
			this.txtboxFirstName = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblMobile = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtboxAddress = new System.Windows.Forms.TextBox();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.lblGender = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.dgvContactlist = new System.Windows.Forms.DataGridView();
			this.lblSearch = new System.Windows.Forms.Label();
			this.txtboxSearch = new System.Windows.Forms.TextBox();
			this.closebutton = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvContactlist)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblContactID
			// 
			this.lblContactID.AutoSize = true;
			this.lblContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContactID.Location = new System.Drawing.Point(85, 197);
			this.lblContactID.Name = "lblContactID";
			this.lblContactID.Size = new System.Drawing.Size(104, 25);
			this.lblContactID.TabIndex = 1;
			this.lblContactID.Text = "Contact ID";
			this.lblContactID.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtboxContactID
			// 
			this.txtboxContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxContactID.Location = new System.Drawing.Point(266, 194);
			this.txtboxContactID.Name = "txtboxContactID";
			this.txtboxContactID.ReadOnly = true;
			this.txtboxContactID.Size = new System.Drawing.Size(289, 30);
			this.txtboxContactID.TabIndex = 2;
			this.txtboxContactID.TextChanged += new System.EventHandler(this.txtboxContactID_TextChanged);
			// 
			// txtboxEmail
			// 
			this.txtboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxEmail.Location = new System.Drawing.Point(266, 401);
			this.txtboxEmail.Name = "txtboxEmail";
			this.txtboxEmail.Size = new System.Drawing.Size(289, 30);
			this.txtboxEmail.TabIndex = 3;
			// 
			// txtboxMobile
			// 
			this.txtboxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxMobile.Location = new System.Drawing.Point(266, 348);
			this.txtboxMobile.Name = "txtboxMobile";
			this.txtboxMobile.Size = new System.Drawing.Size(289, 30);
			this.txtboxMobile.TabIndex = 4;
			// 
			// txtboxLastName
			// 
			this.txtboxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxLastName.Location = new System.Drawing.Point(266, 293);
			this.txtboxLastName.Name = "txtboxLastName";
			this.txtboxLastName.Size = new System.Drawing.Size(289, 30);
			this.txtboxLastName.TabIndex = 5;
			// 
			// txtboxFirstName
			// 
			this.txtboxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxFirstName.Location = new System.Drawing.Point(266, 244);
			this.txtboxFirstName.Name = "txtboxFirstName";
			this.txtboxFirstName.Size = new System.Drawing.Size(289, 30);
			this.txtboxFirstName.TabIndex = 6;
			this.txtboxFirstName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(85, 401);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(68, 25);
			this.lblEmail.TabIndex = 7;
			this.lblEmail.Text = "E-Mail";
			this.lblEmail.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// lblMobile
			// 
			this.lblMobile.AutoSize = true;
			this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMobile.Location = new System.Drawing.Point(85, 348);
			this.lblMobile.Name = "lblMobile";
			this.lblMobile.Size = new System.Drawing.Size(70, 25);
			this.lblMobile.TabIndex = 8;
			this.lblMobile.Text = "Mobile";
			this.lblMobile.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastName.Location = new System.Drawing.Point(85, 293);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(106, 25);
			this.lblLastName.TabIndex = 9;
			this.lblLastName.Text = "Last Name";
			this.lblLastName.Click += new System.EventHandler(this.label3_Click);
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstName.Location = new System.Drawing.Point(85, 244);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(106, 25);
			this.lblFirstName.TabIndex = 10;
			this.lblFirstName.Text = "First Name";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.Location = new System.Drawing.Point(85, 495);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(85, 25);
			this.lblAddress.TabIndex = 11;
			this.lblAddress.Text = "Address";
			// 
			// txtboxAddress
			// 
			this.txtboxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxAddress.Location = new System.Drawing.Point(266, 495);
			this.txtboxAddress.Multiline = true;
			this.txtboxAddress.Name = "txtboxAddress";
			this.txtboxAddress.Size = new System.Drawing.Size(289, 108);
			this.txtboxAddress.TabIndex = 12;
			// 
			// cmbGender
			// 
			this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.cmbGender.Location = new System.Drawing.Point(266, 448);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(289, 33);
			this.cmbGender.TabIndex = 13;
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGender.Location = new System.Drawing.Point(85, 447);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(77, 25);
			this.lblGender.TabIndex = 14;
			this.lblGender.Text = "Gender";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdd.Location = new System.Drawing.Point(70, 687);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(123, 47);
			this.btnAdd.TabIndex = 15;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(250, 687);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(103, 47);
			this.btnUpdate.TabIndex = 16;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Red;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.Location = new System.Drawing.Point(408, 687);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(109, 47);
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Yellow;
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(574, 687);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(103, 47);
			this.btnClear.TabIndex = 18;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// dgvContactlist
			// 
			this.dgvContactlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContactlist.Location = new System.Drawing.Point(602, 244);
			this.dgvContactlist.Name = "dgvContactlist";
			this.dgvContactlist.RowHeadersWidth = 51;
			this.dgvContactlist.RowTemplate.Height = 24;
			this.dgvContactlist.Size = new System.Drawing.Size(856, 359);
			this.dgvContactlist.TabIndex = 19;
			this.dgvContactlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactlist_CellContentClick);
			this.dgvContactlist.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactlist_RowHeaderMouseClick);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.BackColor = System.Drawing.Color.Transparent;
			this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(602, 194);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(75, 25);
			this.lblSearch.TabIndex = 20;
			this.lblSearch.Text = "Search";
			// 
			// txtboxSearch
			// 
			this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtboxSearch.Location = new System.Drawing.Point(683, 194);
			this.txtboxSearch.Name = "txtboxSearch";
			this.txtboxSearch.Size = new System.Drawing.Size(775, 30);
			this.txtboxSearch.TabIndex = 21;
			this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
			// 
			// closebutton
			// 
			this.closebutton.Image = global::EContact.Properties.Resources.CloseIcon;
			this.closebutton.Location = new System.Drawing.Point(1435, 1);
			this.closebutton.Name = "closebutton";
			this.closebutton.Size = new System.Drawing.Size(75, 62);
			this.closebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.closebutton.TabIndex = 22;
			this.closebutton.TabStop = false;
			this.closebutton.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::EContact.Properties.Resources.E_Contact;
			this.pictureBox1.Location = new System.Drawing.Point(602, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(299, 103);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// EContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1508, 805);
			this.Controls.Add(this.closebutton);
			this.Controls.Add(this.txtboxSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.dgvContactlist);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.cmbGender);
			this.Controls.Add(this.txtboxAddress);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblMobile);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtboxFirstName);
			this.Controls.Add(this.txtboxLastName);
			this.Controls.Add(this.txtboxMobile);
			this.Controls.Add(this.txtboxEmail);
			this.Controls.Add(this.txtboxContactID);
			this.Controls.Add(this.lblContactID);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EContact";
			this.Text = " EContact";
			this.Load += new System.EventHandler(this.EContact_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvContactlist)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblContactID;
		private System.Windows.Forms.TextBox txtboxContactID;
		private System.Windows.Forms.TextBox txtboxEmail;
		private System.Windows.Forms.TextBox txtboxMobile;
		private System.Windows.Forms.TextBox txtboxLastName;
		private System.Windows.Forms.TextBox txtboxFirstName;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblMobile;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtboxAddress;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DataGridView dgvContactlist;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox txtboxSearch;
		private System.Windows.Forms.PictureBox closebutton;
	}
}

