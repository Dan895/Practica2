<%@ Page Title="Eliminar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="lstCursos.aspx.cs" Inherits="WebApplication.lstCursos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:GridView ID="grilla" runat="server" Height="255px" Width="395px" AutoGenerateColumns="False">
    </asp:GridView>

    <table class="table">
      <thead>
        <tr>
          <th scope="col">Codigo</th>
          <th scope="col">Curso</th>
          <th scope="col">Descripción</th>
        </tr>
      </thead>
      <tbody>
        @
        <tr>
          <th scope="row">1</th>
          <td>Mark</td>
          <td>Otto</td>
          <td>@mdo</td>
        </tr>
      </tbody>
    </table>
</asp:Content>
