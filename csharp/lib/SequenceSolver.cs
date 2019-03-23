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

            // Jacobsthal numbers start at J(0) however the algorithm needs to start at J(1)
            double sequenceNumber = Sequences.JacobsthalNumberRabagoAlgorithm(numberOfVariables + 1);
            double nextSequenceNumber = Sequences.JacobsthalNumberRabagoAlgorithm(numberOfVariables + 2);
            variables[0] = ((Math.Pow(2, numberOfVariables) * sequenceEndValue) - (sequenceNumber * sequenceStartValue)) / nextSequenceNumber;

            for (int i = 1; i < numberOfVariables; i++) {
                sequenceNumber = Sequences.JacobsthalNumberRabagoAlgorithm(i + 1);
                nextSequenceNumber = Sequences.JacobsthalNumberRabagoAlgorithm(i + 2);
                variables[i] = ((sequenceNumber * sequenceStartValue) + (nextSequenceNumber * variables[0])) / Math.Pow(2, i);
            }
        }

        public static double ArithmeticMeanSequenceVariable(double sequenceStartValue, double sequenceEndValue, int numberOfVariables, int variableToSolve)
        {
            // If there are no variables then skip computation
            if (numberOfVariables == 0 || variableToSolve > numberOfVariables) {
                return 0;
            }

            // Jackobsthal Sequence Generator starts at J(0), however for the calculations
            // the sequence needs to start from J(1). Thus the varlues in the parameters are
            // corrected with an addition of 1 to shift the sequence
            double nthJacobsthal = Sequences.JacobsthalNumberRabagoAlgorithm(variableToSolve + 1);
            double preNthJacobsthal = Sequences.JacobsthalNumberRabagoAlgorithm(variableToSolve);
            double sizeVarJacobsthal = Sequences.JacobsthalNumberRabagoAlgorithm(numberOfVariables + 1);
            double nextSizeVarJacobsthal = Sequences.JacobsthalNumberRabagoAlgorithm(numberOfVariables + 2);

            double yCalculation = Math.Pow(2, numberOfVariables) * nthJacobsthal * sequenceEndValue;
            double xCalculation = ((Math.Pow(-1, variableToSolve) * sizeVarJacobsthal) +
                (Math.Pow(-1, numberOfVariables) * preNthJacobsthal)) * sequenceStartValue;
            double numerator = yCalculation + xCalculation;
            double denominator = nextSizeVarJacobsthal * Math.Pow(2, variableToSolve - 1);

            return numerator / denominator;
        }
    }
}