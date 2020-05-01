<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FormWebProducto.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="estilos.css" rel="stylesheet" type="text/css" />


</head>
<body >
    <form id="formProducto" runat="server" >
        <div>
            <h3>Productos: </h3>
            <asp:Label class="label" ID="LabelNombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label class="label" ID="LabelDescripcion" runat="server" Text="Descripcion:"></asp:Label>
            <asp:TextBox ID="TxtDescripcion" runat="server"></asp:TextBox>
            <br />
            <asp:Label class="label" ID="LabelPrecio" runat="server" Text="Precio:"></asp:Label>
            <asp:TextBox ID="TxtPrecio" runat="server"></asp:TextBox>
            <br />
            <asp:Label class="label" ID="LabelStock" runat="server" Text="Stock:"></asp:Label>
            <asp:TextBox ID="TxtStock" runat="server"></asp:TextBox>
        </div>
        <br />
         <div class="botones">
        <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
        <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" OnClick="BtnCancelar_Click" />
        <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click" />
    </div>
        <br />
        <asp:GridView ID="GridViewProductos" runat="server" OnSelectedIndexChanged="GridViewProductos_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
          
            
        </asp:GridView>
        
        
    </form>   
        
</body>
</html>
