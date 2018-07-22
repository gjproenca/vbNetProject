<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="WebApplication._default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <%--My CSS--%>
    <%--<link href="content/font-awesome.min.css" rel="stylesheet" />--%>

    <title>VBNet Avaliação</title>
</head>
<body>
    <form id="body" runat="server">
        <div>

            <div class="py-5">
                <div class="container">
                    <div class="row">
                        <div class="col-md-3">
                        </div>

                        <!-- Form -->
                        <div class="col-md-6">
                            <div class="p-5 card text-white bg-primary border-secondary">
                                <div class="card-body">
                                    <h1 class="mb-4 text-center text-white">Sign In</h1>

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

                                    <asp:Button ID="buttonSubmit" runat="server" Text="Submit" class="btn btn-dark text-white col-12" />
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
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>