using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp
{
    class Warrior
    {
        public string name;
        public int health;
        int attkMax;
        int blockMax;
        Random random = new Random();

        public Warrior(string name, int health, int attkMax, int blockMax)
        {
            this.name = name;
            this.health = health;
            this.attkMax = attkMax;
            this.blockMax = blockMax;
        }

        public int Attack()
        {
            return random.Next(0, attkMax + 1);
        }
        public int Block()
        {
            return random.Next(0, blockMax + 1);
        }


    }
}
