using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TripManagment.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TripName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TripDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCompleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "DateCompleted", "DateStarted", "TripDescription", "TripName" },
                values: new object[,]
                {
                    { new Guid("960078a3-6f1f-4367-af8e-75793c2f4322"), null, new DateTime(2017, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vienna, is one the most beautiful cities in Austria and in Europe as well. Other than the Operas for which it is well known, Vienna also has many beautiful parks...", "Vienna, Austria" },
                    { new Guid("065fa04b-aeed-4fa9-a1d5-3fcbe0b15aab"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carpinteria is a city located on the central coast of California, just south of Santa Barbara. It has many beautiful beaches as well as a popular Avocado Festival which takes place every year in October...", "Carpinteria, CA, USA" },
                    { new Guid("f12eb82e-ba6b-4e07-9e3b-32b9d05b4c50"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Francisco is a metropolitan area located on the west coast of the United States. Some popular tourist features include the Golden Gate Bridge, Chinatown, and Fisherman's Wharf. There are a variety of popular food options...", "San Francisco, CA, USA" },
                    { new Guid("0f4a7809-ecfe-43fe-8277-890e5df3d122"), null, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tucson is a southwestern city in Arizona that is home to the University of Arizona. It was recently named a world gastronomy city, and is well known for its desert landscape and various bike races...", "Tucson, AZ, USA" },
                    { new Guid("593805aa-07b7-42df-9ce2-ab48a28fb848"), new DateTime(2015, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albuquerque is a city located in New Mexico that is famous for its balloon festivals, picturesque views and references to TV shows.", "Albuquerque, NM, USA" },
                    { new Guid("dd0a778f-f500-4288-a6ea-bb3bbf449d09"), null, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Munich is an important city in Germany, located in the heart of Bavaria. It's famous for its traditional Oktoberfest annual festival, and many nice lakes and parks...", "Munich, Germany" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
