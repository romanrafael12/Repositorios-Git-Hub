<?php
	function CalcMaxRate($argAge){
		$max=220-$argAge;
		
		return $max;

	}

	function CalcMinExRate($argAge){
		$max=CalcMaxRate($argAge);
		$ans=.5*$max;
		
		return $ans;

	}
	
	function CalcMaxExRate($argAge){
		$max=CalcMaxRate($argAge);
		$ans=.8*$max;
		
		return $ans;

	}
	
	function InRange($argAge,$argBeats,$argSeconds){
		//this function accepts these arguments
		//$argAge - age of person
		//$argBeats - how many pulse beats were counted
		//$argSeconds - how many seconds took pulse for
		//return values: -1 = below range, 0=in range, 1=above range
		
		$bpm=$argBeats * 60 / $argSeconds;
		$max=CalcMaxExRate($argAge);
		$min=CalcMinExRate($argAge);
		
		if ($bpm < $min){
			$ans=-1;
		}
		
		if ($bpm > $max){
			$ans=1;
		}
		
		if ($bpm >= $min && $bpm<=$max){
			$ans=0;
		}
		
		return $ans;

	}
	
?>