<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CadastroComputadores.aspx.cs" Inherits="Projeto3._1.CadastroComputadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row margin-top-60">
        <div class="col-6">
            <div class="box border margin-right-20">
                <h2>Computador</h2>
                <br />
                <asp:Label ID="Mensagem" ForeColor="Red" Font-Size="18px" runat="server"></asp:Label>
                <br />
                <asp:Label ID="ComputadorID" Font-Bold="true" Font-Size="20px" runat="server"></asp:Label>
                <br />
                <label>IDENTIFICAÇÃO</label>
                <asp:TextBox ID="Identificacao" MaxLength="255" runat="server"></asp:TextBox>

                <label>ANOTAÇÕES</label>
                <asp:TextBox ID="Anotacoes" MaxLength="255" runat="server"></asp:TextBox>

                <label>STATUS</label>
                <asp:DropDownList ID="Status" runat="server">
                    <asp:ListItem Text="Ativo" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Inativo" Value="0"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Button ID="InserirEditar" runat="server" OnClick="InserirEditar_Click" CssClass="botao-editar" Text="Inserir" />
                <asp:Button ID="Excluir" OnClick="Excluir_Click" runat="server" Text="Excluir" Visible="false" />
            </div>
        </div>
        <div class="col-6">
            <div class="box border">
                <asp:TextBox ID="BuscarComputador" Width="180px" runat="server"></asp:TextBox>
                <asp:Button ID="Buscar" runat="server" Text="Buscar" OnClick="Buscar_Click" />
                <asp:Button ID="Cancelar" runat="server" Text="X" OnClick="Cancelar_Click" Visible="false" />

                <asp:GridView ID="ExibirComputadores" AutoGenerateColumns="true" AutoGenerateSelectButton="true" Width="100%" OnSelectedIndexChanged="ExibirComputadores_SelectedIndexChanged" CellPadding="4" BorderColor="#c0c0c0" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
