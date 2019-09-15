"use strict"

class Sequences {
    static jacobsthalNumber(position) {
        if (position === undefined || isNaN(position) || position < 0) {
            return 0;
        }

        if (position === 0) return 0;
        if (position === 1) return 1;

        return 2 * this.jacobsthalNumber(position - 2) + this.jacobsthalNumber(position - 1);
    }

    static jacobsthalNumberNonRecursive(position) {
        if (position === undefined || isNaN(position) || position < 0) {
            return 0;
        }

        return ((2 ** position) - ((-1) ** position)) / 3;
    }

    static * jacobsthalNumberGenerator(maxPosition) {
        if (maxPosition === undefined || isNaN(maxPosition) || maxPosition < 1) {
            return 0;
        }

        let preLastPosition = 0;
        let lastPosition = 1;
        for (let position = 0; position <= maxPosition; position++) {
            if (position === 0) yield preLastPosition;
            if (position === 1) yield lastPosition;

            let newSequenceNumber = 2 * preLastPosition + lastPosition;
            preLastPosition = lastPosition;
            lastPosition = newSequenceNumber;

            yield newSequenceNumber;
        }
    }

    static * jacobsthalNumberNonRecursiveGenerator(maxPosition) {
        if (maxPosition === undefined || isNaN(maxPosition) || maxPosition < 1) {
            return 0;
        }

        for (let position = 0; position <= maxPosition; position++) {
            yield ((2 ** position) - ((-1) ** position)) / 3;
        }
    }
}

module.exports = Sequences;