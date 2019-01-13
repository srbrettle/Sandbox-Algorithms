// https://codingbat.com/prob/p117334

public String stringSplosion(String str) {
  String result = "";
  for (int i = 0; i <= str.length(); i++) {
    result = result.concat(str.substring(0, i));
  }
  return result;
}
