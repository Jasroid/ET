<%@ Page Title="" Language="C#" MasterPageFile="~/ETMaster.Master" AutoEventWireup="true" CodeBehind="SentMesseges.aspx.cs" Inherits="EasyToken.SentMesseges" %>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 	<!--banner-->	
		     <div class="banner">
		    	<h2>
			<a href="Messeges.aspx">Messeges</a>
				<i class="fa fa-angle-right"></i>
				<span>Sent Messeges</span>
                 
				</h2>
		    </div>
		<!--//banner-->
             <div class="typo-grid">
 	  
        <div class="typo-1">
  <div class="grid_3 grid_4">
           	 <div class="profile">
             <div class="typo-grid">

        <div class="typo-1">
      <div class="inbox-mail">
	<div class="col-md-4 compose">
	  <h2><a href="NewMessege.aspx"> <asp:Label ID="lblcompose" ForeColor="White" runat="server" Text="New Messege"></asp:Label></a></h2>
    <nav class="nav-sidebar">
		<ul class="nav tabs">
          <li class="active"><asp:LinkButton ID="btninbox" runat="server" ForeColor="Gray" OnClick="btninbox_Click"><i class="fa fa-inbox"></i>Inbox<asp:Label ID="lblinboxnum" runat="server" Text="0"></asp:Label></asp:LinkButton></li>
          <li class=""><asp:LinkButton ID="btnsent" runat="server" ForeColor="Gray" OnClick="btnsent_Click"><i class="fa fa-paper-plane-o"></i>Sent<asp:Label ID="lblsentnum" runat="server" Text="0"></asp:Label></asp:LinkButton></li>
                                     
		</ul>
	</nav>
		
</div>


          <div class="col-md-8 tab-content tab-content-in">
<div class="tab-pane active text-style" id="tab1">
  <div class="inbox-right">
               
<asp:Label ID="lblmessagelist" runat="server" Text=""></asp:Label>
         <div class="mailbox-content">
    

   </div></div></div></div>
          </div>
            </div></div></div></div></div></div>

</asp:Content>
