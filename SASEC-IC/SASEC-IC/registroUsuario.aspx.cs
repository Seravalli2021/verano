using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;


namespace SASEC_IC
{
    public partial class registroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNombre.Text == "") || (txtCedula.Text == "") || (txtPass.Text == ""))
                {
                    txtNombre.Text = "";
                    txtCedula.Text = "";
                    txtPass.Text = "";
                    string mensajeAlerta = @"<script type='text/javascript'> alert('favor llenar cada uno de los espacios correspondientes'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta);

                }
                else
                {
                    string cadena = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
                    SqlConnection con = new SqlConnection(cadena);

                    string ad = "insert into USUARIO values(@nombre,@cedula,@contraUsuario,@tipo)";
                    SqlCommand cmd = new SqlCommand(ad, con);

                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = txtNombre.Text;
                    cmd.Parameters.Add("@cedula", SqlDbType.VarChar, 50).Value = txtCedula.Text;
                    cmd.Parameters.Add("@contraUsuario", SqlDbType.VarChar, 50).Value = txtPass.Text;
                    cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 50).Value = "Estudiante";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    txtNombre.Text = "";
                    txtCedula.Text = "";
                    txtPass.Text = "";

                    string mensajeAlerta1 = @"<script type='text/javascript'> alert('Insercion satisfactoria'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta1);
                }
            }
            catch
            {
                string mensajeAlerta2 = @"<script type='text/javascript'> alert('La Insercion no se ha podido realizar, favor intentar de nuevo.'); </script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta2);
                txtNombre.Text = "";
                txtCedula.Text = "";
                txtPass.Text = "";
            }
        }
    }
}