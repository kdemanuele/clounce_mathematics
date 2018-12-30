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
}