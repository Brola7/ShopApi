using System;
using System.Collections.Generic;

namespace FinalProject.Entities;

public partial class PurchaseHistory
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Category { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public decimal Price { get; set; }
}
