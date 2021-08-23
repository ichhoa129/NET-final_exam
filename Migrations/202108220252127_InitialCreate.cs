namespace _102190064_NguyenIchHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonAn_NguyenLieu",
                c => new
                    {
                        Ma = c.String(nullable: false, maxLength: 5),
                        SoLuong = c.Int(nullable: false),
                        DonViTinh = c.String(),
                        MaMonAn = c.Int(nullable: false),
                        MaNguyenLieu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ma)
                .ForeignKey("dbo.MonAns", t => t.MaMonAn, cascadeDelete: true)
                .ForeignKey("dbo.NguyenLieux", t => t.MaNguyenLieu, cascadeDelete: true)
                .Index(t => t.MaMonAn)
                .Index(t => t.MaNguyenLieu);
            
            CreateTable(
                "dbo.MonAns",
                c => new
                    {
                        MaMonAn = c.Int(nullable: false, identity: true),
                        TenMonAn = c.String(),
                    })
                .PrimaryKey(t => t.MaMonAn);
            
            CreateTable(
                "dbo.NguyenLieux",
                c => new
                    {
                        MaNguyenLieu = c.Int(nullable: false, identity: true),
                        TenNguyenLieu = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaNguyenLieu);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonAn_NguyenLieu", "MaNguyenLieu", "dbo.NguyenLieux");
            DropForeignKey("dbo.MonAn_NguyenLieu", "MaMonAn", "dbo.MonAns");
            DropIndex("dbo.MonAn_NguyenLieu", new[] { "MaNguyenLieu" });
            DropIndex("dbo.MonAn_NguyenLieu", new[] { "MaMonAn" });
            DropTable("dbo.NguyenLieux");
            DropTable("dbo.MonAns");
            DropTable("dbo.MonAn_NguyenLieu");
        }
    }
}
