<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="BetterTech_Webpage.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <!-- BREADCRUMBS SETCTION START -->
        <div class="breadcrumbs-section plr-200 mb-80">
            <div class="breadcrumbs overlay-bg">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="breadcrumbs-inner">
                                <h1 class="breadcrumbs-title">Blog style 2</h1>
                                <ul class="breadcrumb-list">
                                    <li><a href="index.html">Home</a></li>
                                    <li>Blog Style - 2</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- BREADCRUMBS SETCTION END -->

        <!-- Start page content -->
        <div id="page-content" class="page-wrapper">

            <!-- BLOG SECTION START -->
            <div class="blog-section mb-50">
                <div class="container">
                    <div class="row">
                        <!-- blog-item start -->
                        <div class="col-sm-6 col-xs-12">
                            <div class="blog-item-2">
                                <div class="row">
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-image">
                                            <a href="single-blog.html"><img src="img/blog/4.jpg" alt=""></a>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-desc">
                                            <h5 class="blog-title-2"><a href="ReportNumVisits.aspx">Number of Visits</a></h5>
                                            <div id="numVisits" runat="server"></div>
                                            <div class="read-more">
                                                <a href="ReportNumVisits.aspx">Read more</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- blog-item end -->
                        <!-- blog-item start -->
                        <div class="col-sm-6 col-xs-12">
                            <div class="blog-item-2">
                                <div class="row">
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-image">
                                            <a href="single-blog.html"><img src="img/blog/5.jpg" alt=""></a>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-desc">
                                            <h5 class="blog-title-2"><a href="ReportNumRegUsers.aspx">Number of Registered Users</a></h5>
                                            <div id="numRegUsers" runat="server"></div>
                                            <div class="read-more">
                                                <a href="ReportNumRegUsers.aspx">Read more</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- blog-item end -->
                        <!-- blog-item start -->
                        <div class="col-sm-6 col-xs-12">
                            <div class="blog-item-2">
                                <div class="row">
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-image">
                                            <a href="single-blog.html"><img src="img/blog/4.jpg" alt=""></a>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-desc">
                                            <h5 class="blog-title-2"><a href="ReportNumProducts.aspx">Number of Products</a></h5>
                                            <div id="numProducts" runat="server"></div>
                                            <div class="read-more">
                                                <a href="ReportNumProducts.aspx">Read more</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- blog-item end -->
                        <!-- blog-item start -->
                        <div class="col-sm-6 col-xs-12">
                            <div class="blog-item-2">
                                <div class="row">
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-image">
                                            <a href="single-blog.html"><img src="img/blog/4.jpg" alt=""></a>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-desc">
                                            <h5 class="blog-title-2"><a href="ReportSOH.aspx">Stock on Hand</a></h5>
                                            <p>Click read more to get a detailed description of stock on hand.</p>
                                            <div class="read-more">
                                                <a href="ReportSOH.aspx">Read more</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- blog-item end -->
                        <!-- blog-item start -->
                        <div class="col-sm-6 col-xs-12">
                            <div class="blog-item-2">
                                <div class="row">
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-image">
                                            <a href="single-blog.html"><img src="img/blog/5.jpg" alt=""></a>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-desc">
                                            <h5 class="blog-title-2"><a href="ReportGross.aspx">Gross Revenue</a></h5>
                                            <div id="grossRev" runat="server"></div>
                                            <div class="read-more">
                                                <a href="ReportGross.aspx">Read more</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- blog-item end -->
                        <!-- blog-item start -->
                        <div class="col-sm-6 col-xs-12">
                            <div class="blog-item-2">
                                <div class="row">
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-image">
                                            <a href="single-blog.html"><img src="img/blog/4.jpg" alt=""></a>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-xs-12">
                                        <div class="blog-desc">
                                            <h5 class="blog-title-2"><a href="ReportNumCustom.aspx">Number of Custom Computers Sold</a></h5>
                                            <p>There are many variations of passages of in psum available, but the majority have sufe ered on in some form...</p>
                                            <div class="read-more">
                                                <a href="ReportNumCustom.aspx">Read more</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- blog-item end -->
                    </div>
                </div>
            </div>
            <!-- BLOG SECTION END -->             
        </div>
        <!-- End page content -->
</asp:Content>
