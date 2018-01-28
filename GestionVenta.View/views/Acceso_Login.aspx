<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/MasterPageLogin.Master" AutoEventWireup="true" CodeBehind="Acceso_Login.aspx.cs" Inherits="GestionVenta.View.Layout.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
<!--
    Revisar si sustituir el correo por un nombre de usuario
    -->
    <div class="container">
        <div class="card card-container">
            <img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" />
            <p id="profile-name" class="profile-name-card">
            </p>
            <form runat="server" class="form-signin">
                <span id="reauth-email" class="reauth-email"></span>
                <input type="email" id="inputEmail" runat="server" class="form-control" placeholder="Email address" required="required" autofocus="autofocus" />
                <input type="password" id="inputPassword" runat="server" class="form-control" placeholder="Password" required="required" />
                <div id="remember" class="checkbox">
                    <label>
                    <input type="checkbox" value="remember-me" /> Recordar
                    </label>
                </div>
                <div class="btn btn-lg btn-primary btn-block btn-signin" style="text-align: center;">
                 <asp:Button ID="Btn_LOGIN" runat="server" class="btn btn-lg btn-primary btn-block btn-signin"  Text="ACCEDER" OnClick="Btn_LOGIN_Click" UseSubmitBehavior="false" />
             </div> <!--  <button class="btn btn-lg btn-primary btn-block btn-signin" type="submit"  runat="server" id="testButton">
                    Acceder
                </button> -->
            </form>
            <!-- /form -->
            <a href="Cotizacion.aspx" class="forgot-password">¿Recuperar Contraseña? </a>
        </div>
        <!-- /card-container -->
    </div>
    <!-- /container -->


        
        </asp:Content>


