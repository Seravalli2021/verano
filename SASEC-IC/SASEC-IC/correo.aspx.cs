using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Drawing;

namespace SASEC_IC
{
    public partial class correo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if((TextBox1.Text == "")||(TextBox2.Text == "")||(TextBox3.Text == "")||(TextBox4.Text == "")||(TextArea1.Text == ""))
                {
                    string mensajeAlerta = @"<script type='text/javascript'> alert('Correo No enviado'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta);
                }
                else
                {
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;

                    smtp.Credentials = new NetworkCredential(TextBox1.Text, TextBox2.Text);
                    MailMessage mail = new MailMessage(TextBox1.Text, TextBox3.Text, TextBox4.Text, TextArea1.Text);
                    smtp.Send(mail);

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextArea1.Text = "";

                    string mensajeAlerta1 = @"<script type='text/javascript'> alert('Correo Enviado Satisfactoriamente'); </script>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta1);
                }
            }
            catch
            {
                string mensajeAlerta1 = @"<script type='text/javascript'> alert('Imposible enviar el mensaje, favor intentar mas tarde.'); </script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", mensajeAlerta1);
            }

        }
    }
}