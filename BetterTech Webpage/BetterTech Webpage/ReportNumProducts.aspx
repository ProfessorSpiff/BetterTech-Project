<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="ReportNumProducts.aspx.cs" Inherits="BetterTech_Webpage.ReportNumProducts" %>
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
                                <h1 class="breadcrumbs-title">Section Title</h1>
                                <ul class="breadcrumb-list">
                                    <li><a href="index.html">Home</a></li>
                                    <li>Section Title</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- BREADCRUMBS SETCTION END -->

        <!-- Start page content -->
        <section id="page-content" class="page-wrapper">

            <!-- This is single section start-->
            <div class="theme-section mb-80">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="section-title  text-center mb-40">
                                <div runat="server" id="numProducts"></div>
                                
                                <h6 class="mb-40">This is the total number of products on this site.</h6>
                            </div>
                        </div>
                    </div><hr>
                </div>
            </div>
            <div class="theme-section mb-80">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="section-title  text-center mb-40">
                                <div runat="server" id="numSpecial"></div>
                                
                                <h6 class="mb-40">This is the number of products currently on special.</h6>
                            </div>
                        </div>
                    </div><hr>
                </div>
            </div>
            <div class="theme-section mb-80">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="section-title  text-center mb-40">
                                <div runat="server" id="numRecent"></div>
                                
                                <h6 class="mb-40">This is the number of products added in the last 3 months.</h6>
                            </div>
                        </div>
                    </div><hr>
                </div>
            </div>
            <!-- This is single section end-->
        </section>
        <!-- End page content -->
</asp:Content>
