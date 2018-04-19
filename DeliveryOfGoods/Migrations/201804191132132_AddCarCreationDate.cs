namespace DeliveryOfGoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarCreationDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CreationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "CreationDate");
        }
    }
}
