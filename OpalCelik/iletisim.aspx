<%@ Page Title="" Language="C#" MasterPageFile="~/OpalCelik.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="OpalCelik.iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <title>İletişim | OPAL ÇELİK KONSTRÜKSİYON</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphOrtaAlan" runat="server">

    <!-- CONTENT START -->
    <div class="page-content">

        <!-- INNER PAGE BANNER -->
        <div class="mt-bnr-inr overlay-wraper bg-parallax bg-top-center" data-stellar-background-ratio="0.5" style="background-image: url(images/banner/2.jpg);">
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
                            <li><a href="default.aspx" style="color:white">Anasayfa</a></li>
                            <li>İletişim</li>
                        </ul>
                    </div>

                    <!-- BREADCRUMB ROW END -->
                </div>
            </div>
        </div>
        <!-- INNER PAGE BANNER END -->

        <!-- SECTION CONTENTG START -->
        <div class="section-full p-tb80 inner-page-padding">
            <!-- LOCATION BLOCK-->
            <div class="container">
                <div class="gmap-outline  mb-30">
                    <div id="gmap_canvas2" class="google-map" style="width:100%">
                        <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d6016.457335531622!2d28.80651!3d41.063994!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x839ce9d4ef42dc14!2sOpal%20%C3%87elik!5e0!3m2!1str!2str!4v1623325842716!5m2!1str!2str" width="100%" height="450" style="border: 0;" allowfullscreen="" loading="lazy"></iframe>
                    </div>
                </div>
                <!-- GOOGLE MAP & CONTACT FORM -->
                <div class="section-content ">
                    <!-- CONTACT FORM-->
                    
                    <div class="row m-b40">
                        <div class="col-md-12 col-sm-12">
                            <form class="contact-form cons-contact-form" method="post" action="form-handler.php">
                                <div class="contact-one m-b30">

                                    <!-- TITLE START -->
                                    <div class="section-head">
                                        <div class="mt-separator-outer separator-left">
                                            <div class="mt-separator">
                                                <h2 class="text-uppercase sep-line-one "><span class="font-weight-300 text-primary">İLETİŞİM</span> FORMU</h2>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- TITLE END -->

                                    <div class="form-group">
                                        <input name="username" type="text" required="" class="form-control" placeholder="Ad Soyad">
                                    </div>

                                    <div class="form-group">
                                        <input name="email" type="text" class="form-control" required="" placeholder="E-posta">
                                    </div>

                                    <div class="form-group">
                                        <textarea name="message" rows="4" class="form-control " required="" placeholder="Mesaj"></textarea>
                                    </div>

                                    <div class="text-right">
                                        <button name="submit" type="submit" value="Submit" class="site-button btn-effect">
                                            Gönder
                                        </button>
                                    </div>

                                </div>
                            </form>
                        </div>

                    </div>
                    <div class="row ">
                        <div class="col-md-12 col-sm-12">
                            <div class="contact-info m-b30">
                                <!-- TITLE START -->
                                <div class="section-head">
                                    <div class="mt-separator-outer separator-left">
                                        <div class="mt-separator">
                                            <h2 class="text-uppercase sep-line-one "><span class="font-weight-300 text-primary">İLETİŞİM </span> BİLGİLERİ</h2>
                                        </div>
                                    </div>
                                </div>
                                <!-- TITLE END -->
                                <div class="col-md-6 col-sm-6">
                                    <div class="bg-dark p-a20 text-white" style="width: 100%">
                                        <div class="mt-icon-box-wraper left p-b40">
                                            <div class="icon-xs"><i class="fa fa-map-marker"></i></div>
                                            <div class="icon-content p-b20">
                                                <h5 class="m-t0 font-weight-500">Merkez Ofis</h5>
                                                <p>MALL OF İSTANBUL ZİYA GÖKALP MAH. SÜLEYMAN DEMİREL BULVARI NO:7 E KAT: 15 OFİS NO : 120 BAŞAKŞEHİR - İSTANBUL / TÜRKİYE</p>
                                            </div>
                                            <div class="icon-xs"><i class="fa fa-map-marker"></i></div>
                                            <div class="icon-content">
                                                <h5 class="m-t0 font-weight-500">Fabrika</h5>
                                                <p>SAKARYA 3.ORGANİZE SAN. BÖL. SÖĞÜTLÜ SAKARYA / TÜRKİYE</p>
                                            </div>
                                        </div>
                                        <div class="mt-icon-box-wraper left p-b40">
                                            <div class="icon-xs"><i class="fa fa-mobile"></i></div>
                                            <div class="icon-content">
                                                <p>+90 549 792 52 61 (Turkish - English)<br />+90 552 545 62 45 (Arabic)</p>
                                            </div>
                                        </div>
                                        <div class="mt-icon-box-wraper left p-b40">
                                            <div class="icon-xs"><i class="fa fa-phone"></i></div>
                                            <div class="icon-content">
                                                <p>+90 212 659 19 52<br />+90 212 659 19 55</p>
                                            </div>
                                        </div>
                                        <div class="mt-icon-box-wraper left p-b40">
                                            <div class="icon-xs"><i class="fa fa-fax"></i></div>
                                            <div class="icon-content">
                                                <p>+90 212 659 04 01</p>
                                            </div>
                                        </div>

                                        <div class="mt-icon-box-wraper left p-b0">
                                            <div class="icon-xs"><i class="fa fa-envelope"></i></div>
                                            <div class="icon-content">
                                                <p ><a href="mailto:info@opalcelik.com" style="color:white">info@opalcelik.com</a><br />
                                                    <a href="mailto:opalinsaat@gmail.com" style="color:white">opalinsaat@gmail.com</a>
                                                </p>
                                            </div>
                                        </div>


                                    </div>
                                </div>

                                <div class="col-md-6 col-sm-6">
                                    <div class="bg-dark p-a20 text-white" style="width: 100%">
                                        <div class="mt-icon-box-wraper left p-b40" >
                                            <div class="icon-xs"><i class="fa fa-map-marker"></i></div>
                                            <div class="icon-content">
                                                <h5 class="m-t0 font-weight-500">Almanya Ofis</h5>
                                                <p>Kavy GmbH, Obersayn 14, 56459 Rothenbach Geschäftsführer: M. Sevban Güclü Amtsgericht Montabaur HRB 25574 Ust Id: 267786485</p>
                                            </div>
                                        </div>
                                        <div class="mt-icon-box-wraper left p-b40">
                                            <div class="icon-xs"><i class="fa fa-phone"></i></div>
                                            <div class="icon-content">
                                                <p>+49 2666 9599794</p>
                                            </div>
                                        </div>
                                        <div class="mt-icon-box-wraper left p-b40">
                                            <div class="icon-xs"><i class="fa fa-fax"></i></div>
                                            <div class="icon-content">
                                                <p>+49 3222 6444679</p>
                                            </div>
                                        </div>
                                        <div class="mt-icon-box-wraper left p-b40">
                                            <div class="icon-xs"><i class="fa fa-globe"></i></div>
                                            <div class="icon-content">
                                                <p><a href="https://www.kavy-group.com" style="color:white">www.kavy-group.com</a></p>
                                            </div>
                                        </div>

                                        <div class="mt-icon-box-wraper left" style="padding-bottom:23%">
                                            <div class="icon-xs"><i class="fa fa-envelope"></i></div>
                                            <div class="icon-content">
                                                <h5 class="m-t0 font-weight-500">Email address</h5>
                                                <p><a href="mailto:info@kavy-group.com" style="color:white">info@kavy-group.com</a></p>
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

        <!-- SECTION CONTENT END -->

    </div>

    <!-- CONTENT END -->

</asp:Content>
