using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp
{
    class FightingGame
    {

       
        static void Main(string[] args) {
            Warrior thor = new Warrior("Danny", 130, 25, 10);
            Warrior hulk = new Warrior("Lynn", 135, 25, 10);
            Battle.StartFight(thor, hulk);
            Console.ReadLine();

            
         
          
            }
    }

    }
       
    
   
    

