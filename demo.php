 <html>
<head>
	
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
	
</head>
	<body>
	

        <div class="container">

        	<div class="card card-body">

        		<?php 
        		if(isset($msg)){
        			
        			echo $msg;
        		}
        		?>
        		<form action="<?php echo site_url('Welcome/signup');?>" method="post">
        			<div class="md-form">
        				<input type="text" class="form-control" placeholder="username" name="username" required="required">
        			</div>
        			<div class="md-form">
        						<input type="text" class="form-control" placeholder="email" name="email">
        			</div>
        			<div class="md-form">
	                         <input type="text" class="form-control" placeholder="password" name="password">
        			</div>
        			<div class="md-form">
	                   <input type="text" class="form-control" placeholder="age" name="age">
        			</div>
        			<div class="md-form">
	                 <input type="text" class="form-control" placeholder="university" name="university">
        			</div>
        			<div class="md-form">
	                     <input type="text" class="form-control" placeholder="profession" name="profession">
        			</div>
        			<div class="text-center mt-5">
        				<input type="submit" name="register" class="btn btn-indigo">
        			</div>
        		</form>
        	</div>

        	<div class="card card-body">
        		<?php if(isset($msg)){?>
            <div class="alert alert-danger">
  <strong>Error:</strong> <?php  echo $msg;?> 
</div>
<?php }?>
        		<form action="<?php  echo site_url('Welcome/process');?>" method="post">

        			<div class="form-group row">
        				<label for="inputemail" class="col-sm-2 col-form-label">Email</label>
        				<div class="col-md-8">
        					 <input type="text" class="form-control  z-depth-0" id="inputemail" placeholder="Email" name="useremail" style="border-radius:0px;" required="required">
        				</div>
        			</div>

        			<div class="form-group row">

        				<label for="userpass" class="col-sm-2 col-form-label">Password</label>
        				<div class="col-md-8">
        					 <input type="password" class="form-control z-depth-0" id="userpass" placeholder="Password" name="userpassword" style="border-radius:0px; ">
        				</div>

        			</div>

        			<div class="text-center mt-5">
        				<input type="submit" name="login" class="btn btn-amber" value="Login">
        			</div>

        		</form>
        	</div>

        </div>


	</body>

</html>