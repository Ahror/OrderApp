﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public class Menu
    {
        public Guid MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}