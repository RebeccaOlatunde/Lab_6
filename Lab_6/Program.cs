using System;


namespace Lab_6
{
    class program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] Dice1 = new int[6];
            int[] Dice2 = new int[6];

            //Declaring variables

            string response;
            string sides;
            int sides1;
            bool isItANum;
            int diceRoll = 0;


            Console.WriteLine("Welcome to GrandCircus Casino. Roll the dice (y/n?)");
            response = Console.ReadLine().ToLower();
            while (response! == "y")
            {


                Console.WriteLine("How many sides does each dice have?"); //Enter 6
                sides = Console.ReadLine();
                isItANum = int.TryParse(sides, out sides1);

                // Dice Roll Prompt
                do
                {
                    Console.WriteLine("Roll");

                    diceRoll = rnd.Next(6);
                    Dice1[diceRoll]++;
                    Console.WriteLine("Dice1: {0}", diceRoll + 1);

                    diceRoll = rnd.Next(6);
                    Dice1[diceRoll]++;
                    Console.WriteLine("Dice2: {0}", diceRoll + 1);

                    // Subsequent Dice Roll

                    Console.WriteLine("Roll Dice again? (y/n?)");

                    response = Console.ReadLine().ToLower();

                } while (response == "y");
                Console.WriteLine("GoodBye");
                Console.ReadLine();


                // Welcome to GrandCircus Casino. Roll the dice(y/n?)
                // Response: y
                // How many sides does each dice have?
                // Response: 6
                // Roll
                // Dice1: 5 (number randomly chosen ny app)
                // Dice2: 4 (number randomly chosen by app)
                // Roll Dice again? (y/n?)
                // If "y" it continues, if "n" then Goodbye.


            }
        } 
    }
}    


        
