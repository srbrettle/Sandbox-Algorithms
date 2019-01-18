// https://codingbat.com/prob/p138990

public boolean closeFar(int a, int b, int c) {
  if (Math.abs(b-a)<=1) {
    // b is "close" to a
    if ((Math.abs(c-a)>1) && (Math.abs(c-b)>1)) {
      // c is "far" from a and b
      return true;
    }
  }
  else if (Math.abs(c-a)<=1) {
    // c is "close" to a
    if ((Math.abs(b-a)>1) && (Math.abs(b-c)>1)) {
      // b is "far" from a and c
      return true;
    }
  }
  return false;
}
