using NUnit.Framework;
using TechTalk.SpecFlow;

namespace RPNCalculator2.Specs
{
    [Binding]
    public class RPNCalculatorTest
    {
        public CalculatorContext _context = new CalculatorContext();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string p0)
        {
            _context.Command = p0;
        }

        [When(@"I Compute the command")]
        public void WhenIComputeTheCommand()
        {
            _context.Result = Calculator.ParseCommand(_context.Command);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.AreEqual(p0, _context.Result);
        }
    }
}
