public int sumNumbers(String str) {
  int sum = 0;
  String currentNumber = "0";
  // Iterate through char array
  for(char c : str.toCharArray()) {
    if (Character.isDigit(c)) {
      // Character is a number, append to currentNumber
      currentNumber += c;
    }
    else {
      // Character is not a number
      sum += Integer.parseInt(currentNumber);
      currentNumber = "0";
    }
  }
  // End of array: Add remaining currentNumber 
  sum += Integer.parseInt(currentNumber);
  return sum;
}
