"use strict";

class Averages {
    static arithmeticMean(sample) {
        let sum = 0;
        for(let point of sample) {
            sum += point;
        }

        return sum / sample.length;
    }

    static mode(sample) {
        let counts = {};
        let maxima = 0;

        for(let point of sample) {
            if (typeof counts[point] === 'undefined') {
                counts[point] = 1;
            } else {
                counts[point]++;
            }

            maxima = Math.max(maxima, counts[point]);
        }

        let result = [];

        for(let value in counts) {
            if (counts[value] == maxima) {
                result.push(value);
            }
        }

        return result;
    }

    static median(sample) {
        let sortedArray = sample.slice().sort(function(a,b) { return a - b;});
        let sampleSize = sortedArray.length;
        if (sampleSize == 0) {
            return 0;
        }
        
        let middle = Math.floor(sampleSize / 2);
        if (sampleSize % 2 == 1) {
            return sortedArray[middle];
        }

        // Since the indices of arrays start at 0, we have to deduct 1 from the value obtained
        return (sortedArray[middle - 1] + sortedArray[middle]) / 2;
    }
}

module.exports = Averages;