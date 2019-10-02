var sequences = require('../lib/sequences.js');

let i = 1;
for (let sequenceNumber of sequences.kappaNumberGenerator(9)) {
    process.stdout.write(`k(9, ${(i++).toString().padStart(2)}): ${sequenceNumber.toString().padEnd(30)}`)
    if (i % 3 == 1) {
        console.log();
    }
}

console.log("Using direct computation");
for (let position = 1; position <= 9; ) {
    process.stdout.write(`k(9, ${(position++).toString().padStart(2)}): ${sequences.kappaNumber(9, position).toString().padEnd(30)}`)
    if (position % 3 === 1) {
        console.log();
    }
}