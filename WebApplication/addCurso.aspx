<%@ Page Title="Curso" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddCurso.aspx.cs" Inherits="WebApplication.Paginas.Curso.addCurso" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Creación de cursos</h2>

        <div>
            <p class="lead">Código:</p>
            <asp:TextBox class="lead" ID="txtId" runat="server"></asp:TextBox>
        </div>
        <div>
            <p class="lead">Nombre Curso: </p>
            <asp:TextBox class="lead" ID="txtCurso" runat="server"></asp:TextBox>
        </div>
        <div>
            <p class="lead">Descripción:</p>
            <asp:TextBox class="lead" ID="txtDesc" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="guardarCurso" class="btn btn-primary btn-lg" runat="server" Text="Guardar" OnClick="guardarCurso_Click" />
        </div>
        <div>
            <p><%= this.msg %></p>
        </div>
    </div>

</asp:Content>
