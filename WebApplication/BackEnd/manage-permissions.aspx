<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="manage-permissions.aspx.vb" Inherits="WebApplication.manage_users" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <%--My CSS--%><%--<link href="content/font-awesome.min.css" rel="stylesheet" />--%>

    <title>VBNet Avaliação</title>
</head>
<body>
    <form id="body" runat="server">
        <div>
            <%-- nav --%>
            <nav class="navbar navbar-expand-md bg-primary navbar-dark">
                <div class="container">
                    <a class="navbar-brand">DomoSys</a>
                    <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbar2SupportedContent">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse text-center justify-content-end" id="navbar2SupportedContent">
                        <ul class="navbar-nav">
                            <li class="nav-item">
                                <a class="nav-link" href="./register-users.aspx">Register Users</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link">|</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="./manage-users.aspx">Manage Users</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link active" href="./manage-permissions.aspx">Manage Permissions</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link">|</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="./default.aspx">Control Panel</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link">|</a>
                            </li>
                        </ul>
                        <a class="btn navbar-btn btn-dark ml-2 text-white" href="./sign-out.aspx">Sign Out</a>
                    </div>
                </div>
            </nav>

            <div class="py-5">
                <div class="container">
                    <div class="row">

                        <!-- Form -->
                        <div class="col-md-12">
                            <div class="p-5 card bg-primary border-secondary">
                                <div class="card-body">
                                    <h1 class="mb-4 text-center text-white">Manage Permissions</h1>

                                    <%-- Grid view permissions --%>
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="IdPermission" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." AllowPaging="True" AllowSorting="True" CssClass="table table-hover table-responsive table-light" GridLines="None" HorizontalAlign="Center">
                                        <Columns>
                                            <asp:CommandField ShowEditButton="True" />
                                            <asp:BoundField DataField="IdPermission" HeaderText="IdPermission" ReadOnly="True" SortExpression="IdPermission" InsertVisible="False" Visible="False" />
                                            <asp:BoundField DataField="IdUser" HeaderText="IdUser" SortExpression="IdUser" Visible="False" />
                                            <asp:BoundField DataField="UserName" HeaderText="UserName" ReadOnly="True" SortExpression="UserName" />
                                            <asp:CheckBoxField DataField="SoftwareStatus" HeaderText="SoftwareStatus" SortExpression="SoftwareStatus" />
                                            <asp:CheckBoxField DataField="Alarm" HeaderText="Alarm" SortExpression="Alarm" />
                                            <asp:CheckBoxField DataField="Fire" HeaderText="Fire" SortExpression="Fire" />
                                            <asp:CheckBoxField DataField="Message" HeaderText="Message" SortExpression="Message" />
                                            <asp:CheckBoxField DataField="LightBedR1" HeaderText="LightBedR1" SortExpression="LightBedR1" />
                                            <asp:CheckBoxField DataField="LightBedR2" HeaderText="LightBedR2" SortExpression="LightBedR2" />
                                            <asp:CheckBoxField DataField="LightBedR3" HeaderText="LightBedR3" SortExpression="LightBedR3" />
                                            <asp:CheckBoxField DataField="LightLiving" HeaderText="LightLiving" SortExpression="LightLiving" />
                                            <asp:CheckBoxField DataField="LightDining" HeaderText="LightDining" SortExpression="LightDining" />
                                            <asp:CheckBoxField DataField="LightGarage" HeaderText="LightGarage" SortExpression="LightGarage" />
                                            <asp:CheckBoxField DataField="TimeStamp" HeaderText="TimeStamp" SortExpression="TimeStamp" />
                                        </Columns>
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DomoSysConnectionString %>" DeleteCommand="DELETE FROM [Permissions] WHERE [IdPermission] = @IdPermission" InsertCommand="INSERT INTO [Permissions] ([IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp]) VALUES (@IdUser, @SoftwareStatus, @Alarm, @Fire, @Message, @LightBedR1, @LightBedR2, @LightBedR3, @LightLiving, @LightDining, @LightGarage, @TimeStamp)" SelectCommand="SELECT Permissions.IdPermission, Permissions.IdUser, Users.UserName, Permissions.SoftwareStatus, Permissions.Alarm, Permissions.Fire, Permissions.Message, Permissions.LightBedR1, Permissions.LightBedR2, Permissions.LightBedR3, Permissions.LightLiving, Permissions.LightDining, Permissions.LightGarage, Permissions.TimeStamp FROM Permissions INNER JOIN Users ON Permissions.IdUser = Users.IdUser" UpdateCommand="UPDATE [Permissions] SET [SoftwareStatus] = @SoftwareStatus, [Alarm] = @Alarm, [Fire] = @Fire, [Message] = @Message, [LightBedR1] = @LightBedR1, [LightBedR2] = @LightBedR2, [LightBedR3] = @LightBedR3, [LightLiving] = @LightLiving, [LightDining] = @LightDining, [LightGarage] = @LightGarage, [TimeStamp] = @TimeStamp WHERE [IdPermission] = @IdPermission">
                                        <DeleteParameters>
                                            <asp:Parameter Name="IdPermission" Type="Int32" />
                                        </DeleteParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="IdUser" Type="Int32" />
                                            <asp:Parameter Name="SoftwareStatus" Type="Boolean" />
                                            <asp:Parameter Name="Alarm" Type="Boolean" />
                                            <asp:Parameter Name="Fire" Type="Boolean" />
                                            <asp:Parameter Name="Message" Type="Boolean" />
                                            <asp:Parameter Name="LightBedR1" Type="Boolean" />
                                            <asp:Parameter Name="LightBedR2" Type="Boolean" />
                                            <asp:Parameter Name="LightBedR3" Type="Boolean" />
                                            <asp:Parameter Name="LightLiving" Type="Boolean" />
                                            <asp:Parameter Name="LightDining" Type="Boolean" />
                                            <asp:Parameter Name="LightGarage" Type="Boolean" />
                                            <asp:Parameter Name="TimeStamp" Type="Boolean" />
                                        </InsertParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="SoftwareStatus" Type="Boolean" />
                                            <asp:Parameter Name="Alarm" Type="Boolean" />
                                            <asp:Parameter Name="Fire" Type="Boolean" />
                                            <asp:Parameter Name="Message" Type="Boolean" />
                                            <asp:Parameter Name="LightBedR1" Type="Boolean" />
                                            <asp:Parameter Name="LightBedR2" Type="Boolean" />
                                            <asp:Parameter Name="LightBedR3" Type="Boolean" />
                                            <asp:Parameter Name="LightLiving" Type="Boolean" />
                                            <asp:Parameter Name="LightDining" Type="Boolean" />
                                            <asp:Parameter Name="LightGarage" Type="Boolean" />
                                            <asp:Parameter Name="TimeStamp" Type="Boolean" />
                                            <asp:Parameter Name="IdPermission" Type="Int32" />
                                        </UpdateParameters>
                                    </asp:SqlDataSource>


                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        </div>
    </form>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>
