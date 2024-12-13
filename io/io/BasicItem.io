BasicItem := Object clone do(

    name := ""
    baseDamage ::= 0
    damageModifier := 0

    with := method(name, baseDamage, damageModifier,
        result := self clone
        result name = name
        result baseDamage = baseDamage
        result damageModifier = damageModifier
        result
    )

)
