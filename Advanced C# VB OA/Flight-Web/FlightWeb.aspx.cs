using System;
using System.Data.SqlClient;


namespace Flight_Web
{
    public partial class FlightWeb : System.Web.UI.Page
    {
        SqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Book_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a connection

                connection = new SqlConnection("Data Source=LAPTOP-B4QKB7DR\\SQLEXPRESS;Initial Catalog=Flight;Integrated Security=True");
                string q = "Insert into BookingDetails(Departure, Arrival, DeptDate, Name, IDNumber, Cell) values (@Departure, @Arrival, @DeptDate, @Name, @IDNumber, @Cell)";
                SqlCommand cmd = new SqlCommand(q, connection);
                //get detail from textboxes 
                cmd.Parameters.AddWithValue("@Departure", DropDownDepart.Text);
                cmd.Parameters.AddWithValue("@Arrival", DropDownArrival.Text);
                cmd.Parameters.AddWithValue("@DeptDate", TextDate.Text);
                cmd.Parameters.AddWithValue("@Name", TextName.Text);
                cmd.Parameters.AddWithValue("@IDNumber", TextID.Text);
                cmd.Parameters.AddWithValue("@Cell", TextCell.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                lbl_result.Text = "Great news " + TextName.Text + " your booking has been confirmed";
                Disconnect();
            }
            catch (SqlException ex)
            {
                lbl_result.Text = ex.ToString() + "Error occured connecting to the database";
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
                lbl_result.Text = "Disconnect From Database";

            }
        }
    }
}