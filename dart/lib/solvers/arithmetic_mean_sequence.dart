import 'dart:math';
import '../sequences/jacobsthal_numbers.dart';

class ArithmeticMeanSequence {
  static void solve(num sequenceStartValue, num sequenceEndValue, List<num> variables) {
    if (variables == null || variables.length == 0) {
      return;
    }

    var numberOfVariables = variables.length;
    var sequenceNumber = JacobsthalNumber.computeWithoutRecursion(numberOfVariables);
    var nextSequenceNumber = JacobsthalNumber.computeWithoutRecursion(numberOfVariables + 1);

    variables[0] = ((pow(2, numberOfVariables) * sequenceEndValue) - (sequenceNumber * sequenceStartValue)) / nextSequenceNumber;

    for (var i = 1; i < numberOfVariables; i++) {
        sequenceNumber = JacobsthalNumber.computeWithoutRecursion(i);
        nextSequenceNumber = JacobsthalNumber.computeWithoutRecursion(i + 1);

        variables[i] = ((sequenceNumber * sequenceStartValue) + (nextSequenceNumber * variables[0])) /pow(2, i);
    }
  }

  static num solveForVariable(num sequenceStartValue, num sequenceEndValue, int numberOfVariables, int variableToSolve) {
    if (sequenceStartValue == 0 || sequenceEndValue == 0 || numberOfVariables == 0 || variableToSolve == 0 ||
            variableToSolve > numberOfVariables) {
                return 0;
        }

        var nthJacobsthal = JacobsthalNumber.computeWithoutRecursion(variableToSolve);
        var preNthJacobsthal = JacobsthalNumber.computeWithoutRecursion(variableToSolve - 1);
        var sizeVarJacobsthal = JacobsthalNumber.computeWithoutRecursion(numberOfVariables);
        var nextSizeVarJacobsthal = JacobsthalNumber.computeWithoutRecursion(numberOfVariables + 1);

        var yCalculation = pow(2, numberOfVariables) * nthJacobsthal * sequenceEndValue;
        var xCalculation = ((pow(-1, variableToSolve) * sizeVarJacobsthal) +
                (pow(-1, numberOfVariables) * preNthJacobsthal)) * sequenceStartValue;
        var numerator = yCalculation + xCalculation;
        var denominator = nextSizeVarJacobsthal * pow(2, variableToSolve - 1);

        return numerator / denominator;
  }
}