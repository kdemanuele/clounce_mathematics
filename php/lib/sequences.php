<?php

namespace ClounceMath;

class Sequences {
    public static function jacobsthalNumber(int $position) {
        if ($position == 1) {
            return 0;
        }

        if ($position == 2) {
            return 1;
        }

        return 2 * self::jacobsthalNumber($position - 2) + self::jacobsthalNumber($position - 1);
    }

    public static function jacobsthalNumberFreySellersAlgorithm(int $position) {
        return (pow(2, $position + 1) + pow(-1, $position)) / 3;
    }

    public static function jacobsthalNumberRabagoAlgorithm(int $position) {
        return (pow(2, $position) - pow(-1, $position)) / 3;
    }

    public static function jacobsthalNumberGenerator(int $maxPosition) {
        $preLastPosition = 0;
        $lastPosition = 1;

        for ($position = 1; $position < $maxPosition; $position++) {
            if ($position == 1) {
                yield $preLastPosition;
            }

            if ($position == 2) {
                yield $lastPosition;
            }

            $newSequenceNumber = 2 * $preLastPosition + $lastPosition;
            $preLastPosition = $lastPosition;
            $lastPosition = $newSequenceNumber;

            yield $newSequenceNumber;
        }
    }

    public static function jacobsthalNumberBabagoGenerator(int $maxPosition) {
        for ($position = 1; $position < $maxPosition; $position++) {
            yield (pow(2, $position) - pow(-1, $position)) / 3;
        }
    }

    public static function jacobsthalNumberFreySellerGenerator(int $maxPosition) {
        for ($position = 1; $position < $maxPosition; $position++) {
            yield (pow(2, $position + 1) + pow(-1, $position)) / 3;
        }
    }
}