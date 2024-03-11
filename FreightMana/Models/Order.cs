using System;
using System.Collections.Generic;

namespace FreightMana.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public string? Product { get; set; }

    public int? NumberOfProduct { get; set; }

    public int TransportId { get; set; }

    public float? Cod { get; set; }

    public float? TransportFee { get; set; }

    public string? Note { get; set; }

    public DateTime? RecordAt { get; set; }

    public int ReceiverId { get; set; }

    public int SenderId { get; set; }

    public int WarehouseId { get; set; }

    public string? Status { get; set; }

    public int? CusId { get; set; }

    public virtual CusAccount? Cus { get; set; }

    public virtual Receiver Receiver { get; set; } = null!;

    public virtual Sender Sender { get; set; } = null!;

    public virtual Transport Transport { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
