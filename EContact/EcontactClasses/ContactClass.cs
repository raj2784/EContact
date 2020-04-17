using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EContact.EcontactClasses
{
	class ContactClass
	{
		//Getter and Setter properties
		public int ContactId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
		public string Gender { get; set; }
		public string Address { get; set; }

		static string myconnectionstring = ConfigurationManager.ConnectionStrings["EcontactEntities"].ConnectionString;

		//Selecting Data fron DB
		public DataTable Select()
		{
			//step 1 DB Conncetion
			SqlConnection con = new SqlConnection(myconnectionstring);
			DataTable dt = new DataTable();
			try
			{//writing SQL query

				string sql = "SELECT * FROM tblContact";
				//Creating cmd using sql and con
				SqlCommand cmd = new SqlCommand(sql, con);
				//creating SQL DataAdapter using cmd
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				con.Open();
				adapter.Fill(dt);


			}
			catch (Exception ex)
			{

			}
			finally
			{
				con.Close();
			}
			return dt;
		}

		//inserting data into db

		public bool Insert(ContactClass model)
		{
			bool isSuccess = false;
			//step 1 connect DB
			SqlConnection con = new SqlConnection(myconnectionstring);
			try
			{//Create SQL Query to insert DATA
				string sql = "INSERT INTO tblContact (FirstName, LastName, Mobile, Email, Gender, Address) " +
					          "VALUES (@FirstName, @LastName, @Mobile, @Email, @Gender, @Address)";
				//Creat Sql Command using cmd and sql
				SqlCommand cmd = new SqlCommand(sql, con);
				//Create parameter to add Data
				cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
				cmd.Parameters.AddWithValue("@LastName", model.LastName);
				cmd.Parameters.AddWithValue("@Mobile", model.Mobile);
				cmd.Parameters.AddWithValue("@Email", model.Email);
				cmd.Parameters.AddWithValue("@Gender", model.Gender);
				cmd.Parameters.AddWithValue("@Address", model.Address);

				// open Connection
				con.Open();
				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					isSuccess = true;
				}
				else
				{
					isSuccess = false;
				}


			}
			catch (Exception ex)
			{

			}
			finally
			{
				con.Close();
			}
			return isSuccess;
		}
		// method to update DATA
		public bool Update(ContactClass model)
		{
			bool isSccess = false;
			SqlConnection con = new SqlConnection(myconnectionstring);
			try
			{
				// SQL Qery to update  data in DB
				string sql = "UPDATE tblContact SET FirstName=@FirstName, LastName=@LastName, Mobile=@Mobile, " +
					          "Email=@Email, Gender=@Gender, Address=@Address WHERE ContactId=@ContactId";
				//Crate Sql Command
				SqlCommand cmd = new SqlCommand(sql, con);
				//create parameter to update value
				cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
				cmd.Parameters.AddWithValue("@LastName", model.LastName);
				cmd.Parameters.AddWithValue("@Mobile", model.Mobile);
				cmd.Parameters.AddWithValue("@Email", model.Email);
				cmd.Parameters.AddWithValue("@Gender", model.Gender);
				cmd.Parameters.AddWithValue("@Address", model.Address);
				cmd.Parameters.AddWithValue("@ContactId", model.ContactId);
				//open db conncetion
				con.Open();
				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					isSccess = true;
				}
				else
				{
					isSccess = false;
				}
			}
			catch (Exception ex)
			{

			}
			finally
			{
				con.Close();
			}
			return isSccess;
		}
		//method to delete data frm DB
		public bool Delete(ContactClass model)
		{
			//create a default retun value and set its value to false
			bool isSuccess = false;
			//Create SQL connection 
			SqlConnection con = new SqlConnection(myconnectionstring);
			try
			{
				//Sql to Delte DATA from DB
				string sql = "DELETE FROM tblContact WHERE ContactId = @ContactId";
				//createSql command

				SqlCommand cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@ContactId", model.ContactId);
				con.Open();
				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					isSuccess = true;
				}
				else
				{
					isSuccess = false;
				}
			}
			catch (Exception ex)
			{

			}
			finally
			{
				con.Close();
			}

			return isSuccess;
		}


	}
}