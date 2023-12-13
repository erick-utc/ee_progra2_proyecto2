<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedOut.Master" AutoEventWireup="true" CodeBehind="EquiposUsuario.aspx.cs" Inherits="EE_Examen2_Progra2.EquiposUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container">
        <h1 class="text-center">Equipos de Usuario</h1>
        <asp:Label runat="server" ID="lblUsuario" CssClass="form-label text-center" />
        <div class="col--12 p-4">
            <asp:GridView runat="server" ID="dgEquipos" PageSize="10" HorizontalAlign="Center"
                CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
                RowStyle-CssClass="rows" AllowPaging="True"    />
        </div>
    </section>
</asp:Content>
