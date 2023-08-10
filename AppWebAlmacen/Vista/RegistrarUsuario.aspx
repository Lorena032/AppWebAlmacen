<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="AppWebAlmacen.Vista.RegistrarUsuario1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/EstilosRegistro.css" rel="stylesheet" />
    <script src="../Scripts/sweetalert.min.js"></script>
    <link href="css/sweetalert.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--<div class="container">
        <h1>Registrar Usuario</h1>
        <p>Llenar cada uno de los sguientes datos.</p>
        <hr />

        <asp:Label ID="lblDocumento" runat="server" Text="Documento: "></asp:Label>
        <asp:TextBox ID="txtDocumento" placeholder="Documento" runat="server"></asp:TextBox>

        <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="txtNombre" placeholder="Nombre" runat="server"></asp:TextBox>

        <asp:Label ID="lblApellido" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="txtApellido" placeholder="Apellido" runat="server"></asp:TextBox>

        <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtEmail" placeholder="Email" runat="server"></asp:TextBox>

        <asp:Label ID="lblClave" runat="server" Text="Clave: "></asp:Label>
        <asp:TextBox ID="txtClave" placeholder="Clave" type="password" runat="server"></asp:TextBox>

        <hr />
        <asp:Button ID="btnRegistrar" CssClass="registerbtn" runat="server" Text="REGISTRAR" OnClick="btnRegistrar_Click" />
    </div>--%>


    <div class="form">

        <!--TITULO------------------------>
        <h1 class="titulo">Registrar Usuario</h1>

        <!--CAJAS-DE-ENTRADA-DE-DATOS------------------------------------------------>

        <asp:TextBox ID="txtDocumento" CssClass="cajas" runat="server" placeholder="Documento"></asp:TextBox>
        <asp:TextBox ID="txtNombre" CssClass="cajas" runat="server" placeholder="Nombre"></asp:TextBox>
        <asp:TextBox ID="txtApellido" CssClass="cajas" runat="server" placeholder="Apellido"></asp:TextBox>
        <asp:TextBox ID="txtEmail" CssClass="cajas" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>
        <asp:TextBox ID="txtClave" CssClass="cajas" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
        <asp:DropDownList ID="ddlRol" CssClass="cajas" runat="server"></asp:DropDownList> 
 <asp:DropDownList ID="ddlRol" CssClass="cajas" runat="server"></asp:DropDownList> 
        <%--<asp:FileUpload ID="fuImagen" runat="server" CssClass="btn" />--%>
        <%--<asp:DropDownList ID="ddlCategoria" CssClass="cajas" runat="server"></asp:DropDownList>--%>




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
