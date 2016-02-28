<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Projeto.Web.Pages.Time_Pages.Consulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPrincipal" runat="server">

    <div class="container" style="text-align: center">
        <h3>Lista de Times</h3>
        <br />
    </div>

    <div class="container">

        <asp:GridView ID="gridTime" EmptyDataText="Não há registros para exibir" CssClass="table table-hover" runat="server" AutoGenerateColumns="false" GridLines="None" DataKeyNames="idTime" OnRowDeleting="gridTime_RowDeleting" OnRowEditing="gridTime_RowEditing" OnRowUpdating="gridTime_RowUpdating" OnRowCancelingEdit="gridTime_RowCancelingEdit">

            <Columns>
                <asp:TemplateField HeaderText="Código" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:Label ID="lblIdTime" runat="server" Text='<%#Eval("IdTime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:BoundField ItemStyle-CssClass="t-cost" HeaderText="Nome" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center" DataField="Nome" HtmlEncode="False" />

                <asp:BoundField ApplyFormatInEditMode="true" ItemStyle-CssClass="t-cost" HeaderText="Data de Fundação" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center" DataField="DataFundacao" HtmlEncode="False" DataFormatString="{0:d}" />

                <asp:CommandField ShowDeleteButton="true" ShowEditButton="true" ButtonType="Link" HeaderText="Opções" HeaderStyle-CssClass="text-center" ItemStyle-HorizontalAlign="Center" />
            </Columns>

        </asp:GridView>

        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </div>
</asp:Content>
