#ifndef FANTASYBATTLE_ITEM_H
#define FANTASYBATTLE_ITEM_H

#define MAX_NAME_LENGTH 100

typedef struct Item {
    char name[MAX_NAME_LENGTH];
    int base_damage;
    int damage_modifier;
} Item;

Item* create_Item(char* name, int base_damage, int damage_modifier);

#endif //FANTASYBATTLE_ITEM_H
