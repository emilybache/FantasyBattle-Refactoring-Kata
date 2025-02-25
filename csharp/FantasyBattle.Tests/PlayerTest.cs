using System.Collections.Generic;
using System.Text;
using Moq;
using NSubstitute;
using Xunit;

namespace FantasyBattle.Tests
{
    /*
     * Helpful test data which corresponds to items listed in the top level README file
     */
    public class TestData
    {
        public static BasicItem shield = new BasicItem("round shield", 0, 1.4f);
        public static BasicItem sword = new BasicItem("Flashy sword of danger", 10, 1.0f);
        public static BasicItem excalibur = new BasicItem("Excalibur", 20, 1.5f);
        public static BasicItem helmet = new BasicItem("helmet of swiftness", 0, 1.2f);
        public static BasicItem boots = new BasicItem("ten league boots", 0, 0.1f);
        public static BasicItem breastplate = new BasicItem("breastplate of steel", 0, 1.4f);
        public static SimpleEnemy enemy = new SimpleEnemy(
            new SimpleArmor(5), 
            new List<Buff>() {new BasicBuff(1.0f, 1.0f)}
            );
    }
    
    public class PlayerTest
    {

        // choose this one if you are familiar with mocks
        [Fact(Skip = "Test is not finished yet")]
        public void DamageCalculationsWithMocks() {
            var inventory = new Mock<Inventory>();
            var stats = new Mock<Stats>();
            var target = new Mock<SimpleEnemy>();

            var damage = new Player(inventory.Object, stats.Object).CalculateDamage(target.Object);
            Assert.Equal(10, damage.Amount);
        }

        // choose this one if you are not familiar with mocks
        [Fact(Skip = "Test is not finished yet")]
        public void DamageCalculations() {
            Inventory inventory = new Inventory(null);
            Stats stats = new Stats(0);
            SimpleEnemy target = new SimpleEnemy(null, null);
            Damage damage = new Player(inventory, stats).CalculateDamage(target);
            Assert.Equal(10, damage.Amount);
        }
    }
}
