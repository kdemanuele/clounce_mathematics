namespace ClounceMath {
    using System.Collections.Generic;

    public sealed class Sequences {
        static public ulong JacobsthalNumber(int position) {
            if (position == 1) {
                return 0;
            }

            if (position == 2) {
                return 1;
            }

            return 2*JacobsthalNumber(position - 2) + JacobsthalNumber(position - 1);
        }

        static public IEnumerable<ulong> JacobsthalNumberGenerator(int maxPosition) {
            ulong preLastPosition = 0, lastPosition = 1;
            for (int position = 1; position < maxPosition; position++) {
                if (position == 1) {
                    yield return preLastPosition;
                }

                if (position == 2) {
                    yield return lastPosition;
                }
                
                var newSequenceNumber = 2 * preLastPosition + lastPosition;
                preLastPosition = lastPosition;
                lastPosition = newSequenceNumber;

                yield return newSequenceNumber;
            }
        }
    }
}