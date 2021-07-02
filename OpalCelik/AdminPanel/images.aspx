<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminPanel.Master" AutoEventWireup="true" CodeBehind="images.aspx.cs" Inherits="OpalCelik.AdminPanel.images" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphPanelOrta" runat="server">
    <header class="blue accent-3 relative">
        <div class="container-fluid text-white">
            <div class="row p-t-b-0 ">
                <div class="col" style="text-align: center">
                    <h4>
                        <i class="icon-photo"></i>
                        Fotoğraflar
                    </h4>
                </div>
            </div>
            <div class="row">
                <ul class="nav responsive-tab nav-material nav-material-white">
                    <li>
                        <a class="nav-link active" href="images.aspx"><i class="icon icon-photo"></i>Fotoğraflar</a>
                    </li>
                </ul>
            </div>
        </div>
    </header>


    <div class="container-fluid animatedParent animateOnce">
        <div class="animated fadeInUpShort my-3">
            <ul class="list-unstyled d-flex align-content-start flex-wrap">
                <li class="my-2 col-md-3">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </li>
            </ul>
        </div>

    </div>
</asp:Content>
