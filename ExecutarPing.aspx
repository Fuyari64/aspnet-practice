<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ExecutarPing.aspx.cs" Inherits="Projeto3._1.ExecutarPing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row margin-top-60">
        <div class="col-6">
            <div class="box border margin-right-20">
                <h2>Executar ping</h2>
                <br />
                <label>Entre com o endereço</label>
                <asp:TextBox ID="Endereco" runat="server"></asp:TextBox>  
                <br />
                <asp:Button ID="Enviar" runat="server" OnClick="Enviar_Click" CssClass="botao-editar" Text="Enviar" />
            </div>
        </div>

        <div class="col-6">
            <div class="box border">
                <h2>RESULTADO</h2>
                <br />
                <asp:Label ID="Resultado" Font-Size="16px" runat="server"></asp:Label>
                
            </div>
        </div>
    </div>
</asp:Content>
