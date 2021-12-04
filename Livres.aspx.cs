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
    public partial class Livres : System.Web.UI.Page
    {
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";


        protected void Page_Load(object sender, EventArgs e)
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
            con.Close();

            String A = "";

            foreach (DataRow row in dt.Rows)
            {

                //WE LOOP AND SHOW SAME AS HOME PAGE

                A += "<div class=\"menu__card\">";
                A += "<div class=\"menu__card_des\"><h6>";
                A += row["titre"].ToString() + " " + row["prix"].ToString() + "$";
                A += "</h6>";
                A += "<div class=\"menu__btn\">";
                A += "<a href=Delete.aspx?id=" + row["Numlivre"];
                A += "><button  style=\"background-color:crimson\">Supprimer</button></a></div></div></div>";



            }

            menu__wrapper.Text = A;


        }

    }
}