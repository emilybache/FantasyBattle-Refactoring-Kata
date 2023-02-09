namespace FantasyBattle
{
    public interface IInventory
    {
        IEquipment Equipment { get; }
    }

    public class Inventory : IInventory
    {
        public IEquipment Equipment { get; }

        public Inventory()
        {
        }

        public Inventory(IEquipment equipment)
        {
            Equipment = equipment;
        }
        
    }
}