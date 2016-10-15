using System;
using System.Collections.Generic;

namespace RPNCalculator2
{
    public static class Calculator
    {
        #region Operators

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

        #endregion

        public static int ParseCommand(string command)
        {
            var commandMembers = command.Split(' ');
            var stack = new List<string>();

            foreach (var member in commandMembers)
            {
                ProcessingMember(stack, member);
            }

            return int.Parse(stack[0]);
        }

        private static void ProcessingMember(List<string> stack, string member)
        {
            int value;
            if (int.TryParse(member, out value))
            {
                AddValue(stack, value);
            }
            else
            {
                ComputeStack(stack, member);
            }
        }

        private static void AddValue(ICollection<string> stack, int value)
        {
            stack.Add(value.ToString());
        }

        private static void ComputeStack(List<string> stack, string oper)
        {
            var stackCount = stack.Count;
            var firstOperand = int.Parse(stack[stackCount - 2]);
            var secondOperand = int.Parse(stack[stackCount - 1]);
            var value = Compute(firstOperand, secondOperand, oper);
            RemoveTwoLast(stack);
            AddValue(stack, value);
        }

        private static void RemoveTwoLast(List<string> stack)
        {
            stack.RemoveRange(stack.Count - 2, 2);
        }

        private static int Compute(int firstOperand, int secondOperand, string oper)
        {
            switch (oper)
            {
                case "+":
                    return Add(firstOperand, secondOperand);
                case "-":
                    return Substract(firstOperand, secondOperand);
                case "*":
                    return Multiply(firstOperand, secondOperand);
                default:
                    return Divide(firstOperand, secondOperand);
            }
        }
    }
}
