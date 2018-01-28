<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="Presupuesto.aspx.cs" Inherits="GestionVenta.View.Layout.Formulario_web11" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">

    <script  src="https://code.jquery.com/jquery-1.11.1.min.js" type="text/javascript"></script>
<script  src="https://cdn.datatables.net/1.10.4/js/jquery.dataTables.min.js" type="text/javascript"></script>
<script  src="https://cdn.datatables.net/plug-ins/3cfcc339e89/integration/bootstrap/3/dataTables.bootstrap.js" type="text/javascript"></script>
<link rel="stylesheet" type="text/css" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css"/>

<link rel="stylesheet" type="text/css" href="http://cdn.datatables.net/plug-ins/3cfcc339e89/integration/bootstrap/3/dataTables.bootstrap.css"/>

<link href="../content/css/StyleDataTable.css" rel="stylesheet" />

<!-- header -->
    <div id="top-nav" class="navbar navbar-inverse navbar-static-top">
        <div class="container-fluid">
            <div class="navbar-header">

                <a class="navbar-brand" href="#">Dashboard</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li class="dropdown"><a class="dropdown-toggle" role="button" data-toggle="dropdown" href="#"><i class="glyphicon glyphicon-user" style="width:20%"></i> Admin <span class="caret"></span></a>
                        <ul id="g-account-menu" class="dropdown-menu" role="menu">
                            <li><a href="#">Mi Perfil</a></li>
                        </ul>
                    </li>
                    <li><a href="#"><i class="glyphicon glyphicon-lock" style="width:25%"></i> Salir</a></li>
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

                <a href="#"><strong> My Dashboard</strong></a>
                <hr/>
                <div class="row">
                <!-- center left-->
                    <div class="col-md-6">
                        <div class="well">
                            Inbox Messages <span class="badge pull-right">3</span></div>
                        <hr/>
                        <div class="btn-group btn-group-justified">
 
                        </div>
                        <hr/>
                        <hr/>

                    <!--tabs-->
                        <div class="panel">
                            <ul class="nav nav-tabs" id="myTab">
                                <li class="active"><a href="#profile" data-toggle="tab"> Profile</a></li>
                                <li><a href="#messages" data-toggle="tab"> Messages</a></li>
                                <li><a href="#settings" data-toggle="tab"> Settings</a></li>
                            </ul>
                            <div class="tab-content">
                                <div class="tab-pane active well" id="profile">
                                    <h4></h4>
                                    Lorem profile dolor sit amet, consectetur adipiscing elit. Duis pharetra varius quam sit amet vulputate.
                                    <p>
                                        Quisque mauris augue, molestie tincidunt condimentum vitae, gravida a libero. Aenean sit amet felis dolor, in sagittis nisi.</p>
                                </div>
                                <div class="tab-pane well" id="messages">
                                    <h4></h4>
                                    Message ipsum dolor sit amet, consectetur adipiscing elit. Duis pharetra varius quam sit amet vulputate.
                                    <p>
                                        Quisque mauris augu.</p>
                                </div>
                                <div class="tab-pane well" id="settings">
                                    <h4></h4>
                                    Lorem settings dolor sit amet, consectetur adipiscing elit. Duis pharetra varius quam sit amet vulputate.
                                    <p>
                                        Quisque mauris augue, molestie.</p>
                                </div>
                            </div>
                        </div>
                    <!--/tabs-->

                        <hr/>
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4>New Requests</h4>
                            </div>
                            <div class="panel-body">
                                <div class="list-group">
                                    <a href="#" class="list-group-item active">Hosting virtual mailbox serv..</a> <a href="#" class="list-group-item">Dedicated server doesn't..</a> <a href="#" class="list-group-item">RHEL 6 install on new..</a>
                                </div>
                            </div>
                        </div>
                    </div>
                <!--/col-->
                    <div class="col-md-6">
                       <div class="table-responsive">
                         <form runat="server">

                       <div class="table-responsive">

                        <asp:GridView ID="GridViewPresupuesto" runat="server" CssClass="table table-striped table-bordered dt-responsive nowrap" AutoGenerateColumns="false" ToolTip="Visualización de Presupuesto"  >
                            <Columns>
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripciones" />
                            <asp:BoundField DataField="FechaEmision" HeaderText="Fecha Emision" />
                            </Columns>
                           </asp:GridView>

                       </div>


                        <div class="btn-group">
                          <button type="button" class="btn btn-primary">Izquierdo</button>
                          <button type="button" class="btn btn-group-sm">Central</button>
                          <button type="button" class="btn btn-default">Derecho</button>
                          <asp:Button ID="btn_ConsultarDato" runat="server" Text="Button asp" OnClick="btn_ConsultarDato_Click" CssClass="btn btn-info" />
                        </div>


                       </form>
                     </div>


                        <div class="panel panel-default">
                          
                        </div>
                    <!--/panel-->

                    </div>
                <!--/col-span-6-->

                </div>
            <!--/row-->

                <hr/><a href="#"><strong><i class="glyphicon glyphicon-comment"></i> Discussions</strong></a>
                <hr/>
                <div class="row">
                    <div class="col-md-12">
                        <ul class="list-group">
                            <li class="list-group-item"><a href="#"><i class="glyphicon glyphicon-flash"></i><small>(3 mins ago)</small> The 3rd page reports don't contain any links. Does anyone know why..</a></li>
                            <li class="list-group-item"><a href="#"><i class="glyphicon glyphicon-flash"></i><small>(1 hour ago)</small> Hi all, I've just post a report that show the relationship betwe..</a></li>
                            <li class="list-group-item"><a href="#"><i class="glyphicon glyphicon-heart"></i><small>(2 hrs ago)</small> Paul. That document you posted yesterday doesn't seem to contain the over..</a></li>
                            <li class="list-group-item"><a href="#"><i class="glyphicon glyphicon-heart-empty"></i><small>(4 hrs ago)</small> The map service on c243 is down today. I will be fixing the..</a></li>
                            <li class="list-group-item"><a href="#"><i class="glyphicon glyphicon-heart"></i><small>(yesterday)</small> I posted a new document that shows how to install the services layer..</a></li>
                            <li class="list-group-item"><a href="#"><i class="glyphicon glyphicon-flash"></i><small>(yesterday)</small> ..</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        <!--/col-span-9-->
        </div>
    </div>
<!-- /Main -->

    <script>
        $(document).ready(function () {
         $('#datatable').dataTable();

         $("[data-toggle=tooltip]").tooltip();

 });
    </script>


      </asp:Content>


