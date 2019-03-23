import 'dart:async';
import 'dart:core';
import 'dart:math';

class JacobsthalNumber {
  static num compute(int position) {
    if (position <= 1) {
      return 0;
    }

    if (position == 2) {
      return 1;
    }

    return (2 * compute(position - 2)) + compute(position - 1);
  }

  static num computeUsingFreySellers(int position) {
      return (pow(2, position + 1) + pow(-1, position)) / 3;
  }

  static num comnputeUsingJacobsthalNumberRabago(int position) {
      return (pow(2, position) - pow(-1, position)) / 3;
  }

  static Stream<int> generate(int maxPosition) async* {
    var lastPosition = 1;
    var preLastPosition = 0;

    for (var position = 1; position < maxPosition; position++) {
      if (position == 1) yield preLastPosition;
      if (position == 2) yield lastPosition;

      var newSequenceNumber = (2 * preLastPosition) + lastPosition;
      preLastPosition = lastPosition;
      lastPosition = newSequenceNumber;

      yield newSequenceNumber;
    }
  }

  static Stream<num> generateUsingFreySeller(int maxPosition) async* {
    for (var position = 1; position < maxPosition; position++) {
      yield (pow(2, position + 1) + pow(-1, position)) / 3;
    }
  }

  static Stream<num> generateUsingRabago(int maxPosition) async* {
    for (var position = 1; position < maxPosition; position++) {
      yield (pow(2, position) - pow(-1, position)) / 3;
    }
  }
}