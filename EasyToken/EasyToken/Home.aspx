<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EasyToken.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="CSS/Home/css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
<script src="CSS/Home/js/jquery.min.js"></script>
<!-- Custom Theme files -->
<!--theme-style-->
<link href="CSS/Home/css/style.css" rel="stylesheet" type="text/css" media="all" />	
<!--//theme-style-->
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Fashion Store Responsive web template, Bootstrap Web Templates, Flat Web Templates, Andriod Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyErricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!--fonts-->
<link href='http://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700,900' rel='stylesheet' type='text/css'>
<!--//fonts-->
<script type="CSS/Home/text/javascript" src="js/move-top.js"></script>
<script type="CSS/Home/text/javascript" src="js/easing.js"></script>
<script type="CSS/Home/text/javascript">
					jQuery(document).ready(function($) {
						$(".scroll").click(function(event){		
							event.preventDefault();
							$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
						});
					});
					</script>
					<!----start-top-nav-script---->
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
<!--header-->
	<div class="header" id="home">
			<div class="container">
				<div class="header-top">
					<div class="logo">
			
					</div>
					<div class="top-nav">
					<span class="menu"> </span>
						<ul>
							<li class="active" ><a href="index.html" class="scroll">HOME</a></li>
							<li><a href="Login.aspx" class="scroll"> LOGIN</a></li>
							<li><a href="Register.aspx" class="scroll">CREATE ACCOUNT </a></li>
						</ul>
						<script>
						$("span.menu").click(function(){
							$(".top-nav ul").slideToggle(500, function(){
							});
						});
				</script>
					</div>
				<div class="clearfix"> </div>
			</div>
			
			<div class="clearfix"> </div>
		</div>
	</div>
	<!---->
	<div class="banner">
			<div class="banner-matter">
				<h2>EasyToken: Token Management Made Easy</h2>
				<a href="Login.aspx" class="down">START</a>								
			</div>
			
	</div>
	<!--content-->
	
	<div class="footer">
		
			<p class="footer-grid">Easy Token | 2018 </p>
			 
		 </div>
		 <script type="CSS/Home/text/javascript">
						$(document).ready(function() {
							/*
							var defaults = {
					  			containerID: 'toTop', // fading element id
								containerHoverID: 'toTopHover', // fading element hover id
								scrollSpeed: 1200,
								easingType: 'linear' 
					 		};
							*/
							
							$().UItoTop({ easingType: 'easeOutQuart' });
							
						});
					</script>			
	 

    </form>
</body>
</html>
