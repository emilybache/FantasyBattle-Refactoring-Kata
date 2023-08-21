#ifndef FANTASYBATTLE_INVENTORY_H
#define FANTASYBATTLE_INVENTORY_H

#include "equipment.h"

typedef struct Inventory {
    Equipment* equipment;
} Inventory;

Inventory* create_Inventory(Equipment* equipment);

#endif //FANTASYBATTLE_INVENTORY_H
