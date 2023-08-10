<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="AppWebAlmacen.Vista.RegistrarUsuario1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/EstilosRegistro.css" rel="stylesheet" />
    <script src="../Scripts/sweetalert.min.js"></script>
    <link href="css/sweetalert.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

    <div class="form">




        <!--TERMINOS-Y-CONDICIONES---------------------------------------------------------------------------------->
        <p class="termino1">
            <input type="checkbox" />
            Estoy de acuerdo con <a class="termino2" href="#">Terminos y Condiciones</a>
        </p>

        <!--BOTON-DE-REGISTRARSE-------------------------->

        <asp:Button ID="btnRegistrar" CssClass="btn" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />


        <!--YA-TENGO-CUENTA----------------------------------------------------------->
        <p class="tengo-cuenta"><a href="#" class="tengo-cuenta">Ya tengo cuenta</a></p>
    </div>
    <script src="Bootstrap/js/bootstrap.min.js"></script>
</asp:Content>
