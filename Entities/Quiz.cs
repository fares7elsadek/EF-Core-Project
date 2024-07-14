﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore07.Entities
{
    public abstract class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public Course Course { get; set; }  
    }
}
