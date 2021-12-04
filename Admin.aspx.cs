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
    public partial class Admin : System.Web.UI.Page
    {

        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Test1.accdb";


        protected void Page_Load(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM clients";
            OleDbDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            int Clients = 0;

            foreach (DataRow row in dt.Rows)
            {
                Clients += 1;

            }

            Client.Text = Clients.ToString();


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM livres";

            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);

            int Books = 0;

            foreach (DataRow row in dt.Rows)
            {
                Books += 1;

            }

            Livre.Text = Books.ToString();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM commandes";

            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);


            int Comnd = 0;

            foreach (DataRow row in dt.Rows)
            {
                Comnd += 1;

            }

            Command.Text = Comnd.ToString();



        }

    }


}

