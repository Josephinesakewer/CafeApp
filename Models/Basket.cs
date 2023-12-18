using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeApp.Models;

public class Basket
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int? DishId { get; set; }

    public int? OrderId { get; set; }

    public Dish? Dish { get; set; }

    public Order? Order { get; set; }
    public int? CountDishes {  get; set; }
}
