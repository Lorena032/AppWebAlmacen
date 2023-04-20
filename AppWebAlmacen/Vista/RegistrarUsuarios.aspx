<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarUsuarios.aspx.cs" Inherits="AppWebAlmacen.Vista.RegistrarUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/StyleSheetRegU.css" rel="stylesheet" />
    <link href="Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
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

            <%--<asp:Button ID="btnRegistrar" CssClass="registerbtn" runat="server" Text="Registrar" OnClick="btnRegistrar_Click1" />--%>
        </div>

    </form>
    <script src="Bootstrap/js/bootstrap.min.js"></script>
</body>
</html>

