import math

size = int(input())
values = list(map(int, input().split(" ")))

mean = sum(values)/size

sumSquaredDistances = 0
for value in values:
    sumSquaredDistances += math.pow(value-mean, 2)

standardDeviation = math.pow(sumSquaredDistances/size, 1/2)
print (round(standardDeviation, 1))

