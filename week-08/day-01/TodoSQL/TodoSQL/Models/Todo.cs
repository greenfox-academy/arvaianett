﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TodoSQL.Models
{
    public class Todo
    {
        [Key]
        public long TodoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool IsUrgent { get; set; } = false;
        public bool IsDone { get; set; } = false;
        public DateTime DateTime { get; set; } = DateTime.Now;

        public User User { get; set; }
    }
}
