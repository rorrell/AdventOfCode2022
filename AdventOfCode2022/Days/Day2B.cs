namespace AdventOfCode2022.Days
{
    public class Day2B : Day<int>
    {
        public override string GetFileName() => "Input2.txt";

        public override int Calculate(string[] lines)
        {
            var total = 0;
            foreach (var line in lines)
            {
                var game = new RockPaperScissors2(line.Split(' '));
                game.DetermineMove();
                total += game.ScoreGame();
            }
            return total;
        }
    }

    internal class RockPaperScissors2 : RockPaperScissors
    {
        private string Outcome;

        public RockPaperScissors2(string[] players) : base(players)
        {
            Outcome = players[1];
        }

        public void DetermineMove()
        {
            switch (Outcome)
            {
                case "X" when Opponent == "B":
                case "Y" when Opponent == "A":
                case "Z" when Opponent == "C":
                    You = "X";
                    break;
                case "X" when Opponent == "C":
                case "Y" when Opponent == "B":
                case "Z" when Opponent == "A":
                    You = "Y";
                    break;
                case "X" when Opponent == "A":
                case "Y" when Opponent == "C":
                case "Z" when Opponent == "B":
                    You = "Z";
                    break;

            }
        }
    }
}