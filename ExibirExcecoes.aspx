<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ExibirExcecoes.aspx.cs" Inherits="Projeto3._1.ExibirExcecoes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="margin-top-60">
        <asp:Label ID="Excecoes" runat="server"></asp:Label>
        <br />
        <hr />
        <asp:Button ID="Limpar" onClick="Limpar_Click" runat="server" Text="Limpar" />
    </div>
</asp:Content>
