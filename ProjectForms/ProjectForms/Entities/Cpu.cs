using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForms.Entities
{
    internal class Cpu
    {
        public int Id { get; set; }

        public string Brand { get; set; } = null!;

        public string Model { get; set; } = null!;

        public int Cores { get; set; }

        public string ClockSpeed { get; set; } = null!;

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
