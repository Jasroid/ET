<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EasyToken.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
<script>
		addEventListener("load", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
	</script>
	<!-- //Meta tag Keywords -->

	<!-- Custom-Files -->
	<link rel="stylesheet" href="CSS/Home/css/bootstrap.css"/>
	<!-- Bootstrap-Core-CSS -->
	<link rel="stylesheet" href="CSS/Home/css/owl.carousel.min.css" type="text/css" media="all" />
	<link rel="stylesheet" href="CSS/Home/css/owl.theme.default.min.css" type="text/css" media="all" />
	<!-- Owl-Carousel-CSS -->
	<link rel="stylesheet" href="CSS/Home/css/style.css" type="text/css" media="all" />
	<!-- Style-CSS -->
	<link rel="stylesheet" href="CSS/Home/css/fontawesome-all.css"/>
	<!-- Font-Awesome-Icons-CSS -->
	<!-- //Custom-Files -->

	<!-- Web-Fonts -->
	<link href="//fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i&amp;subset=latin-ext"
	    rel="stylesheet">
	<link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet">
	<!-- //Web-Fonts -->

</head>
<body>
    <form id="form1" runat="server">
    
	<!-- //header -->

	<!-- welcome -->
	<div class="about py-sm-5 py-4">
		<div class="container">
			<div class="row py-xl-5 py-lg-3">
				<div class="col-lg-7 about-left">
					<h5>We are best in this industry from last 30 Years.</h5>
					<p class="mt-md-3 mt-2 mb-lg-5 mb-4">Masagni dolores eoquie int Basmodi temporant, ut laboreas dolore magnam aliquam kuytase uaeraquis autem vel eum iure
						reprehend.Unicmquam eius, Basmodi temurer sehsMunim.Sed ut perspiciatis unde omnis iste natus error sit voluptatem
						accusantium doloremque laudantium.</p>
					<h6 class="mb-lg-4 mb-3">Our Benefits</h6>
					<ul>
						<li class="mb-2">
							<i class="fas fa-check mr-3"></i>Best Tracking system on every step</li>
						<li class="mb-2">
							<i class="fas fa-check mr-3"></i>Free Insurance for your goods</li>
						<li class="mb-2">
							<i class="fas fa-check mr-3"></i>100% Safe and Secure Transport</li>
						<li class="mb-2">
							<i class="fas fa-check mr-3"></i>Best Tracking system on every step</li>
						<li class="mb-2">
							<i class="fas fa-check mr-3"></i>Free Insurance for your goods</li>
					</ul>
				</div>
				<div class="col-lg-5">
					<div class="about-right px-lg-4 py-lg-3 p-4">
						<form action="#" method="post">
							<div class="form-group">
								<label class="col-form-label">I Need</label>
								<select class="category form-control" required="">
									<option value="">Choose Value</option>
									<option value="">Packaging and storage</option>
									<option value="">Worldwide transport</option>
									<option value="">Cargo</option>
									<option value="">Warehousing</option>
									<option value="">Door to door delivery</option>
								</select>
							</div>
							<div class="form-group">
								<label class="col-form-label">Commodity</label>
								<select class="category form-control" required="">
									<option value="">Choose Value</option>
									<option value="">We can package and store your things.</option>
									<option value="">Let us transport your things from point A to point B fast and securely. </option>
									<option value="">We can transport your things anywhere in the world. </option>
									<option value="">We have top notch security and loads of space</option>
									<option value="">Do you need something delivered? </option>
								</select>
							</div>
							<div class="form-group">
								<label class="col-form-label">Distance (km)</label>
								<input type="text" class="form-control" placeholder=" " name="distance" required="">
							</div>
							<div class="form-group">
								<label class="col-form-label">E-mail</label>
								<input type="email" class="form-control" placeholder=" " name="email" required="">
							</div>
							<div class="form-group">
								<label class="col-form-label">Phone Number</label>
								<input type="text" class="form-control" placeholder=" " name="number" required="">
							</div>
							<div class="right-w3l">
								<input type="submit" class="form-control" value="Submit">
							</div>
						</form>
					</div>
				</div>
			</div>
		</div>
	</div>
        
    </form>
</body>
</html>
