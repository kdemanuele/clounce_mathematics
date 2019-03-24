<?php

namespace ClounceMath;

require_once('sequences.php');

class SequenceSolver {
    public static function ArithmeticMeanSequence($sequenceStartValue, $sequenceEndValue, array &$variables) {
        if ($variables == null || count($variables) == 0) {
            return 0;
        }

        $numberOfVariables = count($variables);
        $sequenceNumber = Sequences::jacobsthalNumberNonRecursive($numberOfVariables);
        $nextSequenceNumber = Sequences::jacobsthalNumberNonRecursive($numberOfVariables + 1);

        $variables[0] = ((pow(2, $numberOfVariables) * $sequenceEndValue) - ($sequenceNumber * $sequenceStartValue)) / $nextSequenceNumber;

        for ($i = 1; $i < $numberOfVariables; $i++) {
            $sequenceNumber = Sequences::jacobsthalNumberNonRecursive($i);
            $nextSequenceNumber = Sequences::jacobsthalNumberNonRecursive($i + 1);

            $variables[$i] = (($sequenceNumber * $sequenceStartValue) + ($nextSequenceNumber * $variables[0])) / pow(2, $i);
        }
    }

    public static function arithmeticMeanSequenceVariable($sequenceStartValue, $sequenceEndValue, int $numberOfVariables, int $variableToSolve) {
        // If there are no variables then skip computation
        if ($numberOfVariables == 0 || $variableToSolve > $numberOfVariables) {
            return 0;
        }

        $nthJacobsthal = Sequences::jacobsthalNumberNonRecursive($variableToSolve);
        $preNthJacobsthal = Sequences::jacobsthalNumberNonRecursive($variableToSolve - 1);
        $sizeVarJacobsthal = Sequences::jacobsthalNumberNonRecursive($numberOfVariables);
        $nextSizeVarJacobsthal = Sequences::jacobsthalNumberNonRecursive($numberOfVariables + 1);

        $yCalculation = pow(2, $numberOfVariables) * $nthJacobsthal * $sequenceEndValue;
        $xCalculation = ((pow(-1, $variableToSolve) * $sizeVarJacobsthal) +
                (pow(-1, $numberOfVariables) * $preNthJacobsthal)) * $sequenceStartValue;
        $numerator = $yCalculation + $xCalculation;
        $denominator = $nextSizeVarJacobsthal * pow(2, $variableToSolve - 1);

        return $numerator / $denominator;
    }
}