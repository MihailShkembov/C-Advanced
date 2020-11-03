using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._1Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var input2 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Queue<int> bombEffects = new Queue<int>(input1);
            Stack<int> bombCasing = new Stack<int>(input2);           
            bool bombPouch = false;
            int datura = 0;
            int cherryBombs = 0;
            int smokeGranade = 0;
            bool isEmpty = false;

            //  35, 100, 80
            //20, 25,

            
            while (bombCasing.Any()&&bombEffects.Any()&&bombPouch==false)
            {
                int currEffect = bombEffects.Peek();
                int currCaing = bombCasing.Peek();
                if (currEffect+currCaing==40)
                {
                    datura++;
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else if (currEffect + currCaing == 60)
                {
                    cherryBombs++;
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else if (currEffect + currCaing == 120)
                {
                    smokeGranade++;
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else
                {
                    var tempList = new List<int>(bombCasing);
                    
                    tempList[0] -= 5;
                    tempList.Reverse();
                    bombCasing = new Stack<int>(tempList);
                }
                if (datura>=3&&cherryBombs>=3&&smokeGranade>=3)
                {
                    bombPouch = true;
                    break;
                }
                if (!bombEffects.Any()||!bombCasing.Any())
                {
                    isEmpty = true;
                    break;
                }
            }
            if (bombPouch==true)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (!bombEffects.Any())
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",bombEffects)}");
            }
            if (!bombCasing.Any())
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeGranade}");
        }
    }
}
