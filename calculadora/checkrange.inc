			<?php
			function DisplayOutput(){
				$age=$_REQUEST["txtAge"];
				$beats=$_REQUEST["txtBeats"];
				$result=InRange($age,$beats, 6);
				if ($result==-1){
			?>	
					<p>You are below optimal exercise heart range</p>
			<?php	
				}
				if ($result==0){
			?>	
					<p>You are in optimal exercise heart range</p>
			<?php	
				}if ($result==1){
			?>	
					<p>You are above optimal exercise heart range</p>
			<?php	
				}
			}
			
			function ValidateForm(){
				$valid=true;
				$age=$_REQUEST["txtAge"];
				$beats=$_REQUEST["txtBeats"];
				if (!isset($age)){
					$valid=false;
					print ("<p>No valule for age</p>");
					
				}
				if (!isset($beats)){
					$valid=false;
					print ("<p>No valule for beats");
					
				}
				if (!is_numeric($age)){
					$valid=false;
					print ("<p>age not a number</p>");
					
				}
				if (!is_numeric($beats)){
					$valid=false;
					print ("<p>beats not a number</p>");
					
				}
				
				return $valid;
			}
			?>