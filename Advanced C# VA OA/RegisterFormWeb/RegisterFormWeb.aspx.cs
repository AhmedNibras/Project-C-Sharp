using System;
using System.Data.SqlClient;


namespace RegisterFormWeb
{
    public partial class RegisterFormWeb : System.Web.UI.Page
    {
        SqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Data Source=LAPTOP-B4QKB7DR\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");

                string q = "Insert into RegistrationDetails(Degree, Name, Surname, Age, Cellnumber) values(@Degree, @Name, @Surname, @Age, @CellNumber)";
                SqlCommand cmd = new SqlCommand(q, connection);

                cmd.Parameters.AddWithValue("@Degree", dropDegree.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@CellNumber", txtCellNumber.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                lbl_message.Text = "You have sucessfully Registered";
                Disconnect();
            }

            catch (SqlException)
            {
                lbl_message.Text = "Error occur connecting to database";

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
                lbl_message.Text = ("Error occured while connecting to the database.");
            }
        }

    }
}