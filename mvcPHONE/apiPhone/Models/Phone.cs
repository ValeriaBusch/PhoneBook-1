﻿

namespace apiPhone.Models//ctrl 
    //hicimos ctrl .

{
    using System.ComponentModel.DataAnnotations;
    public enum TypeContact //pegamos
    {
        PhoneNumber,
        Email,
        Facebook,
        Twitter,
        LinkedIN
    }

    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public TypeContact Type { get; set; }

        [Required]
        public string Contact { get; set; }


    }
}