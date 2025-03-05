import pytest

from enemy import SimpleEnemy
from inventory import Inventory
from player import Player, Stats
from gear import *

# Helpful test data which corresponds to items listed in the top level README file

def standard_items():
    return {
        "left_hand": BaseItem("round shield", 0, 1.4),
        "right_hand": BaseItem("Excalibur", 20, 1.5),
        "head": BaseItem("helmet of swiftness", 0, 1.2),
        "feet": BaseItem("ten league boots", 0, 0.1),
        "chest": BaseItem("breastplate of steel", 0, 1.4),
    }

def enemy():
    return SimpleEnemy(SimpleArmor(5), [BasicBuff(1.0, 1.0)])


@pytest.mark.skip(reason="Test is not finished yet")
def test_damage_calculations():
    inventory = Inventory(None)
    stats = Stats(1)
    player = Player(inventory, stats)

    damage = player.calculate_damage(None)

    assert damage.amount == 9
