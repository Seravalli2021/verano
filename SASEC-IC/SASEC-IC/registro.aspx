<%@ Page Title="" Language="C#" MasterPageFile="~/sasecMaster.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="SASEC_IC.registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='cssmenu'>
                <ul style="color: #449BAF; background-color: #314E6E; font-family: 'Segoe UI Emoji'; font-size: medium;">
                   
                   <li class='active'><a href='inicio.aspx'><span>Volver al Inicio</span></a></li>
                </ul>
    </div>
    
   
        <div id="registro">
            <div id="formularioRegistro">
             <fieldset>
                <legend>Registro de Usuarios</legend>
                      
                      <div id="formRegistro">

                          <asp:Label ID="lblNombre" runat="server" Text="( * ) Nombre:"></asp:Label>
                          <br />
                          <br />
                          <asp:TextBox ID="txtNombre" runat="server" Width="263px"></asp:TextBox>
                          <br />
                          <asp:Label ID="cedula" runat="server" Text="( * ) Cedula:"></asp:Label>
                          <br />
                          <br />
                          <asp:TextBox ID="txtCedula" runat="server" Width="260px"></asp:TextBox>
                          <br />
                          <asp:Label ID="lblPass" runat="server" Text="( * ) Contraseña:"></asp:Label>
                          <br />
                          <br />
                          <asp:TextBox ID="txtPass" runat="server" Width="257px"></asp:TextBox>
                          <br />
                          <asp:Label ID="lblTipo" runat="server" Text="( * ) Tipo:"></asp:Label>
                          <br />
                          <br />
                          <asp:DropDownList ID="drpTipo" runat="server">
                              <asp:ListItem>SuperUsuario</asp:ListItem>
                              <asp:ListItem>Administrador</asp:ListItem>
                              <asp:ListItem>Estudiante</asp:ListItem>
                          </asp:DropDownList>
                          <br />
                          <br />
                          <asp:Button ID="btnRegistro" runat="server" Text="Registrarse" OnClick="btnRegistro_Click" />


                      </div>

                      <div id="imagenRegistro">
                        <img id="imagenReg" border="0" src="imagenes/registro.png" alt="Pulpit rock">
                     </div>
      
             </fieldset>
            </div>
      </div>
     
</asp:Content>
