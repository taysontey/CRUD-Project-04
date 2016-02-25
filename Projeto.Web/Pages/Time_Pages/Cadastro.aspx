<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Projeto.Web.Pages.Time_Pages.Cadastro" %>

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
                <label class="control-label col-md-2">Data de Fundação:</label>
                <div class="col-md-2">
                    <asp:TextBox CssClass="form-control" ID="txtDataFundacao" runat="server" TextMode="Date"></asp:TextBox>
                </div>
            </div>
            <hr />

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button CssClass="btn btn-default" ID="btnCadastro" runat="server" Text="Cadastrar Time" OnClick="btnCadastro_Click" />
                </div>
            </div>
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </div>

</asp:Content>
