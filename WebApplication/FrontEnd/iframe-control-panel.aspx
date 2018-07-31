<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="iframe-control-panel.aspx.vb" Inherits="WebApplication.iframe_control_panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="refresh" content="1">

    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <%--My CSS--%><%--<link href="content/font-awesome.min.css" rel="stylesheet" />--%>

    <title>VBNet Avaliação</title>
    <style type="text/css">
        .auto-style1 {
            margin-right: 0;
            margin-bottom: 1;
        }

        .auto-style3 {
            width: 260px;
        }

        .auto-style7 {
            width: 260px;
            height: 35px;
        }

        .auto-style9 {
            width: 549px;
        }

        .auto-style10 {
            height: 35px;
            width: 549px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table class="w-100">
                <tr>
                    <td class="auto-style3">Actions</td>
                    <td class="auto-style9">Status On/Off</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Messages"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="buttonStatus" runat="server" />
                    </td>
                    <td class="auto-style9">
                        <asp:CheckBox ID="checkBoxStatus" runat="server" Enabled="False" />
                    </td>
                    <td rowspan="9">
                        <asp:TextBox ID="textBoxViewMessages" runat="server" Height="305px" TextMode="MultiLine" Width="517px" ReadOnly="True" Style="resize: none;" BorderStyle="Solid" CssClass="modal-open"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="buttonAlarm" runat="server" />
                    </td>
                    <td class="auto-style9">
                        <asp:CheckBox ID="checkBoxAlarm" runat="server" Enabled="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="buttonFire" runat="server" />
                    </td>
                    <td class="auto-style9">
                        <asp:CheckBox ID="checkBoxFire" runat="server" Enabled="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="buttonLightBedR1" runat="server" CssClass="auto-style1" />
                    </td>
                    <td class="auto-style9">
                        <asp:CheckBox ID="checkBoxLightBedR1" runat="server" Enabled="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="buttonLightBedR2" runat="server" />
                    </td>
                    <td class="auto-style9">
                        <asp:CheckBox ID="checkBoxLightBedR2" runat="server" Enabled="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="buttonLightBedR3" runat="server" />
                    </td>
                    <td class="auto-style10">
                        <asp:CheckBox ID="checkBoxLightBedR3" runat="server" Enabled="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="buttonLiving" runat="server" />
                    </td>
                    <td class="auto-style9">
                        <asp:CheckBox ID="checkBoxLiving" runat="server" Enabled="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="buttonDining" runat="server" />
                    </td>
                    <td class="auto-style9">
                        <asp:CheckBox ID="checkBoxDining" runat="server" Enabled="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="buttonGarage" runat="server" />
                    </td>
                    <td class="auto-style9">
                        <asp:CheckBox ID="checkBoxGarage" runat="server" Enabled="False" />
                    </td>
                </tr>
            </table>
        </div>
    </form>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.bundle.min.js"></script>

</body>
</html>
