<%@ Page Title="Maestro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddMaestro.aspx.cs" Inherits="WebApplication.addMaestro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Creación de Maestro</h2>

        <div>
            <p class="lead">Carnet:</p>
            <asp:TextBox class="lead" ID="txtId" runat="server"></asp:TextBox>
        </div>
        <div>
            <p class="lead">Nombre Maestro: </p>
            <asp:TextBox class="lead" ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <div>
            <p class="lead">Fecha Nacimiento:</p>
            <asp:TextBox class="lead" ID="txtFechaNac" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="guardarCurso" class="btn btn-primary btn-lg" runat="server" Text="Guardar" OnClick="guardarMaestro_Click" />
        </div>
        <div>
            <p><%= this.msg %></p>
        </div>
    </div>

</asp:Content>
