// https://codingbat.com/prob/p182879

public int noTeenSum(int a, int b, int c) {
  int sum = fixTeen(a);
  sum += fixTeen(b);
  sum += fixTeen(c);
  return sum;
}

public int fixTeen(int n) {
  if (((n >= 13) && (n <= 14)) || ((n >= 17) && (n <= 19))) {
    return 0;    
  }
  return n;
}
