// https://codingbat.com/prob/p234011

def interpret(value, commands, args):
  for command, arg in zip(commands, args):
    if (command == "+"):
      value += arg
    elif (command == "-"):
      value -= arg
    elif (command == "*"):
      value *= arg
    else:
      return -1
  
  return value
