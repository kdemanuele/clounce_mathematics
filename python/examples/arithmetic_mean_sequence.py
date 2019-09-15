import sys

sys.path.insert(0, '../lib/')
from sequence_solver import SequenceSolver

if __name__ == "__main__":
    variables = [None] * 4
    SequenceSolver.arithmetic_mean_sequence(45, 100, variables)

    print("Running example from Brilliant 17 March 2019 Daily Challenge")
    print("n the sequence of integers below, each number (starting with b) is the average of the two numbers before it. What is the value of a?")
    print("45, a, b, c, d, 100")
    print("a = {}, b = {}, c = {}, d = {}".format(variables[0], variables[1], variables[2], variables[3]))

    print()
    print()
    print()
    print("Verify the values by direct computation")
    print("a = {}".format(SequenceSolver.arithmetic_mean_sequence_variable(45, 100, 4, 1)))
    print("b = {}".format(SequenceSolver.arithmetic_mean_sequence_variable(45, 100, 4, 2)))
    print("c = {}".format(SequenceSolver.arithmetic_mean_sequence_variable(45, 100, 4, 3)))
    print("d = {}".format(SequenceSolver.arithmetic_mean_sequence_variable(45, 100, 4, 4)))