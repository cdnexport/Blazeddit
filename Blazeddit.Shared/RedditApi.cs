using AutoMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blazeddit.Shared
{
    public static class RedditApi
    {
        public static string PROXY = "https://blooming-hollows-45267.herokuapp.com/";

        static RedditApi()
        {
            Mapper.Initialize(cfg => cfg.AddMaps("Blazeddit.Shared"));
        }

        public async static Task<Subreddit> GetSubreddit(string sub = "all", string after = null)
        {
            using (HttpClient client = new HttpClient())
            {
                Subreddit subreddit = null;
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{PROXY}https://reddit.com/r/{sub}.json{(after == null ? "" : $"?after={after}")}");
                    Console.WriteLine(response);
                    response.EnsureSuccessStatusCode();

                    SubResponse subResponse = null;
                    using (var reader = new StreamReader(await response.Content.ReadAsStreamAsync()))
                    {
                        subResponse = SubResponse.FromJson(reader.ReadToEnd());
                    }

                    subreddit = new Subreddit
                    {
                        Name = sub,
                        Posts = Mapper.Map<Post[]>(subResponse.Data.Children)
                    };
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Exception");
                    Console.WriteLine($"Message: {e.Message}");
                }

                return subreddit;
            }
        }

        public static Comment[] GetComments(string permalink)
        {
            return new Comment[0];
        }
    }
}
