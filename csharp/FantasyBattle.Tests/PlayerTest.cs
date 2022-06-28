using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;

namespace FantasyBattle.Tests
{
    public class PlayerTest
    {
        [Fact]
        public void DamageCalculationsWithMocks()
        {
            var inventory = new Mock<IInventory>();
            inventory.Setup(i => i.CalculateBaseDamage()).Returns(10);
            inventory.Setup(i => i.CalculateDamageModifier(It.IsAny<Player>())).Returns(1);
            var stats = new Stats(1);
            var target = new Mock<Target>();
            target.Setup(t => t.GetSoak(It.IsAny<int>())).Returns(1);

            var damage = new Player(inventory.Object, stats).CalculateDamage(target.Object);
            Assert.Equal(9, damage.Amount);
        }
        
        [Fact]
        public void DamageCalculations() {
            Inventory inventory = new FakeInventory();
            Stats stats = new Stats(0);
            Target target = new FakeEnemy();
            Damage damage = new Player(inventory, stats).CalculateDamage(target);
            Assert.Equal(10, damage.Amount);
        }
    }
    
    

    public class FakeEnemy : Target
    {
        public override int GetSoak(int totalDamage)
        {
            return 0;
        }

    }

    public class FakeInventory : Inventory
    {
        public FakeInventory() : base(null)
        {
        }

        public override int CalculateBaseDamage()
        {
            return 10;
        }

        public override float CalculateDamageModifier(Player player)
        {
            return 1.0f;
        }
    }
}
