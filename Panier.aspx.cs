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
    public partial class Panier : System.Web.UI.Page
    {

        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";


        protected void Page_Load(object sender, EventArgs e)
     
        
        
        {


            if (Session["Id"] != null)
            {
                Button.Text = "Deconxion";
                Insc.Text = "Mon Profile";
            }


            if (Session["Id"] == null)
                Response.Redirect("Login.aspx");



            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "SELECT * FROM commandes,livres,authentification WHERE authentification.NumAuth=" + Session["Id"] + " AND authentification.NumAuth = commandes.NumClient AND commandes.NumLivre = livres.NumLivre ";
            cmd.ExecuteNonQuery();

            //NumAuth	login	password	Numclient
            //N°	NumLivre	NumClient	dateCommande	dateLivraison	quantites
           //

            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            String A = "";
            float Prix = 0;
            foreach (DataRow row in dt.Rows)
            {

                Prix += float.Parse(row["prix"].ToString());

                A += "   <div class=\"cartItem row align - items - start\"><div class=\"col - 3 mb - 2\">";
                A += "<img class=\"w - 100\" src=\"Style/img/book1.jpg\" alt=\"art image\" height='180px'> </div><div class=\"col - 5 mb - 2\">";


                A += "<h6 >"+row["titre"]+ "</h6> <p class=\"pl - 1 mb - 0\">"+row["auteur"] +"</p>";
                A += " <p class=\"pl - 1 mb - 0\">"+row["edition"]+"</p> </div> <div class=\"col - 2\">";
                A += "<p class=\"cartItemQuantity p-1 text-center\">1</p></div>";
                A += "<div class=\"col - 2\"> <p id=\"cartItem1Price\">" + row["prix"] + "$</p>";
                A += "</div></div><hr><br>";



            }

            Label.Text = A;
            Total.Text = Prix.ToString()+"$";
            TOTAL1.Text = Prix.ToString() + "$";

            /*
          
    
             
                           $66
                        </div>
                    </div>

             
             
             */
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