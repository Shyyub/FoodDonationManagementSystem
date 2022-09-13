using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Models
{
    public class SchoolModel
    {
        [Key]
        public int DonarId { get; set; }
        public string DonarName { get; set; }
        public string DonarCity { get; set; }
        public string DonarAddress { get; set; }
    }
}
