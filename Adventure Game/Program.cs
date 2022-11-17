using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizariaAdventure
{
    class Program
    {
        static int Square1()
        {
            int square = 1;
            Console.Write("You are on the side of a road that, continues East or bends south");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {

                case "E": square = square + 1; break;
                case "S": square = square + 5; break;

            }

            return square;
        }

        static int Square2()
        {
            int square = 2;
            Console.Write("You are on the side of the road which continues West and East. There is a park with a pond south");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {

                case "E": square = square + 1; break;
                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square3(List<string> backpack)
        {
            int square = 3;
            Console.Write("You are on the drive outside your house. " +
                "There is a road leading East, West and South " +
                "There is something green on the floor of your drive " +
                "do you want to pick it up? (y/n)");

            string pickUpCard = Console.ReadLine();
            if (pickUpCard == "y")
            {
                Console.Write("You found your Bank Card");
                Pockets(backpack, "Bank Card");
            }

            Console.WriteLine("Move S, E, W");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {

                case "E": square = square + 1; break;
                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square4()
        {
            int square = 4;
            Console.Write("You are on a road that leads East and West " +
                "There is a grass park south");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {

                case "E": square = square + 1; break;
                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square5(int bankCurrency, List<string> backpack)
        {
            int square = 5;
            Console.WriteLine("You are outside the bank. It's shut but there is an ATM running");
            Console.WriteLine("Would you like to use the ATM? (y/n)");

            string useATM = Console.ReadLine();

            switch (useATM)
            {
                case "y": ATMWithdrawal(bankCurrency, backpack); break;
            }

            //Moving the character to another block
            Console.WriteLine("Move: S, W");
            string move = Console.ReadLine();
            switch (move)
            {


                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square6()
        {
            int square = 6;
            Console.Write("You are on the side of a road that leads North " +
                "There is a footpath that leads South." +
                "There is another path that leads East");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;
                case "S": square = square + 5; break;

            }

            return square;
        }

        static int Square7()
        {
            int square = 7;
            Console.Write("You are on the edge of a huge pond. " +
                "There are ducks floating on the surface");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;
                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square8()
        {
            int square = 8;
            Console.Write("You are on a Road that leads North and South");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;
                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square9()
        {
            int square = 9;
            Console.Write("You are in a grass field, There is nothing of interest in sight");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;
                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square10()
        {
            int square = 10;
            Console.Write("You are on a road that leads south");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square11()
        {
            int square = 11;
            Console.Write("You are outside a car garage " +
                "there is an old mercedes with something shiny on the ground next to it");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;
                case "S": square = square + 5; break;

            }

            return square;
        }

        static int Square12()
        {
            int square = 12;
            Console.Write("You are on the side of the road which continues West and East. There is a park with a pond North");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;
                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square13()
        {
            int square = 13;
            Console.Write("You are inside a pizeria " +
                "it is full of people waiting for food and drink " +
                "you walk up to the counter to be  greeted by a coworker ");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;
                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square14()
        {
            int square = 14;
            Console.Write("You are in an empty grass field");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;


            }

            return square;
        }

        static int Square15(int playerHealth)
        {
            int square = 15;
            Console.Write("You are under a bridge " +
                "there is a strong pungent smell " +
                "A hobo jumps out from behind a pillar, looking ready to fight ");

            //Interaction with hobo
            Console.WriteLine("Do you fight(1), Run(2), Give them money(3)");

            string hoboAction = Console.ReadLine();
            switch (hoboAction)
            {
                case "1": Console.Write(HoboFight(playerHealth)); break;
                    //case "2": Console.Write(HoboRun()); break;
                    //case "3": Console.Write(HoboMoney()); break;
            }

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "S": square = square + 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square16()
        {
            int square = 16;
            Console.Write("You are on a footpath leading East");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;


            }

            return square;
        }

        static int Square17()
        {
            int square = 17;
            Console.Write("You are in the alleyway West from your work" +
                "You hear a rat-tling from one of the bins");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square18()
        {
            int square = 18;
            Console.Write("You are in the Kitchen of your work" +
                "There is the strong smell of pizza");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square19()
        {
            int square = 19;
            Console.Write("You are in the storehouse of your pizaria");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "E": square = square + 1; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int Square20()
        {
            int square = 20;
            Console.Write("You are west of the storehouse");

            //Moving the character to another block
            string move = Console.ReadLine();
            switch (move)
            {
                case "N": square = square - 5; break;
                case "W": square = square - 1; break;
            }

            return square;
        }

        static int HoboFight(int playerHealth)
        {

            Console.WriteLine("You and the Hobo stare at each other, a classsic Mexican standoff");

            int health = 100;
            Random random1to6int = new Random();

            //picking who attacks first
            Random random1to2int = new Random();
            int num1 = random1to2int.Next(1, 2);

            //hobo goes first
            if (num1 == 1)
            {
                Console.WriteLine("The Hobo moves first");
                
                {
                    Console.WriteLine("the hobo swings bottle in hand");
                    int num2 = random1to6int.Next(1, 6);
                    if (num2 > 4)
                    {
                        Console.WriteLine("The Hobo Missed!");
                    }
                    else if (num2 == 4)
                    {
                        Console.WriteLine("The Hobo got a critical Hit!");
                        playerHealth = playerHealth - 20;
                    }
                    else
                    {
                        Console.WriteLine("The Hobo got a Hit!");
                        playerHealth = playerHealth - 10;
                    }
                }

            }
            
            // actual fight

            int num3 = random1to6int.Next(1, 6);

            string attack = Console.ReadLine();
            if (attack == "1")
            {

            }
            return playerHealth;
        }

        static void Pockets(List<string> backpack, string item)
        {

            Console.WriteLine(". Would you like to add " + item + " to your inventory?(y/n)");
            string addToInventory = Console.ReadLine();
            switch (addToInventory)
            {
                case "y": backpack.Add(item); break;
                case "n": break;
            }

            Console.WriteLine("would you like to veiw to your inventory?(y/n)");
            string veiwInventory = Console.ReadLine();
            switch (veiwInventory)
            {
                case "y": backpack.ForEach(items => Console.WriteLine(items)); break;
                case "n": break;
            }

        }

        static int ATMWithdrawal(int bankCurrency, List<string> backpack)
        {
            Console.WriteLine("You insert your card and enter your Pin");
            Console.WriteLine("You have £" + bankCurrency + " in your account currently");
            if (bankCurrency <= 0)
            {
                Console.WriteLine("You are unable to withdraw cash");
            }

            else
            {
                Console.WriteLine("How much would you like to withdraw?");
                int withdrawValue = Convert.ToInt32(Console.ReadLine());

                if (withdrawValue > bankCurrency)
                {
                    Console.WriteLine("Withdrawal is too high. Please withdraw less");
                }

                else
                {
                    bankCurrency = bankCurrency - withdrawValue;
                    //Pockets(backpack,  withdrawValue);
                }
            }
            return bankCurrency;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Moving is N, S, E, W \n");
            int bankCurrency = 100;
            int square = 3;
            int playerHealth = 100;

            List<string> Inventory = new List<string>();

            //organising which square goes to which place
            while (square != 69)
            {
                switch (square)
                {
                    case 1: square = Square1(); break;
                    case 2: square = Square2(); break;
                    case 3: square = Square3(Inventory); break;
                    case 4: square = Square4(); break;
                    case 5: square = Square5(bankCurrency, Inventory); break;
                    case 6: square = Square6(); break;
                    case 7: square = Square7(); break;
                    case 8: square = Square8(); break;
                    case 9: square = Square9(); break;
                    case 10: square = Square10(); break;
                    case 11: square = Square11(); break;
                    case 12: square = Square12(); break;
                    case 13: square = Square13(); break;
                    case 14: square = Square14(); break;
                    case 15: square = Square15(playerHealth); break;
                    case 16: square = Square16(); break;
                    case 17: square = Square17(); break;
                    case 18: square = Square18(); break;
                    case 19: square = Square19(); break;
                    case 20: square = Square20(); break;
                    case 69: break;
                }
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}