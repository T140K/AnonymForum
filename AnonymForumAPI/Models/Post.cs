﻿using System;
using System.Collections.Generic;

namespace AnonymForumAPI.Models
{
    public partial class Post
    {
        public Post()
        {
            Replies = new HashSet<Reply>();
        }

        public int Id { get; set; }
        public int Fktopic { get; set; }
        public string Title { get; set; } = null!;
        public string Contents { get; set; } = null!;
        public DateTime TimePosted { get; set; }

        public virtual Topic FktopicNavigation { get; set; } = null!;
        public virtual ICollection<Reply> Replies { get; set; }
    }
}
