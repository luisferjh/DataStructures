namespace ParenthesisValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            ParenthesisValidation parenthesisValidation = new ParenthesisValidation();

            string text = "hello (I'm greeting to you [don't be mad]), how are you";

            Console.WriteLine(parenthesisValidation.ValidString(text));
        
        }
    }
}