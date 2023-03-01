using System;
using System.Data.SqlClient;

namespace Tennis_Club
{
    public partial class LoginPage : System.Web.UI.Page
    {

        SqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                textUsername.Focus();
            }
        }

        private void Connect()
        {
            connection = new SqlConnection("Data Source=LAPTOP-B4QKB7DR\\SQLEXPRESS;Initial Catalog=Coaches;Integrated Security=True");
            connection.Open();
        }

        protected void Disconnect()
        {
            try
            {

                connection.Close();
            }
            catch
            {
                lbl_message.Text = "Error in closing the connection";
            }
        }


        protected void Login_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a connection
                Connect();
                SqlCommand cmd = connection.CreateCommand();

                string query = "Select * From MemberDetails Where Username='" + textUsername.Text + "' and Password'" + textPassword.Text + "'";

                SqlDataReader row = cmd.ExecuteReader();
                if (row != null && row.HasRows)
                {
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    lbl_message.Text = "Username and Password is incorrect";
                }
                Disconnect();
            }
            catch (SqlException ex)
            {
                lbl_message.Text = ex.ToString() + "Error";
            }
        }
    }
}