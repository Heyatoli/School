using System;
using System.Collections.Generic;
using System.Text;

namespace Subproject_2
{
    class Comment
    {
        public int id { get; set; }

        public int score { get; set; }

        public string text { get; set; }

        public DateTime creationDate { get; set; }

        public User user { get; set; }

        public Post post { get; set; }
    }
}
