using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_102.Models
{
    public partial class JenisKendaraan
    {
        public int IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Jenis Kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }
    }
}
