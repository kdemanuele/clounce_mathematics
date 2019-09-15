<?php

require_once('../lib/sequence_solver.php');

$variables = array_fill(0, 4, -1);

ClounceMath\SequenceSolver::arithmeticMeanSequence(45, 100, $variables);

print("Running example from Brilliant 17 March 2019 Daily Challenge" . PHP_EOL);
print("n the sequence of integers below, each number (starting with b) is the average of the two numbers before it. What is the value of a?" . PHP_EOL);
print("45, a, b, c, d, 100" . PHP_EOL);
printf("a = %s, b = %s, c = %s, d = %s" . PHP_EOL, $variables[0], $variables[1], $variables[2], $variables[3]);
print(PHP_EOL);
print(PHP_EOL);
print(PHP_EOL);
print("Verify the values by direct computation" . PHP_EOL);
printf("a = %s" . PHP_EOL, ClounceMath\SequenceSolver::arithmeticMeanSequenceVariable(45, 100, 4, 1));
printf("b = %s" . PHP_EOL, ClounceMath\SequenceSolver::arithmeticMeanSequenceVariable(45, 100, 4, 2));
printf("c = %s" . PHP_EOL, ClounceMath\SequenceSolver::arithmeticMeanSequenceVariable(45, 100, 4, 3));
printf("d = %s" . PHP_EOL, ClounceMath\SequenceSolver::arithmeticMeanSequenceVariable(45, 100, 4, 4));