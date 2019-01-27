import statistics as st

# get inputs
size = int(input())
values = list(map(int, input().split(" ")))
values.sort()

# Calculate median and ranges
median = st.median(values)
if (size % 2 == 0):
    # size is even
    first_quartile = st.median(values[:size//2])
    third_quartile = st.median(values[size//2:])    
else:
    # size is odd
    first_quartile = st.median(values[:size//2])
    third_quartile = st.median(values[size//2+1:])

# print outputs
print(int(first_quartile))
print(int(median))
print(int(third_quartile))

