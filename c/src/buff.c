#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#include "buff.h"

Buff* create_Buff(float soak_modifier, float damage_modifier)
{
    Buff* buff = malloc(sizeof(*buff));
    buff->soak_modifier = soak_modifier;
    buff->damage_modifier = damage_modifier;

    return buff;
}


