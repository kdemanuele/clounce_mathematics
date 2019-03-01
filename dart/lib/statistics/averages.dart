import 'dart:math';

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

  static List<num> mode(List<num> sample) {
    var sampleSize = sample.length;

    if (sampleSize == 0) {
      return null;
    }

    Set<num> uniquePoints = Set.of(sample);
    Map<num, int> pointCount = new Map<num, int>();
    uniquePoints.forEach((point) => pointCount[point] = sample.where((p) => p == point).length);

    num maxima = pointCount.values.reduce(max);
    pointCount.removeWhere((point, recurrence) => recurrence != maxima);
    return pointCount.keys.toList();
  }
}