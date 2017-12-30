<%@ Page Title="ViewState2" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewState2.aspx.cs" Inherits="ViewState.ViewState2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h1>ViewState2</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>       
    </div>

</asp:Content>

