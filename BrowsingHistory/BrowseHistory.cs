using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowsingHistory
{
    public class BrowseHistory
    {
        private readonly Stack<URL> _urls;
        public BrowseHistory()
        {
            _urls = new Stack<URL>();
        }

        public void Push(URL url) => _urls.Push(url);

        public void Pop() 
        {
            if (_urls.Count > 0 && _urls.Count != 1)
            {
                _urls.Pop();
            }            
        }

        public URL GetUrlTop() => _urls.Count >= 0 ? _urls.Peek() : null;
    }
}
