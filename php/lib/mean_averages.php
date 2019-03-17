<?php

namespace ClounceMath;

class MeanAverages {
    static function arithmeticMean($sample) {
        $sampleSize = count($sample);
        if ($sampleSize == 0) {
            return 0;
        }

        $sum = 0;

        foreach ($sample as $point) {
            if (is_numeric($point)) {
                $sum += $point;
            }
        }

        return $sum / $sampleSize;
    }

    static function mode($sample) {
        $sampleSize = count($sample);
        if ($sampleSize == 0) {
            return 0;
        }

        $sampleStringified = array_map(function($point) {
            return number_format($point, 10);
        }, $sample);

        $pointCount = array_count_values($sampleStringified);
        $maxima = max(array_values($pointCount));

        $max = [];
        foreach($pointCount as $point => $count) {
            if ($count == $maxima) {
                $max[] = floatval($point);
            }
        }

        return $max;
    }

    static function median($sample) {
        $sampleSize = count($sample);
        if ($sampleSize == 0) {
            return 0;
        }

        $sortedSample = array_splice($sample, 0);
        sort($sortedSample);

        $middle = intval(floor($sampleSize / 2));
        if ($sampleSize % 2 == 1) {
            return $sortedSample[$middle];
        }

        return ($sortedSample[$middle - 1] + $sortedSample[$middle]) / 2;
    }
}