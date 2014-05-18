using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

using System.Data;
using System.Configuration;



namespace SASEC_IC
{
    

    public partial class gestionarSolicitud : System.Web.UI.Page
    {
        public string id; 
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            SqlConnection Con;
            SqlCommand Cmd;


            Con = new SqlConnection();
            Con.ConnectionString = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
            Cmd = new SqlCommand("select * from SOLICITUD_ASISTENCIA where carnet ='" + DropDownList1.SelectedItem + "'", Con);
            Con.Open();
            SqlDataReader leer = Cmd.ExecuteReader();
            
            if (leer.Read() == true)
            {
                id = leer["idSolicitud"].ToString();
                TextBox1.Text = leer["carnet"].ToString();
                TextBox2.Text = leer["nombre"].ToString();
                TextBox3.Text = leer["carrera"].ToString();
                TextBox4.Text = leer["correoElectronico"].ToString();
                TextBox5.Text = leer["numTelefono"].ToString();
                TextBox6.Text = leer["cedula"].ToString();
                TextBox7.Text = leer["numcuenta"].ToString();
                TextBox13.Text = leer["banco"].ToString();
                TextBox8.Text = leer["nombreFuncionario"].ToString();
                TextArea1.Text = leer["actividades"].ToString();
                TextBox9.Text = leer["notaCurso"].ToString();
                TextBox10.Text = leer["promedio"].ToString();
                TextBox11.Text = leer["fechaInicio"].ToString();
                TextBox12.Text = leer["fechaFin"].ToString();
                lblIdent.Text = id;
                
            }
            else
            {
                Response.Write("<script language='javascript'>alert('no encontrado');</script>");
               
            }
            Con.Close();
  
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string pend = "Pendiente";
            SqlConnection Con;
            SqlCommand Cmd;
            SqlDataReader Dr;

            Con = new SqlConnection();
            Con.ConnectionString = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
            Con.Open();
            Cmd = new SqlCommand("select carnet from SOLICITUD_ASISTENCIA where estado ='" +  pend + "'", Con);
            Dr = Cmd.ExecuteReader();
            DropDownList1.Items.Clear();

            while (Dr.Read())
            {
                DropDownList1.Items.Add(Dr[0].ToString());

            }
            Dr.Close();
            Con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (DropDownList1.Text == "")
                {
                    string mensajeAlerta1 = @"<script type='text/javascript'> alert('Favor Cargar los datos antes de oprimir el boton'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta1);
                }
                else
                {
                    SqlConnection Con;
                    SqlCommand Cmd;

                    Con = new SqlConnection();
                    Con.ConnectionString = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
                    Cmd = new SqlCommand("UPDATE SOLICITUD_ASISTENCIA set estado = '" + DropDownList2.Text + "'WHERE idSolicitud = '" + lblIdent.Text + "'", Con);

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox13.Text = "";
                    TextBox8.Text = "";
                    TextArea1.Text = "";
                    TextBox10.Text = "";
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    Con.Open();

                    Cmd.ExecuteNonQuery();

                    Con.Close();

                    string mensajeAlerta = @"<script type='text/javascript'> alert('Solicitud gestionada correctamente'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta);
                }
            }
            catch
            {
                string mensajeAlerta3 = @"<script type='text/javascript'> alert('Error al gestionar solicitud, favor intentarlo de nuevo'); </script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta3);
            }
        }
    }
}