using System;
using System.Collections.Generic;

namespace AkbilYonetimiVeriKatmani.Models;

public partial class Kullanicilar
{
    public int Id { get; set; }

    public DateTime EklenmeTarihi { get; set; }

    public string Email { get; set; } = null!;

    public string Parola { get; set; } = null!;

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public DateTime? DogumTarihi { get; set; }

    public virtual ICollection<Akbiller> Akbillers { get; } = new List<Akbiller>();
}
