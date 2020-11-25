using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_102.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoPolisi { get; set; }
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        public string Ketersediaan { get; set; }
    }
}
