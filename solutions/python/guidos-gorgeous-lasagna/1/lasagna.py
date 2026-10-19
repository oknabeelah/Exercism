
EXPECTED_BAKE_TIME = 40

def bake_time_remaining(elapsed_bake_time):
    """time left to bake"""
    return EXPECTED_BAKE_TIME - elapsed_bake_time

def preparation_time_in_minutes(number_of_layers):
    """how long it took to make the layers"""
    return 2 * number_of_layers

def elapsed_time_in_minutes(number_of_layers, elapsed_bake_time):
    """ total cooking time"""
    return preparation_time_in_minutes(number_of_layers) + elapsed_bake_time
