<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistroProducto.aspx.cs" Inherits="AppWebAlmacen.Vista.RegistroProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/sweetalert.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-w3layouts wrapper">
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
    </div>
</asp:Content>
