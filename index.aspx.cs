using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace database_connection
{
    public partial class index : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["stdKeyId"].ConnectionString;
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert student_table values(@stdid,@stdname,@stdclass,@stdsub)";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@stdid", TxtId.Text);
            cmd.Parameters.AddWithValue("@stdname", TxtName.Text);
            cmd.Parameters.AddWithValue("@stdclass", TxtClass.Text);
            cmd.Parameters.AddWithValue("@stdsub", TxtSub.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            TxtId.Text = string.Empty;
            TxtName.Text = string.Empty;
            TxtClass.Text = string.Empty;
            TxtSub.Text = string.Empty;
            TxtId.Focus();
            Display_Refactor();
           
        }

        protected void dispBtn_Click(object sender, EventArgs e)
        {
            Display_Refactor();
        }

        private void  Display_Refactor()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from student_table";
            cmd.Connection = con;
            SqlDataReader stdDataReader;
            stdDataReader = cmd.ExecuteReader();
            ListBox1.DataTextField = "stdName";
            ListBox1.DataValueField = "stdId";
            ListBox1.DataSource = stdDataReader;
            ListBox1.DataBind();
            stdDataReader.Close();
            cmd.Dispose();
        }
    }
}