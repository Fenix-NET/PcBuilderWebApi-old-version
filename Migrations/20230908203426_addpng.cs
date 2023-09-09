using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PcBuilderWebApi.Migrations
{
    /// <inheritdoc />
    public partial class addpng : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {

                    ImageNamePng = table.Column<string>(type: "text", nullable: true)
                });


            migrationBuilder.CreateTable(
                name: "Cpu",
                columns: table => new
                {

                    ImageNamePng = table.Column<string>(type: "text", nullable: true)
                });


            migrationBuilder.CreateTable(
                name: "Gpu",
                columns: table => new
                {

                    ImageNamePng = table.Column<string>(type: "text", nullable: true)
                });


            migrationBuilder.CreateTable(
                name: "Hdd",
                columns: table => new
                {

                    ImageNamePng = table.Column<string>(type: "text", nullable: true)
                });


            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {

                    ImageNamePng = table.Column<string>(type: "text", nullable: true)
                });


            migrationBuilder.CreateTable(
                name: "Psu",
                columns: table => new
                {

                    ImageNamePng = table.Column<string>(type: "text", nullable: true)
                });


            migrationBuilder.CreateTable(
                name: "Ram",
                columns: table => new
                {

                    ImageNamePng = table.Column<string>(type: "text", nullable: true)
                });


            migrationBuilder.CreateTable(
                name: "Ssd",
                columns: table => new
                {

                    ImageNamePng = table.Column<string>(type: "text", nullable: true)
                });
                
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
