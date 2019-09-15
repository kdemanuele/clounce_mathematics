import 'package:clounce_math/solvers/arithmetic_mean_sequence.dart';

void main(List<String> args) {
  var variables = new List<num>(4);

  ArithmeticMeanSequence.solve(45, 100, variables);

  print("Running example from Brilliant 17 March 2019 Daily Challenge");
  print("n the sequence of integers below, each number (starting with b) is the average of the two numbers before it. What is the value of a?");
  print("45, a, b, c, d, 100");
  print("a = ${variables[0]}, b = ${variables[1]}, c = ${variables[2]}, d = ${variables[3]}");
  print('');
  print('');
  print('');
  print("Verify the values by direct computation");
  print("a = ${ArithmeticMeanSequence.solveForVariable(45, 100, 4, 1)}");
  print("b = ${ArithmeticMeanSequence.solveForVariable(45, 100, 4, 2)}");
  print("c = ${ArithmeticMeanSequence.solveForVariable(45, 100, 4, 3)}");
  print("d = ${ArithmeticMeanSequence.solveForVariable(45, 100, 4, 4)}");
}