// https://codingbat.com/prob/p126332

public Map<String, String> pairs(String[] strings) {
  Map<String, String> map = new HashMap<String, String>();
  
  // Iterate strings in array
  for (String str : strings) {
    if (!map.containsKey(str.charAt(0))) {
      // Add first character as key, last character as value
      map.put(str.substring(0, 1), str.substring(str.length() - 1));
    }
  }
  
  return map;
}
