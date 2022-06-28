using System;
using System.Linq;

namespace FantasyBattle
{
    public class Player : Target
    {
        public IInventory Inventory { get; }
        public Stats Stats { get; }

        public Player(IInventory inventory, Stats stats)
        {
            Inventory = inventory;
            Stats = stats;
        }

        public Damage CalculateDamage(Target other)
        {
            int baseDamage = Inventory.CalculateBaseDamage();
            float damageModifier = Inventory.CalculateDamageModifier(this);
            int totalDamage = (int)Math.Round(baseDamage * damageModifier, 0);
            int soak = other.GetSoak(totalDamage);
            return new Damage(Math.Max(0, totalDamage - soak));
        }
    }
}