// https://codingbat.com/prob/p158767

public boolean canBalance(int[] nums) {
  // Calculate total
  int sum = 0;
  for (int num : nums) {
    sum += num;
  }
  
  // Impossible if sum is odd
  if (sum % 2 == 1) {
    return false;
  }
  
  // Try to get to half the sum
  int value = 0;
  for (int i=0; i < nums.length; i++) {
    value += nums[i];
    if (value == sum/2) {
      return true;
    }
  }
  
  return false;
}
