size = int(input())
numbers = list(map(int, input().split(" ")))
numbers.sort()

# mean
mean = sum(numbers)/size
print(mean)

# median
if size%2==1:
    # odd size
    median = numbers[int(size/2-0.5)]
else:
    # even size
    median = (numbers[int(size/2-1)]+numbers[int(size/2)])/2
print(median)

# mode
mode = max(numbers, key=numbers.count)
print(mode)
