import 'dart:async';
import 'dart:core';
import 'dart:math';
import 'jacobsthal_numbers.dart';

class KappaNumber {
  static num compute(int maxPosition, int position) {
    return pow(2, maxPosition) * (JacobsthalNumber.computeWithoutRecursion(position) / pow(2, position - 1));
  }

  static Stream<num> generate(int maxPosition) async* {
    for (var position = 1; position <= maxPosition; position++) {
      yield compute(maxPosition, position);
    }
  }
}