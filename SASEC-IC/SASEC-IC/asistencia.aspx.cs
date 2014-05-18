using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace SASEC_IC
{
    public partial class asistencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnasistencia_Click(object sender, EventArgs e)
        {

            try
            {
                if((TextBox1.Text == "")||(TextBox2.Text == "")||(TextBox3.Text == "")||(TextBox4.Text == "")||(TextBox5.Text == "")||
                    (TextBox6.Text == "")||(TextBox7.Text == "")||(TextBox8.Text == "")||(TextBox9.Text == "")||(TextBox10.Text == "")||
                    (TextBox11.Text == "")||(TextBox12.Text == "")||(TextArea1.Text == ""))
                {
                    string mensajeAlerta = @"<script type='text/javascript'> alert('Favor llenar cada uno de los espacios correspondientes'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta);
                }
                else
                {
                    string cadena = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
                    SqlConnection con = new SqlConnection(cadena);

                    string ad = "insert into SOLICITUD_ASISTENCIA values(@fecha,@carnet,@nombre,@carrera,@correoElectronico,@numTelefono,@cedula,@numCuenta,@banco,@nombreFuncionario,@actividades,@notaCurso,@promedio,@fechaInicio,@fechaFin,@estado)";
                    SqlCommand cmd = new SqlCommand(ad, con);

                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now; 
                    cmd.Parameters.Add("@carnet", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = TextBox2.Text;
                    cmd.Parameters.Add("@carrera", SqlDbType.VarChar, 50).Value = TextBox3.Text;
                    cmd.Parameters.Add("@correoElectronico", SqlDbType.VarChar, 50).Value = TextBox4.Text;
                    cmd.Parameters.Add("@numTelefono", SqlDbType.VarChar, 50).Value = TextBox5.Text;
                    cmd.Parameters.Add("@cedula", SqlDbType.Int).Value = Convert.ToInt32(TextBox6.Text);
                    cmd.Parameters.Add("@numcuenta", SqlDbType.VarChar, 50).Value = TextBox7.Text;
                    cmd.Parameters.Add("@banco", SqlDbType.VarChar, 50).Value = DropDownList1.Text;
                    cmd.Parameters.Add("@nombreFuncionario", SqlDbType.VarChar, 50).Value = TextBox8.Text;
                    cmd.Parameters.Add("@actividades", SqlDbType.VarChar, 50).Value = TextArea1.Text;
                    cmd.Parameters.Add("@notaCurso", SqlDbType.Float).Value = System.Convert.ToSingle(TextBox9.Text);
                    cmd.Parameters.Add("@promedio", SqlDbType.Float).Value = System.Convert.ToSingle(TextBox10.Text);
                    cmd.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = TextBox11.Text;
                    cmd.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = TextBox12.Text;
                    cmd.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = "Pendiente";
                    cmd.ExecuteNonQuery();

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                    TextBox9.Text = "";
                    TextBox10.Text = "";
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    TextArea1.Text = "";
                    con.Close();

                    string mensajeAlerta1 = @"<script type='text/javascript'> alert('Solicitud registrada satisfactoriamente'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta1);

                }
            }
            catch (Exception exc)
            {
                string mensajeAlerta2 = @"<script type='text/javascript'> alert('Error al ingresar solicitud'); </script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta2);

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                TextBox11.Text = "";
                TextBox12.Text = "";
                TextArea1.Text = "";
            }
            
        }
    }
}