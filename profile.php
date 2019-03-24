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
	    <script type="text/javascript" src="<?php echo base_url();?>asset/js/browseunable.js"></script>
</head>
<body>

<div class="container">
	<form action="" method="post" enctype="multipart/form-data">

		<div class="form-group row">
			<label class="col-sm-2 col-form-label"  for="inputfile">Userimage</label>
			<div class="col-md-8">
				<input type="file" name="imgfile" id="inputfile" class="form-control">
			</div>
		</div>


		<div class="form-group row">
			<label class="col-sm-2 col-form-label"  for="inputsname">screen name</label>
			<div class="col-md-8">
				<input type="text" name="sname" class="form-control" id="inputsname">
			</div>
		</div>

		<div class="form-group row">

				<label class="col-sm-2 col-form-label"  for="inputage">age</label>
			<div class="col-md-8">
				<input type="text" name="age" class="form-control" id="inputage">
			</div>

		</div>

		<div class="form-group row">

			<label class="col-sm-2 col-form-label"  for="inputbio">my bio</label>
			<div class="col-md-8">
				<input type="text" name="bio" class="form-control" id="inputbio">
			</div>

		</div>



	</form>
</div>

</body>
</html>