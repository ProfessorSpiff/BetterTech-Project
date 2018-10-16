<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BetterTech_Webpage.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- BREADCRUMBS SETCTION START -->
       <%-- <div class="breadcrumbs-section plr-200 mb-80">
            <div class="breadcrumbs overlay-bg">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="breadcrumbs-inner">
                                <h1 class="breadcrumbs-title">Login / Register</h1>
                                <ul class="breadcrumb-list">
                                    <li><a href="index.html">Home</a></li>
                                    <li>Login / Register</li>
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

            <!-- LOGIN SECTION START -->
            <div class="login-section mb-80" runat="server">
                <div class="container" runat="server">
                    <div class="row" runat="server">
                        <div class="col-md-6" runat="server">
                            <div id="error" runat="server" visible=false class="alert alert-danger"></div>
                            <div class="registered-customers" runat="server">
                                <h6 class="widget-title border-left mb-50">REGISTERED CUSTOMERS</h6>
                                
                                    <div runat="server" class="login-account p-30 box-shadow">
                                        <p>If you have an account with us, Please log in.</p>
                                        <label for="loginEmail">Email</label>
                                        <input runat="server" id="loginEmail" type="text" name="name" placeholder="Email Address">
                                        <label for="loginPassword">Password</label>
                                        <input runat ="server" id="loginPassword" type="password" name="password" placeholder="Password">
                                        <asp:Button id="loginb" runat="server" CssClass="submit-btn-1 btn-hover-1" OnClick="login_Click" Text="login"/>
                                        
                                    </div>
                                
                            </div>
                        </div>
                        <!-- new-customers -->
                        <div class="col-md-6">
                            <div class="new-customers">
                                <div id="alertReg" runat="server" visible=false class="alert alert-danger"></div>
                                    <h6 class="widget-title border-left mb-50">NEW CUSTOMERS</h6>
                                    <div class="login-account p-30 box-shadow">
                                        <div class="row">
                                            <div class="col-sm-6">
                                                <label for="Username">Username</label>
                                                <input runat="server" id="username" type="text"  placeholder="Username">
                                            </div>
                                            <div class="col-sm-6">
                                                <label for="firstname">First Name</label>
                                                <input runat="server" id="firstname" type="text"  placeholder="First Name">
                                            </div>
                                            <div class="col-sm-6">
                                                <label for="lastname">Last Name</label>
                                                <input type="text"  runat="server" id="lastname" placeholder="last Name">
                                            </div>
                                        </div>
                                        <label for="add1">Address</label>
                                        <input type="text" runat="server" id="add1" placeholder="Address Line 1...">
                                        <label for="add2">Address</label>
                                        <input type="text" runat="server" id="add2" placeholder="Address Line 2...">
                                        <label for="zip">Zip Code</label>
                                        <input type="text" runat="server" id="zip" placeholder="Zip Code...">
                                        <label for="email">Email</label>
                                        <input type="text" runat="server" id="email" placeholder="Email address here...">
                                        <label for="pass1">Password</label>
                                        <input type="password"  runat="server" id="pass1" placeholder="Password">
                                        <label for="pass2">Confirm Password</label>
                                        <input type="password" runat="server" id="pass2"  placeholder="Confirm Password">
                                        
                                        <div class="row">
                                            <div class="col-md-6">
                                                <asp:Button runat="server" id="regBtn" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="regBtn_Click" Text="Register"/>
                                            </div>
                                            <div class="col-md-6">
                                                <button class="submit-btn-1 mt-20 btn-hover-1 f-right" type="reset">Clear</button>
                                            </div>
                                        </div>
                                    </div>
                                
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- LOGIN SECTION END -->             

        </div>
        <!-- End page content -->
</asp:Content>
