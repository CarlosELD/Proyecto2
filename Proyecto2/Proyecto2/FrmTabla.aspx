<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmTabla.aspx.cs" Inherits="Proyecto2.FrmCategorias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 194px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text="ID:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="ISBN:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtISBN" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="TITULO:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTitulo" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Font-Size="Medium" Text="NUMEROdeEDICION:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNumEdic" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Font-Size="Medium" Text="NOMBREAUTORES:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNumAut" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Font-Size="Medium" Text="PAISPUBLICACION:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPaisP" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label8" runat="server" Font-Size="Medium" Text="SINOPSIS:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSinopsis" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label9" runat="server" Font-Size="Medium" Text="CARRERA:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCarrera" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label10" runat="server" Font-Size="Medium" Text="MATERIA:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMateria" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label11" runat="server" Font-Size="Medium" Text="AÑOPUBLICACION:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAño" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAgregar" runat="server" Height="40px" OnClick="btnAgregar_Click" Text="Agregar" Width="111px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="gv" runat="server" Width="673px">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
