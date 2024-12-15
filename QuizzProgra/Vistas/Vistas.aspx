<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vistas.aspx.cs" Inherits="QuizzProgra.Vistas.Usuarios" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Gestión de Escuelas y Clases</title>
    <style>
        /* Estilo general (sin cambios significativos) */
        body {
            font-family: Arial, sans-serif;
            background-color: #b3e5fc;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
        }

        .main-container {
            width: 100%;
            display: flex;
            flex-direction: column;
            align-items: center;
            gap: 20px;
        }

        .container {
            background-color: white;
            padding: 30px;
            border-radius: 15px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
            margin: 15px auto;
            width: 90%;
            max-width: 1200px;
            text-align: center;
        }

        h2 {
            text-align: center;
            margin-bottom: 20px;
        }

        label {
            display: block;
            margin-top: 10px;
        }

        .input-field {
            width: 100%;
            padding: 5px;
            margin-top: 5px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .btn {
            width: 100%;
            padding: 10px;
            margin-top: 10px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        .btn:hover {
            background-color: #0056b3;
        }

        .grid-view {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
            text-align: left;
        }

        .grid-view th, .grid-view td {
            border: 1px solid #ddd;
            padding: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <h2>Lista de Escuelas</h2>


            <asp:GridView ID="GridViewSchool" CssClass="grid-view" runat="server"></asp:GridView>


            <label for="SchoolIDTextBox">ID Escuela:</label>
            <asp:TextBox ID="SchoolIDTextBox" type="number" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="NameSchoolTextBox">Nombre:</label>
            <asp:TextBox ID="NameSchoolTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="EmailSchoolTextBox">Correo Electrónico:</label>
            <asp:TextBox ID="EmailSchoolTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="PhoneSchoolTextBox">Teléfono:</label>
            <asp:TextBox ID="PhoneSchoolTextBox" type="number" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="DescriptionSchoolTextBox">Descripcion:</label>
            <asp:TextBox ID="DescriptionSchoolTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="PostCodeTextBox">Codigo Postal:</label>
            <asp:TextBox ID="PostCodeTextBox" type= "number" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="PostAddressTextBox">PostAddress:</label>
            <asp:TextBox ID="PostAddressTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            
            
   
            <asp:Button ID="AgregarSC" runat="server" CssClass="btn" Text="Agregar" OnClick="AgregarSC_Click" />
            <asp:Button ID="BorrarSC" runat="server" CssClass="btn" Text="Borrar" OnClick="BorrarSC_Click" />
            <asp:Button ID="ModificarSC" runat="server" CssClass="btn" Text="Modificar" OnClick="ModificarSC_Click" />
        </div>


        <br /><br />


        <div class="container">
            <h2>Lista de Clases</h2>

            <asp:GridView ID="GridViewClass" CssClass="grid-view" runat="server"></asp:GridView>

            <label for="ClassIDTextBox">ID de la Escuela:</label>
            <asp:TextBox ID="ClassIDTextBox" type="number" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="NameClassTextBox"> Nombre de la clase:</label>
            <asp:TextBox ID="NameClassTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="DescriptionClassTextBox">Descripcion:</label>
            <asp:TextBox ID="DescriptionClassTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            <asp:Button ID="AgregarC" runat="server" CssClass="btn" Text="Agregar" OnClick="AgregarC_Click" />
            <asp:Button ID="BorrarC" runat="server" CssClass="btn" Text="Borrar" OnClick="BorrarC_Click" />
        </div>
    </form>
</body>
</html>