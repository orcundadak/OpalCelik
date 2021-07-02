<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminPanel.Master" AutoEventWireup="true" CodeBehind="updateProject.aspx.cs" Inherits="OpalCelik.AdminPanel.updateProject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelOrta" runat="server">
    <header class="blue accent-3 relative">
        <div class="container-fluid text-white">
            <div class="row p-t-b-0 ">
                <div class="col" style="text-align: center">
                    <h4>
                        <i class="icon-package"></i>
                        Proje Ekle
                    </h4>
                </div>
            </div>
            <div class="row">
                <ul class="nav responsive-tab nav-material nav-material-white">
                    <li>
                        <a class="nav-link" href="Projects.aspx"><i class="icon icon-list"></i>Tüm Projeler</a>
                    </li>
                    <li>
                        <a class="nav-link active" href="addProject.aspx"><i
                            class="icon icon-edit"></i>Projeyi Düzenle</a>
                    </li>
                </ul>
            </div>
        </div>
    </header>

    <div class="container-fluid animatedParent animateOnce my-3">
        <div class="animated fadeInUpShort">
            <form runat="server">
                <div class="row">
                    <div class="col-md-8 ">
                        <div class="card">

                            <h3 class="card-header white">Türkçe</h3>
                                <asp:Button ID="btnAc" class="btn btn-success" type="submit" runat="server" Text="Düzenlemeyi Aç" OnClick="btnAc_Click" style="float: right;" />
                    
                            <div class="card-body">
                                
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <label for="txtProjeAdi">Proje Adı</label>
                                        <asp:TextBox ID="txtProjeAdi" runat="server" class="form-control"
                                            placeholder="Proje Adı" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <label for="txtMusteri">Müşteri</label>
                                        <asp:TextBox ID="txtMusteri" runat="server" class="form-control"
                                            placeholder="Müşteri" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <label for="txtLokasyon">Lokasyon</label>
                                        <asp:TextBox ID="txtLokasyon" runat="server" class="form-control"
                                            placeholder="Lokasyon" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                                        </div>
                                    </div>
                                    <div class="col-md-3 mb-3">
                                        <label for="txtSektor">Sektör</label>
                                        <asp:TextBox ID="txtSektor" runat="server" class="form-control"
                                            placeholder="Sektör" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                    <div class="col-md-3 mb-3">
                                        <label for="txtKapsam">Kapsam</label>
                                        <asp:TextBox ID="txtKapsam" runat="server" class="form-control"
                                            placeholder="Kapsam" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-3 mb-3">
                                        <label for="txtYil">Yil</label>
                                        <asp:TextBox ID="txtYil" runat="server" class="form-control"
                                            placeholder="Yil" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                    <div class="col-md-3 mb-3">
                                        <label for="txtMiktar">Miktar</label>
                                        <asp:TextBox ID="txtMiktar" runat="server" class="form-control"
                                            placeholder="Miktar" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <h3 class="card-header white">İngilizce</h3>
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <label for="txtProjectName">Project Name</label>
                                        <asp:TextBox ID="txtProjectName" runat="server" class="form-control"
                                            placeholder="Project Name" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <label for="txtSector">Sector</label>
                                        <asp:TextBox ID="txtSector" runat="server" class="form-control"
                                            placeholder="Sector" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>


                                </div>
                                <div class="row">
                                    <div class="col-md-3 mb-3">
                                        <label for="txtScope">Scope</label>
                                        <asp:TextBox ID="txtScope" runat="server" class="form-control"
                                            placeholder="Scope" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                    <div class="col-md-3 mb-3">
                                        <label for="txtSira">Sıra</label>
                                        <asp:TextBox ID="txtSira" runat="server" class="form-control"
                                            placeholder="Sıra" required="required"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Please provide a valid price.
                               
                                        </div>
                                    </div>
                                    <div class="col-md-6 mb-3">
                                    </div>

                                </div>
                                <div class="row mt-10">
                                    <div class="col-md-3 mb-3" style="float: right">
                                        <asp:Button ID="btnKaydet" class="btn btn-primary" type="submit" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <%--<div class="card mt-4">
                            <h6 class="card-header white">Projeyi Kaydet</h6>
                            <div class="card-body">


                                <%--<input type="checkbox" class="custom-control-input" id="customControlValidation1" required>
                                <h4 class="" for="customControlValidation1">Projeyi kaydetmek ve resimleri eklemek için butona basın.</h4>
                                <div class="invalid-feedback">Example invalid feedback text</div>

                            </div>
                            <div class="card-footer bg-transparent">
                            </div>
                        </div>--%>
                        <div class="card ">
                            <div class="ml-2">
                                <div class="ml-2 mt-3">
                                    <h6 class="card-header white">Kategori</h6>
                                    <div class="mt-2">
                                        <asp:Label ID="Label1" runat="server" Text="Önceden Seçili Olan Kategoriler: " ForeColor="Red"></asp:Label><br />
                                        <asp:Label ID="lblKategori" runat="server" Text="" ForeColor="Red" Font-Bold="true"></asp:Label>
                                    </div>
                                    <div class="mt-2">

                                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1"
                                            DataTextField="CategoryName" DataValueField="categoryID" RepeatColumns="2">
                                        </asp:CheckBoxList>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ConnectionStrings:OpalConStr%>"
                                            SelectCommand="SELECT CategoryName, categoryID FROM dbo.categories"></asp:SqlDataSource>

                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card mt-2">
                            <div>
                                <h6 class="card-header white">Ana Görsel</h6>
                                <asp:FileUpload ID="FileUpload1" class="form-control" runat="server" />
                            </div>
                            <div class="mt-10">
                                <h6 class="card-header white">Diğer Görseller</h6>
                                <asp:FileUpload ID="MultipleFileUpload" class="form-control" runat="server" AllowMultiple="true" />
                            </div>
                        </div>
                    </div>

                </div>
            </form>
        </div>
    </div>
</asp:Content>
