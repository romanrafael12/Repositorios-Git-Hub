<!doctype html>
<?php
			
			include ("heart.inc");
			include ("checkrange.inc");
?>
<html>
	<head>
		<title>Planet Zellers</title>
		<link rel="stylesheet" type="text/css" href="main.css">
	</head>
	
	<body>
		
		<?php
			
			include ("header.inc");
			include ("nav.inc");
		?>

		
		<section>
			<h1>Planet Zellers</h1>
			<h2>Heart Rate Calculator - take pulse for 6 seconds</h2>


			
			<?php
				$valid=ValidateForm();
				
				if ($valid){
					DisplayOutput();
				}
			
			
			?>
			
		</section>
		
		<?php
			include ("footer.inc");
			
		?>


	</body>

</html>