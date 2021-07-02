<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminPanel.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="OpalCelik.AdminPanel.profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelOrta" runat="server">
    <header class="blue accent-3 relative nav-sticky">
        <div class="container-fluid text-white">
            <div class="row p-t-b-0 ">
                <div class="col" style="text-align: center">
                    <h4>
                        <i class="icon-person"></i>
                        Profil
                    </h4>
                </div>
            </div>
        </div>
    </header>
    <div class="container-fluid animatedParent animateOnce my-3">
        <div class="animated fadeInUpShort">
            <div class="card no-b shadow">
                <div class="card-body">
                    <form runat="server">
                        <div class="row">
                            <div class="col-md-8 ">
                                <div style="float: right;">
                                    <asp:Button ID="btnGuncelle" class="btn btn-primary" type="submit" runat="server" Text="Düzenle" OnClick="btnGuncelle_Click" />
                                </div>
                                <div class="row" style="margin-top: 5%">

                                    <div class="col-md-6 mb-3">
                                        <label for="txtUserName">Kullanıcı Adı</label>
                                        <asp:TextBox ID="txtUserName" runat="server" class="form-control"
                                            required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <label for="txtSifre">Şifre</label>
                                        <asp:TextBox ID="txtSifre" runat="server" class="form-control"
                                            required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <label for="txtRealName">Ad Soyad</label>
                                        <asp:TextBox ID="txtRealName" runat="server" class="form-control"
                                            required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                                        </div>
                                    </div>
                                </div>
                                <div class="row" style="float: right">
                                    <div>
                                        <asp:Button ID="btnKaydet" class="btn btn-success" type="submit" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="card mt-4">
                                    <h6 class="card-header white">Bilgi</h6>
                                    <div class="card-body">
                                        <h4 class="" for="customControlValidation1">Bilgileri düzenlemek için <b>düzenle</b>, kaydetmek için <b>kaydet </b>butonunu kullanın.</h4>
                                    </div>
                                </div>
                            </div>
                        </div>


                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
