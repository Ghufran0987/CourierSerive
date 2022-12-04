namespace CourierSerive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBookingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Guid(nullable: false),
                        BookingName = c.String(nullable: false),
                        Amount = c.Int(nullable: false),
                        ContactNo = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        UserName = c.String(),
                        UserId = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BookingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bookings");
        }
    }
}
