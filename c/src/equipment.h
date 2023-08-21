#ifndef FANTASYBATTLE_EQUIPMENT_H
#define FANTASYBATTLE_EQUIPMENT_H

#include "item.h"

typedef struct Equipment {
    Item* left_hand;
    Item* right_hand;
    Item* head;
    Item* chest;
    Item* feet;
} Equipment;

Equipment* create_Equipment(Item* left_hand, Item* right_hand, Item* head, Item* chest, Item* feet);

#endif //FANTASYBATTLE_EQUIPMENT_H
