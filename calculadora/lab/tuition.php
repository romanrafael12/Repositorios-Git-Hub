<?php 

			
	function creditvalor(){
		$min= 144.04;
		
		for ($Credits = 1; $Credits <=18;$Credits= $Credits+1)
			{
				
			echo '<tr>';
			echo "<td> $Credits </td>";
			echo "<td> $ ";
			
			 if ($Credits <= 12 ){

				if($Credits==5 || $Credits==10){
				echo  $min .'0' ;
				}else{
				echo $min;	
				}

				$min = $min +  144.04;
			
			}else {
				echo $min;	
			}


			echo "</td>";
			echo '</tr>';
			
		}
	}