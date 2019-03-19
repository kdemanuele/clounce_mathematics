"use strict"

let sequences = require('./sequences.js');

class SequenceSolver {
    static arithmeticMeanSequence(sequenceStartValue, sequenceEndValue, variables) {
        if (variables === undefined || sequenceStartValue === undefined || sequenceEndValue === undefined ||
            isNaN(sequenceStartValue) || isNaN(sequenceEndValue) || variables.length == 0) {
                return 0;
        }

        let numberOfVariables = variables.length;
        // Jacobsthal numbers start at J(0) however the algorithm needs to start at J(1)
        let sequenceNumber = sequences.jacobsthalNumber(numberOfVariables + 1);
        let nextSequenceNumber = sequences.jacobsthalNumber(numberOfVariables + 2);

        variables[0] = (((2 ** numberOfVariables) * sequenceEndValue) - (sequenceNumber * sequenceStartValue)) / nextSequenceNumber;

        for (let i = 1; i < numberOfVariables; i++) {
            sequenceNumber = sequences.jacobsthalNumber(i + 1);
            nextSequenceNumber = sequences.jacobsthalNumber(i + 2);

            variables[i] = ((sequenceNumber * sequenceStartValue) + (nextSequenceNumber * variables[0])) / (2 ** i);
        }
    }

    static arithmeticMeanSequenceVariable(sequenceStartValue, sequenceEndValue, numberOfVariables, variableToSolve) {
        if (sequenceStartValue === undefined || sequenceEndValue === undefined || numberOfVariables === undefined || variableToSolve === undefined ||
            isNaN(sequenceStartValue) || isNaN(sequenceEndValue) || isNaN(numberOfVariables) || isNaN(variableToSolve) ||
            variableToSolve > numberOfVariables) {
                return 0;
        }

        // Jackobsthal Sequence Generator starts at J(0), however for the calculations
        // the sequence needs to start from J(1). Thus the varlues in the parameters are
        // corrected with an addition of 1 to shift the sequence
        let nthJacobsthal = sequences.jacobsthalNumber(variableToSolve + 1);
        let preNthJacobsthal = sequences.jacobsthalNumber(variableToSolve);
        let sizeVarJacobsthal = sequences.jacobsthalNumber(numberOfVariables + 1);
        let nextSizeVarJacobsthal = sequences.jacobsthalNumber(numberOfVariables + 2);

        let yCalculation = (2 ** numberOfVariables) * nthJacobsthal * sequenceEndValue;
        let xCalculation = ((((-1) ** variableToSolve) * sizeVarJacobsthal) +
                (((-1) ** numberOfVariables) * preNthJacobsthal)) * sequenceStartValue;
        let numerator = yCalculation + xCalculation;
        let denominator = nextSizeVarJacobsthal * (2 ** (variableToSolve - 1));

        return numerator / denominator;
    }
}

module.exports = SequenceSolver;