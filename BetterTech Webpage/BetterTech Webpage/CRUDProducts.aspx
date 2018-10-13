<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="CRUDProducts.aspx.cs" Inherits="BetterTech_Webpage.CRUDProducts" %>
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
                        <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
                            <div class="panel panel-default">
                                <div class="panel-heading" role="tab" id="headingOne">
                                    <h4 class="panel-title">
                                        <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                        Add New Product
                                        </a>
                                    </h4>
                                </div>
                                <div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
                                    <div class="panel-body">
                                        <input runat="server" id="prodID" type="text" name="name" placeholder="Product ID" autofocus required>
                                        <input runat="server" id="prodName" type="text" name="name" placeholder="Product Name" autofocus required>
                                        <input runat="server" id="prodPrice" type="text" name="name" placeholder="Product Price" autofocus required>
                                        <input runat="server" id="prodDesc" type="text" name="name" placeholder="Product Description" autofocus required>
                                        <input runat="server" id="prodType" type="text" name="name" placeholder="Product Type" autofocus required>
                                        <input runat="server" id="prodImg" type="text" name="name" placeholder="Product Image" autofocus required>
                                        <input runat="server" id="prodOnHand" type="text" name="name" placeholder="Stock On Hand" autofocus required>
                                        <input runat="server" id="prodBrand" type="text" name="name" placeholder="Product Brand" autofocus required>
                                        <asp:Button id="addProdBtn" runat="server" CssClass="submit-btn-1 btn-hover-1" Text="Add" OnClick="addProd_Click"/>
                                        <div id="addResponse" runat="server"></div>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-default">
                                <div class="panel-heading" role="tab" id="headingTwo">
                                    <h4 class="panel-title">
                                        <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                                        Remove a Product
                                        </a>
                                    </h4>
                                </div>
                                <div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
                                    <div class="panel-body">
                                        <div id="removeProd" runat="server">

                                        </div>
                                        <input runat="server" id="deleteId" type="text" name="name" placeholder="Remove Product" autofocus required>
                                        <asp:Button id="removeBtn" runat="server" CssClass="submit-btn-1 btn-hover-1" Text="Remove" OnClick="removeBtn_Click"/>
                                    </div>
                                </div>
                            </div>
                            <div class="panel panel-default">
                                <div class="panel-heading" role="tab" id="headingThree">
                                    <h4 class="panel-title">
                                        <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                                        Edit a Product
                                        </a>
                                    </h4>
                                </div>
                                <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
                                    <div class="panel-body">
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
                                        <br/>

                                        <br/>
                                        <input runat="server" id="prodEditThing" type="text" name="name" placeholder="Product...">
                                        <br />

                                        <br/>
                                        
                                        <asp:Button ID="editButton" runat="server" CssClass="submit-btn-1 btn-hover-1" Text="Edit" OnClick="editBtn_Click"/>
                                        <!-- <div id="responseEdit" runat="server"></div> -->
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Accordion End -->   

            </div>         
        </section>
        <!-- End page content -->
</asp:Content>
