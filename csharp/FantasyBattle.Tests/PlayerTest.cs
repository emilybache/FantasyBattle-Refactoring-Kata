using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;

namespace FantasyBattle.Tests
{
    public class PlayerTest
    {
        BasicItem leftHand = new BasicItem("round shield", 0, 1.4f);
        BasicItem rightHand = new BasicItem("Excalibur", 20, 1.5f);
        BasicItem head = new BasicItem("helmet of swiftness", 0, 1.2f);
        BasicItem feet = new BasicItem("ten league boots", 0, 0.1f);
        BasicItem chest = new BasicItem("breastplate of steel", 0, 1.4f);

        [Fact]
        public void DamageCalculationsWithMocks()
        {
            var inventory = new Mock<IInventory>();
            var equipment = new Mock<IEquipment>();
            inventory.SetupGet(i => i.Equipment).Returns(equipment.Object);
            equipment.SetupGet(e => e.LeftHand).Returns(leftHand);
            equipment.SetupGet(e => e.RightHand).Returns(rightHand);
            equipment.SetupGet(e => e.Head).Returns(head);
            equipment.SetupGet(e => e.Feet).Returns(feet);
            equipment.SetupGet(e => e.Chest).Returns(chest);
            
            var stats = new Stats(1);
            var target = new Mock<Target>();

            var damage = new Player(inventory.Object, stats).CalculateDamage(target.Object);
            Assert.Equal(114, damage.Amount);
        }
        
        [Fact]
        public void DamageCalculationsWithFake() {
            IInventory inventory = new FakeInventory(new FakeEquipment(leftHand, rightHand, head, feet, chest));
            Stats stats = new Stats(1);
            Target target = new FakeEnemy();
            Damage damage = new Player(inventory, stats).CalculateDamage(target);
            Assert.Equal(114, damage.Amount);
        }
    }
    
    

    public class FakeEnemy : Target
    {
        
    }

    public class FakeInventory : IInventory
    {
        public FakeInventory(IEquipment equipment)
        {
            Equipment = equipment;
        }

        public int CalculateBaseDamage()
        {
            return 10;
        }

        public float CalculateDamageModifier(Player player)
        {
            return 1.0f;
        }

        public IEquipment Equipment { get; }
    }

    public class FakeEquipment : IEquipment
    {
        public FakeEquipment(Item leftHand, Item rightHand, Item head, Item feet, Item chest)
        {
            LeftHand = leftHand;
            RightHand = rightHand;
            Head = head;
            Feet = feet;
            Chest = chest;
        }

        public Item LeftHand { get; }
        public Item RightHand { get; }
        public Item Head { get; }
        public Item Feet { get; }
        public Item Chest { get; }
    }

    public class FakeItem : Item
    {
        public int BaseDamage { get; }
        public float DamageModifier { get; }
    }
}
