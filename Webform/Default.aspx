<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webform._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row text-center" style="width: 100%">
        <div style="width: 50%; float: none; margin: 0 auto">
            <div class="form-group">
                <img src="https://image.ibb.co/iKfYKx/computer.jpg" />
            </div>
            <div class="form-group">
                <div class="col-md-pull-10">
                    <input type="text" id="email" name="email" class="form-control" placeholder="Email" />
                </div>
                <div class="col-md-pull-10">
                    <input type="password" id="password" name="password" class="form-control" placeholder="PassWord" />
                </div>
            </div>
            <br />
            <button type="button" class="btn btn-danger" onclick="Login();">로그인</button>
        </div>
    </div>

    <script>
        function Login() {
            var url = "Login.aspx";
            var params = "";
            params = params + "email=" + $("#email").val();
            params = params + "&password=" + $("#password").val();

            $.ajax({
                type: "GET",
                url: url,
                data: params,
                contentType: "application/x-www-form-urlencoded; charset=utf-8",
                success: function (data) {
                    if (data == "OK") {
                        alert("로그인성공");
                    }
                    else {
                        alert("로그인실패");
                    }
                }
            });
        };
    </script>
</asp:Content>
