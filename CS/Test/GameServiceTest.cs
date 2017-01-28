using Microsoft.VisualStudio.TestTools.UnitTesting;
using static RockPaperSissorsSpockLizard.GameService;

namespace RockPaperSissorsSpockLizard.Test
{
    [TestClass]
    public class GameServiceTest
    {
        [TestMethod]
        public void Execute()
        {
            var service = new GameService();
            var resultado = service.Evaluate(Move.Rock, Move.Rock);
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void IsTie()
        {
            var service = new GameService();
            var resultado = service.IsTie(Move.Rock, Move.Rock);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Win_Rock_against_Scissors()
        {
            var service = new GameService();
            Assert.IsTrue(service.Defeats(Move.Rock, Move.Scissors), "Rock defeats Scissors");
        }

        [TestMethod]
        public void Win_Rock_against_Lizard()
        {
            var service = new GameService();
            Assert.IsTrue(service.Defeats(Move.Rock, Move.Lizard), "Rock defeats Lizard");
        }

        [TestMethod]
        public void Win_Paper_against_Piedra()
        {
            var service = new GameService();
            Assert.IsTrue(service.Defeats(Move.Paper, Move.Rock), "Paper defeats Rock");
        }

        [TestMethod]
        public void Win_Paper_against_Spock()
        {
            var service = new GameService();
            Assert.IsTrue(service.Defeats(Move.Paper, Move.Spock), "Paper defeats Spock");
        }

        [TestMethod]
        public void Win_Scissors_against_Paper()
        {
            var service = new GameService();
            Assert.IsTrue(service.Defeats(Move.Scissors, Move.Paper), "Scissors defeats Paper");
        }

        [TestMethod]
        public void Win_Scissors_against_Lizard()
        {
            var service = new GameService();
            Assert.IsTrue(service.Defeats(Move.Scissors, Move.Lizard), "Scissors defeats Lizard");
        }

        [TestMethod]
        public void Win_Lizard_against_pock()
        {
            var service = new GameService();
            Assert.IsTrue(service.Defeats(Move.Lizard, Move.Spock), "Lizard defeats Spock");
        }

        [TestMethod]
        public void Win_Lizard_against_Paper()
        {
            var service = new GameService();
            Assert.IsTrue(service.Defeats(Move.Lizard, Move.Paper), "Lizard defeats Paper");
        }

        [TestMethod]
        public void Win_Spock_against_Scissors()
        {
            var service = new GameService();
            Assert.IsTrue(service.Defeats(Move.Spock, Move.Scissors), "Lizard defeats Scissors");
        }

        [TestMethod]
        public void Win_Spock_against_Piedra()
        {
            var service = new GameService();
            Assert.IsTrue(service.Defeats(Move.Spock, Move.Rock), "Spock defeats Rock");
        }

        [TestMethod]
        public void Rock_loses_out_to_Paper()
        {
            var service = new GameService();
            Assert.IsFalse(service.Defeats(Move.Rock, Move.Paper), "Rock loses out to Paper ");
        }

        [TestMethod]
        public void Rock_loses_out_to_Spock()
        {
            var service = new GameService();
            Assert.IsFalse(service.Defeats(Move.Rock, Move.Spock), "Rock loses out to Spock");
        }

        [TestMethod]
        public void Paper_loses_out_to_Lizard()
        {
            var service = new GameService();
            Assert.IsFalse(service.Defeats(Move.Paper, Move.Lizard), "Paper loses out to Lizard");
        }

        [TestMethod]
        public void Paper_loses_out_to_Scissors()
        {
            var service = new GameService();
            Assert.IsFalse(service.Defeats(Move.Paper, Move.Scissors), "Paper loses out to Scissors");
        }

        [TestMethod]
        public void Scissors_loses_out_to_Piedra()
        {
            var service = new GameService();
            Assert.IsFalse(service.Defeats(Move.Scissors, Move.Rock), "Scissors loses out to Rock");
        }

        [TestMethod]
        public void Scissors_loses_out_to_Spock()
        {
            var service = new GameService();
            Assert.IsFalse(service.Defeats(Move.Scissors, Move.Spock), "Scissors loses out to Spock");
        }

        [TestMethod]
        public void Lizard_loses_out_to_Piedra()
        {
            var service = new GameService();
            Assert.IsFalse(service.Defeats(Move.Lizard, Move.Rock), "Lizard loses out to Rock");
        }

        [TestMethod]
        public void Lizard_loses_out_to_Scissors()
        {
            var service = new GameService();
            Assert.IsFalse(service.Defeats(Move.Lizard, Move.Scissors), "Lizard loses out to Scissors");
        }

        [TestMethod]
        public void Spock_loses_out_to_Paper()
        {
            var service = new GameService();
            Assert.IsFalse(service.Defeats(Move.Spock, Move.Paper), "Rock loses out to Paper");
        }

        [TestMethod]
        public void Spock_loses_out_to_Lizard()
        {
            var service = new GameService();
            Assert.IsFalse(service.Defeats(Move.Spock, Move.Lizard), "Spock loses out to Lizard");
        }

        [TestMethod]
        public void Evaluate_Rock_Win_Scissors()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Rock, Move.Scissors);
            Assert.AreEqual(Result.Win, result);
        }


        [TestMethod]
        public void Evaluate_Rock_Win_Lizard()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Rock, Move.Lizard);
            Assert.AreEqual(Result.Win, result);
        }

        [TestMethod]
        public void Evaluate_Paper_Win_Piedra()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Paper, Move.Rock);
            Assert.AreEqual(Result.Win, result);
        }


        [TestMethod]
        public void Evaluate_Paper_Win_Spock()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Paper, Move.Spock);
            Assert.AreEqual(Result.Win, result);
        }

        [TestMethod]
        public void Evaluate_Scissors_Win_Paper()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Scissors, Move.Paper);
            Assert.AreEqual(Result.Win, result);
        }


        [TestMethod]
        public void Evaluate_Scissors_Win_Lizard()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Scissors, Move.Lizard);
            Assert.AreEqual(Result.Win, result);
        }

        [TestMethod]
        public void Evaluate_Spock_Win_Scissors()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Spock, Move.Scissors);
            Assert.AreEqual(Result.Win, result);
        }


        [TestMethod]
        public void Evaluate_Spock_Win_Piedra()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Spock, Move.Rock);
            Assert.AreEqual(Result.Win, result);
        }

        [TestMethod]
        public void Evaluate_Lizard_Win_Spock()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Lizard, Move.Spock);
            Assert.AreEqual(Result.Win, result);
        }


        [TestMethod]
        public void Evaluate_Lizard_Win_Paper()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Lizard, Move.Paper);
            Assert.AreEqual(Result.Win, result);
        }

        [TestMethod]
        public void Evaluate_Scissors_Pierde_Piedra()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Scissors, Move.Rock);
            Assert.AreEqual(Result.Lose, result);
        }


        [TestMethod]
        public void Evaluate_Lizard_Pierde_Piedra()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Lizard, Move.Rock);
            Assert.AreEqual(Result.Lose, result);
        }

        [TestMethod]
        public void Evaluate_Rock_Pierde_Paper()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Rock, Move.Paper);
            Assert.AreEqual(Result.Lose, result);
        }


        [TestMethod]
        public void Evaluate_Spock_Pierde_Paper()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Spock, Move.Paper);
            Assert.AreEqual(Result.Lose, result);
        }

        [TestMethod]
        public void Evaluate_Paper_Pierde_Scissors()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Paper, Move.Scissors);
            Assert.AreEqual(Result.Lose, result);
        }


        [TestMethod]
        public void Evaluate_Lizard_Pierde_Scissors()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Lizard, Move.Scissors);
            Assert.AreEqual(Result.Lose, result);
        }

        [TestMethod]
        public void Evaluate_Scissors_Pierde_Spock()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Scissors, Move.Spock);
            Assert.AreEqual(Result.Lose, result);
        }


        [TestMethod]
        public void Evaluate_Rock_Pierde_Spock()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Rock, Move.Spock);
            Assert.AreEqual(Result.Lose, result);
        }

        [TestMethod]
        public void Evaluate_Spock_Pierde_Lizard()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Spock, Move.Lizard);
            Assert.AreEqual(Result.Lose, result);
        }


        [TestMethod]
        public void Evaluate_Paper_Pierde_Lizard()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Paper, Move.Lizard);
            Assert.AreEqual(Result.Lose, result);
        }

        [TestMethod]
        public void Evaluate_Rock_Empate()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Rock, Move.Rock);
            Assert.AreEqual(Result.Tie, result);
        }

        [TestMethod]
        public void Evaluate_Paper_Empate()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Paper, Move.Paper);
            Assert.AreEqual(Result.Tie, result);
        }

        [TestMethod]
        public void Evaluate_Scissors_Empate()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Scissors, Move.Scissors);
            Assert.AreEqual(Result.Tie, result);
        }

        [TestMethod]
        public void Evaluate_Lizard_Empate()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Lizard, Move.Lizard);
            Assert.AreEqual(Result.Tie, result);
        }

        [TestMethod]
        public void Evaluate_Spock_Empate()
        {
            var service = new GameService();
            var result = service.Evaluate(Move.Spock, Move.Spock);
            Assert.AreEqual(Result.Tie, result);
        }
    }
}
