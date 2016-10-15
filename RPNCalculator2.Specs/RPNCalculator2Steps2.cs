using NUnit.Framework;
using TechTalk.SpecFlow;

namespace RPNCalculator2.Specs
{
    [Binding]
    public class RPNCalculator2Steps2
    {
        private CalculatorContext _context;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string p0)
        {
            _context = new CalculatorContext { CommandText = p0 };
        }

        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            _context.Result = Calculator.Compute(_context.CommandText);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.AreEqual(p0, _context.Result);
        }
    }
}
