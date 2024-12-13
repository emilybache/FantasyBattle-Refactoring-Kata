Stats := Object clone do(
    // TODO add dexterity that will both help with soak and damage
    // but half of what strength gives

    strength ::= 0

    with := method(strength,
        result := self clone
        result strength = strength
        result
    )

)
