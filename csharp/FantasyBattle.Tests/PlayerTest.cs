using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;

namespace FantasyBattle.Tests
{
    public class PlayerTest
    {
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
        public override int CalculateSoak(int totalDamage, int soak)
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
