import sys

sys.path.insert(0, '../lib/')
from sequences import Sequences

if __name__ == "__main__":
    i = 1
    k = 9
    for sequenceNumber in Sequences.kappa_generator(k):
        print('k({:>3}, {:>3}): {:<40}'.format(k, i, sequenceNumber), end='')
        i += 1
        if i % 3 == 1:
            print()
    print()
    print()
    print('Using a single number computation')
    for i in range(1, k + 1):
        print('k({:>3}, {:>3}): {:<40}'.format(k, i, Sequences.kappa_number(k, i)), end='')
        i += 1
        if i % 3 == 1:
            print()