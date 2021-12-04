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
    public partial class Ajouter : System.Web.UI.Page
    {
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";

        protected void Page_Load(object sender, EventArgs e)
        {
           


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "SELECT * FROM livres";
            OleDbDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);


            int Cid = 0;
            String A = "";
            //NumAuth	login	password	Numclient

            foreach (DataRow row in dt.Rows)
            {
                Cid = Int32.Parse(row["Numlivre"].ToString());
            }
            Cid++;

            cmd.CommandText = "INSERT INTO livres(Numlivres,titre,categorie,auteur,prix,edition) VALUES('" + Cid+ "','" + TextBox1.Text + "','" + Request.Form["SELECT"] + "','" + TextBox2.Text + "','" +TextBox3.Text + "','" + TextBox4.Text + "')";
            cmd.ExecuteNonQuery();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label.Text = "<p style=\"color:green\">Livre a ajouter avec  succes </p>";


        }
    }
}