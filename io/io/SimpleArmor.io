SimpleArmor := Object clone do(

    soak := 0

    with := method(soak,
        result := self clone
        result soak = soak
        result
    )

    getDamageSoak := method(
        soak
    )

)
