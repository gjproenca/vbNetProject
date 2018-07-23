<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="WebApplication._default1" %>

<!DOCTYPE html>

<html>
<head runat="server">
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
                                <a class="nav-link" href="./manage-permissions.aspx">Manage Permissions</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link">|</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link active" href="./default.aspx">Control Panel</a>
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
                                    <h1 class="mb-4 text-center text-white">Control Panel</h1>

                                    <asp:GridView ID="GridViewStatus" runat="server" AutoGenerateColumns="False" DataKeyNames="IdStatus" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." CssClass="table table-hover table-responsive table-light" AllowPaging="True" AllowSorting="True" GridLines="None">
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
