namespace RPS_Game
{
    public class RPSGam
    {
        public Player player;
        public Player ai;
        private int roundsPlayed;

        public RPSGam(string playerName)
        {
            player = new Player { Name = playerName };
           ai = new Player { Name = "AI" };
            roundsPlayed = 0;
        }

        public void StartGame()
        {
            while ((player.Score < 3 && ai.Score < 3))

            {
                string playerMove = player.chooseMove();
                string aiMove = aiRandomMove();
                Console.WriteLine($"You choose {playerMove} and AI choose {aiMove}");
                string result = compareGame(playerMove, aiMove);
                UpdateScore(result);
                Console.WriteLine(result);
                Console.WriteLine($"Your score is {player.Score} and The AI score is {ai.Score}");

            }

        }

        public string aiRandomMove()
        {
            Random random = new Random();
            int randomMove = random.Next(0, 3);
            string[] aiMoves = { "ROCK", "PAPER", "SCISSORS" };
            return aiMoves[randomMove];
        }

        public string compareGame(string playerMove, string aiMove)
        {
            if (playerMove == aiMove)
            {
                return "tie";
            }
            else if (playerMove == "ROCK" && aiMove == "SCISSORS" ||
                     playerMove == "PAPER" && aiMove == "ROCK" ||
                     playerMove == "SCISSORS" && aiMove == "PAPER")
            {
                return $"{player.Name}, you won";
            }
            else
            {
                return $"{ai.Name}, AI won";
            }


        }

        public void UpdateScore(string result)
        {
            if (result.Contains(player.Name))
            {
                player.Score++;
            }
            else if (result.Contains(ai.Name))
            {
                ai.Score++;
            }

        }


    }

}
