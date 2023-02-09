using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;

namespace FantasyBattle.Tests
{
    public class ItemTestData
    {
        public static BasicItem leftHand = new BasicItem("round shield", 0, 1.4f);
        public static BasicItem rightHand = new BasicItem("Excalibur", 20, 1.5f);
        public static BasicItem head = new BasicItem("helmet of swiftness", 0, 1.2f);
        public static BasicItem feet = new BasicItem("ten league boots", 0, 0.1f);
        public static BasicItem chest = new BasicItem("breastplate of steel", 0, 1.4f);
    }

    public class PlayerTestWithStubs
    {
        Mock<IInventory> inventory = new Mock<IInventory>();
        Mock<IEquipment> equipment = new Mock<IEquipment>();

        public PlayerTestWithStubs()
        {
            inventory.SetupGet(i => i.Equipment).Returns(equipment.Object);
            equipment.SetupGet(e => e.LeftHand).Returns(ItemTestData.leftHand);
            equipment.SetupGet(e => e.RightHand).Returns(ItemTestData.rightHand);
            equipment.SetupGet(e => e.Head).Returns(ItemTestData.head);
            equipment.SetupGet(e => e.Feet).Returns(ItemTestData.feet);
            equipment.SetupGet(e => e.Chest).Returns(ItemTestData.chest);
        }
        
        [Fact]
        public void DamageCalculationsWithEmptyTarget()
        {
            var stats = new Stats(1);
            var target = new Mock<Target>();

            var damage = new Player(inventory.Object, stats).CalculateDamage(target.Object);
            
            Assert.Equal(114, damage.Amount);
        }
        
        [Fact]
        public void DamageCalculationsWithPlayerTarget()
        {
            var stats = new Stats(1);
            var player = new Player(inventory.Object, stats);
            var target = player;
            
            var damage = player.CalculateDamage(target);
            
            Assert.Equal(0, damage.Amount);
        }        
        [Fact]
        public void DamageCalculationsWithSimpleEnemyTarget()
        {
            var stats = new Stats(1);
            var player = new Player(inventory.Object, stats);
            var target = new SimpleEnemy(new SimpleArmor(5), new List<Buff>{new BasicBuff(1.0f, 1.0f)});
            
            var damage = player.CalculateDamage(target);
            
            Assert.Equal(104, damage.Amount);
        }
    }

    public class PlayerTestWithFakes
    {
        private FakeInventory inventory;
        private FakeEquipment equipment;
        
        public PlayerTestWithFakes()
        {
            equipment = new FakeEquipment(ItemTestData.leftHand, ItemTestData.rightHand,
                ItemTestData.head, ItemTestData.feet, ItemTestData.chest);
            inventory = new FakeInventory(equipment);
        }
        [Fact]
        public void DamageCalculationsWithEmptyTarget()
        {
            var stats = new Stats(1);
            Target target = new FakeEnemy();
            
            var damage = new Player(inventory, stats).CalculateDamage(target);
            
            Assert.Equal(114, damage.Amount);
        }
        [Fact]
        public void DamageCalculationsWithPlayerTarget()
        {
            var stats = new Stats(1);
            var player = new Player(inventory, stats);
            Target target = player;
            
            var damage = player.CalculateDamage(target);
            
            Assert.Equal(0, damage.Amount);
        }        [Fact]
        public void DamageCalculationsWithSimpleEnemyTarget()
        {
            var stats = new Stats(1);
            var player = new Player(inventory, stats);
            var target = new SimpleEnemy(new SimpleArmor(5), new List<Buff>{new BasicBuff(1.0f, 1.0f)});

            var damage = player.CalculateDamage(target);
            
            Assert.Equal(104, damage.Amount);
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
}