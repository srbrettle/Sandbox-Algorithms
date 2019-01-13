// https://codingbat.com/prob/p189576

public int maxSpan(int[] nums) {
  int maxSpan = 0;
  // Enumerate through array
  for (int i = 0; i < nums.length; i++) {
    int span = 0;
    int value = nums[i];
    // Enumerate through remainder of array
    for (int j = i; j < nums.length; j++) {
      ++span;
      if (nums[j] == value) {
        // Current int matches with target int
        if (span > maxSpan) {
          // Update max span if current span is higher
          maxSpan = span;
        }
      }
    }  
  }
  
  return maxSpan;
}
