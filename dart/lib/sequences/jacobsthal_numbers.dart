import 'dart:async';
import 'dart:core';
import 'dart:math';

class JacobsthalNumber {
  static num compute(int position) {
    if (position <= 0) {
      return 0;
    }

    if (position == 1) {
      return 1;
    }

    return (2 * compute(position - 2)) + compute(position - 1);
  }

  static num comnputeWithoutRecursion(int position) {
      return (pow(2, position) - pow(-1, position)) / 3;
  }

  static Stream<int> generate(int maxPosition) async* {
    var lastPosition = 1;
    var preLastPosition = 0;

    for (var position = 0; position <= maxPosition; position++) {
      if (position == 0) yield preLastPosition;
      if (position == 1) yield lastPosition;

      var newSequenceNumber = (2 * preLastPosition) + lastPosition;
      preLastPosition = lastPosition;
      lastPosition = newSequenceNumber;

      yield newSequenceNumber;
    }
  }

  static Stream<num> generateWithoutRecursion(int maxPosition) async* {
    for (var position = 0; position <= maxPosition; position++) {
      yield (pow(2, position) - pow(-1, position)) / 3;
    }
  }
}