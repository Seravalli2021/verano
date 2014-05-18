using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SASEC_IC
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcepta_Click(object sender, EventArgs e)
        {
            SqlConnection Con;
            SqlCommand Cmd;


            Con = new SqlConnection();
            Con.ConnectionString = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
            Cmd = new SqlCommand("select * from USUARIO where cedula ='" + TextBox1.Text + "'AND contraUsuario = '" + TextBox2.Text + "'", Con);
            Con.Open();
            SqlDataReader leer = Cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                if (leer["tipo"].ToString() == "SuperUsuario")
                {
                    Response.Redirect("registro.aspx");
                }
                else
                {
                    if (leer["tipo"].ToString() == "Administrador")
                    {
                        Response.Redirect("gestionarSolicitud.aspx");
                    }
                    else 
                    {
                        Response.Redirect("correo.aspx");
                    }
 
                }
                

            }
            else
            {
                string mensajeAlerta = @"<script type='text/javascript'> alert('Cédula y/o contraseña incorrecta'); </script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta);
                TextBox1.Text = "";
            }
            Con.Close();
        }
    }
}