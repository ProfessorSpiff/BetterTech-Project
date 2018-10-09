﻿<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="BuildCustomPC.aspx.cs" Inherits="BetterTech_Webpage.BuildCustomPC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shop-section mb-80">
        <div class="container">
            <div class="row">
                <div class="col-md-2 col-sm-12">
                    <ul class="cart-tab">
                        <li>
                            <a class="active" href="#preferences" data-toggle="tab">
                                <span>P</span>
                                Preferences
                                    </a>
                        </li>
                        <li>
                            <a href="#cpu" data-toggle="tab">
                                <span>01</span>
                                CPU
                                    </a>
                        </li>
                        <li>
                            <a href="#motherboard" data-toggle="tab">
                                <span>02</span>
                                Motherboard
                                    </a>
                        </li>
                        <li>
                            <a href="#cooling" data-toggle="tab">
                                <span>03</span>
                                Cooling
                                    </a>
                        </li>
                        <li>
                            <a href="#graphics" data-toggle="tab">
                                <span>04</span>
                                Graphics Cards
                                    </a>
                        </li>
                        <li>
                            <a href="#memory" data-toggle="tab">
                                <span>05</span>
                                Memory
                                    </a>
                        </li>
                        <li>
                            <a href="#harddrives" data-toggle="tab">
                                <span>06</span>
                                Hard Drives
                                    </a>
                        </li>
                        <li>
                            <a href="#PSU" data-toggle="tab">
                                <span>07</span>
                                Power Supply
                                    </a>
                        </li>
                        <li>
                            <a href="#Additional" data-toggle="tab">
                                <span>08</span>
                                Additional Components
                                    </a>
                        </li>
                        <li>
                            <a href="#case" data-toggle="tab">
                                <span>09</span>
                                Case
                                    </a>
                        </li>
                        <li>
                            <a href="#finalise" data-toggle="tab">
                                <span>F</span>
                                Finalise
                                    </a>
                        </li>
                    </ul>
                </div>
                <div class="col-md-10 col-sm-12">
                    <!-- Tab panes -->
                    <div class="tab-content">
                        <div class="tab-pane active" id="preferences">
                            <div class="shopping-cart-content">
                                <div runat="server" id="pref" class="table-content table-responsive mb-50">
                                    <div class="login-account p-30 box-shadow">
                                        <div class="row">
                                            <h1>What we do here</h1>
                                            <h5>This page is here to help you create your own pc with some guided help from our engineers at BetterTech. To start, simply add your budget and choose which of the three types of systems you want to build. Then choose each part you want out of a possible three, and we will make sure all your parts fit together properly and achieve your purpose. Once you're done choosing parts, simply finalise and it will all be added to your cart. Enjoy!</h5>
                                            </div>
                                        <hr />
                                        <div class="row">
                                            <div class="col-sm-6">
                                                <label for="budget"><strong>Budget</strong></label>
                                                <input type="text" id="budget" runat="server" placeholder="Budget" autofocus required />


                                            </div>

                                        </div>
                                        <div class="row">

                                            <div class="col-lg-4 col-md-4">
                                                <label for="video"><strong>Video/Photo Editing</strong></label>
                                                <br />
                                                <asp:Button runat="server" ID="video" Text="Choose" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="videoChoose_Click"/>
                                            </div>
                                            <div class="col-lg-4 col-md-4">

                                                <label for="gaming1"><strong>Gaming</strong></label>
                                                <br />
                                                <asp:Button runat="server" ID="gaming1" Text="Choose" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="gaming1_Click"/>
                                            </div>
                                            <div class="col-lg-4 col-md-4">
                                                <label for="general"><strong>General Purpose</strong></label>
                                                <br />
                                                <asp:Button runat="server" ID="general" Text="Choose" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="general_Click" />

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="cpu">
                            <div class="shopping-cart-content">

                                <div runat="server" id="cpuDiv" class="table-content table-responsive mb-50">
                                    <table class="text-center">
                                        <thead>
                                            <tr>
                                                <th class="product-thumbnail">product</th>
                                                <th class="product-price">price</th>
                                                <th class="product-remove">select</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <!-- tr -->
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <img src="img/cart/1.jpg" alt="">
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">
                                                        <h6 class="product-title-2">
                                                            <a href="#">dummy product name</a>
                                                        </h6>
                                                        <p>Brand: Brand Name</p>
                                                        <p>Model: Grand s2</p>
                                                        <p>Color: Black, White</p>
                                                    </div>
                                                </td>
                                                <td class="product-price">$560.00</td>
                                                <td class="product-remove">
                                                    <a href="#"><i class="zmdi zmdi-close"></i></a>
                                                </td>
                                            </tr>
                                            <!-- tr -->
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <img src="img/cart/2.jpg" alt="">
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">
                                                        <h6 class="product-title-2">
                                                            <a href="#">dummy product name</a>
                                                        </h6>
                                                        <p>Brand: Brand Name</p>
                                                        <p>Model: Grand s2</p>
                                                        <p>Color: Black, White</p>
                                                    </div>
                                                </td>
                                                <td class="product-price">$560.00</td>
                                                <td class="product-remove">
                                                    <a href="#"><i class="zmdi zmdi-close"></i></a>
                                                </td>
                                            </tr>
                                            <!-- tr -->
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <img src="img/cart/3.jpg" alt="">
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">
                                                        <h6 class="product-title-2">
                                                            <a href="#">dummy product name</a>
                                                        </h6>
                                                        <p>Brand: Brand Name</p>
                                                        <p>Model: Grand s2</p>
                                                        <p>Color: Black, White</p>
                                                    </div>
                                                </td>
                                                <td class="product-price">$560.00</td>
                                                <td class="product-remove">
                                                    <a href="#"><i class="zmdi zmdi-close"></i></a>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>



                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
