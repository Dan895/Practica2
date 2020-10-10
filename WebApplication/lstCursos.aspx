<%@ Page Title="Eliminar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LstCursos.aspx.cs" Inherits="WebApplication.lstCursos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:GridView ID="grilla" runat="server" Height="255px" Width="1005px" 
        AutoGenerateColumns="False"
        OnRowCancelingEdit="RowCancelingEdit"
        OnRowDeleting="RowDeleting"
        OnRowEditing="RowEditing" 
        OnRowUpdating="RowUpdating"
        DataKeyNames="codigoCurso">

        <Columns>
            <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate>
                    <asp:Label id="cod" Text='<%# Eval("codigoCurso") %>' runat="server"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nombre">
                <ItemTemplate>
                    <asp:Label id="nombre" Text='<%# Eval("cursoNombre") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtNombre" runat="server" Text='<%# Eval("cursoNombre") %>'/>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Descripcion">
                <ItemTemplate>
                    <asp:Label id="desc" Text='<%# Eval("descripcion") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtDesc" runat="server" Text='<%# Eval("descripcion") %>'/>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:CommandField HeaderText="Opciones" ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" /> 
            
        </Columns>
    </asp:GridView>



</asp:Content>
