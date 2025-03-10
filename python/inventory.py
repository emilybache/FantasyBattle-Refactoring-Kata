from gear import Item


class Inventory:
    def __init__(self, equipment):
        self.equipment = equipment


class Equipment:

    def __init__(
        self,
        left_hand: Item,
        right_hand: Item,
        head: Item,
        chest: Item,
        feet: Item
    ) -> None:
        self.chest = chest
        self.feet = feet
        self.left_hand = left_hand
        self.right_hand = right_hand
        self.head = head
