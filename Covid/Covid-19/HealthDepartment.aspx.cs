using System;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace Covid_19
{
    public partial class HealthDepartment : System.Web.UI.Page
    {
        SqlConnection connection;
        

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

            connection = new SqlConnection("Data Source=LAPTOP-B4QKB7DR\\SQLEXPRESS;Initial Catalog=Health;Integrated Security=True");
            string q = "Insert into tbl_patient(idnumber, name, age, vaccine) values(@IDNumber, @Name, @Age, @Vaccine)";

            SqlCommand cmd = new SqlCommand(q, connection);

            int age = Convert.ToInt32(textAge.Text);

                if (age < 18)
                {
                    lblResult.Text = "Sorry, Age must be older than 18";
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IDNumber", textID.Text);
                    cmd.Parameters.AddWithValue("@Name", textName.Text);
                    cmd.Parameters.AddWithValue("@Age", textAge.Text);
                    cmd.Parameters.AddWithValue("@Vaccine", RadioButtonList1.SelectedValue);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    lblResult.Text = "Congratulations, You have successfully registered.";
                    Disconnect();
                }
            }
            catch(SqlException ex)
            {
                lblResult.Text = "Error" + ex;
            }
        }
        public void Disconnect()
        {
            try
            {
                connection.Close();
            }
            catch
            {
                lblResult.Text = "Disconnect from the server";
            }

        }
    }
}