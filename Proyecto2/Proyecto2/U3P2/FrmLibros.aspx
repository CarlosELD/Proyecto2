<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLibros.aspx.cs" Inherits="U3P2.FrmLibros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 507px;
            background-color: #CCCCFF;
        }
        .auto-style2 {
            width: 194px;
        }
        .auto-style3 {
            background-color: #CCCCFF;
        }
        .auto-style4 {
            width: 194px;
            background-color: #CCCCFF;
        }
        .auto-style5 {
            height: 137px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label12" runat="server" style="color: #000066" Text="LIBROS ITSUR "></asp:Label>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text="ID:"></asp:Label>
                    </td>
                    <td>
                        Incremental</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="ISBN:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtISBN" runat="server" Font-Size="Medium" Width="327px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="TITULO:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTitulo" runat="server" Font-Size="Medium" Width="327px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Font-Size="Medium" Text="NÚMERO DE EDICION:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNumEdic" runat="server" Font-Size="Medium" Width="327px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label6" runat="server" Font-Size="Medium" Text="NOMBREAUTORES:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtNumAut" runat="server" Font-Size="Medium" Width="327px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Font-Size="Medium" Text="PAÍS DE PUBLICACIÓN:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPaisP" runat="server" Font-Size="Medium" Width="327px" OnTextChanged="txtPaisP_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label8" runat="server" Font-Size="Medium" Text="SINOPSIS:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSinopsis" runat="server" Font-Size="Medium" Width="327px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label9" runat="server" Font-Size="Medium" Text="CARRERA:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCarrera" runat="server" Font-Size="Medium" Width="327px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label10" runat="server" Font-Size="Medium" Text="MATERIA:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMateria" runat="server" Font-Size="Medium" Width="327px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label11" runat="server" Font-Size="Medium" Text="AÑO DE PUBLICACIÓN:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAño" runat="server" Font-Size="Medium" Width="327px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAgregar" runat="server" Height="44px" OnClick="btnAgregar_Click" Text="AGREGAR" Width="112px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style5">
                        <asp:GridView ID="gvLibros" runat="server" Width="673px" style="background-color: #FFFFFF">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="MOSTRAR" Height="45px" Width="112px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
