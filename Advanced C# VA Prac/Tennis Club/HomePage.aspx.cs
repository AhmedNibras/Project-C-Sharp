using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Tennis_Club
{
    public partial class HomePage : System.Web.UI.Page
    {
        SqlConnection connection;
        public void Connect()
        {
            connection = new SqlConnection("");
            connection.Open();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Connect();
                ArrayList ar = new ArrayList();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select * from CoachDetails";
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ar.Add(reader.GetString(1));
                }
                drpList.DataSource = ar;
                drpList.DataBind();
                Disconnect();
            }
        }

        
        protected void drpList_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Connect();
                DataSet ds = new DataSet();
                string u = "Select * From CoachDetails Where Coach_Name = '" + drpList.SelectedItem.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(u, connection);
                adapter.Fill(ds, "CoachDetails");
                DataTable dt = ds.Tables["CoachDetails"];

                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                Disconnect();
            }
            catch(SqlException ex)
            {
                lbl_message2.Text = ex + "Error connecting to database";
            }

        }

        public void Disconnect()
        {
            connection.Close();
        }
    }
}