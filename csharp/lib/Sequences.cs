namespace ClounceMath {
    using System;
    using System.Collections.Generic;

    public sealed class Sequences {
        static public ulong JacobsthalNumber(int position) {
            if (position <= 0) {
                return 0;
            }

            if (position == 1) {
                return 1;
            }

            return 2*JacobsthalNumber(position - 2) + JacobsthalNumber(position - 1);
        }

        static public ulong JacobsthalNumberNonRecursive(int position) {
            return Convert.ToUInt64((Math.Pow(2, position) - Math.Pow(-1, position)) / 3);
        }

        static public IEnumerable<ulong> JacobsthalNumberGenerator(int maxPosition) {
            ulong preLastPosition = 0, lastPosition = 1;
            for (int position = 0; position <= maxPosition; position++) {
                if (position == 0) {
                    yield return preLastPosition;
                }

                if (position == 1) {
                    yield return lastPosition;
                }
                
                var newSequenceNumber = 2 * preLastPosition + lastPosition;
                preLastPosition = lastPosition;
                lastPosition = newSequenceNumber;

                yield return newSequenceNumber;
            }
        }

        static public IEnumerable<ulong> JacobsthalNumberNonRecursiveGenerator(int maxPosition) {
            for (int position = 0; position <= maxPosition; position++) {
                yield return Convert.ToUInt64((Math.Pow(2, position) - Math.Pow(-1, position)) / 3);
            }
        }

        static public double KappaNumber(int maxPosition, int position) {
            return Math.Pow(2, maxPosition) * (JacobsthalNumber(position) / Math.Pow(2d, position - 1));
        }
        
        static public IEnumerable<double> KappaNumberGenerator(int maxPosition) {
            for (int position = 1; position <= maxPosition; position++) {
                yield return KappaNumber(maxPosition, position);
            }
        }
    }
}