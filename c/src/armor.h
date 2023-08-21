#ifndef FANTASYBATTLE_ARMOR_H
#define FANTASYBATTLE_ARMOR_H

typedef struct Armor {
    int damage_soak;
} Armor;

Armor* create_Armor(int damage_soak);

#endif //FANTASYBATTLE_ARMOR_H
