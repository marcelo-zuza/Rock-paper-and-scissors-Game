using System.Threading;
List<string> opcoes = new List<string>{"pedra", "papel", "tesoura"};
string playerChoice = "";
string objectChoice = "";
string computerChoice = "";
int playerPoints = 0;
int computerPoints = 0;
while(true)
{

    Console.WriteLine("\nWelcome to the game Rock, paper and scissors\n Select an option\n[1] New Game\n[2] Quit");
    string choice = Console.ReadLine();
            Thread.Sleep(500);

    if(choice == "1")
    {
        Thread.Sleep(1000);
        Console.WriteLine("\nThe game will start soon");
        Thread.Sleep(1000);
        while(true)
        {
            Console.WriteLine("\nPoints:\nYou: " + playerPoints + "\nComputer: " + computerPoints);
            Console.Write("\n Choose one option:\n[1] Play\n[2] Quite");
            string roundOption = Console.ReadLine();
            if(roundOption == "1")
            {
                while(true)
                {
                    
                    Console.WriteLine("Choose:\n[1] Rock\n[2] Paper\n[3] Scissors \n[0] End Game");
                    objectChoice = Console.ReadLine();
                    if(objectChoice == "1")
                    {
                        playerChoice = "rock";
                        Console.WriteLine("You choose Rock");
                        break;
                    }
                    else if(objectChoice == "2")
                    {
                        playerChoice = "paper";
                        Console.WriteLine("You choose Paper");
                        break;

                    }
                    else if(objectChoice == "3")
                    {
                        playerChoice = "scissors";
                        Console.WriteLine("You choose Scissors");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Unknow choice, try again");
                    }
                }
            }
            else if(roundOption == "2")
            {
                break;
            }
            Random random = new Random();
            int index = random.Next(opcoes.Count);
            computerChoice = opcoes[index];
            Console.WriteLine("\nThe computer choose: " + computerChoice + "\n");
            if(playerChoice == "rock" & computerChoice == "rock")
            {
                Console.WriteLine("\nIt's a Draw");
            }
            else if(playerChoice == "rock" & computerChoice == "paper")
            {
                Console.WriteLine("\nThe paper covers the rock. Computer Wins");
                computerPoints++;
            }
            else if(playerChoice == "rock" & computerChoice == "scissors")
            {
                Console.WriteLine("\nThe rock breaks the scisssors. You Win");
                playerPoints++;
            }

            else if(playerChoice == "paper" & computerChoice == "rock")
            {
                Console.WriteLine("\nThe paper covers the rock. You Win");
                playerPoints++;
            }
            else if(playerChoice == "paper" & computerChoice == "paper")
            {
                Console.WriteLine("\nIt's a Draw");
            }
            else if(playerChoice == "paper" & computerChoice == "scissors")
            {
                Console.WriteLine("\nThe scissors cuts the paper. Computer Wins");
                computerPoints++;
            }

            else if(playerChoice == "scissors" & computerChoice == "rock")
            {
                Console.WriteLine("\nThe rock breaks the scisssors. Computer Wins");
                computerPoints++;
            }
            else if(playerChoice == "scissors" & computerChoice == "paper")
            {
                Console.WriteLine("\nThe scissors cuts the paper. You Win");
                playerPoints++;
            }
            else if(playerChoice == "scissors" & computerChoice == "scissors")
            {
                Console.WriteLine("\nIt's a Draw");
            }



        }

    }
    else if(choice == "2")
    {
        Thread.Sleep(1000);
        Console.WriteLine("\nThank you for playing\nThis Games is powered by Marceclo Zuza\nGAME OVER\n");
        Thread.Sleep(1000);
        break;
    }
    else
    {
        Thread.Sleep(1000);
        Console.WriteLine("\nUnknow option, please try again");
        Thread.Sleep(1000);

    }
}
