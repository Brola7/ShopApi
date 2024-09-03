﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForms.Entities
{
    internal class Motherboard
    {
        public int Id { get; set; }

        public string Brand { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string Socket { get; set; } = null!;

        public string Ram { get; set; } = null!;

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
