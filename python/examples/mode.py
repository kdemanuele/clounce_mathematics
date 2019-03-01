import sys, random

sys.path.insert(0, '../lib/')
from mean_averages import MeanAverages

if __name__ == "__main__":
    sample_data = open('../../sample_data', 'r')

    sample_index = 1
    for line in sample_data:
        if not line or line.isspace():
            continue

        print('Sample ', sample_index)
        
        sample = [ float(data) for data in line.split(',') ]
        print('Sample Data: ', sample)
        print('Mode: ', MeanAverages.mode(sample))

        sample_index += 1
        print()
        print()
    
    sample_data.close()

    sample = [random.randint(1, 20) for x in range(1, 25)]
    print('Sample ', sample_index)
    print('Sample Data: ', sample)
    print('Mode: ', MeanAverages.mode(sample))
