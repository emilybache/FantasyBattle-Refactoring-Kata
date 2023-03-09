import pytest

from Item import BaseItem


@pytest.fixture
def standard_items():
    return {
        "left_hand":    BaseItem("round shield", 0, 1.4),
        "right_hand":   BaseItem("Excalibur", 20, 1.5),
        "head":         BaseItem("helmet of swiftness", 0, 1.2),
        "feet":         BaseItem("ten league boots", 0, 0.1),
        "chest":        BaseItem("breastplate of steel", 0, 1.4),
    }
