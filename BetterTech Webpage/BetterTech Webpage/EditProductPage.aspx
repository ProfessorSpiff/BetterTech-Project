<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="EditProductPage.aspx.cs" Inherits="BetterTech_Webpage.EditProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:label runat="server" text="Edit Product Name: "></asp:label>
    <asp:textbox runat="server" ID="txtprdctNmOld"></asp:textbox>
    <asp:textbox runat="server" ID="txtNwPrdctNm"></asp:textbox>

    <br />

    <asp:label runat="server" text="Edit Product Price: "></asp:label>
    <asp:textbox runat="server" ID="txtOldPrdctPrc"></asp:textbox>
    <asp:textbox runat="server" ID="txtNwPrdctPrc"></asp:textbox>

    <br />

    <asp:label runat="server" text="Edit Product Description: "></asp:label>
    <textarea id="txtOldDesrp" cols="20" rows="2" runat="server"></textarea>
    <textarea id="txtNwDesrp" cols="20" rows="2" runat="server"></textarea>

    <br />

    <asp:label runat="server" text="Edit Product Type: "></asp:label>
    <asp:textbox runat="server" ID="txtOldPrdctTyp"></asp:textbox>
    <asp:textbox runat="server" ID="txtNwPrdctTyp"></asp:textbox>

    <br />

    <asp:label runat="server" text="Edit Product Number of Product Sold: "></asp:label>
    <asp:textbox runat="server" ID="txtOldPrdctSldNum"></asp:textbox>
    <asp:textbox runat="server" ID="txtNwPrdctSldNum"></asp:textbox>

    <br />

    <asp:label runat="server" text="Edit Product on Hand: "></asp:label>
    <asp:textbox runat="server" ID="txtOldPrdctHnd"></asp:textbox>
    <asp:textbox runat="server" ID="txtnwPrdctHnd"></asp:textbox>

    <br />

    <asp:label runat="server" text="Edit Product Special: "></asp:label><br />
    <asp:CheckBox ID="txtOldPrctSpcl" runat="server" Text="Old Special"/><br />
    <asp:CheckBox ID="txtNwPrctSpcl" runat="server" Text="New Special"/>

    <br />

    <asp:label runat="server" text="Edit Product Special %: "></asp:label>
    <asp:textbox runat="server" ID="txtOldPrdctSpclPerc"></asp:textbox>
    <asp:textbox runat="server" ID="txtNwPrdctSpclPerc"></asp:textbox>

    <br />

    <asp:label runat="server" text="Edit Product Brand: "></asp:label>
    <asp:textbox runat="server" ID="txtOldPrdctBrnd"></asp:textbox>
    <asp:textbox runat="server" ID="txtNwPrdctBrnd"></asp:textbox>

    <br />

     <asp:label runat="server" text="Edit Product Active: "></asp:label>
     <asp:CheckBox ID="txtOldPrdctActv" runat="server"/>
    <asp:CheckBox ID="txtNwPrdctActv" runat="server" />

    <br />
    <br />

    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />

</asp:Content>
