<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedOut.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EE_Examen2_Progra2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center mt-5">


        <div class="card">
            <div class="form px-4 pt-5 pb-5">
            <asp:TextBox ID="txtUser" runat="server" type="text" name="" class="form-control" placeholder="Username" />

            <asp:TextBox ID="txtPass" runat="server" type="password" name="" class="form-control mt-2" placeholder="Password" />
                    
                <asp:Button ID="btnLogin" runat="server" class="btn btn-dark btn-block mt-4" Text="Login" OnClick="btnLogin_Click" />

            </div>
        </div>
        

      </div>
</asp:Content>
