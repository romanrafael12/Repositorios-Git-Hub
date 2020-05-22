<?php

$nombre = $_GET['nombre'];
$edad   = $_GET['edad'];

$edad = $edad * 144.04 ; 



$edad=round($edad,2);

$myObj = array("name" => $nombre, "age" => $edad);

$myJSON = json_encode($myObj);

echo $myJSON;




