var sequences = require('../lib/sequences.js');

let i = 0;
for (let sequenceNumber of sequences.jacobsthalNumberGenerator(50)) {
    process.stdout.write(`${(++i).toString().padStart(2)}: ${sequenceNumber.toString().padEnd(30)}`)
    if (i % 3 == 0) {
        console.log();
    }
}