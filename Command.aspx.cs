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
    public partial class Command : System.Web.UI.Page
    {
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";

        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT commandes.N°,clients.Nom,livres.titre,livres.prix FROM clients,commandes,livres Where clients.NumClient = commandes.NumClient AND livres.Numlivre = commandes.NumLivre";
            OleDbDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}