<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Webform2.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-2 col-md-offset-5">
            <h2 style="text-align: center;">회원가입</h2>
            <hr />
            <div class="text-danger"></div>
            <div class="form-group">
                <label>이메일</label>
                <input type="text" class="form-control" id="email" name="email" />
            </div>
            <div class="form-group">
                <label>이름</label>
                <input class="form-control" id="name" name="name">
            </div>
            <div class="form-group">
                <label>성별</label>
                <input class="form-control" id="gender" name="gender">
            </div>
            <div class="form-group">
                <label>비밀번호</label>
                <input class="form-control" id="password" name="password">
            </div>
            <div class="form-group">
                <label>비밀번호 재입력</label>
                <input class="form-control" id="passcheck" name="passcheck">
            </div>
            <div class="form-group">
                <button type="button" class="btn btn-info" onclick="signup();">등록</button>
            </div>
        </div>
    </div>
    <script>
        function signup() {
            var email = $("#email").val();
            var name = $("#name").val();
            var gender = $("#gender").val();
            var password = $("#password").val();
            var passcheck = $("#passcheck").val();
            if (!email && !name && !gender && !password && !passcheck) {
                alert("입력하지 않은 값이 있습니다.");
                return false;
            }
            else if (password != passcheck) {
                alert("비밀번호와 비밀번호확인을 정확히 입력해주세요.");
                return false;
            }
            else {
                $("#Frm").submit();
            }
        }
    </script>
</asp:Content>
