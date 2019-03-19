var sequenceSolver = require('../lib/sequence_solver.js');

let variables = new Array(4);

sequenceSolver.arithmeticMeanSequence(45, 100, variables);

console.log("Running example from Brilliant 17 March 2019 Daily Challenge");
console.log("n the sequence of integers below, each number (starting with b) is the average of the two numbers before it. What is the value of a?");
console.log("45, a, b, c, d, 100");
console.log("a = %s, b = %s, c = %s, d = %s", variables[0], variables[1], variables[2], variables[3]);
console.log();
console.log();
console.log();
console.log("Verify the values by direct computation");
console.log("a = %s", sequenceSolver.arithmeticMeanSequenceVariable(45, 100, 4, 1));
console.log("b = %s", sequenceSolver.arithmeticMeanSequenceVariable(45, 100, 4, 2));
console.log("c = %s", sequenceSolver.arithmeticMeanSequenceVariable(45, 100, 4, 3));
console.log("d = %s", sequenceSolver.arithmeticMeanSequenceVariable(45, 100, 4, 4));