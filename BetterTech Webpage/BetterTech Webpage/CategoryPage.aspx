<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="CategoryPage.aspx.cs" Inherits="BetterTech_Webpage.CategoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrapper">
        
        <!-- BREADCRUMBS SETCTION START -->
        <%--<div class="breadcrumbs-section plr-200 mb-80">
            <div class="breadcrumbs overlay-bg">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="breadcrumbs-inner">
                                <h1 class="breadcrumbs-title">product grid view</h1>
                                <ul class="breadcrumb-list">
                                    <li><a href="index.html">Home</a></li>
                                    <li>product grid view</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>--%>
        <!-- BREADCRUMBS SETCTION END -->
        
        <!-- Start page content -->
        <div id="page-content" class="page-wrapper">

            <!-- SHOP SECTION START -->
            <div class="shop-section mb-80">
                <div class="container">
                    <div class="row">
                        <div class="col-md-9 col-md-push-3 col-sm-12">
                            <div class="shop-content">
                                <!-- shop-option start -->
                                <div class="shop-option box-shadow mb-30 clearfix">
                                    <!-- Nav tabs -->
                                    <ul class="shop-tab f-left" role="tablist" id="NavTab" runat="server">
                                        <li class="active">
                                            <a href="#gridview" data-toggle="tab"><i class="zmdi zmdi-view-module"></i></a>
                                        </li>
                                        <li>
                                            <a href="#listview" data-toggle="tab"><i class="zmdi zmdi-view-list-alt"></i></a>
                                        </li>
                                    </ul>
                                    <!-- short-by -->
                                    <div class="short-by f-left text-center">
                                        <a href="ControlSpecials.aspx">ControlSpecials.aspx</a>
                                        <span>Sort by :</span>

                                        <%--<select>
                                            <option value="lowestprice">Special Prices</option>
                                            <option value="lowestprice">Lowest to Highest Price</option>
                                            <option value="highestprice">Highest to Lowest Price</option>
                                            
                                        </select>--%>

                                        <asp:DropDownList ID="prcDrpDwn" AutoPostBack="true" runat="server" OnSelectedIndexChanged="prcDrpDwn_SelectedIndexChanged">
                                            
                                            <asp:ListItem Value="0">Ascending Price</asp:ListItem>
                                            <asp:ListItem Value="1">Descending Price</asp:ListItem>
                                        </asp:DropDownList>

                                    </div> 
                                    <!-- showing -->
                                    <%--<div class="showing f-right text-right">
                                        <span>Showing : 01-09 of 17.</span>
                                    </div> --%>                                  
                                </div>
                                <!-- shop-option end -->
                                <!-- Tab Content start -->
                                <div class="tab-content">
                                    <!-- grid-view -->
                                    <div role="tabpanel" class="tab-pane active" id="gridview" >
                                        <div class='row' id="gridImg" runat="server">

                                        <%--Product Images in Grid View Placed Here--%>

                                        </div>
                                    </div>
                                    <!-- list-view -->
                                    <div role="tabpanel" class="tab-pane" id="listview">
                                        <div class="row" id="listImg" runat="server">
                                            
                                            <%--Product Presented In a List View Here--%>

                                        </div>                                        
                                    </div>
                                </div>
                                <!-- Tab Content end -->
                                <!-- shop-pagination start -->

                                <ul class="shop-pagination text-left ptblr-10-30">
                                    <asp:LinkButton ID="btnShwMore" CssClass="zmdi zmdi-arrow-forward" runat="server" OnClick="btnShwMore_Click"><h6> Show More Products</h6></asp:LinkButton>
                                </ul>
                                <br />
                                <ul class="shop-pagination text-right ptblr-10-30">
                                    <asp:LinkButton ID="btnShwLess" CssClass="zmdi zmdi-arrow-back" runat="server" OnClick="btnShwLess_Click"><h6> Show Less Products</h6></asp:LinkButton>
                                </ul>
                                
                                <!-- shop-pagination end -->
                            </div>
                        </div>
                        <div class="col-md-3 col-md-pull-9 col-sm-12">
                            <!-- widget-search -->
                            <aside class="widget-search mb-30">
                                <form action="#">
                                    <input type="text" placeholder="Search here..." runat="server" id="txtSrch">
                                   <%-- <button type="submit"><i class="zmdi zmdi-search"></i></button>--%>
                                    <br />
                                    <asp:LinkButton CssClass="zmdi zmdi-search" ID="btnSrchLst" runat="server" OnClick="btnSrchLst_Click"><h6>Search</h6></asp:LinkButton>

                                </form>
                            </aside>
                            <!-- widget-categories -->
                            <aside class="widget widget-categories box-shadow mb-30">
                                <h6 class="widget-title border-left mb-20">Categories</h6>
                               <%-- <div id="cat-treeview" class="product-cat" runat="server">--%>
                                 <div id="cat-treeview" class="product-cat" >
                                    <ul id="ulCategoryList" runat="server">

                                        <%--Category Selection--%>

                                    </ul>
                                </div>
                            </aside>
                            <!-- shop-filter -->
                            <aside class="widget shop-filter box-shadow mb-30">
                                <h6 class="widget-title border-left mb-20">Price</h6>
                                <div class="price_filter">
                                    <div class="price_slider_amount">
                                        <input type="submit"  value="You range :"/>
                                        <input type="text" id="amount" name="price"  placeholder="Add Your Price" runat="server" ClientIDMode="Static"/>
                                    </div>
                                    <div id="slider-range"></div>
                                    <br />
                                    <%--<a class="button extra-small mb-20" href="CategoryPage.aspx" runat="server"><span>Buttons </span> </a>--%>
                                    <asp:LinkButton CssClass="button extra-small mb-20" ButtonType="LinkButton" ID="btnSrchPrc" runat="server" OnClick="btnSrchPrc_Click" > Search </asp:LinkButton>
                                    <%--<asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>--%>
                                </div>
                            </aside>

                            <!-- widget-product -->
                            <aside class="widget widget-product box-shadow" id="WidgetProduct" runat="server">
                                
                                <%--Recent Product Population Here--%>

                            </aside>
                        </div>
                    </div>
                </div>
            </div>
            <!-- SHOP SECTION END -->             

        </div>
        <!-- End page content -->

     </div>

</asp:Content>
