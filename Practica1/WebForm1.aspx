<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practica1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table>
                <tr>
                    <td>Nombre</td>
                    <td><asp:TextBox ID="Nombre" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>Apellido Paterno</td>
                    <td><asp:TextBox ID="ApellidoP" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>Apellido Materno</td>
                    <td><asp:TextBox ID="ApellidoM" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Borrar" />
                        <asp:Button ID="Button3" runat="server" Text="Actualizar" />
                        <asp:Button ID="Button4" runat="server" Text="Ver" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server" Width="364px"></asp:GridView>


        </div>
    </form>
</body>
</html>
