#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    arr = []

    for _ in range(6):
        arr.append(list(map(int, input().rstrip().split())))
    # determine number of rows and columns
    num_rows = len(arr)
    num_cols = len(arr[0])
    # max sum of encountered hourglasses
    max_sum = -63 # min possible (-9 * 7)

    for i in range(num_rows-2):        
        for j in range(num_cols-2):   
            # find sum of hourglass integers
            hourglass_sum = arr[i][j] + arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2]                    
            # compare to current max_sum and set if larger
            if hourglass_sum > max_sum:
                max_sum = hourglass_sum
                
    print(max_sum)
