<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="BetterTech_Webpage.AdminHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!doctype html>
<html class="no-js" lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>Subash || Blog Right Sidebar</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Favicon -->
    <link rel="shortcut icon" type="image/x-icon" href="img/icon/favicon.png">

    <!-- All CSS Files -->
    <!-- Bootstrap fremwork main css -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <!-- Nivo-slider css -->
    <link rel="stylesheet" href="lib/css/nivo-slider.css">
    <!-- This core.css file contents all plugings css file. -->
    <link rel="stylesheet" href="css/core.css">
    <!-- Theme shortcodes/elements style -->
    <link rel="stylesheet" href="css/shortcode/shortcodes.css">
    <!-- Theme main style -->
    <link rel="stylesheet" href="style.css">
    <!-- Responsive css -->
    <link rel="stylesheet" href="css/responsive.css">
    <!-- Template color css -->
    <link href="css/color/color-core.css" data-style="styles" rel="stylesheet">
    <!-- User style -->
    <link rel="stylesheet" href="css/custom.css">

    <!-- Modernizr JS -->
    <script src="js/vendor/modernizr-2.8.3.min.js"></script>
</head>

<body>
    <!--[if lt IE 8]>
        <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
    <![endif]-->  

    <!-- Body main wrapper start -->
    <div class="wrapper">

        <!-- START MOBILE MENU AREA
        <div class="mobile-menu-area hidden-lg hidden-md">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="mobile-menu">
                            <nav id="dropdown">
                                <ul>
                                    <li><a href="index.html">Home</a>
                                        <ul>
                                            <li>
                                                <a href="index.html">Home Version 1</a>
                                            </li>
                                            <li>
                                                <a href="index-2.html">Home Version 2</a>
                                            </li>
                                            <li>
                                                <a href="index-3.html">Home Version 3</a>
                                            </li>
                                            <li>
                                                <a href="index-4.html">Home 4 Animated Text</a>
                                            </li>
                                            <li>
                                                <a href="index-5.html">Home 5 Animated Text Ovlerlay</a>
                                            </li>
                                            <li>
                                                <a href="index-6.html">Home 6 Background Video</a>
                                            </li>
                                            <li>
                                                <a href="index-7.html">Home 7 BG-Video Ovlerlay</a>
                                            </li>
                                            <li>
                                                <a href="index-8.html">Home 8 Boxed-1</a>
                                            </li>
                                            <li>
                                                <a href="index-9.html">Home 9 Gradient</a>
                                            </li>
                                            <li>
                                                <a href="index-10.html">Home 10 Boxed-2</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="shop.html">Products</a>
                                    </li>
                                    <li><a href="#">Pages</a>
                                        <ul>
                                            <li>
                                                <a href="shop.html">Shop</a>
                                            </li>
                                            <li>
                                                <a href="shop-left-sidebar.html">Shop Left Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="shop-right-sidebar.html">Shop Right Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="shop-list.html">Shop List</a>
                                            </li>
                                            <li>
                                                <a href="shop-list-right-sidebar.html">Shop List Right Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="single-product.html">Single Product</a>
                                            </li>
                                            <li>
                                                <a href="single-product-left-sidebar.html">Single Product Left Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="single-product-no-sidebar.html">Single Product No Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="cart.html">Shopping Cart</a>
                                            </li>
                                            <li>
                                                <a href="wishlist.html">Wishlist</a>
                                            </li>
                                            <li>
                                                <a href="checkout.html">Checkout</a>
                                            </li>
                                            <li>
                                                <a href="order.html">Order</a>
                                            </li>
                                            <li>
                                                <a href="login.html">Login</a>
                                            </li>
                                            <li>
                                                <a href="My-account.html">My Account</a>
                                            </li>
                                            <li>
                                                <a href="about.html">About us</a>
                                            </li>
                                            <li>
                                                <a href="404.html">404</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li><a href="blog.html">Blog</a>
                                        <ul>
                                            <li>
                                                <a href="blog.html">Blog</a>
                                            </li>
                                            <li>
                                                <a href="blog-left-sidebar.html">Blog Left Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="blog-right-sidebar.html">Blog Right Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="blog-2.html">Blog style 2</a>
                                            </li>
                                            <li>
                                                <a href="blog-2-left-sidebar.html">Blog 2 Left Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="blog-2-right-sidebar.html">Blog 2 Right Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="single-blog.html">Blog Details</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="about.html">About Us</a>
                                    </li>
                                    <li>
                                        <a href="contact.html">Contact</a>
                                    </li>
                                </ul>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
        </div>
         END MOBILE MENU AREA -->
        <!-- Start page content -->
        <div id="page-content" class="page-wrapper">

            <!-- BLOG SECTION START -->
            <div class="blog-section mb-50">
                <div class="container">
                    <div class="row">
                        <div class="col-md-9 col-xs-12">
                            <div class="row">
                                <!-- blog-option start -->
                                <div class="col-md-12">
                                    <div class="blog-option box-shadow mb-30  clearfix">
                                        <!-- categories -->
                                        <div class="dropdown f-left">
                                            <button class="option-btn">
                                                <i class="zmdi zmdi-chevron-down"></i>
                                            </button>
                                            <div class="dropdown-menu dropdown-width mt-30">
                                                <aside class="widget widget-categories box-shadow">
                                                    <h6 class="widget-title border-left mb-20">Product</h6>
                                                    <div id="cat-treeview-2" class="product-cat">
                                                        <ul>
                                                            <li class="closed"><a href="#">Add Product</a></li>                                       
                                                            <li class="open"><a href="#">Delete Product</a></li>
                                                            <li class="closed"><a href="#">Edit Product details</a></li>
                                                        </ul>
                                                    </div>
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
                                    <!-- ADDRESS SECTION START -->
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <div class="contact-address box-shadow">
                                <h3>Profit Made</h3>
                                <h6>+25%</h6>
                            </div>
                        </div>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <div class="contact-address box-shadow">
                                <h3>People</h3>
                                <h6>+15%</h6>
                            </div>
                        </div>
            <!-- ADDRESS SECTION END --> 
                                <!-- blog-item start -->
                                <div class="col-md-6 col-sm-6 col-xs-12">
                                    <div class="blog-item">
                                        <img src="img/blog/1.jpg" alt="">
                                        <div class="blog-desc">
                                            <h5 class="blog-title"><a href="single-blog.html">dummy Blog name</a></h5>
                                            <p>There are many variations of passages of psum available, but the majority have suffered alterat on in some form, by injected humour, randomis words which don't look even slightly.</p>
                                            <div class="read-more">
                                                <a href="single-blog.html">Read more</a>
                                            </div>
                                            <ul class="blog-meta">
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-favorite"></i>89 Like</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-comments"></i>59 Comments</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-share"></i>29 Share</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <!-- blog-item end -->
                                <!-- blog-item start -->
                                <div class="col-md-6 col-sm-6 col-xs-12">
                                    <div class="blog-item">
                                        <img src="img/blog/2.jpg" alt="">
                                        <div class="blog-desc">
                                            <h5 class="blog-title"><a href="single-blog.html">dummy Blog name</a></h5>
                                            <p>There are many variations of passages of psum available, but the majority have suffered alterat on in some form, by injected humour, randomis words which don't look even slightly.</p>
                                            <div class="read-more">
                                                <a href="single-blog.html">Read more</a>
                                            </div>
                                            <ul class="blog-meta">
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-favorite"></i>89 Like</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-comments"></i>59 Comments</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-share"></i>29 Share</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <!-- blog-item end -->
                                <!-- blog-item start -->
                                <div class="col-md-6 col-sm-6 col-xs-12">
                                    <div class="blog-item">
                                        <img src="img/blog/3.jpg" alt="">
                                        <div class="blog-desc">
                                            <h5 class="blog-title"><a href="single-blog.html">dummy Blog name</a></h5>
                                            <p>There are many variations of passages of psum available, but the majority have suffered alterat on in some form, by injected humour, randomis words which don't look even slightly.</p>
                                            <div class="read-more">
                                                <a href="single-blog.html">Read more</a>
                                            </div>
                                            <ul class="blog-meta">
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-favorite"></i>89 Like</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-comments"></i>59 Comments</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-share"></i>29 Share</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <!-- blog-item end -->
                                <!-- blog-item start -->
                                <div class="col-md-6 col-sm-6 col-xs-12">
                                    <div class="blog-item">
                                        <img src="img/blog/4.jpg" alt="">
                                        <div class="blog-desc">
                                            <h5 class="blog-title"><a href="single-blog.html">dummy Blog name</a></h5>
                                            <p>There are many variations of passages of psum available, but the majority have suffered alterat on in some form, by injected humour, randomis words which don't look even slightly.</p>
                                            <div class="read-more">
                                                <a href="single-blog.html">Read more</a>
                                            </div>
                                            <ul class="blog-meta">
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-favorite"></i>89 Like</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-comments"></i>59 Comments</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-share"></i>29 Share</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <!-- blog-item end -->
                                <!-- blog-item start -->
                                <div class="col-md-6 col-sm-6 col-xs-12">
                                    <div class="blog-item">
                                        <img src="img/blog/5.jpg" alt="">
                                        <div class="blog-desc">
                                            <h5 class="blog-title"><a href="single-blog.html">dummy Blog name</a></h5>
                                            <p>There are many variations of passages of psum available, but the majority have suffered alterat on in some form, by injected humour, randomis words which don't look even slightly.</p>
                                            <div class="read-more">
                                                <a href="single-blog.html">Read more</a>
                                            </div>
                                            <ul class="blog-meta">
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-favorite"></i>89 Like</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-comments"></i>59 Comments</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-share"></i>29 Share</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <!-- blog-item end -->
                                <!-- blog-item start -->
                                <div class="col-md-6 col-sm-6 col-xs-12">
                                    <div class="blog-item">
                                        <img src="img/blog/6.jpg" alt="">
                                        <div class="blog-desc">
                                            <h5 class="blog-title"><a href="single-blog.html">dummy Blog name</a></h5>
                                            <p>There are many variations of passages of psum available, but the majority have suffered alterat on in some form, by injected humour, randomis words which don't look even slightly.</p>
                                            <div class="read-more">
                                                <a href="single-blog.html">Read more</a>
                                            </div>
                                            <ul class="blog-meta">
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-favorite"></i>89 Like</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-comments"></i>59 Comments</a>
                                                </li>
                                                <li>
                                                    <a href="#"><i class="zmdi zmdi-share"></i>29 Share</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <!-- blog-item end -->
                               
                            </div>                            
                        </div>
                        <!-- sidebar -->
                        <div class="col-md-3 col-xs-12">
                            <!-- widget-categories -->
                            <aside class="widget widget-categories box-shadow mb-30">
                                <h6 class="widget-title border-left mb-20">Product</h6>
                                <div id="cat-treeview" class="product-cat">
                                    <ul>
                                        <li class="closed"><a href="#">Add Product</a></li>
                                        <li class="open"><a href="#">Delete Product</a></li>
                                        <li class="closed"><a href="#">Edit Product details</a></li>
                                    </ul>
                                </div>
                            </aside>
               
                        </div>
                    </div>
                </div>
            </div>
            <!-- BLOG SECTION END -->             
        </div>
        <!-- End page content -->

    </div>
    <!-- Body main wrapper end -->


    <!-- Placed JS at the end of the document so the pages load faster -->

    <!-- jquery latest version -->
    <script src="js/vendor/jquery-3.1.1.min.js"></script>
    <!-- Bootstrap framework js -->
    <script src="js/bootstrap.min.js"></script>
    <!-- jquery.nivo.slider js -->
    <script src="lib/js/jquery.nivo.slider.js"></script>
    <!-- All js plugins included in this file. -->
    <script src="js/plugins.js"></script>
    <!-- Main js file that contents all jQuery plugins activation. -->
    <script src="js/main.js"></script>

</body>

</html>
</asp:Content>
