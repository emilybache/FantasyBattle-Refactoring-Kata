#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#include "damage.h"

Damage* create_Damage(int amount)
{
    Damage* damage = malloc(sizeof(*damage));
    damage->amount = amount;

    return damage;
}



