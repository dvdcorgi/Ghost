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

        public async Task ActionRedditAsync()
        {
            var reddit = new Reddit();
            var subreddit = await reddit.GetSubredditAsync("/r/DotA2");

            var x = subreddit.DisplayName;
            Console.WriteLine(x);
            //var comments = subreddit.Comments.GetListingStream();

            //await comments.Execute();
            //foreach (var comment in subreddit.CommentStream)
            //{
            //    Console.WriteLine(DateTime.Now + "   New Comment posted to /r/example: " + comment.ShortLink);
            //}
        }

        public async Task ActReddit()
        {
            Task<int> randNum = GetRandom();
            int result = await randNum;
            Console.WriteLine(result);
        }

        private async Task<int> GetRandom()
        {
            await Task.Delay(3000);
            Random r = new Random();
            return r.Next(1, 100);
        }

        public void GetSync()
        {
            Random r = new Random();
            var num = r.Next(1, 100);
            Console.WriteLine("Sync " + num);
        }

        public async Task GetAsync()
        {
            await Task.Delay(0);
            Random r = new Random();
            var num = r.Next(1, 100);
            Console.WriteLine("Async " + num);
        }
    }
}
