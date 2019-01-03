<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Tracker Archive Lookup - Version 2.0</h1>
        <p class="lead"> Merchant ID <asp:TextBox ID="txtMID" runat="server"></asp:TextBox><asp:Button ID="btnSearch" class="btn btn-primary btn-lg" runat="server" Text="Search" OnClick="btnSearch_Click" /></p>
        
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:GridView ID="grdResults" runat="server"></asp:GridView>
        </div>

    </div>

</asp:Content>
