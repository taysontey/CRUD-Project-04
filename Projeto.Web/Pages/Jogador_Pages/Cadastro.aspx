<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Projeto.Web.Pages.Jogador_Pages.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPrincipal" runat="server">

    <div class="container">

        <div class="form-horizontal">

            <div class="form-group">
                <label class="control-label col-md-2">Nome:</label>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control" ID="txtNome" runat="server"></asp:TextBox>
                </div>
            </div>

             <div class="form-group">
                <label class="control-label col-md-2">Apelido:</label>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control" ID="txtApelido" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Posição:</label>
                <div class="col-md-5">
                    <asp:TextBox CssClass="form-control" ID="txtPosicao" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Data de Nascimento:</label>
                <div class="col-md-2">
                    <asp:TextBox CssClass="form-control" ID="txtDataNascimento" runat="server" TextMode="Date"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2">Selecione o Time:</label>
                <div class="col-md-2">
                    <asp:DropDownList ID="dropDownTimes" runat="server"></asp:DropDownList>
                </div>
            </div>
            <hr />

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button CssClass="btn btn-default" ID="btnCadastro" runat="server" Text="Cadastrar Jogador" OnClick="btnCadastro_Click" />
                </div>
            </div>
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </div>

</asp:Content>
