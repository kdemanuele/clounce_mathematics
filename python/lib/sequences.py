import math

class Sequences:
    @staticmethod
    def jacobsthal_number(position):
        if position == 1:
            return 0
        
        if position == 2:
            return 1

        return 2 * Sequences.jacobsthal_number(position - 2) + Sequences.jacobsthal_number(position - 1)
    
    @staticmethod
    def jacobsthal_number_frey_sellers(position):
        return (pow(2, position + 1) + pow(-1, position)) / 3

    @staticmethod
    def jacobsthal_number_babago(position):
        return (pow(2, position) - pow(-1, position)) / 3

    @staticmethod
    def jacobsthal_number_generator(max_position):
        pre_last_position = 0
        last_position = 1
        for position in range(1, max_position):
            if position == 1:
                yield 0
            
            if position == 2:
                yield 1
            
            new_jacobsthal_number = 2 * pre_last_position + last_position
            pre_last_position = last_position
            last_position = new_jacobsthal_number

            yield new_jacobsthal_number

    @staticmethod
    def jacobsthal_number_frey_sellers_generator(max_position):
        for position in range(1, max_position):
            yield (pow(2, position + 1) + pow(-1, position)) / 3

            
    @staticmethod
    def jacobsthal_number_babago_generator(max_position):
        for position in range(1, max_position):
            yield (pow(2, position) - pow(-1, position)) / 3