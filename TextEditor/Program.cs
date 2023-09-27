namespace TextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackWords stackWords = new StackWords();
            bool outLoop = true;
           
            do
            {
                Console.WriteLine("1. Add words");
                Console.WriteLine("2. Exit");
                string op = Console.ReadLine();
                int option = int.Parse(op);

                switch (option)
                {
                    case 1:
                        string words = Console.ReadLine();
                        words += "\n";
                        stackWords.AddWords(words);
                        break;
                    case 2:
                        outLoop = false;
                        break;
                }
            } while (outLoop);

            stackWords.Undo();
            stackWords.ShowFullText();
            stackWords.Undo();
            stackWords.ShowFullText();
            stackWords.Redo();
            stackWords.ShowFullText();
        }
    }
}