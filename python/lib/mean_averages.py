from collections import Counter;
from math import floor;

class MeanAverages:
    @staticmethod
    def arithmetic_mean(sample):
        sampleSize = len(sample)
        if sampleSize == 0:
            return 0

        sum = 0
        for point in sample:
            if (isinstance(point, int) or isinstance(point, float)):
                sum += point
                
        return sum / sampleSize
    
    @staticmethod
    def mode(sample):
        sampleSize = len(sample)
        if sample == 0:
            return 0

        pointCount = Counter(sample)
        pointCount = pointCount.most_common()
        return set(pt for pt, count in pointCount if count == pointCount[0][1])

    @staticmethod
    def median(sample):
        sampleSize = len(sample)
        if sample == 0:
            return 0
        
        sortedSample = sorted(sample)
        middle = floor(sampleSize / 2)
        if (sampleSize % 2 == 1):
            return sortedSample[middle];

        return (sortedSample[middle -1 ] + sortedSample[middle]) / 2