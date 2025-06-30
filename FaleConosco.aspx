<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="FaleConosco.aspx.cs" Inherits="Projeto3._1.FaleConosco" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
        <div class="margin-top-60 row">
            <div class="col-6">
                <div class="box border margin-right-20">
                    <h2>Fale Conosco</h2>
                    <br />
                    <asp:Label ID="MensagemErro" runat="server" ForeColor="Red"></asp:Label>
                    <br />
                    <label>SEU NOME</label>
                    <asp:TextBox ID="SeuNome" runat="server"></asp:TextBox>
                    <label>SEU EMAIL</label>
                    <asp:TextBox ID="SeuEmail" runat="server"></asp:TextBox>
                    <label>MENSAGEM</label>
                    <asp:TextBox ID="Mensagem" runat="server" TextMode="MultiLine" Rows="6"></asp:TextBox>
                    <br />
                    <asp:Button ID="Enviar" runat="server" OnClick="Enviar_Click" Text="Enviar" />
                </div>
            </div>
            <div class="col-6">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3679.692129142489!2d-47.35465133451634!3d-22.739681789816835!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c89bea5cdb94f9%3A0xffb368bd91ea12ae!2sFatec%20Americana%20-%20Faculdade%20de%20Tecnologia%20de%20Americana%20Ministro%20Ralph%20Biasi!5e0!3m2!1spt-BR!2sbr!4v1663802659222!5m2!1spt-BR!2sbr" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
            </div>
        </div>
</asp:Content>
