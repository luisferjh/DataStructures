namespace BrowsingHistory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();

            URL url1 = new URL
            {
                Id = Guid.NewGuid(),
                Name = "Google",
                Url = "https://www.google.com"
            };

            URL url2 = new URL
            {
                Id = Guid.NewGuid(),
                Name = "Facebook",
                Url = "https://www.facebook.com"
            };

            URL url3 = new URL
            {
                Id = Guid.NewGuid(),
                Name = "Twitter",
                Url = "https://www.twitter.com"
            };

            URL url4 = new URL
            {
                Id = Guid.NewGuid(),
                Name = "LinkedIn",
                Url = "https://www.linkedin.com"
            };

            URL url5 = new URL
            {
                Id = Guid.NewGuid(),
                Name = "GitHub",
                Url = "https://www.github.com"
            };

            URL url6 = new URL
            {
                Id = Guid.NewGuid(),
                Name = "Amazon",
                Url = "https://www.amazon.com"
            };

            URL url7 = new URL
            {
                Id = Guid.NewGuid(),
                Name = "YouTube",
                Url = "https://www.youtube.com"
            };

            browser.GoToSite(url1);
            browser.GoToSite(url2);
            browser.GoToSite(url3);
            browser.GoToSite(url4);
            browser.GoToSite(url5);

            browser.GoBack();
            browser.GoBack();

            browser.GoToSite(url6);


        }
    }
}