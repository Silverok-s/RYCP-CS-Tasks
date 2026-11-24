using System;
using System.Collections.Generic;
using System.Text;

namespace independent_work
{
    internal class CombatSystem
    {
        public void Attack(Monster attacker, Monster target)
        {
            if (attacker.IsDead || target.IsDead)
                return;

            target.TakeDamage(attacker.AttackStrength);
        }
    }
}
