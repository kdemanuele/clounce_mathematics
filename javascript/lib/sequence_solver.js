"use strict"

let sequences = require('./sequences.js');

class SequenceSolver {
    static arithmeticMeanSequence(sequenceStartValue, sequenceEndValue, variables) {
        if (variables === undefined || sequenceStartValue === undefined || sequenceEndValue === undefined ||
            isNaN(sequenceStartValue) || isNaN(sequenceEndValue) || variables.length == 0) {
                return 0;
        }

        let numberOfVariables = variables.length;
        let sequenceNumber = sequences.jacobsthalNumberNonRecursive(numberOfVariables);
        let nextSequenceNumber = sequences.jacobsthalNumberNonRecursive(numberOfVariables + 1);

        variables[0] = (((2 ** numberOfVariables) * sequenceEndValue) - (sequenceNumber * sequenceStartValue)) / nextSequenceNumber;

        for (let i = 1; i < numberOfVariables; i++) {
            sequenceNumber = sequences.jacobsthalNumberNonRecursive(i);
            nextSequenceNumber = sequences.jacobsthalNumberNonRecursive(i + 1);

            variables[i] = ((sequenceNumber * sequenceStartValue) + (nextSequenceNumber * variables[0])) / (2 ** i);
        }
    }

    static arithmeticMeanSequenceVariable(sequenceStartValue, sequenceEndValue, numberOfVariables, variableToSolve) {
        if (sequenceStartValue === undefined || sequenceEndValue === undefined || numberOfVariables === undefined || variableToSolve === undefined ||
            isNaN(sequenceStartValue) || isNaN(sequenceEndValue) || isNaN(numberOfVariables) || isNaN(variableToSolve) ||
            variableToSolve > numberOfVariables) {
                return 0;
        }

        let nthJacobsthal = sequences.jacobsthalNumberNonRecursive(variableToSolve);
        let preNthJacobsthal = sequences.jacobsthalNumberNonRecursive(variableToSolve - 1);
        let sizeVarJacobsthal = sequences.jacobsthalNumberNonRecursive(numberOfVariables);
        let nextSizeVarJacobsthal = sequences.jacobsthalNumberNonRecursive(numberOfVariables + 1);

        let yCalculation = (2 ** numberOfVariables) * nthJacobsthal * sequenceEndValue;
        let xCalculation = ((((-1) ** variableToSolve) * sizeVarJacobsthal) +
                (((-1) ** numberOfVariables) * preNthJacobsthal)) * sequenceStartValue;
        let numerator = yCalculation + xCalculation;
        let denominator = nextSizeVarJacobsthal * (2 ** (variableToSolve - 1));

        return numerator / denominator;
    }
}

module.exports = SequenceSolver;