import pytest

from Armor import SimpleArmor
from Buff import BasicBuff
from Equipment import Equipment
from Item import Item
from Player import Player
from Stats import Stats
from Target import Target, SimpleEnemy
from test_player_with_stubs import standard_items


class FakeEquipment(Equipment):

    def __init__(self, left_hand: Item, right_hand: Item, head: Item, chest: Item, feet: Item) -> None:
        self.feet = feet
        self.chest = chest
        self.head = head
        self.right_hand = right_hand
        self.left_hand = left_hand


class FakeInventory:

    def __init__(self, equipment) -> None:
        self.equipment = equipment


@pytest.fixture
def inventory(standard_items):
    equipment = FakeEquipment(
        standard_items["left_hand"],
        standard_items["right_hand"],
        standard_items["head"],
        standard_items["chest"],
        standard_items["feet"],
    )
    inventory = FakeInventory(equipment)
    return inventory


class FakeEnemy(Target):
    pass


def test_damange_calculation_empty_target(inventory):
    stats = Stats(1)
    target = FakeEnemy()
    player = Player(inventory, stats)
    damage = player.calculate_damage(target)
    assert damage.amount == 114


def test_damage_calculation_player_target(inventory):
    stats = Stats(1)
    player = Player(inventory, stats)
    target = player
    damage = player.calculate_damage(target)
    assert damage.amount == 0


def test_damage_calculation_simple_enemy_target(inventory):
    stats = Stats(1)
    player = Player(inventory, stats)
    target = SimpleEnemy(SimpleArmor(5), [BasicBuff(1.0, 1.0)])
    damage = player.calculate_damage(target)
    assert damage.amount == 104
