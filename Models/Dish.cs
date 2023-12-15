using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeApp.Models;

public class Dish
{
    public int Id { get; set; }

    public string? NameM { get; set; }

    public string? Description { get; set; }

    public double? Price { get; set; }

    public List<OrderDish> OrderDishes { get; set; } = new ();
}
