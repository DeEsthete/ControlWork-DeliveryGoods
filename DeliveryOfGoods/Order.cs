using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOfGoods
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Company Customer { get; set; }

        [ForeignKey("Provider")]
        public int ProviderId { get; set; }
        public Company Provider { get; set; }
        
        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
        [ForeignKey("Cargo")]
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public double Cost { get; set; }
        public DateTime OrderStartDate { get; set; }
        public DateTime OrderEndDate { get; set; }
    }
}
