Player := Target clone do(

    inventory := nil
    stats := nil

    with := method(inventory, stats,
        result := self clone
        result inventory = inventory
        result stats = stats
        result
    )

    calculateDamage := method(other,
        baseDamage := getBaseDamage
        damageModifier := getDamageModifier
        totalDamage := (baseDamage * damageModifier) round
        soak := getSoak(other, totalDamage)
        
        Damage with((totalDamage - soak) max(0))
    )

    getSoak := method(other, totalDamage,
        soak := 0

        if (other type == "Player",
            // TODO: Not implemented yet
            // Add friendly fire
            soak = totalDamage
        )
        if (other type == "SimpleEnemy",
            soak = (other getArmor getDamageSoak *
                    (other getBuffs map(soakModifier) sum + 1.0)) round
        )

        soak
    )

    getDamageModifier := method(
        equipment := self inventory getEquipment

        leftHand := equipment getLeftHand
        rightHand := equipment getRightHand
        head := equipment getHead
        feet := equipment getFeet
        chest := equipment getChest
        strengthModifier := stats getStrength * 0.1

        strengthModifier +
            leftHand getDamageModifier +
            rightHand getDamageModifier +
            head getDamageModifier +
            feet getDamageModifier +
            chest getDamageModifier
    )

    getBaseDamage := method(
        equipment := self inventory getEquipment
        
        leftHand := equipment getLeftHand
        rightHand := equipment getRightHand
        head := equipment getHead
        feet := equipment getFeet
        chest := equipment getChest
        
        leftHand getBaseDamage +
            rightHand getBaseDamage +
            head getBaseDamage +
            feet getBaseDamage +
            chest getBaseDamage
    )

)
