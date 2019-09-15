from collections import Counter
from math import floor

class MeanAverages:
    @staticmethod
    def arithmetic_mean(sample):
        sample_size = len(sample)
        if sample_size == 0:
            return 0

        sum = 0
        for point in sample:
            if (isinstance(point, int) or isinstance(point, float)):
                sum += point
                
        return sum / sample_size
    
    @staticmethod
    def mode(sample):
        if sample == 0:
            return 0

        point_count = Counter(sample)
        point_count = point_count.most_common()
        return set(pt for pt, count in point_count if count == point_count[0][1])

    @staticmethod
    def median(sample):
        sample_size = len(sample)
        if sample == 0:
            return 0
        
        sorted_sample = sorted(sample)
        middle = floor(sample_size / 2)
        if (sample_size % 2 == 1):
            return sorted_sample[middle]

        return (sorted_sample[middle - 1] + sorted_sample[middle]) / 2

    @staticmethod
    def geometric_mean(sample):
        sample_size = len(sample)
        if sample_size == 0:
            return 0

        # Initialising value to 1 as 1 is the identity value in multiplication
        product = 1
        for point in sample:
            if (isinstance(point, int) or isinstance(point, float)):
                product *= point
        # Using the convertion between nth roots to rational exponents        
        return product ** (1 / float(sample_size))