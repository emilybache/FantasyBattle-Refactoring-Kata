from unittest.mock import Mock

import pytest

from Armor import SimpleArmor
from Buff import BasicBuff
from Equipment import Equipment
from Inventory import Inventory
from Player import Player
from Stats import Stats
from Target import Target, SimpleEnemy


@pytest.fixture
def inventory(standard_items):
    inventory = Mock(Inventory)
    equipment = Mock(Equipment)
    inventory.equipment = equipment
    equipment.left_hand = standard_items["left_hand"]
    equipment.right_hand = standard_items["right_hand"]
    equipment.head = standard_items["head"]
    equipment.chest = standard_items["chest"]
    equipment.feet = standard_items["feet"]
    return inventory


def test_damage_calculations_empty_target(inventory):
    stats = Stats(1)
    target = Mock(Target)
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