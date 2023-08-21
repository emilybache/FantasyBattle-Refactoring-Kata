#include <stdlib.h>
#include <string.h>
#include <stdbool.h>


#include "equipment.h"

Equipment* create_Equipment(Item* left_hand, Item* right_hand, Item* head, Item* chest, Item* feet)
{
    Equipment* equipment = malloc(sizeof(*equipment));
    equipment->left_hand = left_hand;
    equipment->right_hand = right_hand;
    equipment->head = head;
    equipment->chest = chest;
    equipment->feet = feet;

    return equipment;
}

