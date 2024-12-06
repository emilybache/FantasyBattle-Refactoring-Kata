from typing import List


class Armor:
    damage_soak: int


class SimpleArmor(Armor):
    def __init__(self, damage_soak):
        self.damage_soak = damage_soak


class Buff:
    soak_modifier: float
    damage_modifier: float


class BasicBuff(Buff):
    def __init__(self, soak_modifier: float, damage_modifier: float) -> None:
        self.soak_modifier = soak_modifier
        self.damage_modifier = damage_modifier


class Item:
    base_damage: int
    damage_modifier: float


class BaseItem(Item):
    name: str

    def __init__(
            self,
            name: str,
            base_damage: int,
            damage_modifier: float
    ) -> None:
        self.name = name
        self.base_damage = base_damage
        self.damage_modifier = damage_modifier
