<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeBehind="CompanySignUp.aspx.cs" Inherits="EasyToken.CompanySignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
         <link rel="stylesheet" href="CSS/Register/css/jquery-ui.css" />
	<link href="CSS/Register/css/style.css" rel='stylesheet' type='text/css' />
	<!-- //Stylesheet -->
	<!--fonts-->
	<link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:200,300,400,600" rel="stylesheet"/>
	<!--//fonts-->
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <h1> Registration</h1>
	<div class="register-form-w3layouts">
		<!-- Form starts here -->
		<form action="#" method="post"> 
			<h3 class="sub-heading-agileits">Patient Registration</h3>
			<div class="main-flex-w3ls-sectns">
				<div class="field-agileinfo-spc form-w3-agile-text1">
                    
                <asp:TextBox ID="txtName" placeholder="Full Name" runat="server"></asp:TextBox>	
				</div>
				<div class="field-agileinfo-spc form-w3-agile-text2">
                    
                <asp:TextBox ID="txtusername" placeholder="Username" runat="server"></asp:TextBox>	
				</div>
			</div>
			<div class="main-flex-w3ls-sectns">
				<div class="field-agileinfo-spc form-w3-agile-text1">
                <asp:TextBox ID="txtemail" placeholder="Email" runat="server"></asp:TextBox>	
				</div>
				<div class="field-agileinfo-spc form-w3-agile-text2">
                    
                <asp:TextBox ID="txtpassword" TextMode="Password" placeholder="Password" runat="server"></asp:TextBox>	
				</div>
                <div class="field-agileinfo-spc form-w3-agile-text2">
                    
                <asp:TextBox ID="txtConfirm" TextMode="Password" placeholder="Confirm Password" runat="server"></asp:TextBox>	
				</div>
                 
			</div>
            	<div class="main-flex-w3ls-sectns">
                    
                	<div class="field-agileinfo-spc form-w3-agile-text1">
                <asp:TextBox ID="txtaddress" placeholder="Address" runat="server"></asp:TextBox>	
				</div>
				<div class="field-agileinfo-spc form-w3-agile-text2">
                    
                <asp:TextBox ID="txttelephone" placeholder="Telephone" runat="server"></asp:TextBox>	
				</div>
                </div>

  <br/>
                <div class="clear"></div>
                <asp:Button ID="btnregister" class="sub-heading-agileits" Text="Create Account" runat="server" OnClick="btnregister_Click"></asp:Button>
                   <br/>   <asp:Label ID="lblexists" runat="server" ForeColor="Red" Text="Username already exists" Visible="False"></asp:Label>
                   <asp:Label ID="lblmatch" runat="server" ForeColor="Red" Text="Passwords do not match" Visible="False"></asp:Label>
                                            <asp:Label ID="lblerror" runat="server" ForeColor="Red" Text="Please fill in all the fields" Visible="False"></asp:Label>
                        <div class="clear"></div>
		<br/>
	
			<div font-color="white">OR Click <a href="CompanySignUp.aspx">here </a> to Register as a Hospital/Company</div>
		</form>
		<!--// Form starts here -->
	</div>
	<!--copyright-->
	<div class="copyright">
		<p>&copy;Easy Token | 2018
		</p>
	</div>
	<!--//copyright-->
	<script type="text/javascript" src="CSS/Registerjs/jquery-2.2.3.min.js"></script>
	<!-- Calendar Js -->
	<script src="CSS/Register/js/jquery-ui.js"></script>

    </form>
</body>
</html>
