using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeApp.Models;

public partial class Staff
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public List<Worker> Workers { get; set; } = new();
}
