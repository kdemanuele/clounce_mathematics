import math
from sequences import Sequences

class SequenceSolver:
    @staticmethod
    def arithmetic_mean_sequence(sequence_start_value, sequence_end_value, variables):
        number_of_variables = len(variables)

        if (variables is None or number_of_variables == 0) :
            return 0
        
        # Jacobsthal numbers start at J(0) however the algorithm needs to start at J(1)
        sequence_number = Sequences.jacobsthal_number_frey_sellers(number_of_variables + 1)
        next_sequence_number = Sequences.jacobsthal_number_frey_sellers(number_of_variables + 2)

        variables[0] = (((2 ** number_of_variables) * sequence_end_value) - (sequence_number * sequence_start_value)) / next_sequence_number

        for i in range(1, number_of_variables):
            sequence_number = Sequences.jacobsthal_number_frey_sellers(i + 1)
            next_sequence_number = Sequences.jacobsthal_number_frey_sellers(i + 2)
            variables[i] = ((sequence_number * sequence_start_value) + (next_sequence_number * variables[0])) / 2 ** i
    
    @staticmethod
    def arithmetic_mean_sequence_variable(sequence_start_value, sequence_end_value, number_of_variables, variable_to_solve):
        if (number_of_variables == 0 or variable_to_solve > number_of_variables):
            return 0
        
        # Jackobsthal Sequence Generator starts at J(0), however for the calculations
        # the sequence needs to start from J(1). Thus the varlues in the parameters are
        # corrected with an addition of 1 to shift the sequence
        nth_jacobsthal = Sequences.jacobsthal_number_frey_sellers(variable_to_solve + 1)
        pre_nth_jacobsthal = Sequences.jacobsthal_number_frey_sellers(variable_to_solve)
        size_var_jacobsthal = Sequences.jacobsthal_number_frey_sellers(number_of_variables + 1)
        next_size_var_jacobsthal = Sequences.jacobsthal_number_frey_sellers(number_of_variables + 2)
        
        y_calculation = (2  ** number_of_variables) * nth_jacobsthal * sequence_end_value
        x_calculation = ((math.pow(-1, variable_to_solve) * size_var_jacobsthal) \
            + (math.pow(-1, number_of_variables) * pre_nth_jacobsthal)) * sequence_start_value
        numerator = y_calculation + x_calculation
        denominator = next_size_var_jacobsthal * (2 ** (variable_to_solve - 1))

        return numerator / denominator