using System.Collections.Generic;

namespace RockPaperSissorsSpockLizard
{
    public class GameService
    {
        public enum Move { Rock, Paper, Scissors, Spock, Lizard };
        public enum Result { Tie, Win, Lose };

        Dictionary<Move, List<Move>> WinRules = new Dictionary<Move, List<Move>>();

        public GameService()
        {
            WinRules.Add(Move.Rock, new List<Move>()
            {
                Move.Scissors,
                Move.Lizard
            });

            WinRules.Add(Move.Paper, new List<Move>()
            {
                Move.Rock,
                Move.Spock
            });

            WinRules.Add(Move.Scissors, new List<Move>()
            {
                Move.Paper,
                Move.Lizard
            });

            WinRules.Add(Move.Spock, new List<Move>()
            {
                Move.Scissors,
                Move.Rock
            });

            WinRules.Add(Move.Lizard, new List<Move>()
            {
                Move.Spock,
                Move.Paper
            });
        }


        public Result Evaluate(Move jugada1, Move jugada2)
        {
            if (IsTie(jugada1, jugada2))
            {
                return Result.Tie;
            }
            if (Defeats(jugada1, jugada2))
            {
                return Result.Win;
            }
            return Result.Lose;
        }

        public bool IsTie(Move j1, Move j2)
        {
            return j1 == j2;
        }

        public bool Defeats(Move j1, Move j2)
        {
            List<Move> loosers;
            WinRules.TryGetValue(j1, out loosers);
            return loosers.Contains(j2);
        }

    }
}
