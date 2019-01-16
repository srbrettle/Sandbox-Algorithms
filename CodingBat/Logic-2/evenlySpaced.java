// https://codingbat.com/prob/p198700

public boolean evenlySpaced(int a, int b, int c) {
  int smallest;
  int middle;
  int largest;
  
  // Determine smallest
  if (a <= b && a <= c) {
    smallest = a;
  }
  else if (b <= a && b <= c) {
    smallest = b;
  }
  else {  // if (c <= a && c <= b)
    smallest = c;
  }
  
  // Determine largest
  if (a >= b && a >= c) {
    largest = a;
  }
  else if (b >= a && b >= c) {
    largest = b;
  }
  else {  //if (c >= a && c >= b)
    largest = c;
  }
  
  // Determine middle
  if ((a >= b && a <= c) || (a >= c && a <= b))  {
    middle = a;
  }
  else if ((b >= a && b <= c) || (b >= c && b <= a)) {
    middle = b;
  }
  else {  //if (c >= a && c <= b) 
    middle = c;
  }
  
  // Calculate spaces between numbers
  int spaceLargestAndMiddle = largest - middle;
  int spaceMiddleAndSmallest = middle - smallest;
  
  return (spaceLargestAndMiddle == spaceMiddleAndSmallest);
}
