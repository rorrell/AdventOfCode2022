namespace AdventOfCode2022.Days
{
    public class Day2A : Day<int>
    {
        public override string GetFileName() => "Input2.txt";

        public override int Calculate(string[] lines)
        {
            var total = 0;
            foreach (var line in lines)
            {
                var game = new RockPaperScissors(line.Split(' '));
                total += game.ScoreGame();
            }
            return total;
        }
    }

    internal class RockPaperScissors
    {
        internal string You { get; set; }
        internal string Opponent { get; }

        public RockPaperScissors(string[] players)
        {
            Opponent = players[0];
            You = players[1];
        }

        public int ScoreGame()
        {
            var score = 0;
            switch (You)
            {
                case "X" when Opponent == "C":
                case "Y" when Opponent == "A":
                case "Z" when Opponent == "B":
                    score += 6;
                    break;
                case "X" when Opponent == "A":
                case "Y" when Opponent == "B":
                case "Z" when Opponent == "C":
                    score += 3;
                    break;
            }

            switch (You)
            {
                case "X":
                    score += 1;
                    break;
                case "Y":
                    score += 2;
                    break;
                case "Z":
                    score += 3;
                    break;
            }

            return score;
        }
    }

}