size = int(input())
values = list(map(int, input().split(" ")))
weights = list(map(int, input().split(" ")))

weightedValues = [a*b for a,b in zip(values,weights)]
weightedMean = sum(weightedValues)/sum(weights)
print(round(weightedMean, 1))
