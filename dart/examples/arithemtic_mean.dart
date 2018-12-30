import 'dart:core';
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
      var average = Averages.arithmeticMean(sample);

      printSample(sampleNumber++, sample, average);
    }
  });
}

void printSample(int sampleNumber, List<num> sample, num average) {
  print('Sample ${sampleNumber}');
  print('Sample Data: ' + sample.join(', '));
  print('Arithmetic Mean: ${average}');
  print('');
  print('');
}