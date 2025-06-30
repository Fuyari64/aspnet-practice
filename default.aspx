<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Projeto3._1._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="flexslider">
        <ul class="slides">
            <li>
                <img src="images/banner0.png" />
            </li>
            <li>
                <img src="images/banner1.png" />
            </li>
            <li>
                <img src="images/banner2.png" />
            </li>
            <li>
                <img src="images/banner3.png" />
            </li>            
            <li>
                <img src="images/banner4.png" />
            </li>
        </ul>
    </div>
    <script>
        $(window).load(function () {
            $('.flexslider').flexslider({
                animation: "slide",
                slideshowSpeed: 7000,           //Integer: Set the speed of the slideshow cycling, in milliseconds
                animationSpeed: 600,            //Integer: Set the speed of animations, in milliseconds
                randomized: true,
                pauseOnAction: true,
            });
        });
    </script>
</asp:Content>
