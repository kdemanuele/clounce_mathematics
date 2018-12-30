class Averages {
  /// Calculates the Average of the sample by adding the values in the sample and divides the computed value with the sample size
  static num arithmeticMean(List<num> sample) {
    var sampleSize = sample.length;

    if (sampleSize == 0) {
      return 0;
    }

    double sum = 0;
    sample.forEach((point) {
      sum += point;
    });

    return sum / sampleSize;
  }
}