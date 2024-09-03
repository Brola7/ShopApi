using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForms.Entities
{
    internal class PurchaseHistory
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Category { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public string Model { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
