<?php

require_once('../lib/mean_averages.php');

$sampleData = fopen('../../sample_data', 'r');
$sampleIndex = 1;
while (!feof($sampleData)) {
    $line = fgets($sampleData);
    if (empty(trim($line))) {
        continue;
    }

    $sample = explode(',', $line);
    array_walk($sample, function(&$point) {
        $point = floatval($point);
    });

    $average = ClounceMath\MeanAverages::geometricMean($sample);
    
    print("Sample $sampleIndex" . PHP_EOL);
    print('Sample Data: ' . implode(', ', $sample) . PHP_EOL);
    print("Geometric Mean: $average" . PHP_EOL);
    print(PHP_EOL . PHP_EOL);
    $sampleIndex++;
}