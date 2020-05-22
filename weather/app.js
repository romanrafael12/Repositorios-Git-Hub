var input = document.querySelector('.input_text');
var main = document.querySelector('#name');
var temp = document.querySelector('.temp');
var desc = document.querySelector('.desc');
var clouds = document.querySelector('.clouds');
var button= document.querySelector('.submit');


button.addEventListener('click', function(name){
//api.openweathermap.org/data/2.5/weather?q=&appid=799c979e3c61dff569e6cb6e306656fe')
fetch('https://api.openweathermap.org/data/2.5/weather?id= 2172797'+input.value+'{city id}&appid= a6f2046cbd2637b630560a2ddbca0848')

.then(response => response.json())
.then(data => {
  var tempValue = data['main']['temp'];
  var nameValue = data['name'];
  var descValue = data['weather'][0]['description'];

  main.innerHTML = nameValue;
  desc.innerHTML = "Desc - "+descValue;
  temp.innerHTML = "Temp - "+tempValue;
  input.value ="";

})

.catch(err => alert("Wrong city name!"));
})
