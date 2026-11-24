using System;
using System.Collections.Generic;
using System.Text;

namespace independent_work
{
    internal class CombatLogger
    {
        public void Connect(Monster monster)
        {
            monster.HPChanged += LogHPChanged;
        }

        private void LogHPChanged(Monster monster, int oldHP, int newHP)
        {
            Console.WriteLine($"{monster.Name}: HP changed from {oldHP} to {newHP}");
        }
    }
}
