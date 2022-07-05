using System;
using Command_Example.Example2.Abstractions;

namespace Command_Example.Example2.Realization
{
    /* При этом инициатор необязательно указывает на одну команду.
     * Он может управлять множеством команд.
     * Например, на пульте от телевизора есть как кнопка для включения, так и кнопки для регулировки звука:
     */
    public class Volume
    {
        private const int OFF = 0;
        private const int HIGH = 20;
        private int _level;

        public Volume()
        {
            _level = OFF;
        }

        public void RaiseLevel()
        {
            if (_level < HIGH)
            {
                _level++;
                Console.WriteLine("Уровень звука {0}", _level);
            }
        }

        public void DropLevel()
        {
            if (_level > HIGH)
            {
                _level--;
                Console.WriteLine("Уровень звука {0}", _level);
            }
        }
    }
}