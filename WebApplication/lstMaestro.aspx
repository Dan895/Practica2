<%@ Page Title="Listar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LstMaestro.aspx.cs" Inherits="WebApplication.lstMaestro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:GridView ID="grilla" runat="server" Height="255px" Width="1005px" 
        AutoGenerateColumns="False"
        OnRowCancelingEdit="RowCancelingEdit"
        OnRowDeleting="RowDeleting"
        OnRowEditing="RowEditing" 
        OnRowUpdating="RowUpdating"
        DataKeyNames="CarnetMaestro">

        <Columns>
            <asp:TemplateField HeaderText="Carnet">
                <ItemTemplate>
                    <asp:Label id="cod" Text='<%# Eval("CarnetMaestro") %>' runat="server"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nombre">
                <ItemTemplate>
                    <asp:Label id="nombre" Text='<%# Eval("Nombre") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtNombre" runat="server" Text='<%# Eval("Nombre") %>'/>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fecha Nacimiento">
                <ItemTemplate>
                    <asp:Label id="desc" Text='<%# Eval("FechaNac") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtDesc" runat="server" Text='<%# Eval("FechaNac") %>'/>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:CommandField HeaderText="Opciones" ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" /> 
            
        </Columns>
    </asp:GridView>



</asp:Content>
