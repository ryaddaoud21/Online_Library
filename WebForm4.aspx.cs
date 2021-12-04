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
    public partial class WebForm4 : System.Web.UI.Page
    {

        //Here we connect to Database
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";


        protected void Page_Load(object sender, EventArgs e)
        {

            //Here we see if user is connected or not
            if(Session["Id"]!=null)
            {
                Button.Text = "Deconxion";
                Insc.Text = "Mon Profile";
            }


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

            String A = "";
            //We loop for each row in the DataBase
            foreach (DataRow row in dt.Rows)
            {
                //Here we show books from DB
                A += "<div class=\"menu__card\">";
                A += "<div class=\"menu__card_des\"><h6>";
                A +=  row["titre"].ToString() + " " + row["prix"].ToString()+"$";
                A += "</h6>";
                A += "<div class=\"menu__btn\">";
                A += "<a href=Achat.aspx?id="+row["Numlivre"];
                A += "><button>Ajouter au Panier</button></a></div></div></div>";


              
            }

            menu__wrapper.Text = A;


        }

        //here if the user is connected the connexion button will de deconxion 
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