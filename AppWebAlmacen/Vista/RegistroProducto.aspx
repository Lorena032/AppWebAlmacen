<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistroProducto.aspx.cs" Inherits="AppWebAlmacen.Vista.RegistroProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/sweetalert.min.js"></script>
    <link href="css/EstilosRegistro.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<div class="main-w3layouts wrapper">
        <h1>Registrar Producto</h1>
        <div class="main-agileinfo">
            <div class="agileits-top">
                <asp:TextBox ID="txtCodigo" runat="server" placeholder="Codigo Producto"></asp:TextBox><br />
                <asp:TextBox ID="txtNombre" runat="server" placeholder="NombreProducto"></asp:TextBox><br />
                <asp:TextBox ID="txtDescripcion" runat="server" placeholder="Descripcion"></asp:TextBox><br />
                <asp:TextBox ID="txtPrecio" runat="server" placeholder="Precio"></asp:TextBox><br />
                <asp:FileUpload ID="fuImagen" runat="server" /><br />
                <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList><br />
                <div class="wthree-text">
                    <label class="anim">
                        <input type="checkbox" class="checkbox" required="">
                        <span>I Agree To The Terms & Conditions</span>
                    </label>
                    <div class="clear"></div>
                </div>
                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                <p>Don't have an Account? <a href="#">Login Now!</a></p>
            </div>
        </div>
    </div>--%>

    <div class="form">

        <!--TITULO------------------------>
        <h1 class="titulo">Registrar Producto</h1>

        <!--CAJAS-DE-ENTRADA-DE-DATOS------------------------------------------------>
        
        <asp:TextBox ID="txtCodigo" CssClass="cajas" runat="server" placeholder="Codigo"></asp:TextBox>
        <asp:TextBox ID="txtNombre" CssClass="cajas" runat="server" placeholder="Nombre Del Producto"></asp:TextBox>
        <asp:TextBox ID="txtDescripcion" CssClass="cajas" runat="server" placeholder="Descripcion"></asp:TextBox>
        <asp:TextBox ID="txtPrecio" CssClass="cajas" runat="server" placeholder="Precio"></asp:TextBox>
        
        <asp:FileUpload ID="fuImagen" runat="server" CssClass="btn" />
        <asp:DropDownList ID="ddlCategoria" CssClass="cajas" runat="server"></asp:DropDownList> 
        



        <!--TERMINOS-Y-CONDICIONES---------------------------------------------------------------------------------->
        <p class="termino1">
            <input type="checkbox" />
            Estoy de acuerdo con <a class="termino2" href="#">Terminos y Condiciones</a></p>

        <!--BOTON-DE-REGISTRARSE-------------------------->
      
        <asp:Button ID="Button1" CssClass="btn" runat="server" Text="Registrar" OnClick="btnRegistrar_Click"  />
        

        <!--YA-TENGO-CUENTA----------------------------------------------------------->
        <p class="tengo-cuenta"><a href="#" class="tengo-cuenta">Ya tengo cuenta</a></p>
     </div>
</asp:Content>
