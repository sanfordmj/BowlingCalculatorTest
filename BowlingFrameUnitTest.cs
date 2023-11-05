
using BowlingCalculator;
using NuGet.Frameworks;

namespace BowlingCalculatorTest
{
    [TestFixture]
    public class BowlingFrameUnitTest
    {

        BowlingFrame _bowlingFrame = new BowlingFrame();
       
        [Test]
        public void Strike()
        {
            List<int> _frame = new List<int>();
            _frame.Add(10);
            _frame.Add(10);
            _frame.Add(10);
            Assert.IsTrue(_bowlingFrame.CalculateFrame(_frame) == 30, "Unit Test Failed");
        }

        [Test]
        public void Spare()
        {
            List<int> _frame = new List<int>();
            _frame.Add(0);
            _frame.Add(10);
            _frame.Add(1);
            Assert.IsTrue(_bowlingFrame.CalculateFrame(_frame) == 11, "Unit Test Failed");
        }

        [Test]
        public void Open()
        {
            List<int> _frame = new List<int>();
            _frame.Add(5);
            _frame.Add(2);
            _frame.Add(2);
            Assert.IsTrue(_bowlingFrame.CalculateFrame(_frame) == 7, "Unit Test Failed");
        }
    }
}