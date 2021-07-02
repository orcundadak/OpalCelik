<%@ Page Title="" Language="C#" MasterPageFile="~/OpalCelik.Master" AutoEventWireup="true" CodeBehind="Projeler.aspx.cs" Inherits="OpalCelik.Projeler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <title>Projelerimiz | OPAL ÇELİK KONSTRÜKSİYON</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphOrtaAlan" runat="server">
     <!-- CONTENT START -->
        <div class="page-content">
            <!-- INNER PAGE BANNER -->
            <div class="mt-bnr-inr overlay-wraper bg-parallax bg-top-center" data-stellar-background-ratio="0.5" style="background-image:url(images/banner/2.jpg);">
            	<div class="overlay-main bg-black opacity-07"></div>
                <div class="container">
                    <div class="mt-bnr-inr-entry">
                    	<div class="banner-title-outer">
                        	<div class="banner-title-name">
                        		<h2 class="m-b0">ÇELİK YAPIDA DOĞRU ADRES</h2>
                            </div>
                        </div>
                        <!-- BREADCRUMB ROW -->                            
                        
                            <div>
                                <ul class="mt-breadcrumb breadcrumb-style-2">
                                    <li><a href="default.aspx"  style="color:white">Anasayfa</a></li>
                                    <li>Projeler</li>
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
                    <!-- PAGINATION START -->
                   <%-- <div class="filter-wrap p-b30 text-center">
                        <ul class="filter-navigation inline-navigation masonry-filter link-style  text-uppercase">
                            <li class="active"><a data-filter="*" href="#" data-hover="All">All</a></li>
                            <li><a data-filter=".cat-1" href="#" data-hover="Construction">Construction</a></li>
                            <li><a data-filter=".cat-2" href="#" data-hover="Renovation">Renovation</a></li>
                            <li><a data-filter=".cat-3" href="#" data-hover="Outdoor">Outdoor</a></li>
                            <li><a data-filter=".cat-4" href="#" data-hover="Interiors">Interiors </a></li>
                            <li><a data-filter=".cat-5" href="#" data-hover="Consulting">Consulting</a></li>
                        </ul>
                    </div>--%>
                    <!-- PAGINATION END -->
                    
                    <!-- GALLERY CONTENT START -->
                     <div class="portfolio-wrap mfp-gallery work-grid row clearfix">
                        <!-- COLUMNS 1 -->
                         <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                                         
                     </div>
                    <!-- GALLERY CONTENT END -->
            	</div>
            </div>
            <!-- SECTION CONTENT END  -->
        </div>
        <!-- CONTENT END -->
</asp:Content>
