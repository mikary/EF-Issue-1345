using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Model;
using System;

namespace MigrationDownRepro.Migrations
{
    public partial class InitialCreate : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("MyData",
                c => new
                    {
                        MyDataId = c.Int(nullable: false, identity: true)
                    })
                .PrimaryKey("PK_MyData", t => t.MyDataId);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("MyData");
        }
    }
}