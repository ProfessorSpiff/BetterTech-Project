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
                        <!-- blog-option start -->
                        <div class="col-md-12">
                            <div class="blog-option box-shadow mb-30  clearfix">
                                <!-- categories -->
                                <div class="dropdown f-left">
                                    <button class="option-btn">
                                        Categories
                                        <i class="zmdi zmdi-chevron-down"></i>
                                    </button>
                                    <div class="dropdown-menu dropdown-width mt-30">
                                        <aside class="widget widget-categories box-shadow">
                                            <h6 class="widget-title border-left mb-20">Categories</h6>
                                            <div id="cat-treeview" class="product-cat">
                                                <ul>
                                                    <li class="closed"><a href="#">Brand One</a>
                                                        <ul>
                                                            <li><a href="#">Mobile</a></li>
                                                            <li><a href="#">Tab</a></li>
                                                            <li><a href="#">Watch</a></li>
                                                            <li><a href="#">Head Phone</a></li>
                                                            <li><a href="#">Memory</a></li>
                                                        </ul>
                                                    </li>                                       
                                                    <li class="open"><a href="#">Brand Two</a>
                                                        <ul>
                                                            <li><a href="#">Mobile</a></li>
                                                            <li><a href="#">Tab</a></li>
                                                            <li><a href="#">Watch</a></li>
                                                            <li><a href="#">Head Phone</a></li>
                                                            <li><a href="#">Memory</a></li>
                                                        </ul>
                                                    </li>
                                                    <li class="closed"><a href="#">Accessories</a>
                                                        <ul>
                                                            <li><a href="#">Footwear</a></li>
                                                            <li><a href="#">Sunglasses</a></li>
                                                            <li><a href="#">Watches</a></li>
                                                            <li><a href="#">Utilities</a></li>
                                                        </ul>
                                                    </li>
                                                    <li class="closed"><a href="#">Top Brands</a>
                                                        <ul>
                                                            <li><a href="#">Mobile</a></li>
                                                            <li><a href="#">Tab</a></li>
                                                            <li><a href="#">Watch</a></li>
                                                            <li><a href="#">Head Phone</a></li>
                                                            <li><a href="#">Memory</a></li>
                                                        </ul>
                                                    </li>
                                                    <li class="closed"><a href="#">Jewelry</a>
                                                        <ul>
                                                            <li><a href="#">Footwear</a></li>
                                                            <li><a href="#">Sunglasses</a></li>
                                                            <li><a href="#">Watches</a></li>
                                                            <li><a href="#">Utilities</a></li>
                                                        </ul>
                                                    </li>
                                                </ul>
                                            </div>
                                        </aside>
                                    </div>
                                </div>
                                <!-- recent-product -->
                                <div class="dropdown f-left">
                                    <button class="option-btn">
                                        Recent Post
                                        <i class="zmdi zmdi-chevron-down"></i>
                                    </button>
                                    <div class="dropdown-menu dropdown-width mt-30">
                                        <aside class="widget widget-product box-shadow">
                                            <h6 class="widget-title border-left mb-20">recent products</h6>
                                            <!-- product-item start -->
                                            <div class="product-item">
                                                <div class="product-img">
                                                    <a href="single-product.html">
                                                        <img src="img/cart/4.jpg" alt=""/>
                                                    </a>
                                                </div>
                                                <div class="product-info">
                                                    <h6 class="product-title multi-line mt-10">
                                                        <a href="single-product.html">Dummy Blog Name</a>
                                                    </h6>
                                                </div>
                                            </div>
                                            <!-- product-item end -->
                                            <!-- product-item start -->
                                            <div class="product-item">
                                                <div class="product-img">
                                                    <a href="single-product.html">
                                                        <img src="img/cart/5.jpg" alt=""/>
                                                    </a>
                                                </div>
                                                <div class="product-info">
                                                    <h6 class="product-title multi-line mt-10">
                                                        <a href="single-product.html">Dummy Blog Name</a>
                                                    </h6>
                                                </div>
                                            </div>
                                            <!-- product-item end -->
                                            <!-- product-item start -->
                                            <div class="product-item">
                                                <div class="product-img">
                                                    <a href="single-product.html">
                                                        <img src="img/cart/6.jpg" alt=""/>
                                                    </a>
                                                </div>
                                                <div class="product-info">
                                                    <h6 class="product-title multi-line mt-10">
                                                        <a href="single-product.html">Dummy Blog Name</a>
                                                    </h6>
                                                </div>
                                            </div>
                                            <!-- product-item end -->                               
                                        </aside>      
                                    </div>
                                </div>
                                <!-- Tags -->
                                <div class="dropdown f-left">
                                    <button class="option-btn">
                                        Tags
                                        <i class="zmdi zmdi-chevron-down"></i>
                                    </button>
                                    <div class="dropdown-menu dropdown-width mt-30">
                                        <aside class="widget widget-tags box-shadow">
                                            <h6 class="widget-title border-left mb-20">Tags</h6>
                                            <ul class="widget-tags-list">
                                                <li><a href="#">Bleckgerry ios</a></li>
                                                <li><a href="#">Symban</a></li>
                                                <li><a href="#">IOS</a></li>
                                                <li><a href="#">Bleckgerry</a></li>
                                                <li><a href="#">Windows Phone</a></li>
                                                <li><a href="#">Windows Phone</a></li>
                                                <li><a href="#">Androids</a></li>
                                            </ul>                  
                                        </aside>      
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- blog-option end -->
                    </div>
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
                                            <h5 class="blog-title-2"><a href="#">Number of Visits</a></h5>
                                            <p>There are many variations of passages of in psum available, but the majority have sufe ered on in some form...</p>
                                            <div class="read-more">
                                                <a href="#">Read more</a>
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
                                            <h5 class="blog-title-2"><a href="#">Number of Registered Users</a></h5>
                                            <p>There are many variations of passages of in psum available, but the majority have sufe ered on in some form...</p>
                                            <div class="read-more">
                                                <a href="#">Read more</a>
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
                                            <h5 class="blog-title-2"><a href="#">Number of Products</a></h5>
                                            <p>There are many variations of passages of in psum available, but the majority have sufe ered on in some form...</p>
                                            <div class="read-more">
                                                <a href="#">Read more</a>
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
                                            <h5 class="blog-title-2"><a href="#">Stock on Hand</a></h5>
                                            <p>There are many variations of passages of in psum available, but the majority have sufe ered on in some form...</p>
                                            <div class="read-more">
                                                <a href="#">Read more</a>
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
                                            <h5 class="blog-title-2"><a href="#">Gross Revenue</a></h5>
                                            <p>There are many variations of passages of in psum available, but the majority have sufe ered on in some form...</p>
                                            <div class="read-more">
                                                <a href="#">Read more</a>
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
                                            <h5 class="blog-title-2"><a href="#">Number of Custom Computers Sold</a></h5>
                                            <p>There are many variations of passages of in psum available, but the majority have sufe ered on in some form...</p>
                                            <div class="read-more">
                                                <a href="#">Read more</a>
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
