namespace RPS_Game
{
    public class Player
    {
        private String name;
        private int score;

        public string Name { get; set; }

        public int Score { get; set; }

        public string chooseMove()
        {
            Console.WriteLine($"{name},Please choose your move");

            string move = Console.ReadLine().ToUpper();
            while (move != "ROCK" && move != "PAPER" && move != "SCISSORS")
            {
                Console.WriteLine("You choose invalid value");
                move = Console.ReadLine().ToUpper();

            }
            return move;
        }

    }
}
