using System;
using System.Linq;

namespace FantasyBattle
{
    public abstract class Target
    {
        public virtual int GetSoak(int totalDamage) {
            int soak = 0;
            if (this is Player) {
                // TODO: Not implemented yet
                //  Add friendly fire
                soak = totalDamage;
            } else if (this is SimpleEnemy simpleEnemy) {
                soak = (int)Math.Round(
                    simpleEnemy.Armor.DamageSoak *
                    (
                        simpleEnemy.Buffs.Select(x => x.SoakModifier).Sum() + 1
                    ), 0
                );
            }
            return soak;
        }
    }
}