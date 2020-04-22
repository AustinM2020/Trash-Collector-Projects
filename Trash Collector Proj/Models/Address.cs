using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector_Proj.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Zipcode { get; set; }
        public string UserAddress { get; set; }
    }
}
