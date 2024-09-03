using System;
using System.Collections.Generic;

namespace FinalProject.Entities;

public partial class VideoCard
{
    public int Id { get; set; }

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string MemoryType { get; set; } = null!;

    public int MemorySize { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }
}
