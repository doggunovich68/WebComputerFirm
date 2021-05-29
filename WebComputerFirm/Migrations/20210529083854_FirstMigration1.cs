using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebComputerFirm.Migrations
{
    public partial class FirstMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customer_ID = table.Column<int>(type: "INT", nullable: false),
                    Customer_Full_name = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Customer_Address = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Customer_Phone_number = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customer_ID);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Position_ID = table.Column<int>(type: "INT", nullable: false),
                    Salary = table.Column<int>(type: "INT", nullable: false),
                    Responsibilities = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Requirements = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Job_title = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Position_ID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Service_ID = table.Column<int>(type: "INT", nullable: false),
                    Service_title = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Service_description = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Service_cost = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Service_ID);
                });

            migrationBuilder.CreateTable(
                name: "Types_Component",
                columns: table => new
                {
                    Type_ID = table.Column<int>(type: "INT", nullable: false),
                    Type_title = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Type_description = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types_Component", x => x.Type_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "INT", nullable: false),
                    Employee_Full_name = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Employee_Age = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Employee_Gender = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Employee_Address = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Employee_Phone_number = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Employee_Passport = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Position_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_Employee_Position_Position_ID",
                        column: x => x.Position_ID,
                        principalTable: "Position",
                        principalColumn: "Position_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Component",
                columns: table => new
                {
                    Component_ID = table.Column<int>(type: "INT", nullable: false),
                    Component_Manufacturer = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Component_Mark = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Component_Country_Manufacturer = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Component_Date = table.Column<DateTime>(type: "DATE", nullable: false),
                    Component_Discription = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Component_Cost = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Component_Characteristics = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Component_Term_warranty = table.Column<int>(type: "INT", nullable: false),
                    Type_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Component", x => x.Component_ID);
                    table.ForeignKey(
                        name: "FK_Component_Types_Component_Type_ID",
                        column: x => x.Type_ID,
                        principalTable: "Types_Component",
                        principalColumn: "Type_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Order_ID = table.Column<int>(type: "INT", nullable: false),
                    Order_Execution_Date = table.Column<DateTime>(type: "DATE", nullable: false),
                    Order_Execution_mark = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Order_Mark_of_payment = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Order_Prepaid_Share = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Order_Order_date = table.Column<DateTime>(type: "DATE", nullable: false),
                    Order_General_Warranty_Duration = table.Column<int>(type: "INT", nullable: false),
                    Total_cost = table.Column<int>(type: "INT", nullable: false),
                    Component_ID_1 = table.Column<int>(type: "INT", nullable: false),
                    Component_ID_2 = table.Column<int>(type: "INT", nullable: false),
                    Component_ID_3 = table.Column<int>(type: "INT", nullable: false),
                    Customer_ID = table.Column<int>(type: "INT", nullable: false),
                    Employee_ID = table.Column<int>(type: "INT", nullable: false),
                    Service_ID_1 = table.Column<int>(type: "INT", nullable: false),
                    Service_ID_2 = table.Column<int>(type: "INT", nullable: false),
                    Service_ID_3 = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Order_ID);
                    table.ForeignKey(
                        name: "FK_Orders_Services_Component_ID_1",
                        column: x => x.Component_ID_1,
                        principalTable: "Services",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Services_Component_ID_2",
                        column: x => x.Component_ID_2,
                        principalTable: "Services",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Services_Component_ID_3",
                        column: x => x.Component_ID_3,
                        principalTable: "Services",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customer_Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customer",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Employee_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employee",
                        principalColumn: "Employee_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Component_Service_ID_1",
                        column: x => x.Service_ID_1,
                        principalTable: "Component",
                        principalColumn: "Component_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Component_Service_ID_2",
                        column: x => x.Service_ID_2,
                        principalTable: "Component",
                        principalColumn: "Component_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Component_Service_ID_3",
                        column: x => x.Service_ID_3,
                        principalTable: "Component",
                        principalColumn: "Component_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Component_Type_ID",
                table: "Component",
                column: "Type_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Position_ID",
                table: "Employee",
                column: "Position_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Component_ID_1",
                table: "Orders",
                column: "Component_ID_1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Component_ID_2",
                table: "Orders",
                column: "Component_ID_2");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Component_ID_3",
                table: "Orders",
                column: "Component_ID_3");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customer_ID",
                table: "Orders",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Employee_ID",
                table: "Orders",
                column: "Employee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Service_ID_1",
                table: "Orders",
                column: "Service_ID_1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Service_ID_2",
                table: "Orders",
                column: "Service_ID_2");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Service_ID_3",
                table: "Orders",
                column: "Service_ID_3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Component");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Types_Component");
        }
    }
}
