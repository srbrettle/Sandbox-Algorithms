// https://codingbat.com/prob/p262890

int[] sort(int[] a) {

  // Create and populate HashSet
  Set<Integer> set = new HashSet<Integer>();
  for(int i = 0; i < a.length; i++){
    set.add(a[i]);
  }
  
  // Populate new array
  Iterator<Integer> itr = set.iterator();
  int[] sortedArrayWithoutDuplicates = new int[set.size()];
  for (int i = 0; i < set.size(); i++) {
    sortedArrayWithoutDuplicates[i] = itr.next();
  }

  return sortedArrayWithoutDuplicates;
}
