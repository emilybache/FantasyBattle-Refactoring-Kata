#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#include "inventory.h"


Inventory* create_Inventory(Equipment* equipment) {
    Inventory * inventory = malloc(sizeof(*inventory));
    inventory->equipment = equipment;

    return inventory;
}
