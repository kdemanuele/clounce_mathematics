import 'dart:io';
import 'package:clounce_math/sequences/jacobsthal_numbers.dart';

void main(List<String> args) async {
  num i = 0;
  await for (var sequenceNumber in JacobsthalNumber.generate(50)) {
    stdout.write('J(' + (i++).toString().padLeft(2) + '): ' + sequenceNumber.toString().padRight(30));
    if (i % 3 == 0) {
      print('');
    }
  }
}