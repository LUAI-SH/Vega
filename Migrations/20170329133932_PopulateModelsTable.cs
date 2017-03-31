using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class PopulateModelsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Models (Name) VALUES ('Model1')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
