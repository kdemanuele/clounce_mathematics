import math
from sequences import Sequences

class SequenceSolver:
    @staticmethod
    def arithmetic_mean_sequence(sequence_start_value, sequence_end_value, variables):
        number_of_variables = len(variables)

        if (variables is None or number_of_variables == 0) :
            return 0
        
        sequence_number = Sequences.jacobsthal_number_non_recursive(number_of_variables)
        next_sequence_number = Sequences.jacobsthal_number_non_recursive(number_of_variables + 1)

        variables[0] = (((2 ** number_of_variables) * sequence_end_value) - (sequence_number * sequence_start_value)) / next_sequence_number

        for i in range(1, number_of_variables):
            sequence_number = Sequences.jacobsthal_number_non_recursive(i)
            next_sequence_number = Sequences.jacobsthal_number_non_recursive(i + 1)
            variables[i] = ((sequence_number * sequence_start_value) + (next_sequence_number * variables[0])) / 2 ** i
    
    @staticmethod
    def arithmetic_mean_sequence_variable(sequence_start_value, sequence_end_value, number_of_variables, variable_to_solve):
        if (number_of_variables == 0 or variable_to_solve > number_of_variables):
            return 0
        
        nth_jacobsthal = Sequences.jacobsthal_number_non_recursive(variable_to_solve)
        pre_nth_jacobsthal = Sequences.jacobsthal_number_non_recursive(variable_to_solve - 1)
        size_var_jacobsthal = Sequences.jacobsthal_number_non_recursive(number_of_variables)
        next_size_var_jacobsthal = Sequences.jacobsthal_number_non_recursive(number_of_variables + 1)
        
        y_calculation = (2  ** number_of_variables) * nth_jacobsthal * sequence_end_value
        x_calculation = ((pow(-1, variable_to_solve) * size_var_jacobsthal) \
            + (pow(-1, number_of_variables) * pre_nth_jacobsthal)) * sequence_start_value
        numerator = y_calculation + x_calculation
        denominator = next_size_var_jacobsthal * (2 ** (variable_to_solve - 1))

        return numerator / denominator