import sys

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
        print('Geometric Mean: ', MeanAverages.geometric_mean(sample))

        sample_index += 1
        print()
        print()
    
    sample_data.close()
