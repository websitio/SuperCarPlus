using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SeedMakeModelsEntities : Migration
    {
        /// <inheritdoc />
                  protected override void Up(MigrationBuilder migrationBuilder)
        {

migrationBuilder.Sql("INSERT into [Makes] ([Name]) VALUES ('Aston Martin')");
migrationBuilder.Sql("INSERT into [Makes] ([Name]) VALUES ('Jaguar')");
migrationBuilder.Sql("INSERT into [Makes] ([Name]) VALUES ('Lamborghini')");
migrationBuilder.Sql("INSERT into [Makes] ([Name]) VALUES ('Ferrari')");





migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ( (select Id from Makes where Name = 'Aston Martin' ) , 'DB7')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ( (select Id from Makes where Name = 'Aston Martin' ) , 'DB9')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ( (select Id from Makes where Name = 'Aston Martin' ) , 'DBS')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ( (select Id from Makes where Name = 'Aston Martin' ) , 'V8')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ( (select Id from Makes where Name = 'Aston Martin' ) , 'V8 Vantage')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ( (select Id from Makes where Name = 'Aston Martin' ) , 'Vanquish')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ( (select Id from Makes where Name = 'Aston Martin' ) , 'Virage')");




migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'Serie XJ')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'Serie XK')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'Sovereign')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'S-Type')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'E-Type')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'D-Type')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'F-Type')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XF')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XJ6')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XJ8')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XJR')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XJS')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XK120')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XK140')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XK150')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XK8')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XKR')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'X-Type')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XJ')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') , 'XFR-S')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') ,'F-TYPE S')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Jaguar') ,'F-TYPE V8 S')");


migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Lamborghini'),  'aventador')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Lamborghini'),  'Gallardo')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Lamborghini'),  'Countach')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Lamborghini'),  'Espada')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Lamborghini'), 'Diablo')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Lamborghini'),  'Super Trofeo')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Lamborghini'), 'Superleggera')");





migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '328')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '348')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '355')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '360')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '412')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '430')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '456')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '456M')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '512')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '550 Maranello')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '599')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  '612')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'),  'California')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), 'Enzo')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), 'F355')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), 'F40')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), 'F430')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), 'F50')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), 'F512M')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), 'Mondial')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), 'Spider')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), 'Superamerica')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), 'Testarossa')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), '330 LMB')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), '312PB')");
migrationBuilder.Sql("INSERT into [Models] ([MakeId], [Name]) VALUES ((select Id from Makes where Name = 'Ferrari'), '458Italia')");

// migrationBuilder.Sql("");
// migrationBuilder.Sql("");
// if you run down you'll lose the hard coded Id so will need four statements like
// (select Id from Makes where Name = 'Aston Martin' )   to replace 1
// (select Id from Makes where Name = 'Jaguar')  to replace 2    etc etc

 migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Air Bags')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Cup Holder')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Auto Seat positioning')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('8D Sound')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('4-Wheel Steering')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Hybrid Mode')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('4-Wheel Active Suspension')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Apple CarPlay® and Android Auto™')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('A.I. Voice Assistant')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Auto Pilot System')"); 
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Electronic Stability')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Auto Parking')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('360-degree camera')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Biometric door locks')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Fridge')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Personal AirConditioning')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Autonomous emergency braking')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Seat Massage Modes')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Cabin Air Purification')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Autonomous emergency braking')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Video Rearview Mirror')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Reverse Brake Assist')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('USB Charger')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Biometric Health Monitors')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Bluetooth')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Holographic Emitters')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Power Steering')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Multiple Drive Modes')");



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
                 migrationBuilder.Sql("delete  from makes where Name in ('Aston Martin', 'Jaguar', 'Lamborghini', 'Ferrari')");
                 migrationBuilder.Sql("delete  from Features')");
        }

    }
}
