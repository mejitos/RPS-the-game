using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_game
{
    class Program
    {       
        int rounds;
        int score_player;
        int score_cpu;
       
        string p_choice;
        string cpu_choice;
        string result;
        string winner;

        ConsoleKeyInfo KeyInfo;
        
        static void Main(string[] args)
        {
            Console.Title = "ROCK PAPER SCISSORS - THE GAME";
            Console.SetWindowSize(60, 33);
            Program p = new Program();
            
            p.StartScreen();
            p.GameLoop();
        }
        
        // Print the starting screen
        public void StartScreen()
        {
            StartHeader();
            StartGreet();
            GoToSettings();
        }

        // Main loop
        public void GameLoop()
        {           
            GetSettings();
            Display();

            while (score_player < rounds || score_cpu < rounds)
            {
                if (score_player == rounds ||score_cpu == rounds)
                {
                    break;
                }
                PrintPlayerChoice();
                PrintCPUChoice();
                DeclareWinner();
                NextRound();
                Console.Clear();
                Display();                
            }
            
            Console.Clear();
            Display();
            TheBelt();
            Console.Clear();
            Display();
            PlayAgain();
        }

        // Get game settings from player
        public void GetSettings()
        {
            StartHeader();
            rounds = GetRoundNum();
        }

        // Starting screens heafer
        public void StartHeader()
        {
            Console.SetCursorPosition(0, 6);

            Console.WriteLine("            ***********************************            ");
            Console.WriteLine("      ***********************************************      ");
            Console.WriteLine("  **********                                   **********  ");
            Console.WriteLine("******         ROCK PAPER SCISSORS - THE GAME        ******");
            Console.WriteLine("  **********                                   **********  ");
            Console.WriteLine("      ***********************************************      ");
            Console.WriteLine("            ***********************************            ");            
        }

        // Go to settings -> round numer
        public void GoToSettings()
        {
            Console.SetCursorPosition(1, 32);
            Console.ForegroundColor = ConsoleColor.Black;

            while(true)
            {
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.Enter)
                {
                    Console.ResetColor();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.SetCursorPosition(1,32);                
                }
            }                     
        }

        // Greet the player
        public void StartGreet()
        {
            Console.SetCursorPosition(10, 15);
            Console.Write("Welcome to the world championship of the");
            Console.SetCursorPosition(14, 16);
            Console.Write("ROCK PAPER SCISSORS - THE GAME!");
            Console.SetCursorPosition(15, 20);
            Console.Write("PRESS ENTER TO START THE GAME");
        }       

        // Get the number of rounds
        public int GetRoundNum()
        {
            Console.SetCursorPosition(13, 15);
            Console.Write("THE GAME WILL BE A: ");
            Console.SetCursorPosition(33, 15);
            Console.Write("[1] RACE TO 3");
            Console.SetCursorPosition(33, 17);
            Console.Write("[2] RACE TO 5");
            Console.SetCursorPosition(33, 19);
            Console.Write("[3] RACE TO 7");

            Console.SetCursorPosition(1, 32);
            Console.ForegroundColor = ConsoleColor.Black;

            int get_round = 0;

            while(true)
            {
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.NumPad1 || KeyInfo.Key == ConsoleKey.D1)
                {
                    get_round = 3;
                    Console.ResetColor();
                    return get_round;
                }
                else if (KeyInfo.Key == ConsoleKey.NumPad2 || KeyInfo.Key == ConsoleKey.D2)
                {
                    get_round = 5;
                    Console.ResetColor();
                    return get_round;
                }
                else if (KeyInfo.Key == ConsoleKey.NumPad3 || KeyInfo.Key == ConsoleKey.D3)
                {
                    get_round = 7;
                    Console.ResetColor();
                    return get_round;
                }
                else 
                {
                    Console.SetCursorPosition(1,32);
                }
            }                       
        }
   
        // The gamescreen
        public void Display()
        {   Console.SetCursorPosition(0, 0);
            Console.WriteLine("  *******************************************************  ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("***   RACE TO   ***   PLAYER SCORE   ***    CPU SCORE   ***");
            Console.WriteLine("***      {0}      ***         {1}        ***        {2}       ***", rounds, score_player, score_cpu);
            Console.WriteLine("***********************************************************");
            Console.WriteLine("  *******************************************************  ");
            Console.WriteLine("    *****                                         *****    ");
            Console.WriteLine("    *****         PLEASE MAKE YOUR CHOICE         *****    ");
            Console.WriteLine("    *****      YOU CAN USE NUMBERS OR LETTERS     *****    ");
            Console.WriteLine("    *****                                         *****    ");
            Console.WriteLine("    ***************************************************    ");
            Console.WriteLine("    ***************************************************    ");
            Console.WriteLine("    ****    ROCK    ***    PAPER    ***  SCISSORS  ****    ");
            Console.WriteLine("    ****   _,_      ***   +-----+   ***    |  /    ****    ");
            Console.WriteLine("    ****  / ,  '-,  ***   |:::::|   ***    | /     ****    ");
            Console.WriteLine("    **** '---,_'_,| ***   |;;;;;|   ***    O       ****    ");
            Console.WriteLine("    ****            ***   +-----+   ***   ()()     ****    ");
            Console.WriteLine("    **** [1] or 'r' ***  [2] or 'p' *** [3] or 's' ****    ");
            Console.WriteLine("    ***************************************************    ");
            Console.WriteLine("      ***********************************************      ");
        }
        
        // Prints Players choice to the screen
        public void PrintPlayerChoice()
        {
            p_choice = PlayerChoice();
            Console.SetCursorPosition(10, 21);
            Console.WriteLine("PLAYERS CHOICE");
            Console.SetCursorPosition(13, 22);
            Console.WriteLine("{0}", p_choice);
        }

        // Get Players choice
        public string PlayerChoice()
        {
            Console.SetCursorPosition(1, 32);
            Console.ForegroundColor = ConsoleColor.Black;

            string get_choice = "";

            while (true)
            {
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.NumPad1 || KeyInfo.Key == ConsoleKey.D1 || KeyInfo.Key == ConsoleKey.R)
                {
                    get_choice = "  ROCK";
                    Console.ResetColor();
                    return get_choice;
                }
                else if (KeyInfo.Key == ConsoleKey.NumPad2 || KeyInfo.Key == ConsoleKey.D2 || KeyInfo.Key == ConsoleKey.P)
                {
                    get_choice = " PAPER";
                    Console.ResetColor();
                    return get_choice;
                }
                else if (KeyInfo.Key == ConsoleKey.NumPad3 || KeyInfo.Key == ConsoleKey.D3 || KeyInfo.Key == ConsoleKey.S)
                {
                    get_choice = "SCISSORS";
                    Console.ResetColor();
                    return get_choice;
                }
                else
                {
                    Console.SetCursorPosition(1, 32);
                }
            }            
        }

        // Prints CPUs choice to the screen
        public void PrintCPUChoice()
        {   cpu_choice = CPUChoice();
            Console.SetCursorPosition(37, 21);
            Console.WriteLine("CPUS CHOICE");
            Console.SetCursorPosition(39, 22);
            Console.WriteLine("{0}", cpu_choice);
        }

        // Get CPUs choice
        public string CPUChoice()
        {
            Random rndm = new Random();
            int get_cpu_choice = rndm.Next(1, 4);
            string got_cpu_choice = get_cpu_choice.ToString();
            if (got_cpu_choice == "1")
            {
                got_cpu_choice = "  ROCK";
            }
            else if (got_cpu_choice == "2")
            {
                got_cpu_choice = " PAPER";
            }
            else if (got_cpu_choice == "3")
            {
                got_cpu_choice = "SCISSORS";
            }           
            return got_cpu_choice;
        }

        // Get the result (Player choice vs CPU choice)
        public string GetResult()
        {
            string ask_result= "";
            if (p_choice == "  ROCK" && cpu_choice == "  ROCK")
            {
                ask_result = "IT'S A DRAW!";
            }
            else if (p_choice == "  ROCK" && cpu_choice == " PAPER")
            {
                ask_result = "CPU WINS!";
            }
            else if (p_choice == "  ROCK" && cpu_choice == "SCISSORS")
            {
                ask_result = "PLAYER WINS!";
            }
            else if (p_choice == " PAPER" && cpu_choice == "  ROCK")
            {
                ask_result = "PLAYER WINS!";
            }
            else if (p_choice == " PAPER" && cpu_choice == " PAPER")
            {
                ask_result = "IT'S A DRAW!";
            }
            else if (p_choice == " PAPER" && cpu_choice == "SCISSORS")
            {
                ask_result = "CPU WINS!";
            }
            else if (p_choice == "SCISSORS" && cpu_choice == "  ROCK")
            {
                ask_result = "CPU WINS!";
            }
            else if (p_choice == "SCISSORS" && cpu_choice == " PAPER")
            {
                ask_result = "PLAYER WINS!";
            }
            else if (p_choice == "SCISSORS" && cpu_choice == "SCISSORS")
            {
                ask_result = "IT'S A DRAW!";
            }
            return ask_result;
        }

        // Declare the winner
        public void DeclareWinner()
        {
            
            if (GetResult() == "PLAYER WINS!")
            {
                Console.SetCursorPosition(15, 24);
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                Console.SetCursorPosition(15, 25);
                Console.WriteLine("+-+ - -  PLAYER WINS!  - -+-+");
                Console.SetCursorPosition(15, 26);
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");

                score_player++;
            }
            else if (GetResult() == "CPU WINS!")
            {
                Console.SetCursorPosition(15, 24);
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                Console.SetCursorPosition(15, 25);
                Console.WriteLine("+-+ - -   CPU WINS!  - - -+-+");
                Console.SetCursorPosition(15, 26);
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");

                score_cpu++;
            }
            else if (GetResult() == "IT'S A DRAW!")
            {
                Console.SetCursorPosition(15, 24);
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                Console.SetCursorPosition(15, 25);
                Console.WriteLine("+-+ - -  IT'S A DRAW!  - -+-+");
                Console.SetCursorPosition(15, 26);
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            }
        
        } 

        // Enter to play a new round
        public void NextRound()
        {
            Console.SetCursorPosition(13, 28);
            Console.Write("START NEXT ROUND BY PRESSING ENTER");

            Console.SetCursorPosition(1, 32);
            Console.ForegroundColor = ConsoleColor.Black;

            while(true)
            {
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.Enter)
                {
                    Console.ResetColor();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.SetCursorPosition(1,32);                
                }
            }                      
        }

        // Get the winner for the belt
        public string GetWinner()
        {
            string get_winner = "";

            if (score_player == rounds)
            {
                get_winner = "PLAYER";
            }
            else if (score_cpu == rounds)
            {
                get_winner = "CPU";
            }
            return get_winner;
        }
        
        // Who gets the belt
        public void TheBelt()
        {
            winner = GetWinner();

            Console.WriteLine();
            Console.WriteLine("                      .----''''''----.                ");
            Console.WriteLine("     ----------'''''''                '''''''---------");
            Console.WriteLine("       :  :  :           THE   BELT           :  :  : ");
            Console.WriteLine("     ----------_______                _______---------");
            Console.WriteLine("                      '----......----'                ");
            Console.WriteLine();
            Console.WriteLine("              THE WINNER AND THE NEW CHAMPION!       ");
            Console.WriteLine();
            Console.WriteLine("                           {0}", winner);
            Console.Write("");
            
            Console.SetCursorPosition(1, 32);
            Console.ForegroundColor = ConsoleColor.Black;

            while(true)
            {
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.Enter)
                {
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.SetCursorPosition(1,32);                
                }
            }            
        }

        // Ask player if he wants to play again
        public void PlayAgain()
        {
            Console.WriteLine();
            Console.WriteLine("    WANT TO PLAY AGAIN AND GET A REMATCH FOR THE BELT?");
            Console.WriteLine();
            Console.WriteLine("                   [1] or 'y'     YES");
            Console.WriteLine("                   [2] or 'n'     NO ");

            Console.SetCursorPosition(1, 32);
            Console.ForegroundColor = ConsoleColor.Black;
          
            while (true)
            {
                ConsoleKeyInfo KeyInfo;
                KeyInfo = Console.ReadKey();

                if (KeyInfo.Key == ConsoleKey.NumPad1 || KeyInfo.Key == ConsoleKey.D1 || KeyInfo.Key == ConsoleKey.Y)
                {
                    Console.ResetColor();
                    Console.Clear();
                    score_cpu = 0;
                    score_player = 0;
                    GameLoop();
                }
                else if (KeyInfo.Key == ConsoleKey.NumPad2 || KeyInfo.Key == ConsoleKey.D2 || KeyInfo.Key == ConsoleKey.N)
                {
                    Environment.Exit(1);             
                }
                else
                {
                    Console.SetCursorPosition(1, 32);
                }
            }                  
        }
    }
}