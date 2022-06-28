using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;

namespace FantasyBattle.Tests
{
    public class PlayerTest
    {

        // choose this one if you are familiar with mocks
        [Fact(Skip = "Test is not finished yet")]
        public void DamageCalculationsWithMocks() {
            var inventory = new Mock<Inventory>();
            var stats = new Stats(1);
            var target = new Mock<Target>();

            var damage = new Player(inventory.Object, stats).CalculateDamage(target.Object);
            Assert.Equal(9, damage.Amount);
        }

        // choose this one if you are not familiar with mocks
        [Fact(Skip = "Test is not finished yet")]
        public void DamageCalculations() {
            Inventory inventory = new Inventory(null);
            Stats stats = new Stats(1);
            Target target = new SimpleEnemy(null, null);
            Damage damage = new Player(inventory, stats).CalculateDamage(target);
            Assert.Equal(9, damage.Amount);
        }
    }
}
