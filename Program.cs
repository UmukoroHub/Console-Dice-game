// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("-----My Dice Game-------");
Console.WriteLine("");
//This is a variable input for our player 
int PlayerRandomNum;
//This code is used to get the computers input 
int EnemyRandomNum;
bool playAgain = true;//Variable to control the loop

//This code helps us to initiate our random number
Random random = new Random();

while (playAgain)
{
  int PlayerPoints = 0; //Players point
  int EnemyPoints = 0;  //Enemys point

  for (int i = 0; i < 6; i++)
  {
    Console.WriteLine("Press any key to roll the dice:");

    Console.ReadKey();
    //This is used to select a random number between 1 and 6 for the player
    PlayerRandomNum = random.Next(1, 7);
    Console.WriteLine("You rolled a " + PlayerRandomNum);

    //This code helps to determine how fast the reply of the computer comes in
    Console.WriteLine(".......");
    System.Threading.Thread.Sleep(1000);

    //This is used to select a random number between 1 and 6 for the computer
    EnemyRandomNum = random.Next(1, 7);
    Console.WriteLine("Enemy comp rolled a " + EnemyRandomNum);

    if (PlayerRandomNum > EnemyRandomNum)
    {
      PlayerPoints++;
      Console.WriteLine("Player wins this round!");
    }
    else if (EnemyRandomNum > PlayerRandomNum)
    {
      EnemyPoints++;
      Console.WriteLine("Computer wins this round!");
    }
    else
    {
      Console.WriteLine("Draw!");
    }
    Console.WriteLine($"The current score is: \nplayer :  {PlayerPoints}  \nEnemy :  {EnemyPoints}");
  }
  Console.WriteLine("");
  Console.WriteLine("Final Result = ");
  if (PlayerPoints > EnemyPoints)
  {
    Console.WriteLine("Congratulations....You Win!");
  }
  else if (EnemyPoints > PlayerPoints)
  {
    Console.WriteLine("Sorry....You Lost");
  }
  else
  {
    Console.WriteLine("Its a Draw!");
  }

  Console.WriteLine("Would you like to try again? (y/n)");
  string response = Console.ReadLine().ToLower();

  // Check the response
  if (response == "y")
  {
    playAgain = true;
  }
  else if (response == "n")
  {
    playAgain = false;
  }
  else
  {
    Console.WriteLine("Invalid input. Exiting...");
    playAgain = false;
  }
}
Console.WriteLine("Thank You For Playing....");



