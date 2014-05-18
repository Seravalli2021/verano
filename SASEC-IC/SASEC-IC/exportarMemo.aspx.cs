using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SASEC_IC
{
    public partial class exportarMemo : System.Web.UI.Page
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
            try
            {

                if (DropDownList1.Text == "")
                {
                    string mensajeAlerta0 = @"<script type='text/javascript'> alert('Favor cargar el listado'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta0);
                }
                else
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
                        string mensajeAlerta1 = @"<script type='text/javascript'> alert('No encontrado'); </script>";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta1);

                    }
                    Con.Close();
                }
            }
            catch {
                string mensajeAlerta2 = @"<script type='text/javascript'> alert('Error de carga, favor intentarlo de nuevo'); </script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta2);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text == "")
            {
                string mensajeAlerta1 = @"<script type='text/javascript'> alert('Favor llenar el campo con el nombre del documento a exportar'); </script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta1);
            }
            else
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("C:\\" + TextBox6.Text + ".pdf", FileMode.Create));
                doc.Open();

                
                /*titulo*/
                Paragraph enc = new Paragraph(" Memorando \n \n \n", FontFactory.GetFont("Arial", 24, iTextSharp.text.Font.BOLD));
                enc.Alignment = Element.ALIGN_CENTER;
                enc.Font = FontFactory.GetFont(FontFactory.COURIER_BOLD,24);

                /*fecha y consecutivo*/
                Paragraph confe = new Paragraph("Consecutivo: " + TextBox1.Text + "\n" + "Fecha: " + TextBox2.Text + "\n \n");
                confe.Alignment = Element.ALIGN_RIGHT;

                /* DE PARA*/
                Paragraph depara = new Paragraph("Para: " + TextBox3.Text + "\n" + "De: " + TextBox4.Text + "\n \n");
                depara.Alignment = Element.ALIGN_CENTER;
                /*Asunto*/
                Paragraph asunto = new Paragraph("Asunto: " + TextBox5.Text + "\n \n" + TextArea1.Text);
                asunto.Alignment = Element.ALIGN_JUSTIFIED;

               
                
                //Paragraph pr = new Paragraph("Consecutivo: " + TextBox1.Text + "\n" + "Fecha: " + TextBox2.Text + "\n \n" + "Para: " + TextBox3.Text + "\n" + "De: " + TextBox4.Text + "\n \n" + "Asunto: " + TextBox5.Text + "\n \n" + TextArea1.Text);
                doc.Add(enc);
                doc.Add(confe);
                doc.Add(depara);
                doc.Add(asunto);
                doc.Close();

                string mensajeAlerta2 = @"<script type='text/javascript'> alert('Documento creado satisfactoriamente'); </script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta2);

            }
        }
    }
}