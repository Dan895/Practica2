<%@ Page Title="Alumno" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addAlumno.aspx.cs" Inherits="WebApplication.addAlumno" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Creación de Alumno</h2>

        <div>
            <p class="lead">Carnet:</p>
            <asp:TextBox class="lead" ID="txtId" runat="server"></asp:TextBox>
        </div>
        <div>
            <p class="lead">Nombre Alumno: </p>
            <asp:TextBox class="lead" ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <div>
            <p class="lead">Fecha Nacimiento:</p>
            <asp:TextBox class="lead" ID="txtFechaNac" runat="server"></asp:TextBox>
        </div>
        <div>
            <p class="lead">Edad:</p>
            <asp:TextBox class="lead" ID="txtedad" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="guardarCurso" class="btn btn-primary btn-lg" runat="server" Text="Guardar" OnClick="guardarEstudiante_Click" />
        </div>
        <div>
            <p><%= this.msg %></p>
        </div>
    </div>

</asp:Content>

