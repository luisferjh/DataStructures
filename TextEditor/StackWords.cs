using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public class StackWords
    {
        private Stack<string> _undos;
        private Stack<string> _redos;
        public string TextEditor { get; set; }

        public StackWords()
        {
            _undos = new Stack<string>();
            _redos = new Stack<string>();
        }

        public void AddWords(string words) 
        {
            TextEditor += words;
            PushWordsUndo(words);
        }

        public void Undo() 
        {
            string sentence = _undos.Pop();
            TextEditor = TextEditor.Replace(sentence, "");
            PushWordsRedo(sentence);
        }

        public void Redo()
        {
            string sentence = _redos.Pop();
            TextEditor += sentence;
            PushWordsUndo(sentence);
        }

        public void ShowFullText() => Console.WriteLine(TextEditor);

        private void PushWordsUndo(string words) => _undos.Push(words);
        private void PushWordsRedo(string words) => _redos.Push(words);
      

    }
}
