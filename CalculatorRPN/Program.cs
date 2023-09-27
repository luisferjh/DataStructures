using System.Linq.Expressions;

namespace CalculatorRPN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateRPN calculateRPN = new CalculateRPN();

            string rpn1 = "3 4 +";
            string rpn2 = "5 2 * 1 +";
            string rpn3 = "7 2 3 * -";
            string rpn4 = "4 5 + 6 7 + *";
            string rpn5 = "2 3 ^";
            string rpn6 = "10 2 / 3 *";
            string rpn7 = "8 2 / 3 4 * +";


            Console.WriteLine(calculateRPN.ResultExpression(rpn1));
            Console.WriteLine(calculateRPN.ResultExpression(rpn2));
            Console.WriteLine(calculateRPN.ResultExpression(rpn3));
            Console.WriteLine(calculateRPN.ResultExpression(rpn4));
            Console.WriteLine(calculateRPN.ResultExpression(rpn5));
            Console.WriteLine(calculateRPN.ResultExpression(rpn6));
            Console.WriteLine(calculateRPN.ResultExpression(rpn7));
        }
    }
}