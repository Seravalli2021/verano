<%@ Page Title="" Language="C#" MasterPageFile="~/sasecMaster.Master" AutoEventWireup="true" CodeBehind="verificarEstado.aspx.cs" Inherits="SASEC_IC.verificarEstado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .active {
            height: 27px;
            width: 131px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='cssmenu'>
      <ul style="color: #449BAF; background-color: #314E6E; font-family: 'Segoe UI Emoji'; font-size: medium;">
            <li ><a href='correo.aspx'><span>Enviar Correo</span></a></li>
            <li><a href='asistencia.aspx'><span>Realizar Solicitud</span></a></li>
            <li style="width: 208px" class='active'><a href='verificarEstado.aspx' style="width: 152px"><span>Verificar Solicitud</span></a></li>
      </ul>
    </div>
    <a id="link" href='inicio.aspx'>SALIR</a>
    <div >
        
        <fieldset id ="estado1">
            <legend>Favor ingresar los datos: </legend>
            <br />
            <asp:Label ID="Label1" runat="server" Text="(*) Ingrese su carnet:"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ver Estado" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Su solicitud se encuentra:"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
        </fieldset>

    </div>
</asp:Content>
