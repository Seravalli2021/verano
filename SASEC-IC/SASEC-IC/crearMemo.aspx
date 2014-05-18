<%@ Page Title="" Language="C#" MasterPageFile="~/sasecMaster.Master" AutoEventWireup="true" CodeBehind="crearMemo.aspx.cs" Inherits="SASEC_IC.crearMemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id='cssmenu'>
       <ul style="color: #449BAF; background-color: #314E6E; font-family: 'Segoe UI Emoji'; font-size: medium;">
           <li><a href='gestionarSolicitud.aspx' style="width: 153px"><span>Gestionar Solicitud</span></a></li>
           <li style="width: 215px" class='active'><a href='crearMemo.aspx' style="width: 168px"><span>Crear Memorandum</span></a></li>
           <li style="width: 217px"><a href='modificarMemo.aspx' style="width: 200px"><span>Modificar Memorandum</span></a></li>
           <li><a href='exportarMemo.aspx' style="width: 182px"><span>Exportar Memorandum</span></a></li>             
       </ul>
    </div>
    <a id="link" href='inicio.aspx'>SALIR</a>
    <div id="formMemo">
        <fieldset>
            <legend>Creación de Memorandums</legend>

            <div id="memo">
              <fieldset>
                    <legend>Memorandum Escuela de Computación</legend>
                    <h3 id="h1">MEMORANDO</h3> 
                    <div id="encaMemo">
                        <asp:Label ID="Label1" runat="server" Text="Numero de consecutivo:"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" Width="140px" style="margin-left: 13px"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Fecha:"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" Width="140px" style="margin-left: 18px" TextMode="DateTime"></asp:TextBox>
                    </div>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="De:"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 53px" Width="339px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Para:"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 40px" Width="334px"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Asunto:"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 21px" Width="518px"></asp:TextBox>
                    <br />
                    <asp:TextBox id="TextArea1" TextMode="multiline" Columns="5000" Rows="5000" runat="server" Height="333px" style="margin-left: 67px; margin-top: 37px" Width="879px" />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 453px" Text="Guardar" />
                    <br />
                    <br />

              </fieldset>

            </div>
        </fieldset>
    </div>
</asp:Content>
