using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MobileShop.Models
{
    public class Phone
    {
        [Key]
        // Holds the phone Id (primary key)
        public int PhoneId { get; set; }
        // Holds the Phone name
        [Required]
        //[Microsoft.AspNetCore.Mvc.Remote("NameOfPhoneAvailable", "Phone", ErrorMessage = "Name is requried", AdditionalFields = "Id")]
        public string NameOfPhone { get; set; }
        // Holds the name of company who manufacture phone
        public string Company { get; set; }
        // Holds the cost of phone
        public int Cost { get; set; }
        //Holds how much phones are left
        public int Stock { get; set; }

    }
}
