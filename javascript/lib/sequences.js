"use strict"

class Sequences {
    static jacobsthalNumber(position) {
        if (position === undefined || isNaN(position) || position < 1) {
            return 0;
        }

        if (position === 1) return 0;
        if (position === 2) return 1;

        return 2 * this.jacobsthalNumber(position - 2) + this.jacobsthalNumber(position - 1);
    }

    static * jacobsthalNumberGenerator(maxPosition) {
        if (maxPosition === undefined || isNaN(maxPosition) || maxPosition < 1) {
            return 0;
        }

        let preLastPosition = 0;
        let lastPosition = 1;
        for (let position = 1; position < maxPosition; position++) {
            if (position === 1) yield preLastPosition;
            if (position === 2) yield lastPosition;

            let newSequenceNumber = 2 * preLastPosition + lastPosition;
            preLastPosition = lastPosition;
            lastPosition = newSequenceNumber;

            yield newSequenceNumber;
        }
    }
}

module.exports = Sequences;