using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;


namespace Vega.Migrations
{
    public partial class PopulateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Features1')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
