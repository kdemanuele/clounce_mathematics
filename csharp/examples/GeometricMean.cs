namespace ClounceMathExamples {
    using ClounceMath;
    using ClounceMathExamples.Helper;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    sealed class GeometricMean {
        public static void RunExamples() {
            int sampleNumber = 1;
            foreach (IEnumerable<dynamic> sample in SampleDataLoader.GetSamplesFromFile()) {
                double average = MeanAverages.GeometricMean(sample);
                PrintData(sampleNumber++, sample, average);
            }
        }

        private static void PrintData(int sampleNumber, IEnumerable<dynamic> sample, double average) {
            Console.WriteLine($"Sample {sampleNumber}");
            Console.WriteLine($"Sample Data: {string.Join(", ", sample)}");
            Console.WriteLine($"Geometric Mean: {average}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}