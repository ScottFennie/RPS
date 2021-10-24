using System;

namespace RockPaperSciz
{
    class Program
    {
        static void Main(string[] args)
        {
           bool Playing = true;

           while(Playing)
           {
               System.Console.WriteLine("Type: Rock, Paper, or Scissors");
               Random rand = new Random();
               int compChoice = rand.Next(1,4);
               string userChoice = Console.ReadLine();
             
                   /// These are my Win conditions
                   if( userChoice == "Rock" && compChoice == 3 || userChoice == "Paper" && compChoice == 1 || userChoice == "Scissors" && compChoice == 2){
                       System.Console.WriteLine($"the comp chose {compChoice} You chose {userChoice}, You win! Very Neato!");
                    /// These are the Tie conditions
                   } else if (userChoice == "Rock" && compChoice == 1 || userChoice == "Paper" && compChoice == 2 || userChoice == "Scissors" && compChoice == 3){
                      System.Console.WriteLine($"the comp chose {compChoice} You chose {userChoice}, You tie! Nice!");
                    /// These are the Lose conditions
                   } else{ 
                       System.Console.WriteLine($"the comp chose {compChoice} You chose {userChoice},You lose! How embarrasing!");
                   }
                     System.Console.WriteLine("Play again? : y/n");
                     ConsoleKeyInfo res = Console.ReadKey();

                     if(res.KeyChar == 'n'){
                         Playing = false;
                         System.Console.WriteLine("fine, whatever, who even cares anyways");
                     } 
           }
        }
    }
}

