<!DOCTYPE html>
<html>
<head>
	<title></title>


	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css">
    <!-- Bootstrap core CSS -->
    <link href="<?php echo base_url();?>asset/css/bootstrap.min.css" rel="stylesheet">
    <link href="<?php echo base_url();?>asset/css/mdb.min.css" rel="stylesheet">
     <link href="<?php echo base_url();?>asset/css/style.css" rel="stylesheet">
    <script type="text/javascript" src="<?php echo base_url();?>asset/js/jquery-3.3.1.min.js"></script>
    <!-- Bootstrap tooltips -->
    <script type="text/javascript" src="<?php echo base_url();?>asset/js/popper.min.js"></script>
    <!-- Bootstrap core JavaScript -->
    <script type="text/javascript" src="<?php echo base_url();?>asset/js/bootstrap.min.js"></script>
    <!-- MDB core JavaScript -->
    <script type="text/javascript" src="<?php echo base_url();?>asset/js/mdb.js"></script>

    <link rel="icon" type="image/png" href="asset/image.png" sizes="32x32">


<style type="text/css">



.footer
{
	
	color: white;
	position: fixed;
	left: 0;
	bottom: 0;
	width: 100%;
	
	
}



html,
body,
header,
.jarallax {
  height: 100%;
}

@media (max-width: 740px) {
  html,
  body,
  header,
  .jarallax {
    height: 100vh;
  }
}

.top-nav-collapse {
  background-color: #82b1ff !important;
}

.navbar:not(.top-nav-collapse) {
  background: transparent !important;
}

@media (max-width: 991px) {
  .navbar:not(.top-nav-collapse) {
    background: #82b1ff !important;
  }
}

h5 {
  letter-spacing: 3px;
}




</style>




</head>
<body>

<header>
  <!--Navbar-->
  <nav class="navbar navbar-expand-lg navbar-dark fixed-top scrolling-navbar">
    <div class="container-fluid" style="margin: 5px 15px 5px 15% ">
      <a class="navbar-brand white-text" style="font-weight: bold;font-size: 30px;">
        <strong>Friendspace</strong>
      </a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent-7"
        aria-controls="navbarSupportedContent-7" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarSupportedContent-7">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item">
            <a class="nav-link white-text" href="#" style="font-weight: bold;">Policy and Terms</a>
          </li>
          <li class="nav-item">
            <a class="nav-link white-text" href="#" style="font-weight: bold;">Faq</a>
          </li>
          <li class="nav-item">
                <a class="nav-link white-text" href="#" style="font-weight: bold;">About</a>
          </li>
          <li class="nav-item">
            <a class="nav-link white-text" href="#" style="font-weight: bold;">Forgot passsord</a>
          </li>
          
        </ul>
      
<form method="post" action="<?php echo site_url('Welcome/loginprocess');?>" class="form-inline my-2 my-lg-0 ml-auto" style="margin: 5px 15px 5px 15% ">
  
<input type="email" name="" class="form-control mr-lg-2" style="border-radius: 0px;" placeholder="user email" required="required">
<input type="password" name="" class="form-control mr-lg-2"  style="border-radius: 0px;" placeholder="user password" required="required">
<input type="submit" name="Login" value="Login" class="btn btn-outline-white white-text form-control text-center">

</form>



      </div>
    </div>
  </nav>
  <!-- Navbar -->
  <!-- Full Page Intro -->
  <div class="view jarallax"  style="background-image: url('asset/newback.png'); background-repeat: no-repeat; background-size: cover; background-position: center center;">
    <!-- Mask & flexbox options-->
    <div class="mask rgba-black-strong d-flex ">
      <!-- Content -->
      <div class="container" style="margin-top: 10%;">

      <div class="row">

<div class="col-lg-6">
</div>

<div class="col-lg-5">

<form method="post" action="<?php echo  site_url('Welcome/signprocess');?>">
  <h2 class="h1-responsive font-weight-bold white-text" style="font-weight: bold;text-align: left;">Create an account</h2>

  <div class="form-row">
    <div class="col-lg-6">

         <input type="text" name="" placeholder="Full name" class="form-control">

    </div>
    <div class="col-lg-6">
        <input type="number" name="" placeholder="Age" class="form-control">
    </div>
  </div><br>

  <input type="email"    placeholder="useremail"        class="form-control"><br>
  <input type="password" placeholder="userpassword" class="form-control"><br>
  <input type="password" placeholder="confirm-password" class="form-control"><br>

    <h5 class="h5-responsive font-weight-bold white-text" style="font-weight: bold;text-align: left;">Birthday</h2>
      <div class="form-row">
        <div class="col-md-4">

<input type="number" class="form-control">
        </div>
        <div class="col-md-4">

<input type="text" name="" class="form-control">
        </div>

        <div class="col-md-4">
<input type="number" name="" class="form-control">

        </div>
      </div>

</form>


</div>

      </div>

      </div>
      <!-- Content -->
    </div>
    <!-- Mask & flexbox options-->
  </div>
  <!-- Full Page Intro -->
</header>



<div class="footer">
 <div class="footer-copyright text-center py-3">© 2018 Copyright:
    <a href="https://mdbootstrap.com/education/bootstrap/" class="black-text " style="font-weight: bold;"> developed by nerd</a>
  </div>
</div>






</body>
</html>