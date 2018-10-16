<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="UserHomePage.aspx.cs" Inherits="BetterTech_Webpage.UserHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        <!-- BREADCRUMBS SETCTION START -->
      <%--  <div class="breadcrumbs-section plr-200 mb-80">
            <div class="breadcrumbs overlay-bg">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="breadcrumbs-inner">
                                <h1 class="breadcrumbs-title">My Account</h1>
                                <ul class="breadcrumb-list">
                                    <li><a href="index.html">Home</a></li>
                                    <li>My Account</li>
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
            <div class="login-section mb-80">
                <div class="container">
                    <div class="row">
                        <div class="col-md-8 col-md-offset-2">
                            <div class="my-account-content" id="accordion2">
                                <!-- My Personal Information -->
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h4 class="panel-title">
                                            <a data-toggle="collapse" data-parent="#accordion2" href="#personal_info">My Personal Information</a>
                                        </h4>
                                    </div>
                                    <div id="personal_info" class="panel-collapse collapse in" role="tabpanel">
                                        <div class="panel-body">
                                            <form action="#">
                                                <div class="new-customers">
                                                    <div class="p-30">
                                                        <div class="row">
                                                            <div class="col-sm-6">
                                                                <h3 runat="server" id="lblun"> </h3>
                                                                 <%--<input type="text"  placeholder="User Name" runat="server" id="UName">--%>
                                                            </div>
                                                            <div class="col-sm-6">
                                                                <label runat="server" id="lblfn"> </label>
                                                                <input type="text"  placeholder="First Name" runat="server" id="fname">
                                                            </div>
                                                            <div class="col-sm-6">
                                                                <label runat="server" id="Labelln"> </label>
                                                                <input type="text"  placeholder="Last Name" runat="server" id="lname">
                                                            </div>
                                                            <div class="col-sm-6">
                                                                <label runat="server" id="Lble"> </label>
                                                                 <input type="text"  placeholder="E-Mail" runat="server" id="email">
                                                            </div>
                                                            <div class="col-sm-6">
                                                                <label runat="server" id="Labelp"> </label>
                                                                 <input type="text"  placeholder="Province/city" runat="server" id="location1">
                                                            </div>
                                                            <label runat="server" id="Lblc"> </label>
                                                                <input type="text"  placeholder="Physical Address" runat="server" id="location2">
                                                            <div class="col-sm-6">
                                                                <label runat="server" id="Lblzip"> </label>
                                                                 <input type="text"  placeholder="Zip Code" runat="server" id="zipcode">
                                                            </div>
                                                        </div>
                                                        <label runat="server" id="Lblpass">Password: </label>
                                                        <input type="password"  placeholder="Password" runat="server" id="pass1">
                                                        <input type="password"  placeholder="Confirm Password" runat="server" id="pass2"> 
                                                        
                                                        <div class="row">
                                                            <div class="col-md-6">
                                                                <asp:Button ID="savebtn" runat="server" Text="Save" OnClick="savebtn_Click" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </form>
                                        </div>
                                    </div>
                                </div>
                                 <div id="Invoices" runat="server">
                                    <%--this is where the past invoices go--%>    
                                 </div>
                        <%--        <!-- My shipping address -->
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h4 class="panel-title">
                                            <a data-toggle="collapse" data-parent="#accordion2" href="#my_shipping">My shipping address</a>
                                        </h4>
                                    </div>
                                    <div id="my_shipping" class="panel-collapse collapse" role="tabpanel" >
                                        <div class="panel-body">
                                            <form action="#">
                                                <div class="new-customers p-30">
                                                    <div class="row">
                                                        <div class="col-sm-6">
                                                            <input type="text"  placeholder="First Name">
                                                        </div>
                                                        <div class="col-sm-6">
                                                            <input type="text"  placeholder="last Name">
                                                        </div>
                                                        <div class="col-sm-6">
                                                            <select class="custom-select">
                                                                <option value="defalt">country</option>
                                                                <option value="c-1">Australia</option>
                                                                <option value="c-2">Bangladesh</option>
                                                                <option value="c-3">Unitd States</option>
                                                                <option value="c-4">Unitd Kingdom</option>
                                                            </select>
                                                        </div>
                                                        <div class="col-sm-6">
                                                            <select class="custom-select">
                                                                <option value="defalt">State</option>
                                                                <option value="c-1">Melbourne</option>
                                                                <option value="c-2">Dhaka</option>
                                                                <option value="c-3">New York</option>
                                                                <option value="c-4">London</option>
                                                            </select>
                                                        </div>
                                                        <div class="col-sm-6">
                                                            <select class="custom-select">
                                                                <option value="defalt">Town/City</option>
                                                                <option value="c-1">Victoria</option>
                                                                <option value="c-2">Chittagong</option>
                                                                <option value="c-3">Boston</option>
                                                                <option value="c-4">Cambridge</option>
                                                            </select>
                                                        </div>
                                                        <div class="col-sm-6">
                                                            <input type="text"  placeholder="Phone here...">
                                                        </div>
                                                    </div>
                                                    <input type="text"  placeholder="Company neme here...">
                                                    <input type="text"  placeholder="Email address here...">
                                                    <textarea class="custom-textarea" placeholder="Additional information..."></textarea>
                                                    <div class="row">
                                                        <div class="col-md-6">
                                                            <button class="submit-btn-1 mt-20 btn-hover-1" type="submit" value="register">Save</button>
                                                        </div>
                                                        <div class="col-md-6">
                                                            <button class="submit-btn-1 mt-20 btn-hover-1 f-right" type="reset">Clear</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </form>
                                        </div>
                                    </div>
                                </div>--%>
                                <!-- My billing details -->
                          <%--      <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h4 class="panel-title">
                                            <a data-toggle="collapse" data-parent="#accordion2" href="#billing_address">My billing details</a>
                                        </h4>
                                    </div>
                                    <div id="billing_address" class="panel-collapse collapse" role="tabpanel" >
                                        <div class="panel-body">
                                            <form action="#">
                                                <div class="billing-details p-30">
                                                    <input type="text"  placeholder="Your Name Here...">
                                                    <input type="text"  placeholder="Email address here...">
                                                    <input type="text"  placeholder="Phone here...">
                                                    <input type="text"  placeholder="Company neme here...">
                                                    <select class="custom-select">
                                                        <option value="defalt">country</option>
                                                        <option value="c-1">Australia</option>
                                                        <option value="c-2">Bangladesh</option>
                                                        <option value="c-3">Unitd States</option>
                                                        <option value="c-4">Unitd Kingdom</option>
                                                    </select>
                                                    <select class="custom-select">
                                                        <option value="defalt">State</option>
                                                        <option value="c-1">Melbourne</option>
                                                        <option value="c-2">Dhaka</option>
                                                        <option value="c-3">New York</option>
                                                        <option value="c-4">London</option>
                                                    </select>
                                                    <select class="custom-select">
                                                        <option value="defalt">Town/City</option>
                                                        <option value="c-1">Victoria</option>
                                                        <option value="c-2">Chittagong</option>
                                                        <option value="c-3">Boston</option>
                                                        <option value="c-4">Cambridge</option>
                                                    </select>
                                                    <textarea class="custom-textarea" placeholder="Your address here..."></textarea>
                                                    <div class="row">
                                                        <div class="col-md-6">
                                                            <button class="submit-btn-1 mt-20 btn-hover-1" type="submit" value="register">Save</button>
                                                        </div>
                                                        <div class="col-md-6">
                                                            <button class="submit-btn-1 mt-20 btn-hover-1 f-right" type="reset">Clear</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </form>
                                        </div>
                                    </div>
                                </div>--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- LOGIN SECTION END -->
        </div>
        <!-- End page content -->
 

</asp:Content>
