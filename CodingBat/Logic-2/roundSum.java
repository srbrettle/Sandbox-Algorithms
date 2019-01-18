// https://codingbat.com/prob/p186753

public int roundSum(int a, int b, int c) {
  int sum = round10(a);
  sum += round10(b);
  sum += round10(c);
  return sum;
}

public int round10(int num) {
  int rightMostDigit = num % 10;
  if (rightMostDigit >= 5) {
    num += (10 - rightMostDigit);
  }
  else {
    num -= rightMostDigit;
  }
  return num;
}
