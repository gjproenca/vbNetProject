<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="manage-users.aspx.vb" Inherits="WebApplication.manage_users1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link href="./../Content/bootstrap.min.css" rel="stylesheet" />

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
                                <a class="nav-link active" href="./manage-users.aspx">Manage Users</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="./manage-permissions.aspx">Manage Permissions</a>
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

                                    <%-- Grid view users --%>
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="IdUser" DataSourceID="SqlDataSource2" EmptyDataText="There are no data records to display." AllowPaging="True" AllowSorting="True" CssClass="table table-hover table-responsive table-light" GridLines="None">
                                        <Columns>
                                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                            <asp:BoundField DataField="IdUser" HeaderText="IdUser" ReadOnly="True" SortExpression="IdUser" />
                                            <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                                            <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                                            <asp:CheckBoxField DataField="Administrator" HeaderText="Administrator" SortExpression="Administrator" />
                                            <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
                                            <asp:BoundField DataField="TimeStamp" HeaderText="TimeStamp" SortExpression="TimeStamp" />
                                        </Columns>
                                    </asp:GridView>
                                    <%--<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DomoSysConnectionString %>" DeleteCommand="DELETE FROM [Users] WHERE [IdUser] = @IdUser" InsertCommand="INSERT INTO [Users] ([UserName], [Password], [Administrator], [Active], [TimeStamp]) VALUES (@UserName, @Password, @Administrator, @Active, @TimeStamp)" ProviderName="<%$ ConnectionStrings:DomoSysConnectionString.ProviderName %>" SelectCommand="SELECT [IdUser], [UserName], [Password], [Administrator], [Active], [TimeStamp] FROM [Users]" UpdateCommand="UPDATE [Users] SET [UserName] = @UserName, [Password] = @Password, [Administrator] = @Administrator, [Active] = @Active, [TimeStamp] = @TimeStamp WHERE [IdUser] = @IdUser">
                                    --%>    
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DomoSysConnectionString %>" DeleteCommand="UPDATE [Users] SET [Active] = 0, [TimeStamp] = GETDATE() WHERE [IdUser] = @IdUser" InsertCommand="INSERT INTO [Users] ([UserName], [Password], [Administrator], [Active], [TimeStamp]) VALUES (@UserName, @Password, @Administrator, @Active, @TimeStamp)" ProviderName="<%$ ConnectionStrings:DomoSysConnectionString.ProviderName %>" SelectCommand="SELECT [IdUser], [UserName], [Password], [Administrator], [Active], [TimeStamp] FROM [Users]" UpdateCommand="UPDATE [Users] SET [UserName] = @UserName, [Password] = @Password, [Administrator] = @Administrator, [Active] = @Active, [TimeStamp] = GETDATE() WHERE [IdUser] = @IdUser">
                                    
                                        
                                        
                                        
                                        
                                        <DeleteParameters>
                                            <asp:Parameter Name="IdUser" Type="Int32" />
                                        </DeleteParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="UserName" Type="String" />
                                            <asp:Parameter Name="Password" Type="String" />
                                            <asp:Parameter Name="Administrator" Type="Boolean" />
                                            <asp:Parameter Name="Active" Type="Boolean" />
                                            <asp:Parameter Name="TimeStamp" Type="DateTime" />
                                        </InsertParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="UserName" Type="String" />
                                            <asp:Parameter Name="Password" Type="String" />
                                            <asp:Parameter Name="Administrator" Type="Boolean" />
                                            <asp:Parameter Name="Active" Type="Boolean" />
                                            <asp:Parameter Name="TimeStamp" Type="DateTime" />
                                            <asp:Parameter Name="IdUser" Type="Int32" />
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
    <script src="./../Scripts/jquery-3.3.1.min.js"></script>
    <script src="./../Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>
