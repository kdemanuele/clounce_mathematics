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
    }   
}