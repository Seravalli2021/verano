<%@ Page Title="" Language="C#" MasterPageFile="~/sasecMaster.Master" AutoEventWireup="true" CodeBehind="asistencia.aspx.cs" Inherits="SASEC_IC.asistencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div id='cssmenu'>
          <ul style="color: #449BAF; background-color: #314E6E; font-family: 'Segoe UI Emoji'; font-size: medium;">
                <li><a href='correo.aspx'><span>Enviar Correo</span></a></li>
                <li class='active'><a href='asistencia.aspx'><span>Realizar Solicitud</span></a></li>
                <li><a href='verificarEstado.aspx'><span>Verificar Solicitud</span></a></li>
          </ul>
    </div>
    <a id="link" href='inicio.aspx'>SALIR</a>

    <div id="tabla">
         
        <div id="segundoEncabezado">
            <h3> Nombramiento Asistente-Tutores</h3>
           
         </div>

        <div >
             <table border="1">
                 <tr> 
                     <td class="auto-style2"><h4>Escuela de Computación</h4></td>

                     <td class="auto-style1"> Fecha&nbsp; : 
                        <script>
                            var f = new Date();
                            document.write(f.getDate() + "/" + (f.getMonth() + 1) + "/" + f.getFullYear());
                        </script>  
                     </td>
                   </tr>

                 <tr>
                   <div id="tituloTabla">  <td class="auto-style2"> <h4>Información Personal</h4> </td> </div>
                     <td class="auto-style1">Carnet :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                         <asp:TextBox ID="TextBox1" runat="server" Width="193px"></asp:TextBox>
                         </br>
                         Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox2" runat="server" Width="194px"></asp:TextBox>
                         </br>
                         Carrera:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox3" runat="server" Width="194px"></asp:TextBox>
                         </br>
                         Correo Electrónico: &nbsp; &nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server" Height="20px" Width="195px"></asp:TextBox>
                         </br>
                         Número Teléfono:&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox5" runat="server" Height="21px" Width="192px"></asp:TextBox>
                         </br>
                         Número Identificación:&nbsp;
                         <asp:TextBox ID="TextBox6" runat="server" Height="19px" Width="195px"></asp:TextBox>
                         </br> 
                      </td>
                 </tr>


                 <tr>
                   <div id="tituloTabla">  <td class="auto-style2"> <h4> Cuenta Cliente (17 digitos) : </h4> </td> </div>
                      <td class="auto-style1">Número de Cuenta:&nbsp;
                          <asp:TextBox ID="TextBox7" runat="server" Width="198px"></asp:TextBox>
                          </br> 
                          <asp:DropDownList ID="DropDownList1" runat="server">
                              <asp:ListItem Selected="True">BCAC</asp:ListItem>
                              <asp:ListItem>BNCR</asp:ListItem>
                              <asp:ListItem>BP</asp:ListItem>
                          </asp:DropDownList>
                          <br />
                      </td>
                 </tr>

                 <tr>
                    <div id="tituloTabla">  <td class="auto-style2"><h4>Información de Labores de Asistencia</h4></td> </div>
                     <td class="auto-style1">Nombre de Funcionario a Asistir :&nbsp;
                         <asp:TextBox ID="TextBox8" runat="server" Width="182px"></asp:TextBox>
                         </br>
                         Actividades a Realizar :&nbsp; </br>
                          <asp:TextBox id="TextArea1" TextMode="multiline" Columns="50" Rows="5" runat="server" />
                 </tr>     

                 <tr>
                   <td class="auto-style2"><h4>Notas:</h4></td> 
                      <td class="auto-style1"> Nota curso a asistir:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                          <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                          </br>
                           Promedio ponderado semestre anterior:&nbsp;&nbsp; <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                      </td>
                 </tr>

                 <tr>
                  <div id="tituloTabla">   <td class="auto-style2"><h4>Fechas:</h4></td> </div>
                      <td class="auto-style1"> Fecha Inicio Semestre:&nbsp; 
                          <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                          </br>
                           Fecha Fin Semestre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                  
                     </td>
                 </tr>
         
             </table>
           
             <asp:Button ID="btnasistencia" runat="server" Text="Enviar Asistencia" OnClick="btnasistencia_Click" />    
           
       </div>
      
         <div id="requisitos">
            <fieldset>
                <legend> <strong> Requisitos:</strong> </legend>
                <ul>
                    <li> Promedio Ponderado no menor a <strong> 70 </strong> en el último semestre cursado</li>
                    <li> Laborar mínimo <strong>50 </strong> horas semestrales (exoneración total de los derechos
                        de estudio y al finalizar el semestre pago de las 50 horas a 425 colones la hora). </li>
                    <li><strong>Sólo deben tener una asistencia, en caso de tenr dos asistencias se pagará 
                        la que sea de mayor monto</strong></li>
                </ul>
            </fieldset>
        </div>                
       
    </div>
</asp:Content>
