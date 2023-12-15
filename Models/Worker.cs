using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeApp.Models;

public partial class Worker
{
    public int Id { get; set; }

    public int? StaffId { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? NameW { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public List<Order> OrderCookers { get; set; } = new ();

    public List<Order> OrderDelievers { get; set; } = new List<Order>();

    public List<Order> OrderSellers { get; set; } = new List<Order>();

    public Staff? Staff { get; set; }
}
