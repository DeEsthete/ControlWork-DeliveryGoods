using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOfGoods
{
    public class LocationHistory
    {
        [Key]
        public int Id { get; set; }
        public virtual IEnumerable<Location> Locations { get; set; }
    }
}
