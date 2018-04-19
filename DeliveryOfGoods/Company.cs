using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOfGoods
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
