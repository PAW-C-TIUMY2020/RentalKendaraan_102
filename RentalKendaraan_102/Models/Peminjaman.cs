using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_102.Models
{
    public partial class Peminjaman
    {
        public int IdPeminjaman { get; set; }
        [Required(ErrorMessage = "Tanggal Peminjaman tidak boleh kosong")]
        public DateTime? TglPeminjaman { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }
    }
}
