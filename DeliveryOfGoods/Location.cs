using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOfGoods
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
