Equipment := Object clone do(
    // TODO add a ring item that may be equipped
    // that may also add damage modifier

    leftHand := nil
    rightHand := nil
    head := nil
    feet := nil
    chest := nil

    with := method(leftHand, rightHand, head, feet, chest,
        result := self clone
        result leftHand = leftHand
        result rightHand = rightHand
        result head = head
        result feet = feet
        result chest = chest
        result
    )

    getLeftHand := method(leftHand)
    getRightHand := method(rightHand)
    getHead := method(head)
    getFeet := method(feet)
    getChest := method(chest)

)
