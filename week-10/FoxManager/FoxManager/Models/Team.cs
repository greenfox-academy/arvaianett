﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Team
    {
        public long Id { get; set; }
        public string TeamName { get; set; }

        public List<Student> Students { get; set; }
        public List<TaskClass> Tasks { get; set; }
    }
}
