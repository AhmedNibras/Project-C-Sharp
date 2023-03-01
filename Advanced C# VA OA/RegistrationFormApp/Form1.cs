using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        // Database Connection
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Data Source=LAPTOP-B4QKB7DR\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");


                string q = "Insert into RegistrationDetails(Degree, Name, Surname, Age, Cellnumber) values(@Degree, @Name, @Surname, @Age, @CellNumber)";
                SqlCommand cmd = new SqlCommand(q, connection);

                cmd.Parameters.AddWithValue("@Degree", cmbDegree.Text);
                cmd.Parameters.AddWithValue("@Name", textName.Text);
                cmd.Parameters.AddWithValue("@Surname", textSurname.Text);
                cmd.Parameters.AddWithValue("@Age", textAge.Text);
                cmd.Parameters.AddWithValue("@CellNumber", textCellNumber.Text);
                
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("You have Sucessfully Registed", "Sucess");

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
                MessageBox.Show("Disconnect form database");
            }
        }
    }   
}
