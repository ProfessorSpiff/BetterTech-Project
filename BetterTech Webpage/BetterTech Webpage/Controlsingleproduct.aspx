<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="Controlsingleproduct.aspx.cs" Inherits="BetterTech_Webpage.Controlsingleproduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="singlepro" runat="server">

    </div>
    <asp:Label ID="Label1" runat="server" Text="New Special Percentage: "></asp:Label>
     <input type="text" runat="server" id="newper" placeholder="">
        <asp:Label ID="Label2" runat="server" Text="On Special"></asp:Label>
    <asp:CheckBox ID="Cbspecial" runat="server" />
    <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />

</asp:Content>
