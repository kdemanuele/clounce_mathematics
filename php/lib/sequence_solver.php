<?php

namespace ClounceMath;

require_once('sequences.php');

class SequenceSolver {
    public static function ArithmeticMeanSequence($sequenceStartValue, $sequenceEndValue, array &$variables) {
        if ($variables == null || count($variables) == 0) {
            return 0;
        }

        $numberOfVariables = count($variables);
        // Jacobsthal numbers start at J(0) however the algorithm needs to start at J(1)
        $sequenceNumber = Sequences::jacobsthalNumberFreySellerGenerator($numberOfVariables + 1);
        $nextSequenceNumber = Sequences::jacobsthalNumberFreySellerGenerator($numberOfVariables + 2);

        $variables[0] = ((pow(2, $numberOfVariables) * $sequenceEndValue) - ($sequenceNumber * $sequenceStartValue)) / $nextSequenceNumber;

        for ($i = 1; $i < $numberOfVariables; $i++) {
            $sequenceNumber = Sequences::jacobsthalNumberFreySellerGenerator($i + 1);
            $nextSequenceNumber = Sequences::jacobsthalNumberFreySellerGenerator($i + 2);

            $variables[$i] = (($sequenceNumber * $sequenceStartValue) + ($nextSequenceNumber * $variables[0])) / pow(2, $i);
        }
    }

    public static function arithmeticMeanSequenceVariable($sequenceStartValue, $sequenceEndValue, int $numberOfVariables, int $variableToSolve) {
        // If there are no variables then skip computation
        if ($numberOfVariables == 0 || $variableToSolve > $numberOfVariables) {
            return 0;
        }

        // Jackobsthal Sequence Generator starts at J(0), however for the calculations
        // the sequence needs to start from J(1). Thus the varlues in the parameters are
        // corrected with an addition of 1 to shift the sequence
        $nthJacobsthal = Sequences::jacobsthalNumberFreySellerGenerator($variableToSolve + 1);
        $preNthJacobsthal = Sequences::jacobsthalNumberFreySellerGenerator($variableToSolve);
        $sizeVarJacobsthal = Sequences::jacobsthalNumberFreySellerGenerator($numberOfVariables + 1);
        $nextSizeVarJacobsthal = Sequences::jacobsthalNumberFreySellerGenerator($numberOfVariables + 2);

        $yCalculation = pow(2, $numberOfVariables) * $nthJacobsthal * $sequenceEndValue;
        $xCalculation = ((pow(-1, $variableToSolve) * $sizeVarJacobsthal) +
                (pow(-1, $numberOfVariables) * $preNthJacobsthal)) * $sequenceStartValue;
        $numerator = $yCalculation + $xCalculation;
        $denominator = $nextSizeVarJacobsthal * pow(2, $variableToSolve - 1);

        return $numerator / $denominator;
    }
}