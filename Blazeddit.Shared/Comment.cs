using System;

namespace Blazeddit.Shared
{
    public class Comment
    {
        public string Body { get; set; }

        public string User { get; set; }

        public long Score { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}