// Ask user for maximum value
let max;
while (Number.isInteger(Number(max)) === false || max < 2) {
  max = prompt("Maximum number to test? (>= 2)", 100);
}

// Update maximum number field
document.getElementById("maxValue").innerHTML += max;

// Initial variables
let allNumbers = [];
let primes = [];
let squareRootLimit = Math.sqrt(max) - 2; // Outer loop can end at square root of maximum number

// Populate array of all numbers
for (let i = 2; i <= max; i++) {
  allNumbers.push(i);
}
    
// Algorithm to determine if prime, set to 0 if not    
for (let i = 0; i <= squareRootLimit; i++) {
  let outerNumber = allNumbers[i]
  if (outerNumber > 0) {
    for (let innerNumber = (outerNumber*outerNumber - 2); innerNumber < allNumbers.length; innerNumber += outerNumber) {
      allNumbers[innerNumber] = 0;
    }
  }
}

// Populate primes array
for (let i = 0; i < allNumbers.length; i++) {
  let outerNumber = allNumbers[i];
  if (outerNumber > 0) {
    primes.push(outerNumber);
  }
}

// Update document with primes
document.getElementById("primeValue").innerHTML += primes;
