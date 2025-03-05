Importer addSearchPath(File thisSourceFile parentDirectory path .. "/../../io")

/*
 * Helpful test data which corresponds to items listed in the top level README file
 */
TestData := Object clone do(
    shield := BasicItem with("round shield", 0, 1.4)
    sword := BasicItem with("Flashy sword of danger", 10, 1.0)
    excalibur := BasicItem with("Excalibur", 20, 1.5)
    helmet := BasicItem with("helmet of swiftness", 0, 1.2)
    boots := BasicItem with("ten league boots", 0, 0.1)
    breastplate := BasicItem with("breastplate of steel", 0, 1.4)

    enemy := SimpleEnemy with(
            SimpleArmor with(5),
            list(BasicBuff with(1.0, 1.0))
    )
)

PlayerTest := UnitTest clone do(

    testDamageCalculations := method(
        knownBug("Test is not finished yet")

        inventory := Inventory with(nil)
        stats := Stats with(0)
        player := Player with(inventory, stats)

        damage := player calculateDamage(nil)

        assertEquals(9, damage getAmount)
    )

)
