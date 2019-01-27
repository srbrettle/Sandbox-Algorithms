import statistics as st

# Get inputs
initial_size = int(input())
data = list(map(int, input().split()))
freq = list(map(int, input().split()))

# Setup list
values = []
for i in range(initial_size):
    values += [data[i]] * freq[i]
size = sum(freq)
values.sort()

# Calculate ranges
if (size % 2 == 0):
    # size is even
    first_quartile = st.median(values[:size//2])
    third_quartile = st.median(values[size//2:])    
else:
    # size is odd
    first_quartile = st.median(values[:size//2])
    third_quartile = st.median(values[size//2+1:])
    
# Calculate interquartile range
interquartile_range = round(float(third_quartile-first_quartile), 1)
print(interquartile_range)

