using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace RentalKendaraan_102.Models
{
    public partial class Jaminan
    {
        public int IdJaminan { get; set; }
        [Required(ErrorMessage = "Nama Jaminan tidak boleh kosong")]
        public string NamaJaminan { get; set; }
    }
}
