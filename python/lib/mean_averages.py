from collections import Counter;

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