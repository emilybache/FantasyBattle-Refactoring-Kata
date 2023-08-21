#ifndef FANTASYBATTLE_BUFF_H
#define FANTASYBATTLE_BUFF_H

typedef struct Buff {
    float soak_modifier;
    float damage_modifier;
} Buff;

Buff* create_Buff(float soak_modifier, float damage_modifier);

#endif //FANTASYBATTLE_BUFF_H
