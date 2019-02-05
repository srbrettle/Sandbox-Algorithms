# Enter your code here. Read input from STDIN. Print output to STDOUT

# Find number of inputs
num_inputs = int(input())

# Handle each input string
for n in range(0,num_inputs):
    text = input()
    print(text[::2], text[1::2])
