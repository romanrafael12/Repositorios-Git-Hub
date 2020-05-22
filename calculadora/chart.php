<!doctype html>
<?php include ("heart.inc");?>
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
			<h2>Heart Rate Chart</h2>
			<table>
				<tr>
					<th>Age</th>
					<th>Range</th>
					<th>Max</th>
				</tr>
			<?php
				for($age=20;$age <= 80;$age=$age+5)
					{
			?>
				<tr>
					<td><?php print($age); ?></td>
					<td><?php
						$val1=CalcMinExRate($age);
						$val2=CalcMaxExRate($age);
						print("$val1 - $val2 bpm");
					?></td>
					<td><?php print(CalcMaxRate($age));?></td>
				</tr>
			<?php
					}
			?>
			</table>
		</section>
		
		<?php
			include ("footer.inc");
			
		?>


	</body>

</html>