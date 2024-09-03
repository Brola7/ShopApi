using System;
using System.Collections.Generic;

namespace FinalProject.Entities;

public partial class Cpu
{
    public int Id { get; set; }

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Cores { get; set; }

    public string ClockSpeed { get; set; } = null!;

    public decimal Price { get; set; }

    public int Stock { get; set; }
}
