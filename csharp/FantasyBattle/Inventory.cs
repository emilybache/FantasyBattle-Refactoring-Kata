namespace FantasyBattle
{
    public interface IInventory
    {
        int CalculateBaseDamage();
        float CalculateDamageModifier(Player player);
    }

    public class Inventory : IInventory
    {
        public Equipment Equipment { get; }

        public Inventory()
        {
        }

        public Inventory(Equipment equipment)
        {
            Equipment = equipment;
        }

        public virtual int CalculateBaseDamage() {
            Equipment equipment = this.Equipment;
            Item leftHand = equipment.LeftHand;
            Item rightHand = equipment.RightHand;
            Item head = equipment.Head;
            Item feet = equipment.Feet;
            Item chest = equipment.Chest;
            return leftHand.BaseDamage +
                   rightHand.BaseDamage +
                   head.BaseDamage +
                   feet.BaseDamage +
                   chest.BaseDamage;
        }

        public virtual float CalculateDamageModifier(Player player) {
            Equipment equipment = this.Equipment;
            Item leftHand = equipment.LeftHand;
            Item rightHand = equipment.RightHand;
            Item head = equipment.Head;
            Item feet = equipment.Feet;
            Item chest = equipment.Chest;
            float strengthModifier = player.Stats.Strength * 0.1f;
            return strengthModifier +
                   leftHand.DamageModifier +
                   rightHand.DamageModifier +
                   head.DamageModifier +
                   feet.DamageModifier +
                   chest.DamageModifier;
        }
    }

    public class Equipment
    {
        // TODO add a ring item that may be equipped
        //  that may also add damage modifier
        public Item LeftHand { get; }
        public Item RightHand { get; }
        public Item Head { get; }
        public Item Feet { get; }
        public Item Chest { get; }

        public Equipment(Item leftHand, Item rightHand, Item head, Item feet, Item chest)
        {
            LeftHand = leftHand;
            RightHand = rightHand;
            Head = head;
            Feet = feet;
            Chest = chest;
        }
    }

    public interface Item
    {
        int BaseDamage { get; }
        float DamageModifier { get; }
    }
}