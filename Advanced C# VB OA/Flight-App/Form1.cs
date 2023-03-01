using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Flight_App
{
    public partial class Form1 : Form
    {
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a connection
                connection = new SqlConnection("Data Source=LAPTOP-B4QKB7DR\\SQLEXPRESS;Initial Catalog=Flight;Integrated Security=True");
                string query = "Insert into BookingDetails(Departure, Arrival, DeptDate, Name, IDNumber, Cell) values (@Departure, @Arrival, @DeptDate, @Name, @IDNumber, @Cell)";
                SqlCommand cmd = new SqlCommand(query, connection);
                //get detail from textboxes 
                cmd.Parameters.AddWithValue("@Departure", comboDeparture.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Arrival", comboArrival.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DeptDate", textDptDate.Text);
                cmd.Parameters.AddWithValue("@Name", textName.Text);
                cmd.Parameters.AddWithValue("@IDNumber", textIDNumber.Text);
                cmd.Parameters.AddWithValue("@Cell", textCell.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Product has been captured", "Capture Sucess");
                Disconnect();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Disconnect From Database");
            }
        }
    }
}
