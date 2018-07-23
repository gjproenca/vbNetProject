<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="register-users.aspx.vb" Inherits="WebApplication.register" %>

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
                                <a class="nav-link active" href="./register-users.aspx">Register Users</a>
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
                        <div class="col-md-3">
                        </div>

                        <!-- Form -->
                        <div class="col-md-6">
                            <div class="p-5 card text-white bg-primary border-secondary">
                                <div class="card-body">
                                    <h1 class="mb-4 text-center text-white">Register Users</h1>

                                    <%-- Username --%>
                                    <div class="form-group">
                                        <label>Username</label>
                                        <asp:TextBox ID="textBoxUsername" runat="server" class="form-control" MaxLength="50"></asp:TextBox>
                                        <small class="form-text text-muted">Minimum 8 characters
                                        </small>
                                        <asp:RequiredFieldValidator ID="requiredFieldValidatorTextBoxUsername" runat="server" ErrorMessage="Required field"
                                            ControlToValidate="textBoxUsername"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regularExpressionValidatorTextBoxUsername" runat="server" ErrorMessage="Requirements not met"
                                            ControlToValidate="textBoxUsername" ValidationExpression="^\w{8,}$"></asp:RegularExpressionValidator>
                                    </div>

                                    <%-- Password --%>
                                    <div class="form-group">
                                        <label>Password</label>
                                        <asp:TextBox ID="textBoxPassword" runat="server" class="form-control" TextMode="Password" MaxLength="50"></asp:TextBox>
                                        <small class="form-text text-muted">Minimum 8 characters
                                        </small>
                                        <asp:RequiredFieldValidator ID="requiredFieldValidatorTexboxPassword" runat="server" ErrorMessage="Required field"
                                            ControlToValidate="textBoxPassword"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regularExpressionValidatorTexboxPassword" runat="server" ErrorMessage="Requirements not met"
                                            ControlToValidate="textBoxPassword" ValidationExpression="^[^\s].{6,}[^\s]$"></asp:RegularExpressionValidator>
                                    </div>

                                    <%-- Confirm Password --%>
                                    <div class="form-group">
                                        <label>Confirm Password</label>
                                        <asp:TextBox ID="textBoxConfirmPassword" runat="server" class="form-control" TextMode="Password" MaxLength="50"></asp:TextBox>
                                        <small class="form-text text-muted">Minimum 8 characters
                                        </small>
                                        <asp:RequiredFieldValidator ID="requiredFieldValidator1" runat="server" ErrorMessage="Required field"
                                            ControlToValidate="textBoxConfirmPassword"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="regularExpressionValidator1" runat="server" ErrorMessage="Requirements not met"
                                            ControlToValidate="textBoxConfirmPassword" ValidationExpression="^[^\s].{6,}[^\s]$"></asp:RegularExpressionValidator>
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password fields don't match" ControlToCompare="textBoxPassword" ControlToValidate="textBoxConfirmPassword"></asp:CompareValidator>
                                    </div>

                                    <%-- Admin --%>
                                    <div class="form-group text-center">
                                        <label>Administrator </label>
                                        &nbsp;<asp:CheckBox ID="checkBoxAdmin" runat="server" />
                                    </div>

                                    <asp:Button class="btn btn-dark text-white col-md-12" ID="buttonSubmit" runat="server" Text="Submit" CssClass="btn btn-dark text-white col-12" OnClick="buttonSubmit_Click" />
                                    <br />
                                    <br />
                                    <button class="btn btn-dark text-white col-md-12" name="reset" id="reset" type="reset">Reset</button>
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
