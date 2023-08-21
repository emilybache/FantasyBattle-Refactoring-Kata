#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#include "stats.h"

Stats* create_Stats(int strength)
{
    Stats* stats = malloc(sizeof(*stats));
    stats->strength = strength;

    return stats;
}




