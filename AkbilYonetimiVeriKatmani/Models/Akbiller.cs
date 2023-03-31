using System;
using System.Collections.Generic;

namespace AkbilYonetimiVeriKatmani.Models;

public partial class Akbiller
{
    public string AkbilNo { get; set; } = null!;

    public DateTime EklenmeTarihi { get; set; }

    public string AkbilTipi { get; set; } = null!;

    public decimal Bakiye { get; set; }

    public int AkbilSahibiId { get; set; }

    public DateTime? VizelendigiTarih { get; set; }

    public virtual Kullanicilar AkbilSahibi { get; set; } = null!;

    public virtual ICollection<Talimatlar> Talimatlars { get; } = new List<Talimatlar>();
}
