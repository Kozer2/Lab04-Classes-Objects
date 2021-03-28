using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");*/
            StartGame();
        }

        public static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Hello! Please enter your names to play the game.");
            Player player1 = new Player();
            player1.Name = Console.ReadLine();
            

            Player player2 = new Player();
            player2.Name = Console.ReadLine();

            player1.Marker = "x";
            player2.Marker = "o";

            Console.WriteLine($"Welcome {player1.Name} and {player2.Name}. I hope you're ready for the game of a lifetime... ");

            Game game = new Game(player1, player2);
            Player winner = game.Play();

            if(winner is null)
            {
                Console.WriteLine($"There was no winner! Both of you must pay! With your souls....");

            } // end if
            else
            {
                Console.WriteLine($"Congrats! {winner.Name}, you have won. Unfortunatly for the loser. Your soul is mine!");
            } //  end else

        }


    }
}
