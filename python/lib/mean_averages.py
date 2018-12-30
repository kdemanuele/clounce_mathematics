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