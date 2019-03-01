var averages = require('../lib/mean_averages.js');
var fs = require('fs');
var readline = require('readline');

let sampleNumber = 1;

var sampleData = readline.createInterface({
    input: fs.createReadStream('../../sample_data'),
    console: false
});

sampleData.on('line', function(line) {
    line = line.trim();
    if (line.length == 0) {
        return;
    }

    let samplePoints = line.split(",");
    let sample = [];

    samplePoints.forEach(element => {
        sample.push(parseFloat(element));
    });

    let average = averages.mode(sample);

    printData(sampleNumber++, sample, average);
});

sampleData.on('close', () => {
    let sample = [];
    for (let i = 0; i < 25; i++) {
        sample.push(Math.ceil((Math.random() * 100) % 10) + 10);
    }

    let average = averages.mode(sample);

    printData(sampleNumber++, sample, average);
});

function printData(sampleNumber, sample, average) {
    console.log('Sample ' + sampleNumber);
    console.log('Sample Data: ' + sample.join(', '));
    console.log('Mode: ' + average);
    console.log();
    console.log();
}