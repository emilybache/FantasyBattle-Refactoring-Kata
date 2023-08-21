#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#include "armor.h"

Armor* create_Armor(int damage_soak)
{
    Armor* armor = malloc(sizeof(*armor));
    armor->damage_soak = damage_soak;

    return armor;
}



