<%@ Page Title="" Language="C#" MasterPageFile="~/ETMaster.Master" AutoEventWireup="true" CodeBehind="ViewSentMessege.aspx.cs" Inherits="EasyToken.ViewSentMessege" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>

    
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<link href="CSS/M/New/css/bootstrap.min.css" rel='stylesheet' type='text/css' />
<!--<link href="css/bootstrap.css" rel='stylesheet' type='text/css' />-->
<!-- Custom Theme files -->
<link href="CSS/M/New/css/style.css" rel='stylesheet' type='text/css' />
<link href="CSS/M/New/css/font-awesome.css" rel="stylesheet"/> 
<script src="CSS/M/New/js/jquery.min.js"> </script>
<script src="CSS/M/New/js/bootstrap.min.js"> </script>
  <script src="CSS/M/Home/js/bootstrap.js"></script>
<!-- Mainly scripts -->
<script src="CSS/M/js/jquery.metisMenu.js"></script>
<script src="CSS/M/js/jquery.slimscroll.min.js"></script>
<!-- Custom and plugin javascript -->
<link href="CSS/M/New/css/custom.css" rel="stylesheet"/>
<script src="CSS/M/New/js/custom.js"></script>
<script src="CSS/M/New/js/screenfull.js"></script>
		<script>
		$(function () {
			$('#supported').text('Supported/allowed: ' + !!screenfull.enabled);

			if (!screenfull.enabled) {
				return false;
			}

			

			$('#toggle').click(function () {
				screenfull.toggle($('#container')[0]);
			});
			

			
		});
		</script>   
       <style>
        #square {
        width:30%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
 	<!--banner-->	
		     <div class="banner">
		    	<h2>
			
				<i class="fa fa-angle-right"></i>
				<span> Messeges</span>
                 
				</h2>
		    </div>
		<!--//banner-->
        <div class="typo-grid">
 	  
        <div class="typo-1">
  <div class="grid_3 grid_4">
      	<div class="com-mail">
              <div id="square">
               <div class="alert alert-info" role="alert">
    <asp:Label ID="lblMessege" runat="server" Text="Label"></asp:Label>  
          </div></div></div>
  </div></div></div></div></div>
</asp:Content>
