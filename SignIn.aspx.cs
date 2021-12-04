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
    public partial class SignIn : System.Web.UI.Page
    {
        //SAME
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";

        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //WE TEST THAT ALL FILED IS NOT EMPTY
            if (TextBox1.Text == "")
                Label.Text = "<p style=\"color:red\">Username Vide </p>";
            else if (TextBox2.Text == "")
                Label.Text = "<p style=\"color:red\">Mail Vide </p>";
            else if (TextBox3.Text == "")
                Label.Text = "<p style=\"color:red\">Mot pass Vide </p>";
            else if (TextBox3.Text != TextBox4.Text)
                Label.Text = "<p style=\"color:red\">Mot pass 1 et 2 different </p>";
            
            else
            {
                //QUERY TO INSERT NEW USER
                OleDbConnection con = new OleDbConnection(connection);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM clients";
                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);


                int Cid=0;
                String A = "";
                //NumAuth	login	password	Numclient

                foreach (DataRow row in dt.Rows)
                {
                    Cid = Int32.Parse(row["NumClient"].ToString());
                }
                Cid++;
                DateTime dateTime = DateTime.UtcNow.Date;

                cmd.CommandText = "INSERT INTO Clients(NumClient,nom,dateInscription) VALUES('" + Cid + "','" + TextBox1.Text + "','" + dateTime.ToString("d") + "')";
                cmd.ExecuteNonQuery();
                //NumClient	nom	prenom	rue	ville	province	codePostal	tel	dateInscription

                int Aid =0;
                cmd.CommandText = "SELECT * FROM authentification";
                dr = cmd.ExecuteReader();

                dt = new DataTable();
                dt.Load(dr);
                foreach (DataRow row in dt.Rows)
                {
                    Aid = Int32.Parse(row["NumAuth"].ToString());
                }
                Aid++;

                //NumAuth	login	password	Numclient
                cmd.CommandText = "INSERT INTO authentification VALUES('" + Aid + "','" + TextBox1.Text + "','" + TextBox3.Text + "','" +Cid+ "')";
                cmd.ExecuteNonQuery();


             
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                Label.Text = "<p style=\"color:green\">Inscription succes </p>";
                con.Close();



            }
        }
    }
}