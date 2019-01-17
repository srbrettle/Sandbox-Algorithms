// https://codingbat.com/prob/p294185

public int interpret(int value, String[] commands, int[] args) {
  for (int i = 0; i < commands.length; i++) {
    if (commands[i] == "+") {
      value += args[i];
    }
    else if (commands[i] == "-") {
      value -= args[i];
    }
    else if (commands[i] == "*") {
      value *= args[i];
    }
    else {
      return -1;
    }
  }
  
  return value;
}
