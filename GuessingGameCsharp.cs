using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class GuessingGameCsharp
    {
        public void func()
        {
            string secretword = "Riya", guess="";
            int countguess = 0, guesslimit=5;

            while (guess != secretword && countguess<guesslimit)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                ++countguess;
            }
            if (guess == secretword)
                Console.Write("You Win!!");
            else
                Console.Write("You Lose!!");

            Console.ReadLine();
        }
    }
}
