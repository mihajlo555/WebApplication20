<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication20.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label5" runat="server" Text="ime naloga"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:Label ID="Label6" runat="server" Text="lozinka"></asp:Label>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="prijava" OnClick="Button2_Click" />

    <asp:Label ID="Label1" runat="server" Text="prijava radnika" Visible="false"></asp:Label>

    <br/><br/>

    <asp:Label ID="Label2" runat="server" Text="ime" Visible="false"></asp:Label>

    <asp:TextBox ID="TextBox1" runat="server" Visible="false"></asp:TextBox>

    <asp:Label ID="Label3" runat="server" Text="prezime" Visible="false"></asp:Label>

    <asp:TextBox ID="TextBox2" runat="server" Visible="false"></asp:TextBox>

    <asp:Label ID="Label4" runat="server" Text="datum rodjenja" Visible="false"></asp:Label>

    <asp:TextBox ID="TextBox3" runat="server" Visible="false"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="upisi" Visible="false" OnClick="Button1_Click"/>

    <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="true"></asp:GridView>



</asp:Content>
