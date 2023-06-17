<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Welcome to Demo Application</h1>
        <div>
            <asp:Button runat="server" id="loadUsersButton" class="btn btn-primary btn-lg" onclick="LoadUsers_Click" Text="Load Users"/>
            <table id="usersTable" runat="server" class="users-table">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Phone</th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
        </div>
    </div>
    <style>
    .users-table {
        border-collapse: collapse;
        width: 100%;
    }
    
    .users-table th, .users-table td {
        border: 1px solid black;
        padding: 8px;
        text-align: left;
    }
    
    .users-table th {
        background-color: #f2f2f2;
    }

    .load-users-button {
        margin-bottom: 20px;
    }

</style>
</asp:Content>

