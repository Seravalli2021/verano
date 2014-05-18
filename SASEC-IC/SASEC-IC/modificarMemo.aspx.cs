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
    public partial class modificarMemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con;
            SqlCommand Cmd;
            SqlDataReader Dr;

            Con = new SqlConnection();
            Con.ConnectionString = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
            Con.Open();
            Cmd = new SqlCommand("select consecutivo from Memo", Con);
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
            SqlConnection Con;
            SqlCommand Cmd;

            Con = new SqlConnection();
            Con.ConnectionString = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
            Cmd = new SqlCommand("select * from Memo where consecutivo ='" + DropDownList1.SelectedItem + "'", Con);
            Con.Open();
            SqlDataReader leer = Cmd.ExecuteReader();

            if (leer.Read() == true)
            {
                TextBox1.Text = leer["consecutivo"].ToString();
                TextBox2.Text = leer["fecha"].ToString();
                TextBox3.Text = leer["para"].ToString();
                TextBox4.Text = leer["de"].ToString();
                TextBox5.Text = leer["asunto"].ToString();
                TextArea1.Text = leer["cuerpo"].ToString();
                lblID.Text = leer["idMemo"].ToString();

            }
            else
            {
                Response.Write("<script language='javascript'>alert('no encontrado');</script>");

            }
            Con.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TextBox1.Text == "") || (TextBox2.Text == "") || (TextBox3.Text == "") || (TextBox4.Text == "") || (TextBox5.Text == "") || (TextArea1.Text == ""))
                {
                    string mensajeAlerta = @"<script type='text/javascript'> alert('favor llenar cada uno de los espacios correspondientes'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta);
                }
                else
                {

                    SqlConnection Con;
                    SqlCommand Cmd;

                    Con = new SqlConnection();
                    Con.ConnectionString = "Data Source=TOTHAN-PC;Initial Catalog=SASEC-IC_DB;Integrated Security=True";
                    string mod = "UPDATE Memo set consecutivo='" + TextBox1.Text + "',fecha ='" + TextBox2.Text + "', para ='" + TextBox3.Text + "', de ='" + TextBox4.Text + "', asunto ='" + TextBox5.Text + "', cuerpo ='" + TextArea1.Text + "'WHERE idMemo ='" + lblID.Text + "'";

                    Cmd = new SqlCommand(mod, Con);

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextArea1.Text = "";
                    Con.Open();

                    Cmd.ExecuteNonQuery();

                    Con.Close();
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