<%@ Page Title="" Language="C#" MasterPageFile="~/sasecMaster.Master" AutoEventWireup="true" CodeBehind="servicios.aspx.cs" Inherits="SASEC_IC.servicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id='cssmenu'>
                <ul style="color: #449BAF; background-color: #314E6E; font-family: 'Segoe UI Emoji'; font-size: medium;">
                   <li><a href='inicio.aspx'><span>Inicio</span></a></li>
                   <li class='active'><a href='servicios.aspx'><span>Servicios</span></a></li>
                </ul>
    </div>



        <div id="caja1">
            <div id="caja2">
                <fieldset id="fieldServicios">
                    <legend>Servicios Administrativos</legend>
                        <h4 id="h1">Crear Memorándums</h4>
                        <p id="parrafoServicio">Herramienta para crear memorandums oficiales de la Escuela de Computación. </br> En esta seccion se puede crear un
                            memo con las partes oficiales requeridas por el ITCR. </p>
                        
                         </br>
                         </br>
                         </br>

                        <h4 id="h1">Administrar Asistencias</h4>
                        <p id="parrafoServicio"> Aqui se puede administrar las asistencias estudiantiles de la Escuela de Computación y todo lo referente a éstas. </br> Además de exportar documentos
                            como plantillas y solicitudes realizadas por los estudiantes.</p>
                    </fieldset>
                </div>
        
            <div id="caja3">
                <fieldset id="fieldServicios">
                    <legend>Servicios Estudiantiles</legend>
                    <h4 id="h1">Enviar solicitud de Asistencia</h4>
                    <p id="parrafoServicio">
                        En esta seccion se puede completar la boleta oficial de solicitud de Asistencia Estudiantil de 
                        la Escuela de Computación y enviarla para ser valorada. 
                    </p>

                    </br>
                    </br>
                    </br>

                    <h4 id="h1">Enviar correo electrónico al Administrador</h4>
                    <p id="parrafoServicio">
                        Este sitio permite el envio de correos electrónicos al administrador de Asistencias. 
                    </p>
                </fieldset>
            </div>

        </div>
    </div>
</asp:Content>
