<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Projeto.Web.Pages.Jogador_Pages.Consulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPrincipal" runat="server">

    <div class="container" style="text-align: center">
        <h3>Lista de Jogadores</h3>
        <br />
    </div>

    <div class="container">

        <asp:GridView ID="gridJogador" EmptyDataText="Não há registros para exibir" CssClass="table table-hover" runat="server" AutoGenerateColumns="false" GridLines="None" DataKeyNames="idJogador" OnRowDataBound="gridJogador_RowDataBound" OnRowDeleting="gridJogador_RowDeleting" OnRowEditing="gridJogador_RowEditing" OnRowUpdating="gridJogador_RowUpdating" OnRowCancelingEdit="gridJogador_RowCancelingEdit">

            <Columns>
                <asp:TemplateField HeaderText="Código" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:Label ID="lblIdTime" runat="server" Text='<%#Eval("IdJogador") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:BoundField ItemStyle-CssClass="t-cost" HeaderText="Nome" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center" DataField="Nome" HtmlEncode="False" />

                <asp:BoundField ItemStyle-CssClass="t-cost" HeaderText="Apelido" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center" DataField="Apelido" HtmlEncode="False" />

                <asp:BoundField ApplyFormatInEditMode="true" ItemStyle-CssClass="t-cost" HeaderText="Data de Nascimento" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center" DataField="DataNascimento" HtmlEncode="False" DataFormatString="{0:d}" />

                <asp:BoundField ItemStyle-CssClass="t-cost" HeaderText="Posição" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center" DataField="Posicao" HtmlEncode="False" />

                <asp:TemplateField HeaderText="Time" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center">
                    <EditItemTemplate>
                        <asp:DropDownList ID="dropDownTimes" runat="server"></asp:DropDownList>
                    </EditItemTemplate>

                    <ItemTemplate>
                        <asp:Label ID="lblTime" runat="server" Text='<%#Eval("Time.Nome") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:CommandField ShowDeleteButton="true" ShowEditButton="true" ButtonType="Link" HeaderText="Opções" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center" />
            </Columns>

        </asp:GridView>
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </div>
</asp:Content>
