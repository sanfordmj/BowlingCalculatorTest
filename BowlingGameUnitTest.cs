using BowlingCalculator;
using BowlingCalculator.Interfaces;
using NuGet.Frameworks;

namespace BowlingCalculatorTest
{
    [TestFixture]
    public class BowlingGameUnitTest
    {
        private readonly IFrame _frame;
        BowlingGame _bowlingGame;
       
        public BowlingGameUnitTest()
        {
            _frame = new BowlingFrame();
            _bowlingGame = new BowlingGame(_frame);
        }

        [Test]
        public void GetFrameScore()
        {
            List<int> _frame = new List<int>();
            _frame.Add(10);
            _frame.Add(10);
            _frame.Add(10);
            int score = _bowlingGame.GetFrameScore(_frame);
            Assert.IsTrue(score == 30, "Unit Test Failed");
            _bowlingGame.ResetGame();
        }

        [Test]
        public void RemoveRoll()
        {
            List<int> _frame = new List<int>();
            _frame.Add(0);
            _frame.Add(10);
            _frame.Add(1);
            var id = _bowlingGame.RecordScore(_frame);
            _bowlingGame.RemoveRoll(id);
            Assert.IsFalse(_bowlingGame.GetGameStats.ContainsKey(id), "Unit Test Failed");
            _bowlingGame.ResetGame();
        }

        [Test]
        public void ClearGame()
        {
            List<int> _frame = new List<int>();
            _frame.Add(5);
            _frame.Add(2);
            _frame.Add(2);
            Assert.IsTrue(_bowlingGame.GetGameStats.Count == 0, "Unit Test Failed");
            _bowlingGame.ResetGame();
        }

        [Test]
        public void RecordScore()
        {
            List<int> _frame = new List<int>();
            _frame.Add(5);
            _frame.Add(2);
            _frame.Add(2);
            int id = _bowlingGame.RecordScore(_frame);
            Assert.IsTrue(id > -1, "Unit Test Failed");
            _bowlingGame.ResetGame();
        }

        [Test]
        public void GetScore()
        {
            List<int> _frame = new List<int>();
            _frame.Add(10);
            _frame.Add(10);
            _frame.Add(10);
            int id = _bowlingGame.RecordScore(_frame);            ;
            Assert.IsTrue(_bowlingGame.GetScore() == 30, "Unit Test Failed");
            _bowlingGame.ResetGame();
        }

    }
}