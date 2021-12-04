using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace BiB
{
    public partial class Delete : System.Web.UI.Page
    {

        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";

        protected void Page_Load(object sender, EventArgs e)
        {



            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM livres WHERE Numlivre=" + Request.QueryString["id"];
            cmd.ExecuteNonQuery();

            Response.Redirect("Livres.aspx");
        }

    }
}