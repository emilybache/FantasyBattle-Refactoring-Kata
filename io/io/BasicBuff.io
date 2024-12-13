BasicBuff := Object clone do(

    soak := 0
    damage := 0

    with := method(soak, damage,
        result := self clone
        result soak = soak
        result damage = damage
        result
    )


    soakModifier := method(
        soak
    )


    damageModifier := method(
        damage
    )

)
