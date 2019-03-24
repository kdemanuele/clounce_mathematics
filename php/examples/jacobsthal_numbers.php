<?php

require_once('../lib/sequences.php');

$i = 0;
foreach (ClounceMath\Sequences::jacobsthalNumberNonRecursiveGenerator(50) as $sequenceNumber) {
    printf("J(%2s): %-30s", $i++, $sequenceNumber);
    if ($i % 3 === 0) {
        echo PHP_EOL;
    }
}