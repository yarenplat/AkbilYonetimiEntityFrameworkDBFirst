using System;
using System.Collections.Generic;

namespace AkbilYonetimiVeriKatmani.Models;

public partial class Talimatlar
{
    public int Id { get; set; }

    public DateTime EklenmeTarihi { get; set; }

    public string AkbilId { get; set; } = null!;

    public decimal YukleneckTutar { get; set; }

    public bool YuklendiMi { get; set; }

    public DateTime? YuklenmeTarihi { get; set; }

    public virtual Akbiller Akbil { get; set; } = null!;
}
