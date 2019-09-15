namespace ClounceMathExamples {
    using ClounceMath;
    using System;

    sealed class JacobsthalNumbers {
        public static void RunSequence() {
            int i = 0;
            foreach (ulong number in Sequences.JacobsthalNumberNonRecursiveGenerator(50)) {
                Console.Write("J({0,2}): {1,-30}", i, number);
                if (++i % 3 == 0) {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        } 
    }
}