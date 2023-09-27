using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParenthesisValidation
{
    public class ParenthesisValidation
    {
        private Stack<char> _parethesisOpen;
        private List<char> _parenthesisOpenCharacter = new List<char> { '{', '[', '(' };

        private Dictionary<char, char> _parenthesisCloseCharacter = new Dictionary<char, char>
        {
            { ')', '('},
            { '}', '{'},
            { ']', '['}
        };

        public ParenthesisValidation()
        {
            _parethesisOpen = new Stack<char>();
        }

        private void Push(char parenthesis) => _parethesisOpen.Push(parenthesis);

        private void Pop() => _parethesisOpen.Pop();

        public bool ValidString(string text)
        {
            bool isValid = false;
            var arrayText = text.ToArray();
            for (int i = 0; i < arrayText.Length; i++)
            {
                char actual = arrayText[i];
                if (_parenthesisOpenCharacter.Contains(arrayText[i]))
                {
                    Push(arrayText[i]);
                }

                if (_parenthesisCloseCharacter.ContainsKey(arrayText[i]))
                {
                    char parenthesisOpen = _parenthesisCloseCharacter[arrayText[i]];

                    if (_parethesisOpen.Contains(parenthesisOpen))
                        _parethesisOpen.Pop();

                }
            }

            return _parethesisOpen.Count > 0 ? false : true;
        }
    }
}
