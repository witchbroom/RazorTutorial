using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContosoPets.Ui.Models;

[Index("OrderId", Name = "IX_ProductOrders_OrderId")]
[Index("ProductId", Name = "IX_ProductOrders_ProductId")]
public partial class ProductOrder
{
    [Key]
    public int Id { get; set; }

    public int Quantity { get; set; }

    public int ProductId { get; set; }

    public int OrderId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("ProductOrders")]
    public virtual Order Order { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("ProductOrders")]
    public virtual Products Product { get; set; } = null!;
}
