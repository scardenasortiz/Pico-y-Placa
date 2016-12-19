<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PicoPlaca.Web.Default" %>

<!DOCTYPE html>

<html>
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="user-scalable=0, width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
	<title>Pico y Placa
	</title>
	<link rel="stylesheet" type="text/css" href="App_Themes/Template/css/style.css">
	<link rel="stylesheet" type="text/css" href="App_Themes/Template/css/mobile.css">
	<script src="../js/jquery-1.10.2.js" type="text/javascript"></script>
    <link href="../App_Themes/Datepicker/css/jquery-ui.css" rel="stylesheet" type="text/css">
    <script src="../App_Themes/Datepicker/js/jquery-ui.js" type="text/javascript"></script>
    <script src="../js/ui.datepicker-es.js" type="text/javascript"></script>
    <script src="../js/jquery.numeric.js" type="text/javascript"></script>
    <script type="text/javascript">
    function validar_campos() {

        $("input[type=text]").keyup(function () {
            $(this).val($(this).val().replace(/([a-z])/, function (s) { return s.toUpperCase() }));
        });

        $('.campoNumerico').numeric({ negative: false, decimal: false });
    }

    $(document).ready(function () {
        validar_campos();
    });
    </script>
</head>
<body>
	<div id="header">
		<h1><a href="index.html">Pico y Placa <span><br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/App_Themes/Template/images/separador_vehicular.png" /></span></a></h1>
	</div>
	<div id="body">
		<form id="form1" runat="server">
			<h3>Consultas</h3>
            <table style="width: 100%;">
                <tr>
                    <td style="width:50%"><label for="name">
				        <span>Placa</span>
				        <asp:TextBox ID="txtPlacaLetras" TabIndex="1" runat="server" Enabled="True" MaxLength="3" Width="40px" Height="34"></asp:TextBox> -
                        <asp:TextBox ID="txtPlacaNumero" TabIndex="2" runat="server" CssClass="campoNumerico" Enabled="True" MaxLength="4" Width="40px" Height="34"></asp:TextBox>
			            </label>
			            <label for="email">
				            <span>Fecha</span>
                            <asp:TextBox ID="txtFecha" TabIndex="3" runat="server" Enabled="True" MaxLength="10" TextMode="Date" Height="34px"></asp:TextBox>
			            </label>
			            <label for="subject">
				            <span>Tiempo</span>
				            <asp:TextBox ID="txtTiempo" TabIndex="4" runat="server" Enabled="True" MaxLength="5" Width="146px" Height="34px" TextMode="Time"></asp:TextBox>
			            </label>
			            <asp:Button ID="btnConsultar" runat="server" Text="Enviar" OnClick="btnConsultar_Click" />&nbsp;&nbsp;<asp:Button ID="btnReiniciar" runat="server" Text="Iniciar" OnClick="btnReiniciar_Click" />
                    </td>
                    <td style="text-align:center; color:yellow; background-image:url(App_Themes/Template/images/respuesta.png)">
                        <asp:TextBox ID="txtMensaje" runat="server" TextMode="MultiLine" Height="168px" BackColor="#46464C" BorderWidth="0px" ForeColor="Yellow"></asp:TextBox>
                    </td>
                </tr>
                </table>
		</form>
	</div>
</body>
</html>