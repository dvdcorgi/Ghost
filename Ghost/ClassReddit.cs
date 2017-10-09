using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditSharp;

namespace Ghost
{
    class ClassReddit
    {
        public async void LogInAsync(string user, string pass)
        {
            var webAgent = new BotWebAgent(user, pass, "ClientID", "ClientSecret", "RedirectUri");
            //This will check if the access token is about to expire before each request and automatically request a new one for you
            //"false" means that it will NOT load the logged in user profile so reddit.User will be null
            var reddit = new Reddit(webAgent, false);
            var subreddit = reddit.GetSubredditAsync("/r/example");
            //await subreddit.SubscribeAsync();
        }

        public void GetSub()
        {
            var r = new Reddit();
            var x = r.GetPopularSubreddits(5);
            Console.WriteLine(x);
        }
    }
}
