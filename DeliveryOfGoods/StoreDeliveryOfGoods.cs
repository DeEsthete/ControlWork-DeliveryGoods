using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryOfGoods
{
    public class StoreDeliveryOfGoods
    {
        public void CarMove(int id)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                List<LocationHistory> history = context.LocationHistory.ToList();
                List<Car> cars = context.Cars.ToList();
                List<Route> routes = context.Routes.ToList();
            }
        }

        //------------------Add
        public void AddOrder(int id, Company provider, Company customer, Car car, Cargo cargo ,double cost)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                Order temp = new Order();
                temp.Id = id;
                temp.Provider = provider;
                temp.Customer = customer;
                temp.Car = car;
                temp.Cargo = cargo;
                temp.Cost = cost;
                temp.OrderStartDate = DateTime.Now;
                context.Orders.Add(temp);
                context.SaveChanges();
            }
        }

        public void AddDriver(int id, string fullName, int age)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                Driver temp = new Driver();
                temp.Id = id;
                temp.FullName = fullName;
                temp.Age = age;
                context.Drivers.Add(temp);
                context.SaveChanges();
            }
        }

        public void AddCompany(int id, string companyName, Location location)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                Company temp = new Company();
                temp.Id = id;
                temp.CompanyName = companyName;
                temp.Location = location;
                context.Companies.Add(temp);
                context.SaveChanges();
            }
        }

        public void AddLocation(int id, string address, int x, int y)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                Location temp = new Location();
                temp.Id = id;
                temp.Address = address;
                temp.X = x;
                context.Locations.Add(temp);
                context.SaveChanges();
            }
        }

        public void AddCargoes(int id, string name, int weight, int amount, int count)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                Cargo temp = new Cargo();
                temp.Id = id;
                temp.CargoName = name;
                temp.Weight = weight;
                temp.Amount = amount;
                temp.Count = count;
                context.Cargos.Add(temp);
                context.SaveChanges();
            }
        }

        public void AddCar(int id, Driver driver, CarType type)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                Car temp = new Car();
                temp.Driver = driver;
                temp.Type = type;
                context.Cars.Add(temp);
                context.SaveChanges();
            }
        }

        public void AddCarTypes(int id, string type)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                CarType temp = new CarType();
                temp.Id = id;
                temp.Type = type;
                context.CarTypes.Add(temp);
                context.SaveChanges();
            }
        }

        public void AddInfo(int id, Order order)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                Info temp = new Info();
                temp.Id = id;
                temp.Order = order;
                context.Infos.Add(temp);
                context.SaveChanges();
            }
        }

        public void AddMarker(int id, Location location, Info info)
        {
            using (DeliveryOfGoodsContext context = new DeliveryOfGoodsContext())
            {
                Marker temp = new Marker();
                temp.Id = id;
                temp.Location = location;
                temp.Info = info;
                context.Markers.Add(temp);
                context.SaveChanges();
            }
        }
    }
}
