import pytest

from Armor import SimpleArmor
from Buff import BasicBuff
from Equipment import Equipment
from Inventory import Inventory
from Item import BaseItem
from Player import Player
from Stats import Stats
from Target import Target, SimpleEnemy
from fixtures import standard_items


@pytest.fixture
def inventory(standard_items):
    equipment = Equipment(
        left_hand=standard_items["left_hand"],
        right_hand=standard_items["right_hand"],
        head=standard_items["head"],
        chest=standard_items["chest"],
        feet=standard_items["feet"],
    )
    inventory = Inventory(equipment)
    return inventory


def test_damage_calculations_empty_target(inventory):
    stats = Stats(1)
    target = Target()
    damage = Player(inventory, stats).calculate_damage(target)
    assert damage.amount == 114


def test_damage_calculations_player_target(inventory):
    stats = Stats(1)
    player = Player(inventory, stats)
    target = player
    damage = player.calculate_damage(target)
    assert damage.amount == 0


def test_damage_calculations_simple_enemy_target(inventory):
    stats = Stats(1)
    player = Player(inventory, stats)
    target = SimpleEnemy(SimpleArmor(5), [BasicBuff(1.0, 1.0)])
    damage = player.calculate_damage(target)
    assert damage.amount == 104
