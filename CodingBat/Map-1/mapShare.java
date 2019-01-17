// https://codingbat.com/prob/p148813

public Map<String, String> mapShare(Map<String, String> map) {
  if (map.containsKey("a")) {
    // Replace "b" key's value with "a" key's value
    map.put("b", map.get("a"));
  }
  
  // Always remove "c"
  map.remove("c");
  
  return map;
}
