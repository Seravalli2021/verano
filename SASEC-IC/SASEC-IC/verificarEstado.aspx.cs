using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SASEC_IC
{
    public partial class verificarEstado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text == "")
                {
                    string mensajeAlerta0 = @"<script type='text/javascript'> alert('Favor llenar todos los campos'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta0);
                }
                else
                {

                    SqlConnection Con;
                    SqlCommand Cmd;


                    Con = new SqlConnection();
                    Con.ConnectionString = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
                    Cmd = new SqlCommand("select estado from SOLICITUD_ASISTENCIA where carnet ='" + TextBox1.Text + "'", Con);
                    Con.Open();
                    SqlDataReader leer = Cmd.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        TextBox2.Text = leer["estado"].ToString();

                    }
                    else
                    {
                        string mensajeAlerta1 = @"<script type='text/javascript'> alert('Carnet No encontrado'); </script>";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta1);
                        TextBox1.Text = "";
                    }
                    Con.Close();
                }
            }
            catch
            {
                string mensajeAlerta2 = @"<script type='text/javascript'> alert('Favor insertar el numero de carnet correctamente'); </script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta2);
            }
        }
    }
}