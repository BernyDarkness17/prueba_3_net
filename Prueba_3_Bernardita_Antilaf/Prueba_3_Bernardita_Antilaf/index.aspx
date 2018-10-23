<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Prueba_3_Bernardita_Antilaf.index" %>
<%@ Import Namespace="Prueba_3_Bernardita_Antilaf.model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    Resultados consulta:
    <table style="width:100%">
  <tr>
    <th>ID Pelicula</th>
    <th>Nombre Pelicula</th> 
    <th>ID Actor</th>
    <th>Nombre Actor</th>
    <th>Nombre del pais del actor</th>
  </tr>
    <% 
        Data d = new Data();
        foreach(Consulta c in d.read()) {
            %>  <tr>
                <td><%=c.IdPeli %></td>
                <td><%=c.NombrePe %></td>
                <td><%=c.IdActor %></td>
                <td><%=c.NombreActor %></td>
                <td><%=c.NomPaisActor %></td>
                </tr>
            <%
        }
        %>
</table>

</body>
</html>
