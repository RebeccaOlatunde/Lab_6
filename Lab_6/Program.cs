using System;


namespace Lab_6
{
    class program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //Declaring variables

            string response;
            string sides;
            int sides1;
            bool isItANum;
            int diceRoll = 0;


            Console.WriteLine("Welcome to GrandCircus Casino. Roll the dice (y/n?)");
            response = Console.ReadLine().ToLower().Trim();
            while (response == "y")
            {

                do
                {
                    Console.WriteLine("How many sides does each dice have?"); 
                sides = Console.ReadLine();
                isItANum = int.TryParse(sides, out sides1);

                // Dice Roll Prompt
                
                    Console.WriteLine("Roll");

                    diceRoll = rnd.Next(sides1);
                    Console.WriteLine("Dice1: {0}", diceRoll + 1);

                    diceRoll = rnd.Next(sides1);
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
                // Response: Enter 6 or any number of choice
                // Roll
                // Dice1: 5 (number randomly chosen ny app)
                // Dice2: 4 (number randomly chosen by app)
                // Roll Dice again? (y/n?)
                // If "y" it continues, if "n" then Goodbye.


            }
        } 
    }
}    
