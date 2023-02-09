namespace FantasyBattle
{
    public interface IEquipment
    {
        Item LeftHand { get; }
        Item RightHand { get; }
        Item Head { get; }
        Item Feet { get; }
        Item Chest { get; }
    }

    public class Equipment : IEquipment
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
}