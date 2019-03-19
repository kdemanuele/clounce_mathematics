import 'dart:async';
import 'dart:core';

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
}