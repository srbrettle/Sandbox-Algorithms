# Find number of entries
num_entries = int(input())

phonebook = {}
# Add entries to dictionary
for n in range(0, num_entries):
    name, value = input().split(' ')
    phonebook[name] = value

# Unknown number of queries, continue until EOF
while True:
    try:
        # print name and number if found
        name = input();
        if name in phonebook:
            print(name + '=' + phonebook[name])
        else:
            print('Not found')
    except EOFError:
        # End of file, no more input queries
        break
