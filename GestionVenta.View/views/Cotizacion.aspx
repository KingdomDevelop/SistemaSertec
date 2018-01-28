<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/MasterAdmin.Master" AutoEventWireup="true" CodeBehind="Cotizacion.aspx.cs" Inherits="GestionVenta.View.Layout.Formulario_web11" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">

       
    <form id="formCotizacion" runat="server">

    
       
 <script  src="https://code.jquery.com/jquery-1.11.1.min.js" type="text/javascript"></script>
<script  src="https://cdn.datatables.net/1.10.4/js/jquery.dataTables.min.js" type="text/javascript"></script>
<script  src="https://cdn.datatables.net/plug-ins/3cfcc339e89/integration/bootstrap/3/dataTables.bootstrap.js" type="text/javascript"></script>
<link rel="stylesheet" type="text/css" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css"/>

<link rel="stylesheet" type="text/css" href="http://cdn.datatables.net/plug-ins/3cfcc339e89/integration/bootstrap/3/dataTables.bootstrap.css"/>

<link href="../content/css/StyleDataTable.css" rel="stylesheet" />

        <!-- Pop Up -->
  <script src="../content/js/scripts-Pop-up.js"></script>
  <link href="../content/css/pop-up.css" rel="stylesheet" />

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
        <div class="col-sm-3"><!-- Barra navegadora izquierda -->    
            
                    
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



        </div><!-- Fin Barra navegadora izq -->
            


        <!-- /col-3 -->
        <div class="col-sm-8">
            <!-- column 2 -->
            <a href="#"><strong>NUEVA COTIZACION</strong></a>
            <hr/>            
                    <div class="table-responsive">
                        <table class="table table-striped">
                            <tr>
                                <th>CALCULO DE PRESUPUESTO</th>
                            </tr>
                        </table>
                        <hr/>
                        <div class="row">
                          <div class="col-md-8">
                                 <table class="table table-striped">  
                                  <tr>
                                    <td >OBRA</td>
                                    <td ">
                                        <input type="text" name="obra" id="td_obra" style="width:90%" class="form-control input-md"  runat="server"/>
                                    </td>
                                    <td style="width: 8px"></td>
                                  </tr>
                                  <tr>
                                    <td >FECHA EMISION INFORME</td>
                                    <td >
                                   <asp:TextBox  name="fecha" id="td_fecha"  runat="server" ViewStateMode="Enabled" style="width:90%" class="form-fecha input-md" ></asp:TextBox>

                                    </td>
                                    <td style="width: 8px"></td>
                                  </tr>
                                  <tr>
                                    <td >ASCENSOR</td>
                                    <td >
                                        <asp:TextBox ID="td_asc" runat="server" style="width:90%" class="form-control input-md"></asp:TextBox>
                                    </td>
                                    <td style="width: 8px"></td>
                                 </tr>
                                 <tr>
                                    <td >TECNICO EMISOR</td>
                                    <td >
                                        <asp:TextBox ID="td_tec" runat="server" style="width:90%" class="form-control input-md"></asp:TextBox>
                                    </td>
                                    <td style="width: 8px"></td>
                                </tr>
                                <tr>
                                    <td >SUPERVISOR</td>
                                    <td >
                                        <asp:TextBox ID="td_sup" runat="server"  style="width:90%" class="form-control input-md"></asp:TextBox>
                                    </td>
                                    <td style="width: 8px"></td>
                                </tr>
                                <tr>
                                    <td >PRESUPUESTO REP N°</td>
                                    <td >
                                            <asp:TextBox ID="td_pre" runat="server"  style="width:90%"></asp:TextBox>
                                    </td>
                                    <td style="width: 8px"></td>
                                </tr>       
                                 </table>
                          </div>

                          <div class="col-md-4">
                              
                             
                                  <table class="table table-striped">  
                                  <tr>
                                    <td>VALOR UF</td>
                                    <td><input type="text" name="obra" id="td_uf" style="width:90%" runat="server"/></td>
                                    <td>  <asp:TextBox  name="obra" id="td_uf_id"  runat="server" ViewStateMode="Enabled" Visible="false" ></asp:TextBox> </td>
                                  </tr>

                                  <tr>
                                    <td>VALOR HP</td>
                                    <td><input type="number" name="hp" id="td_hp" style="width:90%" runat="server"/></td>
                                    <td> <asp:TextBox  name="hp" id="td_hp_id"  runat="server" ViewStateMode="Enabled"  Visible="false"></asp:TextBox>  </td>
                                   </tr>
                                   <tr>
                                    <td>VALOR FLETE</td>
                                    <td><input type="number" name="flete" id="td_flete" style="width:90%" runat="server"/></td>
                                  <td> <asp:TextBox  name="ofletebra" id="td_flete_id"  runat="server" ViewStateMode="Enabled"  Visible="false"></asp:TextBox> </td>

                                  </tr>
                                <tr>
                                    <td>FECHA CALC</td>
                                    <td> <asp:TextBox  name="fecha2" id="td_fecha2"  runat="server" ViewStateMode="Enabled" style="width:90%;" class="form-control input-md" ></asp:TextBox> </td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>PPTO N°</td>
                                    <td> <asp:TextBox  name="fecha2" id="td_ppto"  runat="server" ViewStateMode="Enabled" style="width:90%;" class="form-control input-md" ></asp:TextBox>
                                    </td>
                                    <td></td>
                                </tr>       
                                 </table>
                          </div>
                        </div>
                        <hr/>
                        <table class="table table-striped">
                                <tr>                                    
                                    <td>BREVE DESCRIPCION DE LA REPARACION A EFECTUAR</td>                                    
                                </tr>
                            <tr>
                                <td>
                                    <asp:TextBox  name="detalle" id="tf_detalle"  runat="server" ViewStateMode="Enabled" style="width:100%" Visible="false"></asp:TextBox> 
                                    <textarea id="tf_detalleArea" rows="4" cols="50"  style="width:100%" runat="server">
                                    </textarea>


                                </td>
                            </tr>
                        </table>
                        <hr/> 
                        <table class="table table-striped">
                                <tr>
                                    <td></td>                                        
                                    <td>REPUESTOS Y/O REPARACION</td>
                                    <td>CANT.</td>
                                    <td>CODIGO</td>
                                    <td>VALOR UNITARIO</td>
                                    <td>SUB TOTAL</td>
                                    <td>HP</td>
                                    <td></td>
                                </tr>
                            <tr>
                                <td><input type="checkbox"/></td>
                                <td>
                                    <asp:TextBox ID="tf_repuesto" runat="server" style="width:100%"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="tf_cantidad" runat="server" style="width:100%"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="tf_codigo" runat="server" style="width:100%"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="tf_valor" runat="server" style="width:100%"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="tf_subtotal" runat="server" style="width:100%"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="tf_hp2" runat="server" style="width:100%"></asp:TextBox>
                                </td>
                                <td></td>
                            </tr>
                            <tr style="width:90%">
                            <td style="width:5%"></td>	
                                <td style="width:40%">
                           <!--         <button type="submit" class="btn btn-success btn-sm"  runat="server" id="btn_aRepuesto">Agregar Repuesto</button>
                                    <button type="submit" class="btn btn-warning btn-sm">Quitar Repuesto</button> -->
                                 
                                    <asp:Button ID="btn_agregarRepuesto" runat="server" Text="Agregar Repuesto" class="btn btn-success btn-sm" OnClick="btn_agregarRepuesto_Click"  />
                                    <asp:Button ID="btn_quitarRepuesto" runat="server" Text="Quitar Repuesto" class="btn btn-warning btn-sm" OnClick="btn_quitarRepuesto_Click"  />

                                </td>

                                <td></td>	
                                <td></td>
                                <td>TOTAL</td>
                                <td>
                                      <asp:TextBox  name="total" id="idTotal"  runat="server" ViewStateMode="Enabled" style="width:100%"></asp:TextBox> 
                                </td>
                                <td>
                                       <asp:TextBox  name="totalhp" id="idTotalHP"  runat="server" ViewStateMode="Enabled" style="width:100%"></asp:TextBox> 
                                </td>
                            </tr>
                        </table>
                        <hr/> 
                  
                           <div class='wrap'>
                              <div class='content'>
                                 
                                  <h6>Well Hello!</h6>
                          
                                    <q>Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.</q>
                               </div>
                             </div>
                          
                           <b class='button glyphicon glyphicon-plus' href='#'>Glosa</b>
                      
                        <hr />
                        <table class="table table-striped">
                                <tr>
                                    <td></td>                                    
                                    <td>TRABAJOS TERCEROS</td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td>VALOR</td>                 
                                </tr>
                            <tr>
                                <td><input type="checkbox"/></td>
                                <td>
                                      <asp:TextBox  name="terceros" id="tf_terceros"  runat="server" ViewStateMode="Enabled" style="width:100%"></asp:TextBox> 
                                </td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td>
                                        <asp:TextBox  name="valorterceros" id="tf_valter"  runat="server" ViewStateMode="Enabled" style="width:100%"></asp:TextBox> 
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td><button type="submit" class="btn btn-success btn-sm" >Agregar Trabajo</button>
                                    <button type="submit" class="btn btn-warning btn-sm" >Quitar Trabajo</button>
                                </td>
                                <td></td>
                                <td></td>
                                <td></td>		
                                <td>TOTAL</td>
                                <td>
                                  <asp:TextBox  name="total" id="idTotalTrabTercero"  runat="server" ViewStateMode="Enabled" style="width:100%"></asp:TextBox> 
                                </td>
                            </tr>
                        </table>
                        <hr/> 
                        <table class="table table-striped">
                                <tr>                                    
                                    <td>DURACION DE TRABAJOS</td>
                                    <td>
                                      <asp:TextBox  name="duracion" id="tf_duracion"  runat="server" ViewStateMode="Enabled" style="width:100%"></asp:TextBox> 
                                    </td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            <tr>
                                <td>RESUMEN</td>
                                <td>VALOR</td>
                                <td>%</td>
                                <td>MANO DE OBRA</td>
                                <td>VALOR</td>
                            </tr>
                            <tr>
                                <td>MANO DE OBRA</td>		
                                <td><input type="text" name="mano1" value="0" style="width:100%"/></td>
                                <td><input type="text" name="mano2" value="0" style="width:100%"/></td>
                                <td>SUB TOTAL</td>
                                <td><input type="text" name="horaspareja" value="0" style="width:100%"/></td>
                            </tr>
                            <tr>
                                <td>REPUESTOS</td>		
                                <td><input type="text" name="rep1" value="0" style="width:100%"/></td>
                                <td><input type="text" name="rep2" value="0" style="width:100%"/></td>
                                <td>HORAS PAREJA</td>
                                <td><input type="text" name="subtotalmano" value="0" style="width:100%"/></td>
                            </tr>
                            <tr>
                                <td>TERCEROS</td>		
                                <td><input type="text" name="ter1" value="0" style="width:100%"/></td>
                                <td><input type="text" name="ter2" value="0" style="width:100%"/></td>
                                <td>RECARGO HH.EE.</td>
                                <td><input type="text" name="recargo" value="0" style="width:100%"/></td>
                            </tr>
                            <tr>
                                <td>FLETES</td>		
                                <td><input type="text" name="fle1" value="0" style="width:100%"/></td>
                                <td><input type="text" name="fle2" value="0" style="width:100%"/></td>
                                <td>VALOR RECARGO</td>
                                <td><input type="text" name="valorecargo" value="0" style="width:100%"/></td>
                            </tr>
                            <tr>
                                <td>SUB-TOTAL</td>		
                                <td><input type="text" name="sub1" value="0" style="width:100%"/></td>
                                <td><input type="text" name="sub2" value="0" style="width:100%"/></td>
                                <td>TOTAL MANO DE OBRA</td>
                                <td><input type="text" name="tmdo" value="0" style="width:100%"/></td>
                            </tr>
                            <tr>
                                <td>COMISIONES</td>		
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>VENTAS (3%)</td>		
                                <td><input type="text" name="venta1" value="0" style="width:100%"/></td>
                                <td><input type="text" name="venta2" value="0" style="width:100%"/></td>
                                <td>FLETES (CANTIDAD)</td>
                                <td><input type="text" name="cant_fletes" value="0" style="width:100%" /></td>
                            </tr>
                            <tr>
                                <td>MARGEN DE VENTA (20%)</td>		
                                <td><input type="text" name="margen1" value="0" style="width:100%" /></td>
                                <td><input type="text" name="margen2" value="0" style="width:100%"/></td>
                                <td>TOTAL</td>
                                <td><input type="text" name="total_fletes" value="0" style="width:100%" /></td>
                            </tr>
                            <tr>
                                <td>TOTAL NETO</td>		
                                <td><input type="text" name="tn1" value="0" style="width:100%" /></td>
                                <td><input type="text" name="tn2" value="0"  style="width:100%" /></td>

                              <td ></td>
                              <td ></td>
                            </tr>
                            <tr>
                                <td></td>		
                                <td></td>
                                <td></td>
                              <td >
                                <asp:Button ID="Button1" runat="server" class="btn btn-danger btn-block" Text="CANCELAR"  />
                              </td>
                              <td >
                              <asp:Button ID="Button2" runat="server" class="btn btn-primary btn-block"  Text="FINALIZAR" OnClick="Button2_Click"  />
                              </td>
                            </tr>
                            </table>

                        <!--/panel content-->
                    </div>
                    <!--/panel-->

                    <div class="panel panel-default">
       
  
                    </div>
                    <!--/panel-->

                </div>
                <!--/col-span-6-->

            </div>
            <!--/row-->
        </div>
        <!--/col-span-9-->

<!-- /Main -->

        </form>

     <script>
         $(document).ready(function () {
             $(".form-control").popover({ title: "Ingresar datos requeridos", placement: "top" });
             $(".form-fecha").popover({ title: "Ingresar fecha requerida", placement: "top" });
         });

         $('b').on('click', function () {
             $('.wrap, a').toggleClass('active');

             return false;
         });


     </script>

        </asp:Content>

