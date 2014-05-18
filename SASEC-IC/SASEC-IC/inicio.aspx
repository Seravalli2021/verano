<%@ Page Title="" Language="C#" MasterPageFile="~/sasecMaster.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="SASEC_IC.inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='cssmenu'>
                <ul style="color: #449BAF; background-color: #314E6E; font-family: 'Segoe UI Emoji'; font-size: medium;">
                   <li class='active'><a href='inicio.aspx'><span>Inicio</span></a></li>
                   <li><a href='servicios.aspx'><span>Servicios</span></a></li>
                </ul>
    </div>
     <div id="caja1">
            <fieldset>
                <legend> Inicio de sesion</legend> 
               <div id="caja2">
                <fieldset>
                    <legend> Reseña </legend>
                    <h1 id="h1">Bienvenidos a SASEC-IC</h1>
                    <p id="parrafoInicio"> SASEC-IC  es una plataforma brinda la comodidad de realizar multiples labores, en el caso de los estudiantes facilita la comunicación y la interacción entre ka secretaria y los estudiantes,
                        facilitando así el proceso de asistencias de los estudiantes. Además brinda la facilidad, en el caso de la Secretaría de la escuela de computación de generar y controlar los diferentes memorándum
                        que se generen en la escuela.
                    </p> 
                    
   
                </fieldset>
               </div>
               
                <div id="caja3">
                    <fieldset >
                    <legend> Registro de Usuarios </legend>    
                    
                    <h3 id="h1">Cedula: 
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </h3>
&nbsp;<h3 id="h1">Contraseña: 
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                        </h3>
                        <br />
                        <asp:Button ID="btnAcepta" runat="server" OnClick="btnAcepta_Click" Text="Aceptar" />
                        <br />
                        <br />
                    <br/>
                    <a id="link" href='registroUsuario.aspx'>Registrarse</a>
                </fieldset>   
               </div>  
                 
            </fieldset>

        </div>
</asp:Content>
