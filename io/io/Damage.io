Damage := Object clone do(

    amount := 0

    with := method(amount,
        result := self clone
        result amount = amount
        result
    )

    getAmount := method( amount )
    
)
