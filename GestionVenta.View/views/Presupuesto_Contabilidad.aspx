<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="Presupuesto_Contabilidad.aspx.cs" Inherits="GestionVenta.View.Layout.Formulario_web12" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>

        <form id="formPresupuestoContabilidad" runat="server">

<!-- header -->
    <div id="top-nav" class="navbar navbar-inverse navbar-static-top">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#">Dashboard</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li class="dropdown"><a class="dropdown-toggle" role="button" data-toggle="dropdown" href="#">Admin <span class="caret"></span></a>
                        <ul id="g-account-menu" class="dropdown-menu" role="menu">
                            <li><a href="#">Mi Perfil</a></li>
                        </ul>
                    </li>
                    <li><a href="Acceso_Login.aspx">Desconectar</a></li>
                </ul>
            </div>
        </div>
    <!-- /container -->
    </div>
<!-- /Header -->

<!-- Main -->
    <div class="container-fluid">
        <div class="row">
              <div class="col-sm-3">
            <!-- Left column -->
                <a href="#"><strong><i class="glyphicon glyphicon-transfer" style="width:10%"> </i>Herramientas</strong></a>
                <hr/>
                <ul class="nav nav-stacked">
                    <li class="nav-header"><a href="#" data-toggle="collapse" data-target="#userMenu"> Acciones</a>
                        <ul class="nav nav-stacked collapse in" id="userMenu">
                            <li class="active"><a href="Cotizacion.aspx"> <i class="glyphicon glyphicon-list-alt" style="width:10%"></i>  Nueva Cotización</a></li>
                            <li><a href="#"><i class="glyphicon glyphicon-envelope"  style="width:10%"></i> Messages <span class="badge badge-info">4</span></a></li>
                            <li><a href="#"><i class="glyphicon glyphicon-list-alt" style="width:10%"></i>  Listado Cotizaciones</a></li>
                        </ul>
                    </li>
                </ul>
                <hr/><a href="#"><strong><i class="glyphicon glyphicon-link" style="width:20%" ></i> Departamento</strong></a>
                <hr/>
                <ul class="nav nav-pills nav-stacked">
                    <li class="nav-header"></li>
                    <li><a href="Presupuesto_Contabilidad.aspx"><i class="glyphicon glyphicon-list-alt" style="width:10%"></i> Contabilidad</a></li>
                    <li><a href="Presupuesto_Operaciones.aspx"><i class="glyphicon glyphicon-briefcase"  style="width:10%"></i> Operaciones</a></li>
                </ul>
                <hr/>
                <hr/><a href="#"><strong><i class="glyphicon glyphicon-list"  style="width:20%"></i> Resumen</strong></a>
                <hr/>
                <ul class="nav nav-stacked">
                    <li class="active"><a rel="nofollow" href="http://goo.gl/pQoXEh" target="ext"  style="width:10%"> Resumen Mensual</a></li>
                    <li><a rel="nofollow" href="https://wrapbootstrap.com/?ref=bootply"  style="width:10%"> Resumen Anual</a></li>
                    <li><a rel="nofollow" href="http://bootstrapzero.com"> BootstrapZero</a></li>
                </ul>
            </div>
        <!-- /col-3 -->
            <div class="col-sm-9">

            <!-- column 2 -->
                <ul class="list-inline pull-right">
                    <li><a href="#"><i class="glyphicon glyphicon-cog"></i></a></li>
                   
                </ul>
                <a href="#"><strong><i class="glyphicon glyphicon-dashboard"></i>My Dashboard</strong></a>
                <hr/>
                <div class="row">
                <!-- center left-->
         
                        <hr/>
                        <hr/>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4>DETALLE:</h4>
                            </div>
                            <div class="panel-body">
                                <!--      Primera Tabla --->
                              <div class="table-responsive">
                                <table class="table table-striped">

                                <tbody>
                                    <tr>
                                        <td>Obra</td>
                                   <td> <asp:TextBox ID="TxtObra" runat="server"></asp:TextBox> </td>
                                        <td>Empresa</td>
                                        <td>Rut</td>
                                    </tr>
                                    <tr>
                                        <td>Fecha Aprobación</td>
                                          <td> <asp:TextBox ID="TxtFechaApro" runat="server"></asp:TextBox> </td>
                                          <td> <asp:TextBox ID="TxtEmpresa" runat="server"></asp:TextBox> </td>
                                          <td> <asp:TextBox ID="TxtRut" runat="server"></asp:TextBox> </td>
                                    </tr>
                                    <tr>
                                        <td>Ascensor</td>
                                           <td> <asp:TextBox ID="TxtAscen" runat="server"></asp:TextBox> </td>
                                        <td>Dirección</td>
                                        <td>..</td>
                                    </tr>
                                    <tr>
                                        <td>Tecnico Emisor</td>
                                        <td> <asp:TextBox ID="TxtTecEm" runat="server"></asp:TextBox> </td>
                                        <td> <asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox> </td>
                                        <td>..</td>
                                    </tr>
                                    <tr>
                                        <td>Supervisor</td>
                                        <td> <asp:TextBox ID="TxtSupervisor" runat="server"></asp:TextBox> </td>
                                        <td>..</td>
                                        <td>..</td>
                                    </tr>
                                </tbody>

                                </table>
                            </div>
                            </div>
                        <!--/panel-body-->
                        </div>
                    <!--/panel-->

                        <hr/>
                        <hr/>

                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4>New Requests</h4>
                            </div>
                            <div class="panel-body">
                                <div class="list-group">
                                    <a href="#" class="list-group-item active">INFORMO A UD. QUE CON ESTA FECHA SE HA APROBADO LO SIGUIENTE:</a> 
                                       <table class="table table-striped">

                                    <tbody>
                                         <tr>
                                        <td style="width:10%"></td>
                                        <td style="width:10%"></td>
                                        <td style="width:10%"></td>
                                        <td style="width:10%"></td>
                                        <td style="width:30%">PRESUPUESTO REP N°</td>
                                        <td style="width:30%"></td>
                                    </tr>
                                    <tr>
                                        <td style="width:10%"></td>
                                        <td style="width:10%"></td>
                                        <td style="width:10%"></td>
                                        <td style="width:10%"></td>
                                        <td style="width:20%"></td>
                                        <td style="width:40%"> <asp:TextBox ID="TextFechaApro" runat="server"></asp:TextBox> </td>
                                    </tr>
                                    </tbody>

                                    </table>
                                    <table class="table table-striped">

                                    <tbody>
                                         <tr>
                                        <td style="width:20%">APROBADO POR</td>
                                        <td style="width:50%"> <asp:TextBox ID="Txt_APROBPOR" runat="server"></asp:TextBox></td>
                                        <td style="width:30%"> VENDEDOR</td>
                                    </tr>
                                    <tr>
                                        <td style="width:20%">TELEFONO CONTACTO</td>
                                        <td style="width:50%">
                                            <asp:TextBox ID="Txt_TELCONTA" runat="server"></asp:TextBox></td>
                                        <td style="width:30%">
                                            <asp:TextBox ID="Txt_VENDEDOR" runat="server"></asp:TextBox></td>
                                    </tr>
                                    </tbody>

                                    </table>
                                    <a href="#" class="list-group-item">BREVE DESCRIPCION DE LA REPARACIÓN A EFECTUAR</a> 
                                    
                                     <table class="table table-striped">

                                       <tbody>
                                        <td>
                                            <textarea id="tf_detalleArea" rows="4" cols="50" style="width: 100%" runat="server">
                                            </textarea>
                                        </td>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                 
                <!--/col-->
                    <!-- COLUMNA IZQUIERDA-->
                    <div class="col-md-6">
                      <div class="panel panel-default">
                    
                             <div class="table-responsive">
                            <table class="table table-striped">
                                <tbody>
                                    <tr>
                                        <td>HORAS PAREJAS VENDIDAS</td>
                                        <td>2 </td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>FLETES</td>
                                        <td>56</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>DURACIÓN DE TRABAJOS (días)</td>
                                        <td>25</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>FECHA PROBABLE DE EJECUCIÓN</td>
                                        <td>02-OCT</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>TECNICO ASIGNADO</td>
                                        <td>AG</td>
                                        <td></td>
                                    </tr>
                                     <tr>
                                        <td>FECHA INICIO</td>
                                        <td>01-OCT</td>
                                        <td></td>
                                    </tr>
                                     <tr>
                                        <td>FECHA TERMINO</td>
                                        <td>01-OCT</td>
                                        <td></td>
                                    </tr>
                                     <tr>
                                        <td>GUIA DE DESPACHO N°</td>
                                        <td>256</td>
                                        <td></td>
                                    </tr>
                                       <tr>
                                        <td>FACTURA N°</td>
                                        <td>1009</td>
                                        <td></td>
                                    </tr>
                                      <tr>
                                        <td>MES FACTURACIÓN</td>
                                        <td>OCTUBRE</td>
                                        <td></td>
                                    </tr>
                                      <tr>
                                        <td>..</td>
                                        <td>..</td>
                                        <td>..</td>
                                    </tr>
                                </tbody>
                            </table>
                            </div>
                         
                      </div>

                     <div class="panel panel-default">
                        <div class="table-responsive">
                            <table class="table table-striped">
                               <thead>
                                    <tr>
                                        <th style="width:60%">RESUMEN</th>
                                        <th style="width:30%">VALOR</th>
                                        <th style="width:10%"></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>MANO DE OBRA</td>
                                        <td>121.500 </td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>REPUESTOS</td>
                                        <td>285.00</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>TERCEROS</td>
                                        <td>0</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>FLETES</td>
                                        <td>20.250</td>
                                        <td></td>
                                    </tr>
                                      <tr>
                                        <td>SUB-TOTAL</td>
                                        <td>426.750</td>
                                        <td>..</td>
                                    </tr>
                                </tbody>
                            </table>
                            </div>
                         <hr />
                        <div class="table-responsive">
                            <table class="table table-striped">
                               <thead>
                                    <tr>
                                        <th style="width:60%">COMISIONES</th>
                                        <th style="width:30%"></th>
                                        <th style="width:10%"></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>3% VENDEDOR</td>
                                        <td>12.803</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>1.8% OTROS</td>
                                        <td>85.350</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>TOTAL NETO</td>
                                        <td>524.903</td>
                                        <td></td>
                                    </tr>
                                      <tr>
                                        <td>..</td>
                                        <td>..</td>
                                        <td>..</td>
                                    </tr>
                                </tbody>
                            </table>
                            </div>
                        </div>
                    <!--/panel-->

                    </div>

                <!--/col-span-6-->
                      <!-- COLUMNA DERECHA-->
                    <div class="col-md-6">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4>FACTURACIÓN EN CUOTAS</h4>
                            </div>
                        <div class="table-responsive">
                            <table class="table table-striped">
                                <thead>
                                    <tr>
                                        <th>N° CUOTA</th>
                                        <th>N° FACTURA</th>
                                        <th>VALOR</th>
                                        <th>MES</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                    </tr>
                                    <tr>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                    </tr>
                                    <tr>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                    </tr>
                                    <tr>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                    </tr>
                                    <tr>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        </div>

                        
                    <!--/panel-->

                        <div id="foreign_checkbox" class="panel panel-default">
                            <div class="panel-heading">
                                <div class="panel-title">
                                    <h4>CONDICIONES DE VENTA</h4>
                                </div>
                            </div>
                            <div class="panel-body">
                                <div><a href="#">Descuentos Ofrecidos</a> </div>
                         
                                <div class="col-xs-4 text-center" style="width:20%">
                                    <a>5%</a>
                                    <asp:CheckBox ID="CheckBox_Cinco" runat="server"/>
                                </div>
                                <div class="col-xs-4 text-center" style="width:20%">
                                    <a>15%</a>
                                    <asp:CheckBox ID="CheckBox_Quince" runat="server" />
                                </div>
                                <div class="col-xs-4 text-center" style="width:40%">
                                    <a>OTRO</a>
                                    <asp:CheckBox ID="CheckBox_Otro" runat="server" /> 
                                    <asp:TextBox ID="TextBox_Otro" runat="server" Enabled="false"></asp:TextBox>
                                </div>
                                <hr />
                                <hr />
                                <div><a href="#">Forma de Pago</a> </div>

                                <div class="col-xs-4" style="width:90%">
                                    <asp:CheckBox ID="CheckBox_cien" runat="server"/>
                                    <a style="width:100%">100% Contra factura al termino de los trabajos</a>
                                </div>
                                <div class="col-xs-4" style="width:90%">
                                   <asp:CheckBox ID="CheckBox_Cincuenta" runat="server"/>
                                   <a style="width:100%">50% Con la orden y saldo contra factura</a>
                                 </div>
                                <div  class="col-xs-4" style="width:90%">
                                   <asp:CheckBox ID="CheckBox_Cuotas" runat="server"/>
                                   <a style="width:100%">Cuotas</a>  &ensp; &ensp; &ensp;  &ensp;   <a>N° Cuotas </a>  
                                   <asp:TextBox ID="TextBox_Cuotas" runat="server" Width="10%" Enabled="false"></asp:TextBox>
                                </div>
                                <div  class="col-xs-4" style="width:90%">
                                   <asp:CheckBox ID="CheckBox_OtroForPag" runat="server"/>
                                   <a style="width:100%">Otro (Indicar)</a>
                                   <asp:TextBox ID="TextBox_Otros" runat="server" Enabled="false"></asp:TextBox>
                                 </div>
                                <hr />
                                <hr />
                                <br />
                                <br />
                                <br />
                                  <div><a href="#">Medio de Aprobación</a> </div>

                               <div class="col-xs-4" style="width:90%">
                                    <asp:CheckBox ID="CheckBox_CopFirm" runat="server"/>
                                    <a style="width:100%">Copia de presupuesto firmado</a>
                                </div>
                               <div class="col-xs-4" style="width:90%">
                                    <asp:CheckBox ID="CheckBox_OC" runat="server"/>
                                    <a style="width:100%">Orden de compra a travez de Chile Compra</a>
                                </div>
                               <div class="col-xs-4" style="width:90%">
                                    <asp:CheckBox ID="CheckBox_OtroMedApo" runat="server"/>
                                    <a style="width:100%">Otro (Indicar)</a>
                                    <asp:TextBox ID="TextBox_OtroMedioApro" runat="server" Enabled="false"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    <!--/panel-->

                    </div>


                </div>
            <!--/row-->

            </div>
        <!--/col-span-9-->
        </div>
    </div>
<!-- /Main -->
       </form>


<script type="text/javascript">
    $(document).ready(function() {

        $("#foreign_checkbox").click(function () {
            if ($('#ContentPlaceHolder1_CheckBox_OtroForPag').is(':checked')) {
                $("#ContentPlaceHolder1_TextBox_Otros").removeAttr("disabled");
            } else {
                $("#ContentPlaceHolder1_TextBox_Otros").attr("disabled", "disabled");
            }
        });

        $("#foreign_checkbox").click(function () {
            if ($('#ContentPlaceHolder1_CheckBox_Cuotas').is(':checked')) {
                $("#ContentPlaceHolder1_TextBox_Cuotas").removeAttr("disabled");
            } else {
                $("#ContentPlaceHolder1_TextBox_Cuotas").attr("disabled", "disabled");
            }
        });
        
        $("#foreign_checkbox").click(function () {
            if ($('#ContentPlaceHolder1_CheckBox_OtroMedApo').is(':checked')) {
                $("#ContentPlaceHolder1_TextBox_OtroMedioApro").removeAttr("disabled");
            } else {
                $("#ContentPlaceHolder1_TextBox_OtroMedioApro").attr("disabled", "disabled");
            }
        });

        $("#foreign_checkbox").click(function () {
            if ($('#ContentPlaceHolder1_CheckBox_Otro').is(':checked')) {
                $("#ContentPlaceHolder1_TextBox_Otro").removeAttr("disabled");
            } else {
                $("#ContentPlaceHolder1_TextBox_Otro").attr("disabled", "disabled");
            }
        });

    });
</script>


</asp:Content>



