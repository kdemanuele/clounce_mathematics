namespace ClounceMathExamples {
    using ClounceMath;
    using System;

    public sealed class ArithmeticMeanSequence {
        public static void RunSample() {
            double[] variables = new double[4];

            SequenceSolver.ArithmeticMeanSequence(45, 100, ref variables);

            Console.WriteLine("Running example from Brilliant 17 March 2019 Daily Challenge");
            Console.WriteLine("n the sequence of integers below, each number (starting with b) is the average of the two numbers before it. What is the value of a?");
            Console.WriteLine("45, a, b, c, d, 100");
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", variables[0], variables[1], variables[2], variables[3]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Verify the values by direct computation");
            Console.WriteLine("a = {0}", SequenceSolver.ArithmeticMeanSequenceVariable(45, 100, 4, 1));
            Console.WriteLine("b = {0}", SequenceSolver.ArithmeticMeanSequenceVariable(45, 100, 4, 2));
            Console.WriteLine("c = {0}", SequenceSolver.ArithmeticMeanSequenceVariable(45, 100, 4, 3));
            Console.WriteLine("d = {0}", SequenceSolver.ArithmeticMeanSequenceVariable(45, 100, 4, 4));
        }
    }
}