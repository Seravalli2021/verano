<%@ Page Title="" Language="C#" MasterPageFile="~/sasecMaster.Master" AutoEventWireup="true" CodeBehind="gestionarSolicitud.aspx.cs" Inherits="SASEC_IC.gestionarSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .active {
            width: 204px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id='cssmenu'>
       <ul style="color: #449BAF; background-color: #314E6E; font-family: 'Segoe UI Emoji'; font-size: medium;">
           <li class='active'><a href='gestionarSolicitud.aspx' style="width: 153px" ><span>Gestionar Solicitud</span></a></li>
           <li style="width: 197px" ><a href='crearMemo.aspx' style="width: 182px"><span>Crear Memorandum</span></a></li>
           <li style="width: 217px"><a href='modificarMemo.aspx' style="width: 200px"><span>Modificar Memorandum</span></a></li>
           <li><a href='exportarMemo.aspx' style="width: 182px"><span>Exportar Memorandum</span></a></li>             
       </ul>
    </div>
    <a id="link" href='inicio.aspx'>SALIR</a>
    <div id="cuerpoGestion">
        <fieldset id="field1">
            <legend  id="h1"> Lista de Pendientes<br />
            </legend>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" style="margin-left: 171px; margin-top: 78px; margin-bottom: 38px" Text="Cargar Listado" />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="23px" style="margin-left: 107px" Width="218px">
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnVer" runat="server" Text="Ver Informacion" OnClick="btnVer_Click" style="height: 26px; margin-left: 162px; margin-top: 30px;" />
            <br />
            <br />
            <br /><br />
        </fieldset><fieldset id="field2">
            <legend  id="h1">Informacion de la solicitud</legend>
            <div id="tabla">
                <div id="segundoEncabezado">
                    <h3>Nombramiento Asistente-Tutores</h3>
                </div>
                <div id="h1">
                    <table border="1">
                        <tr>
                            <td class="auto-style2">
                                <h4>Escuela de Computación</h4>
                            </td>
                            <td class="auto-style1">Fecha&nbsp; : 
                <script>
                    var f = new Date();
                    document.write(f.getDate() + "/" + (f.getMonth() + 1) + "/" + f.getFullYear());
                </script>  
                            </td>
                        </tr>
                        <tr>
           <div id="tituloTabla">  
                            <td class="auto-style2">
                                <h4>Información Personal</h4>
                            </td>
                            </div>
                            <td class="auto-style1">Carnet :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox1" runat="server" Width="193px"></asp:TextBox>
                                <br />Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                <asp:TextBox ID="TextBox2" runat="server" Width="194px"></asp:TextBox>
                                <br />Carrera:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
                                <asp:TextBox ID="TextBox3" runat="server" Width="194px"></asp:TextBox>
                                <br />Correo Electrónico: &nbsp;&nbsp;&nbsp;&nbsp; 
                                <asp:TextBox ID="TextBox4" runat="server" Height="20px" Width="195px"></asp:TextBox>
                                <br />Número Teléfono:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:TextBox ID="TextBox5" runat="server" Height="21px" Width="192px"></asp:TextBox>
                                <br />Número Identificación:&nbsp;
                                <asp:TextBox ID="TextBox6" runat="server" Height="19px" Width="195px"></asp:TextBox>
                                <br /></td>
                        </tr>
                        <tr>
           <div id="tituloTabla">  
                            <td class="auto-style2">
                                <h4>Cuenta Cliente (17 digitos) : </h4>
                            </td>
                            </div>
                            <td class="auto-style1">Número de Cuenta:&nbsp;
                                <asp:TextBox ID="TextBox7" runat="server" Width="198px"></asp:TextBox>
                                <br />
                                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                                <br /></td>
                        </tr>
                        <tr>
            <div id="tituloTabla">  
                            <td class="auto-style2">
                                <h4>Información de Labores de Asistencia</h4>
                            </td>
                            </div>
                            <td class="auto-style1">Nombre de Funcionario a Asistir :&nbsp;
                                <asp:TextBox ID="TextBox8" runat="server" Width="182px"></asp:TextBox>
                                <br />Actividades a Realizar :&nbsp; 
                                <br />
                                <asp:TextBox id="TextArea1" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                            </tr>
                        <tr>
                            <td class="auto-style2">
                                <h4>Notas:</h4>
                            </td>
                            <td class="auto-style1">Nota curso a asistir:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                                <br />Promedio ponderado semestre anterior:&nbsp;&nbsp; 
                                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
          <div id="tituloTabla">   
                            <td class="auto-style2">
                                <h4>Fechas:</h4>
                            </td>
                            </div>
                            <td class="auto-style1">Fecha Inicio Semestre:&nbsp; 
                                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                                <br />Fecha Fin Semestre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                                <br /></td>
                        </tr>
                    </table>
                    <br />La solicitud numero&nbsp;&nbsp;
                    <asp:Label ID="lblIdent" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp; va a ser:<br />
                    <br />
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="22px" Width="154px">
                        <asp:ListItem>Aprobado</asp:ListItem>
                        <asp:ListItem>Rechazado</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Cambiar Estado" OnClick="Button2_Click" />
            </div>
        </fieldset>
     
    </div>
</asp:Content>
