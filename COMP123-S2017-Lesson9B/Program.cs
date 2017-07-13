using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Fuad Mannan
 * Date: July 13, 2017
 * Description: Lab 24
 * Version: 0.8 - Modified Driver class to implement SuperVillain
 */

namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            Console.WriteLine(superHero.ToString());

            SuperVillain superVillain = new SuperVillain("Bodmon", 40);
            superVillain.AddPower("Bad Breath", 80);
            superVillain.AddPower("Disregard for human life", 200);
            Console.WriteLine(superVillain);
        }
    }
}
