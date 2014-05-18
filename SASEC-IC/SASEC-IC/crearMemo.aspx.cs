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
    public partial class crearMemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {   
                if((TextBox1.Text == "")||(TextBox2.Text == "")||(TextBox3.Text == "")||(TextBox4.Text == "")||(TextBox5.Text == "")||(TextArea1.Text == ""))
                {
                     string mensajeAlerta = @"<script type='text/javascript'> alert('favor llenar cada uno de los espacios correspondientes'); </script>";
                     Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta);
                }
                else{

                    string cadena = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
                    SqlConnection con = new SqlConnection(cadena);

                    string ad = "insert into Memo values(@consecutivo,@fecha,@para,@de,@asunto,@cuerpo)";
                    SqlCommand cmd = new SqlCommand(ad, con);

                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@consecutivo", SqlDbType.VarChar, 50).Value = TextBox1.Text;
                    cmd.Parameters.Add("@fecha", SqlDbType.VarChar, 50).Value = TextBox2.Text;
                    cmd.Parameters.Add("@para", SqlDbType.VarChar, 50).Value = TextBox3.Text;
                    cmd.Parameters.Add("@de", SqlDbType.VarChar, 50).Value = TextBox4.Text;
                    cmd.Parameters.Add("@asunto", SqlDbType.VarChar, 50).Value = TextBox5.Text;
                    cmd.Parameters.Add("@cuerpo", SqlDbType.VarChar,8000).Value = TextArea1.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    string mensajeAlerta1 = @"<script type='text/javascript'> alert('Memorando creado satisfactoriamente'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta1);
                }
            }
            catch
            {
                string mensajeAlerta2 = @"<script type='text/javascript'> alert('Error al crear Memorando'); </script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta2);
            }

           
        }
    }
}