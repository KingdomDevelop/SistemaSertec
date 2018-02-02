<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="Presupuesto_Operaciones.aspx.cs" Inherits="GestionVenta.View.Layout.Formulario_web13" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    

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
                                        <td>
                                            <input id="CalendarFechaApro" runat="server" type="datetime-local" style="height:25px"/>
                                        </td>
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
                                        <td style="width:40%"> <asp:DropDownList ID="DropDownListPresupuestos" runat="server" Width="50px"></asp:DropDownList></td>
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
                                         <tr>
                                         <td>
                                             <textarea id="tf_detalleArea" rows="4" cols="50" style="width: 100%" runat="server">
                                            </textarea>
                                         </td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                 
                <!--/col-->


                     <div class="panel panel-default">
                        <div class="table-responsive">
                            <div class="panel-body">
                         <%--   <table class="table table-striped">
                               <thead>
                                    <tr>
                                        <th style="width:60%">REPUESTOS Y/O REPARACIÓN</th>
                                        <th style="width:20%">CANT.</th>
                                        <th style="width:20%">CODIGO</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>...</td>
                                        <td>0</td>
                                        <td>...</td>
                                    </tr>
                                    <tr>
                                        <td>...</td>
                                        <td>0</td>
                                        <td>...</td>
                                    </tr>
                                    <tr>
                                        <td>...</td>
                                        <td>0</td>
                                        <td>...</td>
                                    </tr>
                                    <tr>
                                        <td>...</td>
                                        <td>0</td>
                                        <td>...</td>
                                    </tr>
                                      <tr>
                                        <td>...</td>
                                        <td>0</td>
                                        <td>...</td>
                                    </tr>
                                </tbody>
                            </table>--%>

                            <asp:GridView ID="GridView_RepuestosReparacion" runat="server" Width="100%" class="table table-striped" onrowediting="GridView_RepuestosReparacion_RowEditing" onrowupdating="GridView_RepuestosReparacion_RowUpdating" onrowcancelingedit="GridView_RepuestosReparacion_RowCancelingEdit" style="height: 28px">
                                <Columns>
                                    <asp:CommandField ShowEditButton="True" CancelImageUrl="~/content/Imagenes/cancelGrid.png" HeaderText="Edición" SelectImageUrl="~/content/Imagenes/SeleccionGrid.png" ButtonType="Image" EditImageUrl="~/content/Imagenes/editGrid.png" InsertImageUrl="~/content/Imagenes/warningGrid.png" UpdateImageUrl="~/content/Imagenes/okGrid.png" />
                                    <asp:BoundField HeaderText="Repuestos Y/O Reparación" />
                                    <asp:BoundField HeaderText="CANT." />
                                    <asp:BoundField HeaderText="CODIGO" />
                                </Columns>
                                </asp:GridView>

                           </div>
                         </div>
                         <hr />
                         <hr />
                            <div class="table-responsive">
                               <div class="panel-body">
                            <table class="table table-striped">
                               <thead>
                                    <tr>
                                        <th style="width:10%"></th>
                                        <th style="width:80%">TRABAJOS TERCEROS</th>
                                        <th style="width:10%"></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td></td>
                                        <td>
                                             <textarea id="Textarea_trabTerc" rows="4" cols="50" style="width: 100%" runat="server">
                                            </textarea>
                                        </td>
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
                      </div>
                    <!--/panel-->


                <!--/col-span-6-->
                      <!-- COLUMNA DERECHA-->
              
                        <div class="panel-body">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4>CONTROL DE TERMINO DE TRABAJOS</h4>
                            </div>
                        <div class="table-responsive">
                            <table class="table table-striped">
                                <tbody>
                                    <tr>
                                        <td>FECHA</td>
                                        <td>...</td>
                                        <td>GUIA N°</td>
                                        <td><asp:TextBox ID="TxtBoxGuia" runat="server"></asp:TextBox>
                                        </td>
                                        <td>TECNICO</td>
                                        <td><asp:TextBox ID="TxtBoxTec" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>SUPERVISOR</td>
                                        <td><asp:TextBox ID="TxtBoxSup" runat="server"></asp:TextBox>
                                        </td>
                                        <td>FECHA</td>
                                        <td>...</td>
                                        <td>FIRMA</td>
                                        <td>...</td>
                                    </tr>
                                    <tr>
                                        <td>VENTAS</td>
                                        <td><asp:TextBox ID="TxtBoxNumVen" runat="server"></asp:TextBox>
                                        </td>
                                        <td>FECHA</td>
                                        <td>02-OCT</td>
                                        <td>FIRMA</td>
                                        <td>...</td>
                                    </tr>
                                    <tr>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                        <td>...</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        </div>

                          </div>
                    <!--/panel-->

                </div>
            <!--/row-->
                <hr/>
                <div class="table-responsive">
                        <asp:Button ID="Btn_Guardar" runat="server" class="btn btn-primary btn-block"  Text="GUARDAR" OnClick="BtnGuardar_Click"  />
                 </div>
                <hr/>

            </div>
        <!--/col-span-9-->
        </div>
    </div>
<!-- /Main -->
       </form>
</asp:Content>

