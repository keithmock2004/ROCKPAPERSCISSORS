using System;


namespace ROCKPAPERSCISSORS
{
    class Program 
    {
        private static string inputplayer;

        static void Main(string[] args)
        {
            string inputPlayer;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;

            while (playAgain)
            {

            while(scorePlayer < 3 && scoreCPU < 3)
            { 

            Console.Write("Choose between  ROCK, PAPER and SCISSORS:    ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(1,4);

                switch (randomInt)
                {
                    case 1:

                            //Console.WriteLine("Computer chose ROCK");
                            if (inputplayer == "ROCK")
                        {
                            Console.WriteLine("Draw!!\n\n");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("DRAW!!\n\n");
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                        }

                        break;
                    case 2:
                            //Console.WriteLine("Computer chose PAPER");
                            if (inputplayer == "ROCK")
                        {
                            Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("DRAW!!\n\n");

                        }

                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        break;
                    case 3:

                            //a Console.WriteLine("Computer chose SCISSORS");
                            if (inputplayer == "SCISSORS")
                        {
                            Console.WriteLine("Draw!!\n\n");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        break;
                    default:
                        Console.WriteLine("invalid entry!");
                        break;
                }     
               

                  

                

            }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("PlAYER WON");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                {
                    Console.WriteLine("DO YOU WANT TO PLAY AGAIN?(y/n)");
                }
                    string loop = Console.ReadLine();
                
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }

        }
    }
}
