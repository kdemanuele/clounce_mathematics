<?php

require_once('../lib/sequences.php');

$i = 1;
foreach (ClounceMath\Sequences::kappaNumberGenerator(9) as $sequenceNumber) {
    printf("k(%d, %2s): %-30s", 9, $i++, $sequenceNumber);
    if ($i % 3 === 1) {
        echo PHP_EOL;
    }
}

printf(PHP_EOL . "Using direct computation" . PHP_EOL);
for ($i = 1; $i <= 9; ) {
    printf("k(%d, %2s): %-30s", 9, $i, ClounceMath\Sequences::kappaNumber(9, $i));
    if (++$i % 3 === 1) {
        echo PHP_EOL;
    }
}