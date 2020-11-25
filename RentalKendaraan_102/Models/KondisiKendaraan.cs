using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_102.Models
{
    public partial class KondisiKendaraan
    {
        public int IdKondisi { get; set; }
        [Required(ErrorMessage = "Nama Kondisi tidak boleh kosong")]
        public string NamaKondisi { get; set; }
    }
}
