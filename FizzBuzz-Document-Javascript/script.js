//Ask user for values
var numbers;
while (Number.isInteger(Number(numbers)) === false || numbers < 1) {
  numbers = prompt("Iterate through how many numbers?", 100);
}
var fizzCondition;
while (Number.isInteger(Number(fizzCondition)) === false || fizzCondition < 1) {
  fizzCondition = prompt("Fizz for numbers divisible by what integer value?", 3);
}
var buzzCondition;
while (Number.isInteger(Number(buzzCondition)) === false || buzzCondition < 1) {
  buzzCondition = prompt("Buzz for numbers divisible by what integer value?", 5);
}
var fizzbuzzCondition;
while (Number.isInteger(Number(fizzbuzzCondition)) === false || fizzbuzzCondition < 1) {
  fizzbuzzCondition = prompt("FizzBuzz for numbers divisible by what integer value?", (fizzCondition * buzzCondition));
}

//Update titles
document.getElementById("fizzTitle").innerHTML = "Fizz Values (Divisible by "+fizzCondition+"):";
document.getElementById("buzzTitle").innerHTML = "Buzz Values (Divisible by "+buzzCondition+"):";
document.getElementById("fizzbuzzTitle").innerHTML = "FizzBuzz Values (Divisible by "+fizzbuzzCondition+"):";

//Iterate through values and update document with results
for (i = 1; i <= numbers; i++) {
  if (i % fizzbuzzCondition === 0) {
    document.getElementById("fizzbuzzValues").innerHTML += i+"\n";
  }
  else if (i % fizzCondition === 0) {
    document.getElementById("fizzValues").innerHTML += i+"\n";
  }
  else if (i % buzzCondition === 0) {
    document.getElementById("buzzValues").innerHTML += i+"\n";
  }
}
