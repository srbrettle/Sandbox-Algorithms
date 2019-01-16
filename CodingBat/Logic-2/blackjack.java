// https://codingbat.com/prob/p117019

public int blackjack(int a, int b) {
  if ((a <= 21 && a >= b) || (a <= 21 && b > 21)) {
    // a greater than b and under 21, or b is over 21
    return a;
  }
  if ((b <= 21 && b >= a) || (b <= 21 && a > 21)) {
    // b greater than a and under 21, or a is over 21
    return b;
  }
  // Both values over 21, return 0
  return 0;
}
