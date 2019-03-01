namespace ClounceMath {
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
    }
}