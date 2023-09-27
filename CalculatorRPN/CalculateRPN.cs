using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorRPN
{
    public class CalculateRPN
    {
        private Queue<string> _operators;
        private Stack<int> _operands;
        private List<string> _allOperators = new List<string> { "+", "-", "/", "*", "^" };
        public CalculateRPN()
        {
            _operators = new Queue<string>();
            _operands = new Stack<int>();
        }

        private void Enqueue(string op) => _operators.Enqueue(op);

        private void Dequeue() => _operators.Dequeue();

        private void PushOperand(int operand) => _operands.Push(operand);

        private int PopOperand() => _operands.Pop();

        public int ResultExpression(string expresion) 
        {
            Clean();
            var arrayExpression = expresion.Split(' ');
            FillOperators(expresion);

            for (int i = 0; i < arrayExpression.Length; i++)
            {
                var arrayValue = arrayExpression[i];

                if (string.IsNullOrEmpty(arrayValue) || arrayValue == " ")
                    continue;

                if (IsOperator(arrayValue)) 
                {
                    int opeand1 = PopOperand();
                    int opeand2 = PopOperand();
                    DoExpression(arrayValue, opeand1, opeand2);                               
                }
                else
                    PushOperand(int.Parse(arrayValue));

            }
            return PopOperand();
        }

        private void DoExpression(string op, int opeand1, int opeand2)
        {            
            int result = 0;
            switch (op)
            {
                case "+":
                   
                    result = opeand2 + opeand1;
                    break;
                case "-":                   
                    result = Math.Abs(opeand2 - opeand1);
                    break;
                case "*":                   
                    result = opeand2 * opeand1;
                    break;
                case "/":
                    if (opeand1 == 0)
                    {
                        throw new DivideByZeroException("No se puede dividir entre cero.");
                    }
                    result = opeand2 / opeand1;
                    break;
                case "^":                   
                    result = Convert.ToInt32(Math.Pow(Convert.ToDouble(opeand2), Convert.ToDouble(opeand1)));
                    break;
            }
            PushOperand(result);
        }

        private void FillOperators(string expresion) 
        {
            var arrayExpression = expresion.ToArray();
            for (int i = 0; i < arrayExpression.Count(); i++)
            {                
                if (IsOperator(arrayExpression[i].ToString()))
                    Enqueue(arrayExpression[i].ToString());                
            }
        }

        private bool IsOperator(string character) => _allOperators.Contains(character) ? true : false;

        private void Clean() 
        {
            _operators.Clear();
            _operands.Clear();
        }
    }
}
