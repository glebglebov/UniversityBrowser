﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Univer.Models.Entities
{
    class Subject : Entity
    {
        public string Name { get; set; }

        public Professor Professor { get; set; }
    }
}
