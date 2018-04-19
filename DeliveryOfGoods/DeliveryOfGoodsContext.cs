namespace DeliveryOfGoods
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class DeliveryOfGoodsContext : DbContext
    {
        public DeliveryOfGoodsContext()
            : base("name=DeliveryOfGoodsContext")
        {
        }

        public DbSet<Map> Maps { get; set; }
        public DbSet<Route> Routes  { get; set; }
        public DbSet<Marker> Markers  { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Info> Infos  { get; set; }
        public DbSet<Order> Orders  { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Cargo> Cargos  { get; set; }
        public DbSet<Driver> Drivers  { get; set; }
        public DbSet<LocationHistory> LocationHistory { get; set; }
        public DbSet<CarType> CarTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}