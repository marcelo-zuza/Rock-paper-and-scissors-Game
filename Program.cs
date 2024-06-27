using System.Threading;
List<string> opcoes = new List<string>{"rock", "paper", "scissors"};
string playerChoice = "";
string objectChoice = "";
string computerChoice = "";
int playerPoints = 0;
int computerPoints = 0;
while(true)
{
    Thread.Sleep(1000);
    Console.WriteLine("\nWelcome to the game Rock, paper and scissors\n Select an option\n[1] New Game\n[2] Quit\n==>");
    string choice = Console.ReadLine();
            Thread.Sleep(500);

    if(choice == "1")
    {
        Thread.Sleep(1000);
        Console.WriteLine("\nThe game will start soon");
        Thread.Sleep(1000);
        while(true)
        {
            Thread.Sleep(1000);
            Console.WriteLine("\nPoints:\nYou: " + playerPoints + "\nComputer: " + computerPoints);
            Console.Write("\n Choose one option:\n[any] Play\n[2] Quit\n==>");
            string roundOption = Console.ReadLine();
            if(roundOption == "1")
            {
                while(true)
                {
                    
                    Console.WriteLine("\nChoose:\n[1] Rock\n[2] Paper\n[3] Scissors \n[0] End Game\n==>");
                    objectChoice = Console.ReadLine();
                    if(objectChoice == "1")
                    {
                        playerChoice = "rock";
                        Thread.Sleep(1000);
                        Console.WriteLine("You choose Rock");
                        break;
                    }
                    else if(objectChoice == "2")
                    {
                        playerChoice = "paper";
                        Thread.Sleep(1000);
                        Console.WriteLine("You choose Paper");
                        break;

                    }
                    else if(objectChoice == "3")
                    {
                        playerChoice = "scissors";
                        Thread.Sleep(1000);
                        Console.WriteLine("You choose Scissors");
                        break;

                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Unknow choice, try again");
                    }
                }
                Random random = new Random();
                int index = random.Next(opcoes.Count);
                computerChoice = opcoes[index];
                Thread.Sleep(1000);
                Console.WriteLine("\nThe computer choose: " + computerChoice + "\n");
            }
            else if(roundOption == "2")
            {
                Thread.Sleep(1000);
                Console.WriteLine("Great Game\nScore:\nYou: " + playerPoints + "\nComputer: " + computerPoints);
                if(playerPoints > computerPoints)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("\nYOU WIN");
                }
                else if(playerPoints == computerPoints)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("\nIT'S A DRAW");
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("\nCOMPUTER WINS");

                }
                playerPoints = 0;
                playerChoice = "";
                computerPoints = 0;
                computerChoice = "";
                Thread.Sleep(1000);
                break;

                
            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine("Unknow choice, try again");
            }

            if(playerChoice == "rock" & computerChoice == "rock")
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nIt's a Draw");
            }
            else if(playerChoice == "rock" & computerChoice == "paper")
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nThe paper covers the rock. Computer Wins");
                computerPoints++;
            }
            else if(playerChoice == "rock" & computerChoice == "scissors")
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nThe rock breaks the scisssors. You Win");
                playerPoints++;
            }

            else if(playerChoice == "paper" & computerChoice == "rock")
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nThe paper covers the rock. You Win");
                playerPoints++;
            }
            else if(playerChoice == "paper" & computerChoice == "paper")
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nIt's a Draw");
            }
            else if(playerChoice == "paper" & computerChoice == "scissors")
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nThe scissors cuts the paper. Computer Wins");
                computerPoints++;
            }

            else if(playerChoice == "scissors" & computerChoice == "rock")
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nThe rock breaks the scisssors. Computer Wins");
                computerPoints++;
            }
            else if(playerChoice == "scissors" & computerChoice == "paper")
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nThe scissors cuts the paper. You Win");
                playerPoints++;
            }
            else if(playerChoice == "scissors" & computerChoice == "scissors")
            {
                Thread.Sleep(1000);
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
