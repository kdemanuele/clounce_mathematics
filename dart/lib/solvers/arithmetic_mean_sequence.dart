import 'dart:math';
import '../sequences/jacobsthal_numbers.dart';

class ArithmeticMeanSequence {
  static void solve(num sequenceStartValue, num sequenceEndValue, List<num> variables) {
    if (variables == null || variables.length == 0) {
      return;
    }

    var numberOfVariables = variables.length;
    // Jacobsthal numbers start at J(0) however the algorithm needs to start at J(1)
    var sequenceNumber = JacobsthalNumber.computeUsingFreySellers(numberOfVariables + 1);
    var nextSequenceNumber = JacobsthalNumber.computeUsingFreySellers(numberOfVariables + 2);

    variables[0] = ((pow(2, numberOfVariables) * sequenceEndValue) - (sequenceNumber * sequenceStartValue)) / nextSequenceNumber;

    for (var i = 1; i < numberOfVariables; i++) {
        sequenceNumber = JacobsthalNumber.computeUsingFreySellers(i + 1);
        nextSequenceNumber = JacobsthalNumber.computeUsingFreySellers(i + 2);

        variables[i] = ((sequenceNumber * sequenceStartValue) + (nextSequenceNumber * variables[0])) /pow(2, i);
    }
  }

  static num solveForVariable(num sequenceStartValue, num sequenceEndValue, int numberOfVariables, int variableToSolve) {
    if (sequenceStartValue == 0 || sequenceEndValue == 0 || numberOfVariables == 0 || variableToSolve == 0 ||
            variableToSolve > numberOfVariables) {
                return 0;
        }

        // Jackobsthal Sequence Generator starts at J(0), however for the calculations
        // the sequence needs to start from J(1). Thus the varlues in the parameters are
        // corrected with an addition of 1 to shift the sequence
        var nthJacobsthal = JacobsthalNumber.computeUsingFreySellers(variableToSolve + 1);
        var preNthJacobsthal = JacobsthalNumber.computeUsingFreySellers(variableToSolve);
        var sizeVarJacobsthal = JacobsthalNumber.computeUsingFreySellers(numberOfVariables + 1);
        var nextSizeVarJacobsthal = JacobsthalNumber.computeUsingFreySellers(numberOfVariables + 2);

        var yCalculation = pow(2, numberOfVariables) * nthJacobsthal * sequenceEndValue;
        var xCalculation = ((pow(-1, variableToSolve) * sizeVarJacobsthal) +
                (pow(-1, numberOfVariables) * preNthJacobsthal)) * sequenceStartValue;
        var numerator = yCalculation + xCalculation;
        var denominator = nextSizeVarJacobsthal * pow(2, variableToSolve - 1);

        return numerator / denominator;
  }
}