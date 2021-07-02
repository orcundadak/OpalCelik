<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminPanel.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="OpalCelik.AdminPanel.Projects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelOrta" runat="server">
     <header class="blue accent-3 relative nav-sticky">
        <div class="container-fluid text-white">
            <div class="row p-t-b-0 ">
                <div class="col" style="text-align:center">
                    <h4>
                        <i class="icon-package"></i>
                        Projeler
                    </h4>
                </div>
            </div>
           <div class="row">
                <ul class="nav responsive-tab nav-material nav-material-white">
                    <li>
                        <a class="nav-link active" href="panel-page-products.html"><i class="icon icon-list"></i>Tüm Projeler</a>
                    </li>
                    <li>
                        <a class="nav-link" href="addProject.aspx"><i
                                class="icon icon-plus-circle"></i> Yeni Proje Ekle</a>
                    </li>
                    <li>
                        <a class="nav-link" href="#"><i class="icon icon-trash-can"></i>Silinenler</a>
                    </li>
                </ul>
            </div>
        </div>
    </header>

    <div class="container-fluid animatedParent animateOnce my-3">
        <div class="animated fadeInUpShort">
            <div class="row">
                <div class="col-md-12">
                    <div class="card no-b shadow">
                        <div class="card-body p-0">
                            <div class="table-responsive">
                                <table class="table table-hover ">
                                    <tbody>
                                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                    
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <%--<nav class="pt-3" aria-label="Page navigation">
                <ul class="pagination">
                    <li class="page-item"><a class="page-link" href="#">Önceki</a>
                    </li>
                    <li class="page-item"><a class="page-link" href="#">1</a>
                    </li>
                    <li class="page-item"><a class="page-link" href="#">2</a>
                    </li>
                    <li class="page-item"><a class="page-link" href="#">3</a>
                    </li>
                    <li class="page-item"><a class="page-link" href="#">Sonraki</a>
                    </li>
                </ul>
            </nav>--%>
        </div>
    </div>
</asp:Content>
