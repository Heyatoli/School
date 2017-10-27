using System;
using System.Collections.Generic;
using System.Text;

namespace Subproject_2
{
    class Post
    {
        public int id { get; set; }

        public int type { get; set; }

        public int parent_id { get; set; }

        public int answer_id { get; set; }

        public DateTime creationDate { get; set; }

        public int score { get; set; }

        public string text { get; set; }

        public DateTime closedDate { get; set; }

        public string title { get; set; }

        public User user { get; set; }

        public List<Tag> tags { get; set; }
    }
}
