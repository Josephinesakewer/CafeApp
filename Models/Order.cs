using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeApp.Models;

public class Order
{
    public int Id { get; set; }

    public int? ClientId { get; set; }

    public int? SellerId { get; set; }

    public int? CookerId { get; set; }

    public int? DelieverId { get; set; }

    public DateTime? DateTimeStart { get; set; }

    public DateTime? DateTimeFinish { get; set; }

    public int? StatusId { get; set; }

    public Client? Client { get; set; }

    public  Worker? Cooker { get; set; }

    public  Worker? Deliever { get; set; }

    public List<OrderDish> OrderDishes { get; set; } = new ();

    public Worker? Seller { get; set; }

    public StatusOrder? Status { get; set; }
}
