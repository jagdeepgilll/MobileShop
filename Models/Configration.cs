using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileShop.Models
{
    public class Configration
    {
        [Key]
        // Holds the Configration Id
        public int Id { get; set; }
        [Required]
        //Holds Model of phone to configure Phone. 
        public string Model { get; set; }
        // link to Phone

        //Adding Foreign key 
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }

        // Holds the storage of Phone
        public int Storage { get; set; }
        // Holds the RAM of Phone
        public int RAM { get; set; }

    }
}
