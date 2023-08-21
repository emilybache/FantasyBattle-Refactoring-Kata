#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#include "item.h"

Item *create_Item(char *name, int base_damage, int damage_modifier) {
    Item* item = malloc(sizeof(*item));
    strncpy(item->name, name, sizeof(item->name) - 1);
    item->base_damage = base_damage;
    item->damage_modifier = damage_modifier;

    return item;
}