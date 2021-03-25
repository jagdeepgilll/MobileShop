using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileShop.Models
{
    public class Repair
    {
        [Key]
        // Holds the Repair Id
        public int Id { get; set; }

        //Link to Configration table by adding Foriegn Key
        public int ConfigrationId { get; set; }
            public Configration Configration { get; set; }

        // Holds the defect in phone
        public string DefectInPhone { get; set; }
        // Tells it is repairable or not
        public bool IsRepairable { get; set; }
        // Tells when phone is repaired
        [DataType(DataType.Date)]
        public DateTime RepairDate { get; set; }

    }
}
