﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }
        public int? BlogID { get; set; }
        public Blog Blog { get; set; }
        public int? WriterId { get; set; }
        public Writer Writer { get; set; }

    }
}
