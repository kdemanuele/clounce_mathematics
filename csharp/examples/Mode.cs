namespace ClounceMathExamples {
    using ClounceMath;
    using ClounceMathExamples.Helper;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    sealed class Mode {
        public static void RunExamples() {
            int sampleNumber = 1;

            IEnumerable<IEnumerable<dynamic>> samples = SampleDataLoader.GetSamplesFromFile();

            foreach (IEnumerable<dynamic> sample in SampleDataLoader.GetSamplesFromFile()) {
                dynamic average = MeanAverages.Mode(sample);
                PrintData(sampleNumber++, sample, average);
            }

            var dynamicSample = GenerateDynamicSample();
            var median = MeanAverages.Mode(dynamicSample);
            PrintData(sampleNumber++, dynamicSample, median);
        }

        private static void PrintData(int sampleNumber, IEnumerable<dynamic> sample, dynamic average) {
            Console.WriteLine($"Sample {sampleNumber}");
            Console.WriteLine($"Sample Data: {string.Join(", ", sample)}");
            Console.WriteLine($"Arithmetic Mean: {string.Join(',', average)}");
            Console.WriteLine();
            Console.WriteLine();
        }

        private static IList<dynamic> GenerateDynamicSample() {
            Random rnd = new Random();
            List<dynamic> sample = new List<dynamic>();
            
            for (int i = 0; i < 25; i++) {
                sample.Add(rnd.Next(10, 20));
            }

            return sample;
        }
    }
}