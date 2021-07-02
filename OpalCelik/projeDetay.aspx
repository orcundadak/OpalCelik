<%@ Page Title="" Language="C#" MasterPageFile="~/OpalCelik.Master" AutoEventWireup="true" CodeBehind="projeDetay.aspx.cs" Inherits="OpalCelik.projeDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphOrtaAlan" runat="server">
      <div class="page-content">
        <!-- INNER PAGE BANNER -->
        <div class="mt-bnr-inr overlay-wraper bg-parallax bg-top-center" data-stellar-background-ratio="0.5" style="background-image: url(images/banner/2.jpg);">
            <div class="overlay-main bg-black opacity-07"></div>
            <div class="container">
                <div class="mt-bnr-inr-entry">
                    <div class="banner-title-outer">
                        <div class="banner-title-name">
                            <h2 class="m-b0">
                                <asp:Label ID="lblProjeAdi" runat="server" Text=""></asp:Label></h2>
                        </div>
                    </div>
                    <!-- BREADCRUMB ROW -->

                    <div>
                        <ul class="mt-breadcrumb breadcrumb-style-2">
                            <li><a href="Projeler.aspx?categoryID=0" style="color: white">Projelerimiz</a></li>
                            <li>
                                <asp:Label ID="lblProjeAdi2" runat="server" Text=""></asp:Label></li>
                        </ul>
                    </div>

                    <!-- BREADCRUMB ROW END -->
                </div>
            </div>
        </div>
        <!-- INNER PAGE BANNER END -->

        <!-- SECTION CONTENT START -->
        <div class="section-full p-tb80 inner-page-padding">
            <div class="container">
                <div class="project-detail-outer">
                    <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                            <div class="m-b0">
                                <div class="row portfolio-wrap mfp-gallery work-grid row clearfix">
                                    <div class="col-md-4 col-sm-4">
                                        <div class="project-detail-pic m-b30">
                                            <div class="mt-media">
                                                <a class="mfp-link" href="images/projeler/<%#Eval("image1")%>">
                                                    <img src="images/projeler/<%#Eval("image1")%>" alt="<%#Eval("ProjeAdi")%>" style="object-fit: cover; height: 265px"></a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-sm-4">
                                        <div class="project-detail-pic m-b30">
                                            <div class="mt-media">
                                                <a class="mfp-link" href="images/projeler/<%#Eval("image2")%>">
                                                    <img src="images/projeler/<%#Eval("image2")%>" alt="<%#Eval("ProjeAdi")%>" style="object-fit: cover; height: 265px"></a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-sm-4">
                                        <div class="project-detail-pic m-b30">
                                            <div class="mt-media">
                                                <a class="mfp-link" href="images/projeler/<%#Eval("image3")%>">
                                                    <img src="images/projeler/<%#Eval("image3")%>" alt="<%#Eval("ProjeAdi")%>" style="object-fit: cover; height: 265px"></a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="m-b30">
                                <div class="row">
                                    <div class="col-md-4">
                                        <div class="product-block">
                                            <div class="row">
                                                <div class="col-md-12 m-b10">
                                                    <h4 class="text-uppercase font-weight-600 m-b10">PROJE ADI</h4>
                                                    <p><%#Eval("ProjeAdi")%></p>
                                                </div>

                                                <div class="col-md-12 m-b10">
                                                    <h4 class="text-uppercase font-weight-600 m-b10">MÜŞTERİ</h4>
                                                    <p><%#Eval("Musteri")%></p>
                                                </div>
                                                <div class="col-md-12 m-b10">
                                                    <h4 class="text-uppercase font-weight-600 m-b10">YIL</h4>
                                                    <p><%#Eval("Yil")%></p>
                                                </div>
                                                <div class="col-md-12 m-b10">
                                                    <h4 class="text-uppercase font-weight-600 m-b10">SEKTÖR</h4>
                                                    <p><%#Eval("Sektor")%></p>
                                                </div>
                                                <div class="col-md-12 m-b10">
                                                    <h4 class="text-uppercase font-weight-600 m-b10">LOKASYON</h4>
                                                    <p><%#Eval("Lokasyon")%></p>
                                                </div>
                                                <div class="col-md-12 m-b10">
                                                    <h4 class="text-uppercase font-weight-600 m-b10">KAPSAM</h4>
                                                    <p><%#Eval("Kapsam")%></p>
                                                </div>
                                                <div class="col-md-12 m-b10">
                                                    <h4 class="text-uppercase font-weight-600 m-b10">MİKTAR</h4>
                                                    <p><%#Eval("Miktar")%> Ton</p>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-8">
                                        <div class="mt-box">
                                            <div class="mt-thum-bx mt-img-overlay1 mt-img-effect yt-thum-box">
                                                <img src="images/projeler/<%#Eval("image")%>" alt="<%#Eval("ProjeAdi")%>"  style="object-fit: cover;">
                                                <%--<a href="images/projeler/<%#Eval("image")%>" class="mfp-video play-now">
                                                    <i class="icon fa fa-play"></i>
                                                    <span class="ripple"></span>
                                                </a>--%>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>
        </div>
        <!-- SECTION CONTENT END  -->



    </div>
    <!-- CONTENT END -->
</asp:Content>
