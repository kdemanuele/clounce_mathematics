import 'dart:io';
import 'package:clounce_math/sequences/kappa_numbers.dart';

void main(List<String> args) async {
  num i = 1;
  await for (var sequenceNumber in KappaNumber.generate(9)) {
    stdout.write('k(9, ' + (i++).toString().padLeft(2) + '): ' + sequenceNumber.toString().padRight(30));
    if (i % 3 == 1) {
      print('');
    }
  }

  print('');
  print('Using direct calculation');
  for (var position = 1; position <= 9; position++) {
    stdout.write('k(9, ' + (position).toString().padLeft(2) + '): ' + KappaNumber.compute(9, position).toString().padRight(30));
    if (position % 3 == 0) {
      print('');
    }
  }
}