using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_102.Models
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Custommer tidak boleh kosong")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat wajib diisi")]
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage = "No HP minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP maksimal 13 angka")]
        //[RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [Required(ErrorMessage = "HP wajib diisi")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }
    }
}
