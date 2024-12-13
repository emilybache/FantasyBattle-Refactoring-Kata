SimpleEnemy := Target clone do(

    init := method(
        self armor ::= nil
        self buffs ::= list()
    )

    with := method(armor, buffs,
        result := self clone
        result armor = armor
        result buffs = buffs
        result
    )

)
