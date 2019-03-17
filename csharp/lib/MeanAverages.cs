namespace ClounceMath {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class MeanAverages {
        public static double ArithmeticMean(IEnumerable<dynamic> sample) {
            int sampleSize = sample.Count();
            double sum = 0;

            foreach (dynamic point in sample) {
                double.TryParse(point.ToString(), out double pointValue);
                sum += pointValue;
            }

            return sum / sampleSize;
        }

        public static IList<dynamic> Mode(IEnumerable<dynamic> sample) {
            Dictionary<dynamic, int> counts = new Dictionary<dynamic, int>();

            foreach (dynamic point in sample) {
                if (counts.ContainsKey(point)) {
                    counts[point]++;
                } else {
                    counts[point] = 1;
                }
            }

            int maximumRecurrance = counts.Values.Max();
            return counts.Where(p => p.Value == maximumRecurrance).Select(p => p.Key).ToList();
        }

        public static dynamic Median(IEnumerable<dynamic> sample) {
            List<dynamic> sortedSample = new List<dynamic>(sample);

            sortedSample.Sort();

            int sampleSize = sortedSample.Count;

            // REmove 1 from the computation since indexes start with 0 instead of 1
            dynamic lowerBound = (int) Math.Floor(sampleSize / 2.0) - 1;
            dynamic upperBound = lowerBound + 1;

            // Check if sample size is odd
            if (sampleSize % 2 == 1) {
                return sortedSample[upperBound];
            }

            return (sortedSample[lowerBound] + sortedSample[upperBound]) / 2;
        }
    }
}