namespace RPS_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Enter your name:");
            string playerName = Console.ReadLine();

            RPSGam game = new RPSGam(playerName);
            game.StartGame();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
