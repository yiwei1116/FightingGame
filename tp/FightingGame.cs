using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp
{
     class FightingGame
    {
         class Warrior {
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
          class Battle {
            
             public static void StartFight(Warrior warrior1, Warrior warrior2) {
                
                while (true)
                {
                    if(GetAttackResult(warrior1, warrior2) == "Game Over")
                    { 
                        Console.WriteLine("Game Over");
                        break;
                    }
                    if (GetAttackResult(warrior2, warrior1) == "Game Over")
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                }
                 
            }
            static String GetAttackResult(Warrior warriorA, Warrior warriorB) {
                int warriorA_Attack = warriorA.Attack();
                int warriorB_Block = warriorB.Block();
                int damageOnWarriorB = warriorA_Attack - warriorB_Block;
                damageOnWarriorB = (damageOnWarriorB <= 0) ? 0 : damageOnWarriorB;
                warriorB.health = warriorB.health - damageOnWarriorB;
                Console.WriteLine("{0} attack {1} and deals {2} damage\n", warriorA.name, warriorB.name, damageOnWarriorB);
                Console.WriteLine("{0} is down to {1} health\n", warriorB.name, warriorB.health);

                if (warriorB.health <= 0)
                {
                    Console.WriteLine("{0} is dead and {1} is winner ", warriorB.name, warriorA.name);
                    return "Game Over";
                }
                else
                {
                    return "Fight Again";
                }


            }

         
        }
        static void Main(string[] args) {

            Warrior thor = new Warrior("Danny", 130, 25, 10);
            Warrior hulk = new Warrior("Lynn", 135, 25, 10);
           
            Battle.StartFight(thor, hulk);
            Console.ReadLine();
            


        }
       
    }
   
    
}
