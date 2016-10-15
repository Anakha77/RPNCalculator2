using System;

namespace RPNCalculator2
{
    public static class Calculator
    {
        public static int Add(int firstArgument, int secondArgument)
        {
            return firstArgument + secondArgument;
        }

        public static int Substract(int firstArgument, int secondArgument)
        {
            return firstArgument - secondArgument;
        }

        public static int Multiply(int firstArgument, int secondArgument)
        {
            return firstArgument * secondArgument;
        }

        public static int Divide(int firstArgument, int secondArgument)
        {
            return secondArgument == 0 ? secondArgument : firstArgument / secondArgument;
        }

        public static int Compute(string command)
        {
            int result;
            if (int.TryParse(command, out result))
            {
                return result;
            }
            var operands = command.Split(' ');
            var firstOperand = int.Parse(operands[0]);
            var secondOperand = int.Parse(operands[1]);
            var Operator = Convert.ToChar(operands[2]);

            switch (Operator)
            {
                case '+':
                    return Add(firstOperand, secondOperand);
                case '-':
                    return Substract(firstOperand, secondOperand);
                case '*':
                    return Multiply(firstOperand, secondOperand);
                default:
                    return Divide(firstOperand, secondOperand);
            }
        }
    }
}
