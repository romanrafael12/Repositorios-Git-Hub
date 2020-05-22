<!doctype html>

<html>
	<head>
		<title>Planet Zellers</title>
		<link rel="stylesheet" type="text/css" href="main.css">
		<script>
			function ValidateForm(){
				bValid=true;
				strErrors="";
				
				if (document.getElementById("txtAge").value==""){
					bValid=false;
					strErrors="Missing Age;";
					
				}
				
				document.getElementById("errors").innerHTML=strErrors;
				return bValid;
		
			}
		</script>
	
	</head>
	
	<body>
		
		<?php
			
			include ("header.inc");
			include ("nav.inc");
		?>

		
		<section>
			<h1>Planet Zellers</h1>
			<h2>Heart Rate Calculator - take pulse for 6 seconds</h2>
			<form 
					action="checkrange.php" 
					method="get"
					onsubmit="return ValidateForm();"
			>
				Age: <input type="text" name="txtAge" id="txtAge">
				Beats per 6 seconds: <input type="text" name="txtBeats" id="txtBeats">
				<input  type="submit" value="Calculate" name="btnSubmit">
				<span id="errors"></span>
			
			</form>
		</section>
		
		<?php
			include ("footer.inc");
			
		?>


	</body>

</html>