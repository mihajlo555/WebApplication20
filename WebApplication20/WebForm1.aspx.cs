using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace WebApplication20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=gradiliste;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); 
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    con.Open();

                    GridViewFill(con);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception Message: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("Stack Trace: " + ex.StackTrace);
            }
        }
        void GridViewFill(SqlConnection con)
        {
            string query = "SELECT * FROM Radnik";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();

            GridView1.DataSource = reader;

            GridView1.DataBind();

            reader.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "" && TextBox2.Text == "" && TextBox3.Text == "")
            {
                TextBox1.BorderColor = Color.Red;
                TextBox2.BorderColor = Color.Red;
                TextBox3.BorderColor = Color.Red;
            }
            else
            {
                using (con)
                {
                    con.Open();
                    string searchParameter = TextBox1.Text;
                    string searchParameter2 = TextBox1.Text;
                    string searchParameter3 = TextBox3.Text;
                    SqlParameter p = new SqlParameter();
                    SqlParameter p2 = new SqlParameter();
                    SqlParameter p3 = new SqlParameter();
                    p.Value = searchParameter;
                    p2.Value = searchParameter2;
                    p3.Value = searchParameter3;
                    p.ParameterName = "@searchParameter";
                    p2.ParameterName = "@searchParameter2";
                    p3.ParameterName = "@searchParameter3";
                    string query = "Update Radnik " +
                                   "Set Ime=@searchParameter,Prezime=@searchParameter1,DatumRodjenja=@searchParameter2  " +
                                   "Where RadnikID = 1 ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(p);
                    cmd.Parameters.Add(p2);
                    cmd.ExecuteNonQuery();
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";


                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text == "Sekula" && TextBox5.Text == "mrzimskolu")
            {
                Label1.Visible=true;
                Label2.Visible=true;
                TextBox1.Visible=true;
                Label3.Visible=true;
                TextBox2.Visible=true;
                Label4.Visible=true;
                TextBox3.Visible=true;
                Button1.Visible=true;
            }
        }
    }
}