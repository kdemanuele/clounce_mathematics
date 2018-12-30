"use strict";

class Averages {
    static arithmeticMean(sample) {
        let sampleSize = sample.length;

        if (sampleSize == 0 ) {
            return 0;
        }

        let sum = 0;
        for(let i = 0; i < sampleSize; i++) {
            sum += sample[i];
        }

        return sum / sampleSize;
    }
}

module.exports = Averages;