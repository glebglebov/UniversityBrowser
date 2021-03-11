﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Univer.Models.Entities
{
    class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}