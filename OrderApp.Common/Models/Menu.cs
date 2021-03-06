﻿using System;
using System.Collections.Generic;

namespace OrderApp.Common.Models
{
    public class Menu
    {
        Guid id;
        public Guid Id
        {
            get
            {
                if (id == null || id == Guid.Empty)
                {
                    id = new Guid();
                }
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Order> Orders { get; set; }


    }
}