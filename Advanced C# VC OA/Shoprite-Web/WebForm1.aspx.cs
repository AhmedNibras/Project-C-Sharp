using System;
using System.Data.SqlClient;


namespace Shoprite_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection connection;
        string selectedProduct = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Disconnect()
        {
            try
            {
                connection.Close();
            }
            catch
            {
                lbl_result.Text = ("Error occured while connecting to the database.");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                connection = new SqlConnection("Data Source=LAPTOP-B4QKB7DR\\SQLEXPRESS;Initial Catalog=Shoprite;Integrated Security=True");

                string q = "Insert into ProductDetails(prodName, prodType, prodQuant, prodPrice) values(@ProdName, @ProdType, @ProdQuant, @ProdPrice)";
                SqlCommand cmd = new SqlCommand(q, connection);

                cmd.Parameters.AddWithValue("@prodName", TextName.Text);
                cmd.Parameters.AddWithValue("@prodType", selectedProduct);
                cmd.Parameters.AddWithValue("@prodQuant", TextQuantity.Text);
                cmd.Parameters.AddWithValue("@prodPrice", TextPrice.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                lbl_result.Text = "You have sucessfully Registered";
                Disconnect();
            }

            catch (SqlException)
            {
                lbl_result.Text = "Error occur connecting to database";


            }
        }

        protected void RadioPriceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = RadioPriceType.SelectedItem.ToString();
        }
    }
}
