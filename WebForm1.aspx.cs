using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace BiB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";

            string query = "select * from livres";
            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();



        }
    }
}