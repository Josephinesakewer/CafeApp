using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeApp.Models;

public class Client
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? NameC { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public List<Order> Orders { get; set; } = new ();
}
