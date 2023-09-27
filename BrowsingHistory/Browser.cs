using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowsingHistory
{
    public class Browser
    {
        private BrowseHistory BrowseHistory { get; set; }
        private URL CurrentSite { get; set; }

        public Browser() 
        {
            BrowseHistory = new BrowseHistory();
        }        

        public void GoBack() 
        {
            BrowseHistory.Pop();
            var topSite = BrowseHistory.GetUrlTop();
            if (topSite is not null)
            {               
                CurrentSite = topSite;
                DisplayCurrent();
            }
            else 
            {
                Console.WriteLine("There is no sites in the history");
            }            
        }

        public void GoToSite(URL url) 
        {
            CurrentSite = url;
            BrowseHistory.Push(url);
            DisplayCurrent();
        }

        private void DisplayCurrent() 
        {
            Console.WriteLine($"You are navigating in {CurrentSite.Name} with the url:{CurrentSite.Url}");
        }
        
    }
}
