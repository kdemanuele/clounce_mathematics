import sys

sys.path.insert(0, '../lib/')
from sequences import Sequences

if __name__ == "__main__":
    i = 0
    for sequenceNumber in Sequences.jacobsthal_number_generator(101):
        print('J({:>3}): {:<40}'.format(i, sequenceNumber), end='')
        i += 1
        if i % 3 == 0:
            print()