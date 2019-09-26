namespace ClounceMathExamples
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                Console.WriteLine("Please select a concept to execute the sample data on");
                return;
            }

            switch (args[0])
            {
                case "arithmetic_mean":
                    ArithmeticMean.RunExamples();
                    break;
                case "mode":
                    Mode.RunExamples();
                    break;
                case "median":
                    Median.RunExamples();
                    break;
                case "jacobsthal":
                    JacobsthalNumbers.RunSequence();
                    break;
                case "arithmetic_mean_sequence":
                    ArithmeticMeanSequence.RunSample();
                    break;
                case "geometric_mean":
                    GeometricMean.RunExamples();
                    break;
                case "kappa":
                    KappaNumbers.RunSequence();
                    break;
            }
        }
    }
}
