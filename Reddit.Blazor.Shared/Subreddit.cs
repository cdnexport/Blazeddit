using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.Blazor.Shared
{
    public class Subreddit
    {
        public string Name { get; set; }

        public Post[] Posts { get; set; }
    }
}
