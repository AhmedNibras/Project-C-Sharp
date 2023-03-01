using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shoprite
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string selectedProduct = "";

        public Form1()
        {
            InitializeComponent();
        }

        // close the database connection
        

        private void capture_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Data Source=LAPTOP-B4QKB7DR\\SQLEXPRESS;Initial Catalog=Shoprite;Integrated Security=True");

                string q = "Insert into ProductDetails(prodName, prodType, prodQuant, prodPrice) values(@ProdName, @ProdType, @ProdQuant, @ProdPrice)";
                SqlCommand cmd = new SqlCommand(q, connection);

                cmd.Parameters.AddWithValue("@ProdName", textName.Text);
                cmd.Parameters.AddWithValue("@ProdType", selectedProduct);
                cmd.Parameters.AddWithValue("@ProdQuant", textQuantity.Text);
                cmd.Parameters.AddWithValue("@ProdPrice", textPrice.Text);

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

        private void radioFood_CheckedChanged(object sender, EventArgs e)
        {
            selectedProduct = radioFood.Text;
        }

        private void radioCosmetics_CheckedChanged(object sender, EventArgs e)
        {
            selectedProduct = radioCosmetics.Text;

        }

        private void radioElectronic_CheckedChanged(object sender, EventArgs e)
        {
            selectedProduct = radioElectronic.Text;

        }
    }
}
