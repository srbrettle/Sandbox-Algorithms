// https://codingbat.com/prob/p191363

public int makeChocolate(int small, int big, int goal) {
  while (goal >= 5 && big > 0) {
    --big;
    goal -= 5;
  }
  
  if (small >= goal) {
    return goal;
  }
  
  return -1;
}
