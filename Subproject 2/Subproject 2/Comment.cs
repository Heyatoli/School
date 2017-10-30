﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Subproject_2
{
    class Comment
    {
        [Column("comment_id")]
        public int id { get; set; }

        [Column("comment_score")]
        public int score { get; set; }

        [Column("comment_text")]
        public string text { get; set; }

        [Column("comment_create_date")]
        public DateTime creationDate { get; set; }

        public User user { get; set; }

        //public Post post { get; set; }
    }
}
