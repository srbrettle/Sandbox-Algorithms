class Difference:
    def __init__(self, a):
        self.__elements = a
    def computeDifference(self):
        # set maximumDifference
        self.maximumDifference = max(self.__elements) - min(self.__elements)
# End of Difference class

_ = input()
a = [int(e) for e in input().split(' ')]

d = Difference(a)
d.computeDifference()

print(d.maximumDifference)
