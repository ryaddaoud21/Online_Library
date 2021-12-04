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
    public partial class ListDeLivres : System.Web.UI.Page
    {
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] != null)
            {
                Button.Text = "Deconxion";
                Insc.Text = "Mon Profile";
            }


            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;
            if (Request.QueryString["id"] == null)
            {
                cmd.CommandText = "SELECT * FROM livres";
            }
            else if(Request.QueryString["id"] == "0")
            {
                cmd.CommandText = "SELECT * FROM livres WHERE categorie='Informatique'";

            }
            else if (Request.QueryString["id"] == "1")
            {
                cmd.CommandText = "SELECT * FROM livres WHERE categorie='Affaires'";

            }
            else
            {

                cmd.CommandText = "SELECT * FROM livres WHERE categorie='Technologie'";


            }
            cmd.ExecuteNonQuery();
            OleDbDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            String A = "";

            foreach (DataRow row in dt.Rows)
            {



                A += "<div class=\"menu__card\">";
                A += "<div class=\"menu__card_des\"><h5>";
                A += row["titre"].ToString() + " " + row["prix"].ToString() + "$";
                A += "</h5>";
                A += "<div class=\"menu__btn\">";
                A += "<a href=Achat.aspx?id=" + row["Numlivre"];
                A += "><button>Ajouter au Panier</button></a></div></div></div>";



            }

            Label1.Text = A;


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Id"] != null)
            {
                Session["Id"] = null;
                Response.Redirect("WebForm4.aspx");

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}