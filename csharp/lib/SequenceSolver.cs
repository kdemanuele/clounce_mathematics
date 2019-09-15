namespace ClounceMath {
    using System;

    public sealed class SequenceSolver {

        public static void ArithmeticMeanSequence(double sequenceStartValue, double sequenceEndValue, ref double[] variables)
        {
            int numberOfVariables = variables == null ? 0 : variables.Length;

            // If there are no variables then skip computation
            if (variables == null || numberOfVariables == 0) {
                return;
            }

            double sequenceNumber = Sequences.JacobsthalNumberNonRecursive(numberOfVariables);
            double nextSequenceNumber = Sequences.JacobsthalNumberNonRecursive(numberOfVariables + 1);
            variables[0] = ((Math.Pow(2, numberOfVariables) * sequenceEndValue) - (sequenceNumber * sequenceStartValue)) / nextSequenceNumber;

            for (int i = 1; i < numberOfVariables; i++) {
                sequenceNumber = Sequences.JacobsthalNumberNonRecursive(i);
                nextSequenceNumber = Sequences.JacobsthalNumberNonRecursive(i + 1);
                variables[i] = ((sequenceNumber * sequenceStartValue) + (nextSequenceNumber * variables[0])) / Math.Pow(2, i);
            }
        }

        public static double ArithmeticMeanSequenceVariable(double sequenceStartValue, double sequenceEndValue, int numberOfVariables, int variableToSolve)
        {
            // If there are no variables then skip computation
            if (numberOfVariables == 0 || variableToSolve > numberOfVariables) {
                return 0;
            }

            double nthJacobsthal = Sequences.JacobsthalNumberNonRecursive(variableToSolve);
            double preNthJacobsthal = Sequences.JacobsthalNumberNonRecursive(variableToSolve - 1);
            double sizeVarJacobsthal = Sequences.JacobsthalNumberNonRecursive(numberOfVariables);
            double nextSizeVarJacobsthal = Sequences.JacobsthalNumberNonRecursive(numberOfVariables + 1);

            double yCalculation = Math.Pow(2, numberOfVariables) * nthJacobsthal * sequenceEndValue;
            double xCalculation = ((Math.Pow(-1, variableToSolve) * sizeVarJacobsthal) +
                (Math.Pow(-1, numberOfVariables) * preNthJacobsthal)) * sequenceStartValue;
            double numerator = yCalculation + xCalculation;
            double denominator = nextSizeVarJacobsthal * Math.Pow(2, variableToSolve - 1);

            return numerator / denominator;
        }
    }
}