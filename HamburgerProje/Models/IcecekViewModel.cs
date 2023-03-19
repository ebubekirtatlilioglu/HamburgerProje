﻿using HamburgerProje.Data;

namespace HamburgerProje.Models
{
    public class IcecekViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public int Adet { get; set; }
        public double Fiyat { get; set; }
        public List<Menu> Menuler { get; set; } = new();
        public List<Siparis> Siparisler { get; set; } = new();
        public IFormFile? Resim { get; set; } = null!;
    }
}
