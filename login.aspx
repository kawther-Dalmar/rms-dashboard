<%@ Page Language="VB" AutoEventWireup="false" CodeFile="login.aspx.vb" Inherits="login" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Validated Login Form</title>
	<%--<link rel="stylesheet" href="style.css">--%>
  
    <style>
        *{
	padding: 0;
	margin: 0;
}
body{
	background: #c1efde;
	background-size: cover;
	align-items: center;
	justify-content: center;
	display: flex;
	font-family: sans-serif;
}
.container{
	position: relative;
	margin-top: 100px;
	width: 450px;
	height: auto;
	background: #dedede;
	border-radius: 5px;
    box-shadow:0 2px 4px rgba(0,0,0,.3);
}
.label{
	padding: 20px 130px;
	font-size: 35px;
	font-weight: bold;
	color: #130f40;
}

.login_form{
	padding: 20px 40px;
}
.login_form .font{
	font-size: 18px;
	color: #130f40;
	margin: 5px 0;
}
.login_form #txtusername, #txtpassword{
	height: 40px;
	width: 350px;
	padding: 0 5px;
	font-size: 18px;
	outline: none;
	border: 1px solid silver;
}
.login_form .font2{
	margin-top: 30px;
}
.login_form #btnSubmit{
	margin: 45px 0 30px 0;
	height: 45px;
	width: 365px;
	font-size: 20px;
	color: white;
	outline: none;
	cursor: pointer;
	font-weight: bold;
	background: #151c6a;
	border-radius: 3px;
	border: 1px solid #3949AB;
	transition: .5s;
}
.login_form #btnSubmit:hover{
	background: #130f40;
}
.login_form #user_error,
.login_form #pass_error{
	margin-top: 5px;
	width: 345px;
	font-size: 18px;
	color: #C62828;
	background: rgba(255,0,0,0.1);
	text-align: center;
	padding: 5px 8px;
	border-radius: 3px;
	border: 1px solid #EF9A9A;
	display: none;
}

    </style>
</head>
<body>
    	<div class="container">
            
		<h1 class="label">User Login</h1>
            
		<form class="login_form" action="#" runat="server" name="form" onsubmit="return validated()">
            
			<div class="font">User Name</div>
            <div class="form-group row">
                     <asp:Label for="fname" ID="lblMessage" runat="server" Text=""  visibile="false"></asp:Label>

             </div>
            <asp:TextBox ID="txtusername" autocomplete="off" runat="server" type="text" placeholder="User Name..."></asp:TextBox>
			<%--<input autocomplete="off" type="text" name="email">--%>
			<div id="user_error">Please fill up your user  Name</div>
			<div class="font font2">Password</div>
            <asp:TextBox ID="txtpassword" type="password" placeholder="Password..." runat="server"></asp:TextBox>
			<%--<input type="password" name="password">--%>
			<div id="pass_error">Please fill up your Password</div>
            <asp:Button ID="btnSubmit" type="submit" runat="server" Text="Login" />
			<%--<button type="submit">Login</button>--%>
		</form>
	</div>	
	<script>
        //Validtion Code For Inputs

        var txtusername = document.forms['form']['txtusername'];
        var txtpassword = document.forms['form']['txtpassword'];

        var user_error = document.getElementById('#user_error');
        var pass_error = document.getElementById('#pass_error');

        txtusername.addEventListener('txtusername', user_Verify);
        txtpassword.addEventListener('txtpassword', pass_Verify);

        function validated() {
            if (txtusername.value.length < 9) {
                txtusername.style.border = "1px solid red";
                user_error.style.display = "block";
                txtusername.focus();
                return false;
            }
            if (txtpassword.value.length < 6) {
                txtpassword.style.border = "1px solid red";
                pass_error.style.display = "block";
                txtpassword.focus();
                return false;
            }

        }
        function email_Verify() {
            if (txtusername.value.length >= 8) {
                txtusername.style.border = "1px solid silver";
                user_error.style.display = "none";
                return true;
            }
        }
        function pass_Verify() {
            if (txtusername.value.length >= 5) {
                txtusername.style.border = "1px solid silver";
                pass_error.style.display = "none";
                return true;
            }
        }


	</script>

</body>
</html>
