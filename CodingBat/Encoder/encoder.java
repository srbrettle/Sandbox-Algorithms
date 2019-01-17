// https://codingbat.com/prob/p238573

public String[] encoder(String[] raw, String[] code_words) {
  String[] replacedStrings = new String[raw.length];
  int nextAvailableIndexCodeWords = 0;
  Map<String, String> map = new HashMap<String, String>();
  
  for (int i=0; i < raw.length; i++) {
    if (!map.containsKey(raw[i])) {
      // word has not been encountered before
      replacedStrings[i] = code_words[nextAvailableIndexCodeWords];
      map.put(raw[i], code_words[nextAvailableIndexCodeWords]);
      ++nextAvailableIndexCodeWords;
    }
    else {
      // string encountered before, use map
      replacedStrings[i] = map.get(raw[i]);
    }
  }
  
  return replacedStrings;
}
