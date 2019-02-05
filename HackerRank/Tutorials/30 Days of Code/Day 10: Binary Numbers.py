#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    n = int(input())
    binary = '{0:b}'.format(n)
    longest_consecutive_ones_length = len(max(binary.split('0')))
    print(longest_consecutive_ones_length)
