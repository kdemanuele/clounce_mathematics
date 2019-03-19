<?php

require_once('../lib/sequences.php');

$i = 0;
foreach (ClounceMath\Sequences::jacobsthalNumberGenerator(50) as $sequenceNumber) {
    printf("%2s: %-30s", ++$i, $sequenceNumber);
    if ($i % 3 === 0) {
        echo PHP_EOL;
    }
}