using System;
using System.Collections;

namespace CalcClass
{
    public class Calc
    {
        private static string _lastError = "";

        public static string LastError
        {
            get { return _lastError; }
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                _lastError = "Error 09";
                return 0;
            }
            return a / b;
        }

        public static double Modulus(double a, double b)
        {
            if (b == 0)
            {
                _lastError = "Error 09";
                return 0;
            }
            return a % b;
        }

        public static double ABS(double a)
        {
            return Math.Abs(a);
        }

        public static double IABS(double a)
        {
            return -Math.Abs(a);
        }
    }

    public class ExpressionEvaluator
    {
        private static double erposition = 0;
        private static string expression = "";
        private static bool ShowMessage = true;
        private static string _lastError;

        public static string LastError
        {
            get { return _lastError; }
        }

        public static bool CheckCurrency(string input)
        {
            expression = input;
            erposition = 0;
            int bracketCount = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    erposition = i;
                    bracketCount++;
                }
                else if (expression[i] == ')')
                {
                    bracketCount--;
                    if (bracketCount < 0)
                    {
                        _lastError = $"Error 01 at {i}";
                        return false;
                    }
                }
            }

            if (bracketCount != 0)
            {
                _lastError = $"Error 01 at {GetErrorPosition()}";
                return false;
            }
            return true;
        }
        public static double GetErrorPosition()
        {
            return erposition + 1;
        }

        public static string Format(string input)
        {
            expression = input.Replace(" ", "");
            string formattedExpression = expression;

            if (IsOperator(formattedExpression[expression.Length - 1]))
            {
                _lastError = $"Error 05";
                return "";
            }

            for (int i = 0; i < expression.Length - 1; i++)
            {
                if (IsOperator(formattedExpression[i]) && IsOperator(formattedExpression[i + 1]))
                {
                    _lastError = $"Error 04 at {i}";
                    return "";
                }
                if (!IsOperator(formattedExpression[i]) && !IsDigit(formattedExpression[i]))
                {
                    _lastError = $"Error 02 at {i}";
                    return "";
                }
            }

            return formattedExpression;
        }

        public static ArrayList CreateStack(string input)
        {
            expression = input;
            ArrayList outputStack = new ArrayList();
            Stack operatorStack = new Stack();

            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]) || expression[i] == '.')
                {
                    string number = "";

                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        number += expression[i];
                        i++;
                    }

                    i--;

                    if (double.TryParse(number, out double result))
                    {
                        outputStack.Add(result);
                    }
                    else
                    {
                        _lastError = $"Invalid number in the expression: {number}";
                        return new ArrayList();
                    }
                }
                else if (expression[i] == '(')
                {
                    operatorStack.Push(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (operatorStack.Count > 0 && (char)operatorStack.Peek() != '(')
                    {
                        outputStack.Add(operatorStack.Pop());
                    }

                    if (operatorStack.Count == 0)
                    {
                        _lastError = "Mismatched parentheses in the expression.";
                        return new ArrayList();
                    }

                    operatorStack.Pop();
                }
                else if (IsOperator(expression[i]))
                {
                    while (operatorStack.Count > 0 && GetOperatorPrecedence(expression[i]) <= GetOperatorPrecedence((char)operatorStack.Peek()))
                    {
                        outputStack.Add(operatorStack.Pop());
                    }

                    operatorStack.Push(expression[i]);
                }
            }

            while (operatorStack.Count > 0)
            {
                if ((char)operatorStack.Peek() == '(' || (char)operatorStack.Peek() == ')')
                {
                    _lastError = "Mismatched parentheses in the expression.";
                    return new ArrayList();
                }

                outputStack.Add(operatorStack.Pop());
            }

            return outputStack;
        }

        public static string RunEstimate(ArrayList stack)
        {
            Stack resultStack = new Stack();

            foreach (object token in stack)
            {
                if (token is double)
                {
                    resultStack.Push(token);
                }
                else if (token is char)
                {
                    char op = (char)token;
                    if (resultStack.Count < 2)
                    {
                        _lastError = "Invalid expression.";
                        return "";
                    }

                    double b = (double)resultStack.Pop();
                    double a = (double)resultStack.Pop();
                    double result = 0;

                    switch (op)
                    {
                        case '+':
                            result = a + b;
                            break;
                        case '-':
                            result = a - b;
                            break;
                        case '*':
                            result = a * b;
                            break;
                        case '/':
                            if (b == 0)
                            {
                                _lastError = "Division by zero is not allowed.";
                                return "";
                            }
                            result = a / b;
                            break;
                        case '%':
                            if (b == 0)
                            {
                                _lastError = "Modulus by zero is not allowed.";
                                return "";
                            }
                            result = a % b;
                            break;
                    }

                    resultStack.Push(result);
                }
            }

            if (resultStack.Count != 1)
            {
                _lastError = "Invalid expression.";
                return "";
            }

            return resultStack.Pop().ToString();
        }

        public static string Estimate(string input)
        {
            _lastError = "";
            string formattedExpression = Format(input);
            if (string.IsNullOrWhiteSpace(formattedExpression))
            {
                return _lastError;
            }

            ArrayList stack = CreateStack(formattedExpression);
            if (stack.Count == 0)
            {
                return _lastError;
            }

            string result = RunEstimate(stack);
            if (!string.IsNullOrWhiteSpace(_lastError))
            {
                return _lastError;
            }

            return result;
        }

        private static bool IsOperator(char c)
        {
            return "+-*/%".Contains(c.ToString());
        }

        private static bool IsDigit(char c)
        {
            return "0123456789(),".Contains(c.ToString());
        }

        private static int GetOperatorPrecedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                case '%':
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
