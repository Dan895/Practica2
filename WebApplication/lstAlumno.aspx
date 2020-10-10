<%@ Page Title="Listar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LstAlumno.aspx.cs" Inherits="WebApplication.lstAlumno" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:GridView ID="grilla" runat="server" Height="255px" Width="1005px" 
        AutoGenerateColumns="False"
        OnRowCancelingEdit="RowCancelingEdit"
        OnRowDeleting="RowDeleting"
        OnRowEditing="RowEditing" 
        OnRowUpdating="RowUpdating"
        DataKeyNames="CarnetEstudiante">

        <Columns>
            <asp:TemplateField HeaderText="Carnet">
                <ItemTemplate>
                    <asp:Label id="cod" Text='<%# Eval("CarnetEstudiante") %>' runat="server"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nombre">
                <ItemTemplate>
                    <asp:Label id="nombre" Text='<%# Eval("NombreEstudiante") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtNombre" runat="server" Text='<%# Eval("NombreEstudiante") %>'/>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fecha Nacimiento">
                <ItemTemplate>
                    <asp:Label id="desc" Text='<%# Eval("FechaNac") %>' runat="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtFechaNac" runat="server" Text='<%# Eval("FechaNac") %>'/>
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edad">
                <ItemTemplate>
                    <asp:Label id="desc" Text='<%# Eval("FechaNac") %>' runat="server"/>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:CommandField HeaderText="Opciones" ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" /> 
            
        </Columns>
    </asp:GridView>



</asp:Content>
