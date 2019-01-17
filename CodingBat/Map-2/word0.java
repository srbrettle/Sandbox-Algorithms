// https://codingbat.com/prob/p125327

public Map<String, Integer> word0(String[] strings) {
  Map<String, Integer> map = new HashMap<String, Integer>();
  for(String str : strings) {
    if (!map.containsKey(str)) {
      map.put(str, 0);
    }
  }
  return map;  
}
