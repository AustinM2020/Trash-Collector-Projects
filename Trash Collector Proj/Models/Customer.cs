using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector_Proj.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Zipcode { get; set; }
        public string Address { get; set; }
        [DisplayName("Extra Pick Up Date")]
        public DateTime ExtraPickUp { get; set; }
        [DisplayName("Start Pick Up")]
        public DateTime StartDate { get; set; }
        [DisplayName("End Pick Up")]
        public DateTime EndDate { get; set; }
        public double Balance { get; set; }


        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [ForeignKey("WeekDay")]
        [DisplayName("Weekly Pick Up Day")]
        public int DayId { get; set; }
        public WeekDay WeekDay { get; set; }

        [NotMapped]
        public IEnumerable<WeekDay> WeekDays { get; set; }
    }
}
