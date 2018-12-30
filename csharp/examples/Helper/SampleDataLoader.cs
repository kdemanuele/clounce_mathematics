namespace ClounceMathExamples.Helper {
    using System.IO;
    using System.Collections.Generic;

    sealed class SampleDataLoader {
        private static string path = "../../sample_data";

        public static IEnumerable<IEnumerable<dynamic>> GetSamplesFromFile() {
            string line;

            using (StreamReader sampleData = new StreamReader(path)) {
                while ((line = sampleData.ReadLine()) != null) {
                    if (string.IsNullOrWhiteSpace(line)) {
                        continue;
                    }

                    IList<dynamic> sample = new List<dynamic>();
                    foreach (string data in line.Split(',')) {
                        double.TryParse(data, out double point);

                        sample.Add(point);
                    }

                    yield return sample;
                }
            }
        }
    }
}