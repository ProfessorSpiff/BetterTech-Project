<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="UserHomePage.aspx.cs" Inherits="BetterTech_Webpage.UserHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                                                        <input type="password"  placeholder="Old Password" runat="server" id="oldPassword">
                                                        <input type="password"  placeholder="Password" runat="server" id="pass1">
                                                        <input type="password"  placeholder="Confirm Password" runat="server" id="pass2"> 
                                                        <p id="result" runat="server"></p>
                                                        
                                                        <div class="row">
                                                            <div class="col-md-6">
                                                                <asp:Button ID="savebtn" runat="server" Text="Save" OnClick="savebtn_Click" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                     <hr>
                                                </div>
                                            </form>
                                        </div>
                                    </div>
                                </div>
                                 <div id="Invoices" runat="server">                                    
                                    <%--this is where the past invoices go--%>    
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
