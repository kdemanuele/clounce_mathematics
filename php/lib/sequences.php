<?php

namespace ClounceMath;

class Sequences {
    public static function jacobsthalNumber(int $position) {
        if ($position == 0) {
            return 0;
        }

        if ($position == 1) {
            return 1;
        }

        return 2 * self::jacobsthalNumber($position - 2) + self::jacobsthalNumber($position - 1);
    }

    public static function jacobsthalNumberNonRecursive(int $position) {
        return (pow(2, $position) - pow(-1, $position)) / 3;
    }

    public static function jacobsthalNumberGenerator(int $maxPosition) {
        $preLastPosition = 0;
        $lastPosition = 1;

        for ($position = 0; $position <= $maxPosition; $position++) {
            if ($position == 0) {
                yield $preLastPosition;
            }

            if ($position == 1) {
                yield $lastPosition;
            }

            $newSequenceNumber = 2 * $preLastPosition + $lastPosition;
            $preLastPosition = $lastPosition;
            $lastPosition = $newSequenceNumber;

            yield $newSequenceNumber;
        }
    }

    public static function jacobsthalNumberNonRecursiveGenerator(int $maxPosition) {
        for ($position = 0; $position <= $maxPosition; $position++) {
            yield (pow(2, $position) - pow(-1, $position)) / 3;
        }
    }
}