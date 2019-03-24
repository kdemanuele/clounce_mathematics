import 'dart:math';
import '../sequences/jacobsthal_numbers.dart';

class ArithmeticMeanSequence {
  static void solve(num sequenceStartValue, num sequenceEndValue, List<num> variables) {
    if (variables == null || variables.length == 0) {
      return;
    }

    var numberOfVariables = variables.length;
    var sequenceNumber = JacobsthalNumber.comnputeWithoutRecursion(numberOfVariables);
    var nextSequenceNumber = JacobsthalNumber.comnputeWithoutRecursion(numberOfVariables + 1);

    variables[0] = ((pow(2, numberOfVariables) * sequenceEndValue) - (sequenceNumber * sequenceStartValue)) / nextSequenceNumber;

    for (var i = 1; i < numberOfVariables; i++) {
        sequenceNumber = JacobsthalNumber.comnputeWithoutRecursion(i);
        nextSequenceNumber = JacobsthalNumber.comnputeWithoutRecursion(i + 1);

        variables[i] = ((sequenceNumber * sequenceStartValue) + (nextSequenceNumber * variables[0])) /pow(2, i);
    }
  }

  static num solveForVariable(num sequenceStartValue, num sequenceEndValue, int numberOfVariables, int variableToSolve) {
    if (sequenceStartValue == 0 || sequenceEndValue == 0 || numberOfVariables == 0 || variableToSolve == 0 ||
            variableToSolve > numberOfVariables) {
                return 0;
        }

        var nthJacobsthal = JacobsthalNumber.comnputeWithoutRecursion(variableToSolve);
        var preNthJacobsthal = JacobsthalNumber.comnputeWithoutRecursion(variableToSolve - 1);
        var sizeVarJacobsthal = JacobsthalNumber.comnputeWithoutRecursion(numberOfVariables);
        var nextSizeVarJacobsthal = JacobsthalNumber.comnputeWithoutRecursion(numberOfVariables + 1);

        var yCalculation = pow(2, numberOfVariables) * nthJacobsthal * sequenceEndValue;
        var xCalculation = ((pow(-1, variableToSolve) * sizeVarJacobsthal) +
                (pow(-1, numberOfVariables) * preNthJacobsthal)) * sequenceStartValue;
        var numerator = yCalculation + xCalculation;
        var denominator = nextSizeVarJacobsthal * pow(2, variableToSolve - 1);

        return numerator / denominator;
  }
}