// https://codingbat.com/prob/p117630

public Map<String, Integer> wordCount(String[] strings) {
  Map<String, Integer> map = new HashMap<String, Integer>();
  
  // Iterate array
  for(String str : strings) {
    if (!map.containsKey(str)) {
      // Add key to map
      map.put(str, 1);
    }
    else {
      // Increment value for key
      int value = map.get(str);
      map.put(str, ++value);
    }
  }
  
  return map;
}
