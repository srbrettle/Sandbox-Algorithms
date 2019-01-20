// https://codingbat.com/prob/p159531

public boolean cigarParty(int cigars, boolean isWeekend) {
  return (cigars >= 40 && (cigars <= 60 || isWeekend));
}
