<%@ Page Title="" Language="C#" MasterPageFile="~/BetterTech.Master" AutoEventWireup="true" CodeBehind="BuildCustomPC.aspx.cs" Inherits="BetterTech_Webpage.BuildCustomPC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="shop-section mb-80">
        <div class="container">
            <div class="row">
                <div class="col-md-2 col-sm-12">
                    <ul class="cart-tab">
                        <li>
                            <a runat="server" id="prefBut" class="active" href="#preferences" data-toggle="tab">
                                <span>P</span>
                                Preferences
                            </a>
                        </li>
                        <li>
                            <a runat="server" id="cpuBut" href="#cpu" data-toggle="tab">
                                <span>01</span>
                                CPU
                            </a>
                        </li>
                        <li>
                            <a href="#motherboard" runat="server" id="moboBut" data-toggle="tab">
                                <span>02</span>
                                Motherboard
                            </a>
                        </li>
                        <li>
                            <a href="#cooling" runat="server" id="coolBut" data-toggle="tab">
                                <span>03</span>
                                Cooling
                            </a>
                        </li>
                        <li>
                            <a href="#graphics" runat="server" id="gpuBut" data-toggle="tab">
                                <span>04</span>
                                Graphics Cards
                            </a>
                        </li>
                        <li>
                            <a href="#memory" runat="server" id="memBut" data-toggle="tab">
                                <span>05</span>
                                Memory
                            </a>
                        </li>
                        <li>
                            <a href="#harddrives" runat="server" id="hardBut" data-toggle="tab">
                                <span>06</span>
                                Hard Drives
                            </a>
                        </li>
                        <li>
                            <a href="#PSU" runat="server" id="psuBut" data-toggle="tab">
                                <span>07</span>
                                Power Supply
                            </a>
                        </li>
                        <li>
                            <a href="#cases" runat="server" id="caseBut" data-toggle="tab">
                                <span>08</span>
                                Case
                            </a>
                        </li>
                        <li>
                            <a href="#final" runat="server" id="finBut" data-toggle="tab">
                                <span>F</span>
                                Finalise
                            </a>
                        </li>
                    </ul>
                </div>
                <div class="col-md-10 col-sm-12">
                    <!-- Tab panes -->
                    <div class="tab-content">

                        <div class="tab-pane active" id="preferences" runat="server">
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
                                                <asp:Button runat="server" ID="video" Text="Choose" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="videoChoose_Click" />
                                            </div>
                                            <div class="col-lg-4 col-md-4">

                                                <label for="gaming1"><strong>Gaming</strong></label>
                                                <br />
                                                <asp:Button runat="server" ID="gaming1" Text="Choose" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="gaming1_Click" />
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

                        <div class="tab-pane" id="cpu" runat="server">
                            <div class="shopping-cart-content">

                                <div runat="server" id="cpuDiv" class="table-content table-responsive mb-50">
                                    <div id="budgetCpu" runat="server"></div>
                                    <table class="text-center">
                                        <thead>
                                            <tr>
                                                <th class="product-thumbnail">product</th>
                                                <th class="product-price">price</th>
                                                <th class="product-price">select</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="cpu1img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="cpu1name" runat="server"></div>

                                                        <div id="cpu1brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="cpu1price" runat="server"></div>
                                                </td>
                                                <td class="product-price">

                                                    <asp:RadioButton runat="server" ID="cpu1r" GroupName="cpur" OnCheckedChanged="cpu1r_CheckedChanged" autopostback=true/>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="cpu2img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="cpu2name" runat="server"></div>

                                                        <div id="cpu2brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="cpu2price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="cpu2r" GroupName="cpur" OnCheckedChanged="cpu2r_CheckedChanged" autopostback=true/>

                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="cpu3img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="cpu3name" runat="server"></div>

                                                        <div id="cpu3brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="cpu3price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="cpu3r" GroupName="cpur" OnCheckedChanged="cpu3r_CheckedChanged" autopostback=true/>

                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="backCpu" runat="server" Text="Back" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="backCpu_Click" />
                                    </div>
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="nextCpu" runat="server" Text="Next" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="nextCpu_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tab-pane" id="motherboard" runat="server">
                            <div class="shopping-cart-content">

                                <div runat="server" id="moboDiv" class="table-content table-responsive mb-50">
                                    <div id="budgetMobo" runat="server"></div>
                                    <table class="text-center">
                                        <thead>
                                            <tr>
                                                <th class="product-thumbnail">product</th>
                                                <th class="product-price">price</th>
                                                <th class="product-price">select</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="mobo1img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="mobo1name" runat="server"></div>

                                                        <div id="mobo1brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="mobo1price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="mobo1r" GroupName="mobor" OnCheckedChanged="mobo1r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="mobo2img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="mobo2name" runat="server"></div>

                                                        <div id="mobo2brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="mobo2price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="mobo2r" GroupName="mobor" OnCheckedChanged="mobo2r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="mobo3img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="mobo3name" runat="server"></div>

                                                        <div id="mobo3brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="mobo3price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="mobo3r" GroupName="mobor" OnCheckedChanged="mobo3r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="backMobo" runat="server" Text="Back" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="backMobo_Click1" />
                                    </div>
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="nextMobo" runat="server" Text="Next" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="nextMobo_Click1" />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="tab-pane" id="cooling" runat="server">
                            <div class="shopping-cart-content">

                                <div runat="server" id="coolDiv" class="table-content table-responsive mb-50">
                                    <div id="budgetCool" runat="server"></div>
                                    <table class="text-center">
                                        <thead>
                                            <tr>
                                                <th class="product-thumbnail">product</th>
                                                <th class="product-price">price</th>
                                                <th class="product-price">select</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="cool1img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="cool1name" runat="server"></div>

                                                        <div id="cool1brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="cool1price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="cool1r" GroupName="coolr" OnCheckedChanged="cool1r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="cool2img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="cool2name" runat="server"></div>

                                                        <div id="cool2brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="cool2price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="cool2r" GroupName="coolr" OnCheckedChanged="cool2r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="cool3img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="cool3name" runat="server"></div>

                                                        <div id="cool3brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="cool3price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="cool3r" GroupName="coolr" OnCheckedChanged="cool3r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="coolBack" runat="server" Text="Back" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="coolBack_Click" />
                                    </div>
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="coolNext" runat="server" Text="Next" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="coolNext_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="graphics" runat="server">
                            <div class="shopping-cart-content">

                                <div runat="server" id="gpuDiv" class="table-content table-responsive mb-50">
                                    <div id="budgetGpu" runat="server"></div>
                                    <table class="text-center">
                                        <thead>
                                            <tr>
                                                <th class="product-thumbnail">product</th>
                                                <th class="product-price">price</th>
                                                <th class="product-price">select</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="gpu1img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="gpu1name" runat="server"></div>

                                                        <div id="gpu1brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="gpu1price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="gpu1r" GroupName="gpur" OnCheckedChanged="gpu1r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="gpu2img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="gpu2name" runat="server"></div>

                                                        <div id="gpu2brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="gpu2price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="gpu2r" GroupName="gpur" OnCheckedChanged="gpu2r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="gpu3img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="gpu3name" runat="server"></div>

                                                        <div id="gpu3brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="gpu3price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="gpu3r" GroupName="gpur" OnCheckedChanged="gpu3r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="gpuBack" runat="server" Text="Back" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="gpuBack_Click" />
                                    </div>
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="gpuNext" runat="server" Text="Next" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="gpuNext_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="memory" runat="server">
                            <div class="shopping-cart-content">

                                <div runat="server" id="memDiv" class="table-content table-responsive mb-50">
                                    <div id="budgetMem" runat="server"></div>
                                    <table class="text-center">
                                        <thead>
                                            <tr>
                                                <th class="product-thumbnail">product</th>
                                                <th class="product-price">price</th>
                                                <th class="product-price">select</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="mem1img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="mem1name" runat="server"></div>

                                                        <div id="mem1brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="mem1price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="mem1r" GroupName="memr" OnCheckedChanged="mem1r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="mem2img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="mem2name" runat="server"></div>

                                                        <div id="mem2brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="mem2price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="mem2r" GroupName="memr" OnCheckedChanged="mem2r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="mem3img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="mem3name" runat="server"></div>

                                                        <div id="mem3brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="mem3price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="mem3r" GroupName="memr" OnCheckedChanged="mem3r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="memBack" runat="server" Text="Back" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="memBack_Click" />
                                    </div>
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="memNext" runat="server" Text="Next" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="memNext_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="harddrives" runat="server">
                            <div class="shopping-cart-content">

                                <div runat="server" id="hardDiv" class="table-content table-responsive mb-50">
                                    <div id="budgetHard" runat="server"></div>
                                    <table class="text-center">
                                        <thead>
                                            <tr>
                                                <th class="product-thumbnail">product</th>
                                                <th class="product-price">price</th>
                                                <th class="product-price">select</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="hard1img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="hard1name" runat="server"></div>

                                                        <div id="hard1brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="hard1price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="hard1r" GroupName="hardr" OnCheckedChanged="hard1r_CheckedChanged" autopostback=true /></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="hard2img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="hard2name" runat="server"></div>

                                                        <div id="hard2brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="hard2price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="hard2r" GroupName="hardr" OnCheckedChanged="hard2r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="hard3img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="hard3name" runat="server"></div>

                                                        <div id="hard3brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="hard3price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="hard3r" GroupName="hardr" OnCheckedChanged="hard3r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="hardBack" runat="server" Text="Back" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="hardBack_Click" />
                                    </div>
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="hardNext" runat="server" Text="Next" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="hardNext_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="PSU" runat="server">
                            <div class="shopping-cart-content">

                                <div runat="server" id="psuDiv" class="table-content table-responsive mb-50">
                                    <div id="budgetPsu" runat="server"></div>
                                    <table class="text-center">
                                        <thead>
                                            <tr>
                                                <th class="product-thumbnail">product</th>
                                                <th class="product-price">price</th>
                                                <th class="product-price">select</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="psu1img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="psu1name" runat="server"></div>

                                                        <div id="psu1brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="psu1price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="psu1r" GroupName="psur" OnCheckedChanged="psu1r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="psu2img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="psu2name" runat="server"></div>

                                                        <div id="psu2brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="psu2price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="psu2r" GroupName="psur" OnCheckedChanged="psu2r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="psu3img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="psu3name" runat="server"></div>

                                                        <div id="psu3brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="psu3price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="psu3r" GroupName="psur" OnCheckedChanged="psu3r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="psuBack" runat="server" Text="Back" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="psuBack_Click" />
                                    </div>
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="psuNext" runat="server" Text="Next" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="psuNext_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="cases" runat="server">
                            <div class="shopping-cart-content">

                                <div runat="server" id="caseDiv" class="table-content table-responsive mb-50">
                                    <div id="budgetCase" runat="server"></div>
                                    <table class="text-center">
                                        <thead>
                                            <tr>
                                                <th class="product-thumbnail">product</th>
                                                <th class="product-price">price</th>
                                                <th class="product-price">select</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="case1img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="case1name" runat="server"></div>

                                                        <div id="case1brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="case1price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="case1r" GroupName="caser" OnCheckedChanged="case1r_CheckedChanged" autopostback=true /></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="case2img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="case2name" runat="server"></div>

                                                        <div id="case2brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="case2price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="case2r" GroupName="caser" OnCheckedChanged="case2r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <div class="pro-thumbnail-img">
                                                        <div id="case3img" runat="server"></div>
                                                    </div>
                                                    <div class="pro-thumbnail-info text-left">

                                                        <div id="case3name" runat="server"></div>

                                                        <div id="case3brand" runat="server"></div>
                                                    </div>
                                                </td>
                                                <td class="product-price">
                                                    <div id="case3price" runat="server"></div>
                                                </td>
                                                <td class="product-price">
                                                    <asp:RadioButton runat="server" ID="case3r" GroupName="caser" OnCheckedChanged="case3r_CheckedChanged" autopostback=true/></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="caseBack" runat="server" Text="Back" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="caseBack_Click" />
                                    </div>
                                    <div class="col-lg-4 col-md-4">
                                        <asp:Button ID="caseNext" runat="server" Text="Next" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="caseNext_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="final" runat="server">
                            <div class="shopping-cart-content">
                                <div runat="server" id="whatevs" class="table-content table-responsive mb-50">

                                    <asp:Button runat="server" ID="finalise" CssClass="submit-btn-1 mt-20 btn-hover-1" Text="Finalise" OnClick="finalise_Click" />
                                    <div class="row">
                                        <div class="col-lg-4 col-md-4">
                                            <asp:Button ID="finBack" runat="server" Text="Back" CssClass="submit-btn-1 mt-20 btn-hover-1" OnClick="finBack_Click" />
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
