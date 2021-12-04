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
    public partial class Achat : System.Web.UI.Page
    {

        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Id"] == null)
                Response.Redirect("Login.aspx");



            OleDbConnection con = new OleDbConnection(connection);
            DateTime dateTime = DateTime.UtcNow.Date;

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "SELECT * FROM commandes";

            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            int idC = 0;

            //We loop for each row in the DataBase
            foreach (DataRow row in dt.Rows)

            {
                //N°	NumLivre	NumClient	dateCommande	dateLivraison	quantites
                idC = Int32.Parse(row["N°"].ToString());
            }
            idC++;

                cmd.CommandText = "INSERT INTO commandes(N°,NumLivre,NumClient,dateCommande,dateLivraison,quantites) VALUES('"+idC + "','" + Request.QueryString["id"] + "','" + Session["Id"].ToString() + "','"+ dateTime.ToString("d") + "','"+ dateTime.ToString("d") + "','" +1+ "')";
            cmd.ExecuteNonQuery();
            //N°	NumLivre NumClient   dateCommande dateLivraison   quantites
            Label1.Text = "Product : " + Request.QueryString["id"] + " Client : " + Session["Id"].ToString();
            Response.Redirect("Panier.aspx");
            con.Close();

        }


    }
}