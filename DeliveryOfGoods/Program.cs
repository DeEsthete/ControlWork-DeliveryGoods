using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOfGoods
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                //context.Cars.ToList();
                Location location = new Location();
                location.Address = "Московская 23";
                location.X = 22;
                location.Y = 33;
                Driver driver = new Driver();
                driver.FullName = " Иванов Алексей Петрович";
                driver.Age = 32;
                context.Drivers.Add(driver);
                Company company = new Company();
                company.CompanyName = "Кирпичный завод №3";
                company.Location
            }
        }
    }
}
