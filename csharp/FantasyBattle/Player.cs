using System;
using System.Linq;

namespace FantasyBattle
{
    public class Player : Target
    {
        public Inventory Inventory { get; }
        public Stats Stats { get; }

        public Player(Inventory inventory, Stats stats)
        {
            Inventory = inventory;
            Stats = stats;
        }

        public Damage CalculateDamage(Target other)
        {
            int baseDamage = this.Inventory.CalculateBaseDamage();
            float damageModifier = Inventory.CalculateDamageModifier(this);
            int totalDamage = (int)Math.Round(baseDamage * damageModifier, 0);
            int soak = GetSoak(other, totalDamage);
            return new Damage(Math.Max(0, totalDamage - soak));
        }

        private int GetSoak(Target other, int totalDamage) {
            int soak = 0;
            soak = other.CalculateSoak(totalDamage, soak);
            return soak;
        }
    }
}