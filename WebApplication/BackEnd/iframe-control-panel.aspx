<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="iframe-control-panel.aspx.vb" Inherits="WebApplication.control_panel_iframe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="refresh" content="13">

    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <%--My CSS--%>
    <%--<link href="content/font-awesome.min.css" rel="stylesheet" />--%>

    <title>VBNet Avaliação</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewStatus" runat="server" AutoGenerateColumns="False" DataKeyNames="IdStatus" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." CssClass="table table-hover table-responsive table-light" AllowPaging="True" AllowSorting="True" GridLines="None" AutoGenerateEditButton="False">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="IdStatus" HeaderText="IdStatus" InsertVisible="False" ReadOnly="True" SortExpression="IdStatus" Visible="False" />
                    <asp:BoundField DataField="IdUser" HeaderText="IdUser" SortExpression="IdUser" Visible="False" />
                    <asp:CheckBoxField DataField="SoftwareStatus" HeaderText="SoftwareStatus" SortExpression="SoftwareStatus" />
                    <asp:CheckBoxField DataField="Alarm" HeaderText="Alarm" SortExpression="Alarm" />
                    <asp:CheckBoxField DataField="Fire" HeaderText="Fire" SortExpression="Fire" />
                    <asp:BoundField DataField="Message" HeaderText="Message" SortExpression="Message" />
                    <asp:CheckBoxField DataField="LightBedR1" HeaderText="LightBedR1" SortExpression="LightBedR1" />
                    <asp:CheckBoxField DataField="LightBedR2" HeaderText="LightBedR2" SortExpression="LightBedR2" />
                    <asp:CheckBoxField DataField="LightBedR3" HeaderText="LightBedR3" SortExpression="LightBedR3" />
                    <asp:CheckBoxField DataField="LightLiving" HeaderText="LightLiving" SortExpression="LightLiving" />
                    <asp:CheckBoxField DataField="LightDining" HeaderText="LightDining" SortExpression="LightDining" />
                    <asp:CheckBoxField DataField="LightGarage" HeaderText="LightGarage" SortExpression="LightGarage" />
                    <asp:BoundField DataField="TimeStamp" HeaderText="TimeStamp" SortExpression="TimeStamp" ReadOnly="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DomoSysConnectionString %>" DeleteCommand="DELETE FROM [Status] WHERE [IdStatus] = @IdStatus" InsertCommand="INSERT INTO [Status] ([IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp]) VALUES (@IdUser, @SoftwareStatus, @Alarm, @Fire, @Message, @LightBedR1, @LightBedR2, @LightBedR3, @LightLiving, @LightDining, @LightGarage, @TimeStamp)" SelectCommand="SELECT [IdStatus], [IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp] FROM [Status]" UpdateCommand="UPDATE [Status] SET [SoftwareStatus] = @SoftwareStatus, [Alarm] = @Alarm, [Fire] = @Fire, [Message] = @Message, [LightBedR1] = @LightBedR1, [LightBedR2] = @LightBedR2, [LightBedR3] = @LightBedR3, [LightLiving] = @LightLiving, [LightDining] = @LightDining, [LightGarage] = @LightGarage, [TimeStamp] = GETDATE()  WHERE [IdStatus] = @IdStatus">
                <DeleteParameters>
                    <asp:Parameter Name="IdStatus" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="IdUser" Type="Int32" />
                    <asp:Parameter Name="SoftwareStatus" Type="Boolean" />
                    <asp:Parameter Name="Alarm" Type="Boolean" />
                    <asp:Parameter Name="Fire" Type="Boolean" />
                    <asp:Parameter Name="Message" Type="String" />
                    <asp:Parameter Name="LightBedR1" Type="Boolean" />
                    <asp:Parameter Name="LightBedR2" Type="Boolean" />
                    <asp:Parameter Name="LightBedR3" Type="Boolean" />
                    <asp:Parameter Name="LightLiving" Type="Boolean" />
                    <asp:Parameter Name="LightDining" Type="Boolean" />
                    <asp:Parameter Name="LightGarage" Type="Boolean" />
                    <asp:Parameter Name="TimeStamp" Type="DateTime" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="IdUser" Type="Int32" />
                    <asp:Parameter Name="SoftwareStatus" Type="Boolean" />
                    <asp:Parameter Name="Alarm" Type="Boolean" />
                    <asp:Parameter Name="Fire" Type="Boolean" />
                    <asp:Parameter Name="Message" Type="String" />
                    <asp:Parameter Name="LightBedR1" Type="Boolean" />
                    <asp:Parameter Name="LightBedR2" Type="Boolean" />
                    <asp:Parameter Name="LightBedR3" Type="Boolean" />
                    <asp:Parameter Name="LightLiving" Type="Boolean" />
                    <asp:Parameter Name="LightDining" Type="Boolean" />
                    <asp:Parameter Name="LightGarage" Type="Boolean" />
                    <asp:Parameter Name="IdStatus" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>
