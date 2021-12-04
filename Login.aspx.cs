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
    public partial class Login : System.Web.UI.Page
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
            cmd.CommandText = "SELECT * FROM authentification";
            OleDbDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            String A = "";
            //NumAuth	login	password	Numclient

            foreach (DataRow row in dt.Rows)
            {


                Session["Id"] = -1;

                //WE LOOP ALL DB AND TEST 
                 if (row["login"].ToString() ==TextBox1.Text && row["password"].ToString() == TextBox2.Text) {

                    Session["Id"] = row["NumAuth"];
                     Response.Redirect("WebForm4.aspx");
                    
                 }
                Label.Text = "<p style=\"color:red\">Incorrect Username or Mot pass </p>";


            }


        }
    }
}