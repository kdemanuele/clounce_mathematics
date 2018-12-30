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

    let average = averages.arithmeticMean(sample);

    printData(sampleNumber++, sample, average);
});

function printData(sampleNumber, sample, average) {
    console.log('Sample ' + sampleNumber);
    console.log('Sample Data: ' + sample.join(', '));
    console.log('Arithmetic Mean: ' + average);
    console.log();
    console.log();
}