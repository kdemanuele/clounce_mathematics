<?php

require_once('../lib/mean_averages.php');

function calculateMean($sampleIndex, $sample) {
    $average = ClounceMath\MeanAverages::mode($sample);
    
    print("Sample $sampleIndex" . PHP_EOL);
    print('Sample Data: ' . implode(', ', $sample) . PHP_EOL);
    print("Mode: " . implode(', ', $average) . PHP_EOL);
    print(PHP_EOL . PHP_EOL);
}

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

    calculateMean($sampleIndex, $sample);
    $sampleIndex++;
}

$sample = [];
for ($i = 0; $i < 25; $i++) {
    $sample[] = rand(1, 20);
}
calculateMean($sampleIndex, $sample);