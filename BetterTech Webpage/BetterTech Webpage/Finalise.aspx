<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="Finalise.aspx.cs" Inherits="BetterTech_Webpage.Finalise" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shop-section mb-80">
        <div class="container">
            <div class="row">
                <div class="col-md-2 col-sm-12">
                    <div id="stuff" runat="server"></div>
                    <asp:Button runat="server" ID="final" CssClass="submit-btn-1 mt-20 btn-hover-1" Text="Add To Cart" OnClick="final_Click"/>
                    </div>
                
                </div>
            </div>
        </div>
</asp:Content>
