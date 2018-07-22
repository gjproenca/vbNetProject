<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="manage-permissions.aspx.vb" Inherits="WebApplication.manage_users" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <%--My CSS--%>    <%--<link href="content/font-awesome.min.css" rel="stylesheet" />--%>

    <title>VBNet Avaliação</title>
</head>
<body>
    <form id="body" runat="server">
        <div>

            <div class="py-5">
                <div class="container">
                    <div class="row">
                        <div class="col-md-1">
                        </div>

                        <!-- Form -->
                        <div class="col-md-10">
                            <div class="p-5 card bg-primary border-secondary">
                                <div class="card-body">
                                    <h1 class="mb-4 text-center text-white">Manage Permissions</h1>

                                    <%-- Username --%>
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="IdPermission" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." AllowSorting="True" CssClass="table table-hover table-responsive table-light" GridLines="None">
                                            <Columns>
                                                <asp:CommandField ShowEditButton="True" />
                                                <asp:BoundField DataField="IdPermission" HeaderText="IdPermission" ReadOnly="True" SortExpression="IdPermission" InsertVisible="False" Visible="False" />
                                                <asp:BoundField DataField="IdUser" HeaderText="IdUser" SortExpression="IdUser" Visible="False" />
                                                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" ReadOnly="True" />
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
                                                <asp:BoundField DataField="TimeStamp" HeaderText="TimeStamp" SortExpression="TimeStamp" ReadOnly="True" />
                                            </Columns>
                                        </asp:GridView>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DomoSysConnectionString %>" DeleteCommand="DELETE FROM [Permissions] WHERE [IdPermission] = @IdPermission" InsertCommand="INSERT INTO [Permissions] ([IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp]) VALUES (@IdUser, @SoftwareStatus, @Alarm, @Fire, @Message, @LightBedR1, @LightBedR2, @LightBedR3, @LightLiving, @LightDining, @LightGarage, @TimeStamp)" SelectCommand="SELECT Permissions.IdPermission, Permissions.IdUser, Users.UserName, Permissions.SoftwareStatus, Permissions.Alarm, Permissions.Fire, Permissions.Message, Permissions.LightBedR1, Permissions.LightBedR2, Permissions.LightBedR3, Permissions.LightLiving, Permissions.LightDining, Permissions.LightGarage, Permissions.TimeStamp FROM Permissions INNER JOIN Users ON Permissions.IdUser = Users.IdUser" UpdateCommand="UPDATE [Permissions] SET [SoftwareStatus] = @SoftwareStatus, [Alarm] = @Alarm, [Fire] = @Fire, [Message] = @Message, [LightBedR1] = @LightBedR1, [LightBedR2] = @LightBedR2, [LightBedR3] = @LightBedR3, [LightLiving] = @LightLiving, [LightDining] = @LightDining, [LightGarage] = @LightGarage, [TimeStamp] = GETDATE() WHERE [IdPermission] = @IdPermission">
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
                                                <asp:Parameter Name="TimeStamp" Type="DateTime" />
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
                                                <asp:Parameter Name="TimeStamp" Type="DateTime" />
                                                <asp:Parameter Name="IdPermission" Type="Int32" />
                                            </UpdateParameters>
                                        </asp:SqlDataSource>

                                        <%--<small class="form-text text-muted">Minimum 8 characters
                                        </small>
                                        <asp:RequiredFieldValidator ID="requiredFieldValidatorTextBoxUsername" runat="server" ErrorMessage="Required field"
                                            ControlToValidate="textBoxUsername"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regularExpressionValidatorTextBoxUsername" runat="server" ErrorMessage="Requirements not met"
                                            ControlToValidate="textBoxUsername" ValidationExpression="^\w{8,}$"></asp:RegularExpressionValidator>--%>
                                    </div>

                                    <%-- Password --%><%--                                    <div class="form-group">
                                        <label>Password</label>
                                        <asp:TextBox ID="textBoxPassword" runat="server" class="form-control" TextMode="Password" MaxLength="50"></asp:TextBox>
                                        <small class="form-text text-muted">Minimum 8 characters
                                        </small>
                                        <asp:RequiredFieldValidator ID="requiredFieldValidatorTexboxPassword" runat="server" ErrorMessage="Required field"
                                            ControlToValidate="textBoxPassword"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regularExpressionValidatorTexboxPassword" runat="server" ErrorMessage="Requirements not met"
                                            ControlToValidate="textBoxPassword" ValidationExpression="^[^\s].{6,}[^\s]$"></asp:RegularExpressionValidator>
                                    </div>--%>
                                    <%-- Confirm Password --%><%--                                    <div class="form-group">
                                        <label>Confirm Password</label>
                                        <asp:TextBox ID="textBoxConfirmPassword" runat="server" class="form-control" TextMode="Password" MaxLength="50"></asp:TextBox>
                                        <small class="form-text text-muted">Minimum 8 characters
                                        </small>
                                        <asp:RequiredFieldValidator ID="requiredFieldValidator1" runat="server" ErrorMessage="Required field"
                                            ControlToValidate="textBoxConfirmPassword"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regularExpressionValidator1" runat="server" ErrorMessage="Requirements not met"
                                            ControlToValidate="textBoxConfirmPassword" ValidationExpression="^[^\s].{6,}[^\s]$"></asp:RegularExpressionValidator>
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password fields don't match" ControlToCompare="textBoxPassword" ControlToValidate="textBoxConfirmPassword"></asp:CompareValidator>
                                    </div>--%>
                                    <%--                                    <asp:Button class="btn btn-dark text-white col-md-12" ID="buttonSubmit" runat="server" Text="Submit" CssClass="btn btn-dark text-white col-12" OnClick="buttonSubmit_Click" />
                                    <br />
                                    <br />
                                    <button class="btn btn-dark text-white col-md-12" name="reset" id="reset" type="reset">Limpar</button>--%>
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
