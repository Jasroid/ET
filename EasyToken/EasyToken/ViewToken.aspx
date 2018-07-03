<%@ Page Title="" Language="C#" MasterPageFile="~/ETMaster.Master" AutoEventWireup="true" CodeBehind="ViewToken.aspx.cs" Inherits="EasyToken.ViewToken" %>
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
    
		 <!--/content-inner-->
	<div class="left-content">
	   <div class="inner-content">
		<!-- header-starts -->
			
				<!--content-->
			<div class="content">
<div class="women_main">
	<!-- start content -->
			<div class="row single">
				<div class="det">
				  <div class="single_left">
					<div class="grid images_3_of_2">
						<div class="flexslider">
							        <!-- FlexSlider -->
										<script src="CSS/Dashboard/js/imagezoom.js"></script>
										  <script defer="" src="CSS/Dashboard/js/jquery.flexslider.js"></script>
										<link rel="stylesheet" href="CSS/Dashboard/css/flexslider.css" type="text/css" media="screen">

										<script>
										// Can also be used with $(document).ready()
										$(window).load(function() {
										  $('.flexslider').flexslider({
											animation: "slide",
											controlNav: "thumbnails"
										  });
										});
										</script>
									<!-- //FlexSlider-->

							  
							
								   <div class="thumb-image"> 
                                       <asp:Image ID="imgpic"  class="img-responsive" draggable="false" runat="server" />
                                    
								   </div>
								
							
								
							  </ul><ul class="flex-direction-nav"><li class="flex-nav-prev"><a class="flex-prev" href="#">Previous</a></li><li class="flex-nav-next"><a class="flex-next" href="#">Next</a></li></ul></div>
				  </div>
				  <div class="desc1 span_3_of_2">
					<h3>
                        <asp:Label ID="lblname" runat="server" Text="Customer Name"></asp:Label></h3>
					<span class="brand">Next Appointment: 
                        <asp:Label ID="lblappointment" runat="server" Text="Appointment"></asp:Label><a href="#">  </a></span>
					<br/>
				
						<div class="price">
							<span class="text">Medication:</span>
							<span class="price-new">
                        <asp:Label ID="lblmedication" runat="server" Text="Medication"></asp:Label> </span>
						
						</div>
				
					<div class="btn_form">
						<a href="checkout.html">Message</a>
					</div>
				<p>	<u>Doctors Notes</u></p>
					
			   	 </div>
          	    <div class="clearfix"></div>
          	   </div>
          	    <div class="single-bottom1">
				
                      
                        <asp:Label ID="lbldocnotes" runat="server" Text="Notes"></asp:Label> 
                      
                      	</div>
				
	       </div>		
	  </div>
	<!-- end content -->
	
<div class="footer">
				
					<div class="clearfix"> </div>
						<p>© 2016 Gretong. All Rights Reserved | Design by <a href="http://w3layouts.com/">W3layouts</a></p>
			</div>
</div>

</div>
			<!--content-->
		</div>
</div>
			<!--content-->
</asp:Content>
