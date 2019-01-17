// https://codingbat.com/prob/p183562

public boolean makeBricks(int small, int big, int goal) {
  
  // use big bricks to build up to goal
  while ((big > 0) && (goal >= 5)) {
    // big brick worth 5 inches
    goal = goal - 5;
    --big;
  }
  
  // use small bricks to build up rest of goal
  while ((small > 0) && (goal > 0)) {
    // small brick worth 1 inch
    --goal;
    --small;
  }
  
  return goal == 0;
}
