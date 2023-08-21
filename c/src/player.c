#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#include "player.h"

#define max(x,y) ((x>y)?x:y)

Player* create_Player(Stats* stats, Inventory* inventory)
{
    Player* player = malloc(sizeof(*player));
    player->stats = stats;
    player->inventory = inventory;

    return player;
}

Damage *calculate_damage(Player *self, Player *other) {
    int base_damage = get_base_damage(self);
    float damage_modifier = get_damage_modifier(self);
    float total_damage = base_damage * damage_modifier;
    float soak = get_soak(self, other, total_damage);
    Damage* damage = create_Damage(max(0, total_damage - soak));
    return damage;
}

int get_base_damage(Player *self) {
    return 0;
}

float get_damage_modifier(Player *self) {
    return 0;
}

int get_soak(Player* self, Player *other, int totalDamage) {
    return 0;
}





