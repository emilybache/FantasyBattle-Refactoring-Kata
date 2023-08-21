#ifndef FANTASYBATTLE_PLAYER_H
#define FANTASYBATTLE_PLAYER_H

#include "stats.h"
#include "inventory.h"
#include "damage.h"

typedef struct Player {
    Stats* stats;
    Inventory* inventory;
} Player;

Player* create_Player(Stats* stats, Inventory* inventory);

Damage* calculate_damage(Player* self, Player* target);

int get_base_damage(Player* self);
float get_damage_modifier(Player* self);
int get_soak(Player* self, Player* other, int totalDamage);

#endif //FANTASYBATTLE_PLAYER_H
