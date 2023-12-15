using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeApp.Models;

public partial class StatusOrder
{
    public int Id { get; set; }

    public string? NameS { get; set; }

    public List<Order> Orders { get; set; } = new ();
}
