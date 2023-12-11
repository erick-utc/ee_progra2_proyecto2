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
        <div class="row">
            <div class="col-3 p-2 d-inline-block">
                <label for="id" class="form-label ">CodigoEquipo:</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
        </div>
        <div class="row">
            <div class="btn-group mr-2" role="group" aria-label="Actions group">
                <asp:Button runat="server" IB="BtnConsultar" CssClass="btn btn-primary" Text="Consultar"  />
                <asp:Button runat="server" IB="BtnReset" CssClass="btn btn-primary" Text="Reset"  />
            </div>
        </div>
    </section>
</asp:Content>
