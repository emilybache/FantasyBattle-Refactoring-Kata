
#include <string>
#include <vector>

#include "gtest/gtest.h"
#include "../model/Player.h"
#include "../model/Damage.h"
#include "../model/Inventory.h"
#include "../model/Stats.h"
#include "../model/SimpleEnemy.h"
#include "../model/BasicItem.h"
#include "../model/BasicBuff.h"
#include "../model/SimpleArmor.h"

using namespace std;

// Helpful test data which corresponds to items listed in the top level README file
BasicItem shield = BasicItem("round shield", 0, 1.4f);
BasicItem sword = BasicItem("Flashy sword of danger", 10, 1.0f);
BasicItem excalibur = BasicItem("Excalibur", 20, 1.5f);
BasicItem helmet = BasicItem("helmet of swiftness", 0, 1.2f);
BasicItem boots = BasicItem("ten league boots", 0, 0.1f);
BasicItem breastplate = BasicItem("breastplate of steel", 0, 1.4f);
std::vector<Buff *> buffs = {new BasicBuff(1.0f, 1.0f)};
SimpleArmor armor = SimpleArmor(5);
SimpleEnemy enemy = SimpleEnemy(&armor, buffs);


TEST(PlayerTest, DamageCalculations) {

    //TODO: finish this test case

    auto inventory = new Inventory(/*todo*/);
    auto stats = new Stats(0);
    auto target = new SimpleEnemy(/*todo*/, /*todo*/);

    auto player =  new Player(*inventory, *stats);
    Damage *damage = player->calculateDamage(*target);

    ASSERT_EQ(10, damage->getAmount());
}
