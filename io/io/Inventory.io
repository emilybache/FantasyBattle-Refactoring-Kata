Inventory := Object clone do(

    equipment ::= nil

    with := method(equipment,
        result := self clone
        result equipment = equipment
        result
    )

)
