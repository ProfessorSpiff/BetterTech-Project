<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="CRUDProducts.aspx.cs" Inherits="BetterTech_Webpage.CRUDProducts" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- BREADCRUMBS SETCTION START -->
    <%--<div class="breadcrumbs-section plr-200 mb-80">
            <div class="breadcrumbs overlay-bg">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="breadcrumbs-inner">
                                <h1 class="breadcrumbs-title">Accordion</h1>
                                <ul class="breadcrumb-list">
                                    <li><a href="index.aspx">Home</a></li>
                                    <li>Accordion</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>--%>
    <!-- BREADCRUMBS SETCTION END -->

    <!-- Start page content -->
    <section id="page-content" class="page-wrapper">

        <div class="mb-80">
            <!-- Accordion Start -->
            <div class="container">
                <div class="row">
                    <div class="col-md-12">

                        <div class="panel-body">
                            <h3>Add Product</h3>
                            <input runat="server" id="prodName" type="text" name="name" placeholder="Product Name" >
                            <input runat="server" id="prodPrice" type="text" name="name" placeholder="Product Price" >
                            <input runat="server" id="prodDesc" type="text" name="name" placeholder="Product Description" >
                            <input runat="server" id="prodType" type="text" name="name" placeholder="Product Type">
                            <input runat="server" id="prodImg" type="text" name="name" placeholder="Product Image" >
                            <input runat="server" id="prodOnHand" type="text" name="name" placeholder="Stock On Hand"  >
                            <input runat="server" id="prodBrand" type="text" name="name" placeholder="Product Brand"  >
                            <asp:Button ID="addProdBtn" runat="server" CssClass="submit-btn-1 btn-hover-1" Text="Add" OnClick="addProd_Click" />
                            <div id="addResponse" runat="server"></div>
                        </div>
                        <hr />
                        <div class="panel-body">
                            <h3>Remove Product</h3>
                            <div id="removeProd" runat="server">
                            </div>
                            <input runat="server" id="deleteId" type="text" name="name" placeholder="Remove Product"  >
                            <asp:Button ID="removeBtn" runat="server" CssClass="submit-btn-1 btn-hover-1" Text="Remove" OnClick="removeBtn_Click" />
                        </div>
                        <hr />
                        <div class="panel-body">
                            <h3>Edit Product</h3>
                            <div id="editProd" runat="server">
                            </div>
                            <div class="short-by f-left text-center">
                                <span>Edit:</span>
                                <select size="1" runat="server" name="edit" id="edit">
                                    <option selected="selected" name="editID" runat="server">Product ID</option>
                                    <option name="editName" runat="server">Product Name</option>
                                    <option name="editDesc" runat="server">Product Description</option>
                                    <option name="editType" runat="server">Product Type</option>
                                    <option name="editImg" runat="server">Product Image</option>
                                    <option name="editOH" runat="server">Product On Hand</option>
                                    <option name="editBrand" runat="server">Product Brand</option>
                                </select>
                            </div>
                            <br />
                            <br />
                            <input runat="server" id="prodEditThing" type="text" name="name" placeholder="Product...">
                            <br />
                            <br />
                            <asp:Button ID="editButton" runat="server" CssClass="submit-btn-1 btn-hover-1" Text="Edit" OnClick="editBtn_Click" />
                            <!-- <div id="responseEdit" runat="server"></div> -->
                        </div>

                    </div>
                </div>
                <!-- Accordion End -->

            </div>
        </div>
    </section>
    <!-- End page content -->
</asp:Content>
