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
}

module.exports = Averages;