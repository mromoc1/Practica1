using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Practica1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Practica1BD.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Open )
            {
                conexion.Close();
            }
            conexion.Open();
            Mostrar_BD();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Tablapersona values ('" + Nombre.Text+"','"+ApellidoP.Text+"','"+ApellidoM.Text+"')";
            cmd.ExecuteNonQuery();

            Nombre.Text = "";
            ApellidoM.Text = "";
            ApellidoP.Text = "";
            Mostrar_BD();
        }

        public void Mostrar_BD()
        {
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Tablapersona";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        } 
    }
}