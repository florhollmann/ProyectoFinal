<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaLibro.aspx.cs" Inherits="PresentacionWeb.AltaLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <h2>Ingreso de libro</h2>
    <form id="form1" runat="server">
        <div>
            <table class="table" style="width: 100%;">
                <tr>
                    <td class="auto-style13">ISBN:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="ISBN" runat="server" Width="365px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Nombre del Libro:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="NombreLibro" runat="server" Width="362px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">Nombre Autor:</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="NombreAutor" runat="server" Width="363px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Apellido Autor:</td>
                    <td class="auto-style10"><asp:TextBox ID="ApellidoAutor" runat="server" Width="364px"></asp:TextBox></td>
                </tr>

                
                <tr>
                    <td class="auto-style7"><asp:Button ID="btnEnviar" CssClass="btn-primary" runat="server" Text="Enviar" OnClick="btnEnviar_Click" /></td>
                    <td class="auto-style8"><asp:Label ID="lblMensaje" runat="server" Text=" "></asp:Label></td>
                </tr>
            </table>
        </div>

    </form>
    </body>
</html>
