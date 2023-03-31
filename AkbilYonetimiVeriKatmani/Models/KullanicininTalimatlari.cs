using System;
using System.Collections.Generic;

namespace AkbilYonetimiVeriKatmani.Models;

public partial class KullanicininTalimatlari
{
    public int Id { get; set; }

    public int KullaniciId { get; set; }

    public DateTime EklenmeTarihi { get; set; }

    public string Akbil { get; set; } = null!;

    public decimal YukleneckTutar { get; set; }

    public bool YuklendiMi { get; set; }

    public DateTime? YuklenmeTarihi { get; set; }
}
