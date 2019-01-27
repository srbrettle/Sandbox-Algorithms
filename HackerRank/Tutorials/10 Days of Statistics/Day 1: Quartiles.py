import math

# get inputs
size = int(input())
values = list(map(int, input().split(" ")))
values.sort()

if (size % 2 == 0):  
    # size is even      
    second_quartile = int((values[int(size/2-1)]+values[int(size/2)])/2)        
    if ((size/2) % 2 == 0):
        # half size is even
        first_quartile = int((values[int(math.floor(size/4)-1)]+values[int(math.floor(size/4))])/2)         
        third_quartile = int((values[int(math.floor(3*size/4)-1)]+values[int(math.floor(3*size/4))])/2)        
    else:
        # half size is odd
        first_quartile = values[int(math.floor(size/4))]
        third_quartile = values[int(math.floor(3*size/4))]
        
else:    
    # size is odd
    second_quartile = values[int(size/2-0.5)]  
    if ((size-1) % 2 == 0):
        # size without median is even
        first_quartile = int((values[int(math.floor(size/4)-1)]+values[int(math.floor(size/4))])/2) 
        third_quartile = int((values[int(math.floor(3*size/4))]+values[int(math.floor(3*size/4)+1)])/2)        
    else:        
        # size without median is odd
        first_quartile = values[int((size-1)/3)-1]
        third_quartile = values[int(2*(size-1)/3+1)]

# print outputs
print(first_quartile)
print(second_quartile)
print(third_quartile)
