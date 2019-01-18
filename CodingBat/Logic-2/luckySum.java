// https://codingbat.com/prob/p130788

public int luckySum(int a, int b, int c) {  
  int sum = 0;
  if (a != 13) {
    // Add a
    sum += a;
  }
  else {
    // Skip a, b and c
    return sum;
  }
  
  if (b != 13) {
    // Add b
    sum += b;
  }
  else {
    // Skip b and c
    return sum;
  }
  
  if (c != 13) {
    // Add c
    sum += c;
  }
  return sum;
}
