namespace ClounceMathExamples {
    using ClounceMath;
    using System;

    sealed class KappaNumbers {
        public static void RunSequence() {
            int i = 1;
            int l = 9;
            foreach (double number in Sequences.KappaNumberGenerator(l)) {
                Console.Write("K({0,2}, {1,2}): {2,-30}", l, i, number);
                if (++i % 3 == 0) {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Using the direct value calculation");

            for (i = 1; i <= l; ) {
                Console.Write("K({0,2}, {1,2}): {2,-30}", l, i, Sequences.KappaNumber(l, i));
                if (++i % 3 == 1) {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        } 
    }
}