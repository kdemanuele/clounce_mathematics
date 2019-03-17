import 'dart:core';
import 'dart:math';
import 'dart:io';
import 'package:clounce_math/clounce_math.dart';
import 'package:clounce_math/statistics/averages.dart';

void main(List<String> args) {
  var sampleData = File('../../sample_data').readAsLinesSync();
  int sampleNumber = 1;
  var numRegex = RegExp(r"\d+(.\d+)?");

  sampleData.forEach((line) {
    if (!line.trim().isEmpty) {
      var samplePoints = numRegex.allMatches(line);
      var sample = samplePoints.map((point) => num.tryParse(point.group(0))).toList();
      var average = Averages.median(sample);

      printSample(sampleNumber++, sample, average);
    }
  });

  var sample = List<int>();
  Random rnd = new Random();
  for (var i = 0; i < 25; i++) {
    sample.add(rnd.nextInt(19) + 1);
  }
  printSample(sampleNumber, sample, Averages.median(sample));

  sample = List<int>();
  for (var i = 0; i < 30; i++) {
    sample.add(rnd.nextInt(19) + 10);
  }
  printSample(++sampleNumber, sample, Averages.median(sample));
}

void printSample(int sampleNumber, List<num> sample, num average) {
  print('Sample ${sampleNumber}');
  print('Sample Data: ' + sample.join(', '));
  print('Mode: ${average}');
  print('');
  print('');
}