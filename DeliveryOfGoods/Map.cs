using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOfGoods
{
    public class Map
    {
        [Key]
        public int Id { get; set; }
        public virtual IEnumerable<Marker> Markers {get; set;}
        public virtual IEnumerable<Route> Route { get; set; }
    }
}
