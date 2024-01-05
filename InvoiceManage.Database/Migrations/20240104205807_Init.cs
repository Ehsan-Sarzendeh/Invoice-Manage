using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceManage.Database.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tins = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Sbc = table.Column<string>(type: "TEXT", nullable: true),
                    Scln = table.Column<string>(type: "TEXT", nullable: true),
                    Crn = table.Column<string>(type: "TEXT", nullable: true),
                    Pro = table.Column<string>(type: "TEXT", nullable: true),
                    FilePath = table.Column<string>(type: "TEXT", nullable: true),
                    BaseUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ClientId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BId = table.Column<long>(type: "INTEGER", nullable: true),
                    Tinb = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Bpc = table.Column<string>(type: "TEXT", nullable: true),
                    Bbc = table.Column<string>(type: "TEXT", nullable: true),
                    Bpn = table.Column<string>(type: "TEXT", nullable: true),
                    BillId = table.Column<string>(type: "TEXT", nullable: true),
                    Pro = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sstid = table.Column<string>(type: "TEXT", nullable: true),
                    Sstt = table.Column<string>(type: "TEXT", nullable: true),
                    Vra = table.Column<double>(type: "REAL", nullable: false),
                    InternalCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaxId = table.Column<string>(type: "TEXT", maxLength: 22, nullable: true),
                    Indatim = table.Column<decimal>(type: "TEXT", nullable: false),
                    Indatim_1 = table.Column<string>(type: "TEXT", nullable: true),
                    Indatim_2 = table.Column<string>(type: "TEXT", nullable: true),
                    Indatim2m = table.Column<decimal>(type: "TEXT", nullable: false),
                    Indatim2m_1 = table.Column<string>(type: "TEXT", nullable: true),
                    Indatim2m_2 = table.Column<string>(type: "TEXT", nullable: true),
                    Inno = table.Column<string>(type: "TEXT", nullable: true),
                    Inno_1 = table.Column<long>(type: "INTEGER", nullable: false),
                    GenerateInno = table.Column<bool>(type: "INTEGER", nullable: false),
                    Irtaxid = table.Column<string>(type: "TEXT", nullable: true),
                    Tins = table.Column<string>(type: "TEXT", nullable: true),
                    Tinb = table.Column<string>(type: "TEXT", nullable: true),
                    Sbc = table.Column<string>(type: "TEXT", nullable: true),
                    Bid = table.Column<string>(type: "TEXT", nullable: true),
                    Bpc = table.Column<string>(type: "TEXT", nullable: true),
                    Bbc = table.Column<string>(type: "TEXT", nullable: true),
                    Bpn = table.Column<string>(type: "TEXT", nullable: true),
                    Scln = table.Column<string>(type: "TEXT", nullable: true),
                    Scc = table.Column<string>(type: "TEXT", nullable: true),
                    Crn = table.Column<string>(type: "TEXT", nullable: true),
                    Cdcn = table.Column<string>(type: "TEXT", nullable: true),
                    Cdcd_1 = table.Column<string>(type: "TEXT", nullable: true),
                    Cdcd = table.Column<decimal>(type: "TEXT", nullable: false),
                    BillId = table.Column<string>(type: "TEXT", nullable: true),
                    Cap = table.Column<decimal>(type: "TEXT", nullable: false),
                    Insp = table.Column<decimal>(type: "TEXT", nullable: false),
                    Tax17 = table.Column<decimal>(type: "TEXT", nullable: false),
                    Iinn = table.Column<string>(type: "TEXT", nullable: true),
                    Acn = table.Column<string>(type: "TEXT", nullable: true),
                    Trmn = table.Column<string>(type: "TEXT", nullable: true),
                    Trn = table.Column<string>(type: "TEXT", nullable: true),
                    Pcn = table.Column<string>(type: "TEXT", nullable: true),
                    Pid = table.Column<string>(type: "TEXT", nullable: true),
                    Pdt_1 = table.Column<string>(type: "TEXT", nullable: true),
                    Pdt = table.Column<decimal>(type: "TEXT", nullable: false),
                    Pdt_2 = table.Column<string>(type: "TEXT", nullable: true),
                    Pv = table.Column<decimal>(type: "TEXT", nullable: false),
                    Tm = table.Column<string>(type: "TEXT", nullable: true),
                    RefrenceNumber = table.Column<string>(type: "TEXT", nullable: true),
                    SendStatus = table.Column<string>(type: "TEXT", nullable: true),
                    ResultStatus = table.Column<string>(type: "TEXT", nullable: true),
                    Inty = table.Column<int>(type: "INTEGER", nullable: false),
                    Inp = table.Column<int>(type: "INTEGER", nullable: false),
                    Ins = table.Column<int>(type: "INTEGER", nullable: true),
                    Tob = table.Column<int>(type: "INTEGER", nullable: true),
                    Ft = table.Column<int>(type: "INTEGER", nullable: true),
                    Pmt = table.Column<int>(type: "INTEGER", nullable: true),
                    Setm = table.Column<int>(type: "INTEGER", nullable: true),
                    CompanyId = table.Column<long>(type: "INTEGER", nullable: false),
                    CompanyId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Company_CompanyId1",
                        column: x => x.CompanyId1,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvoiceId = table.Column<long>(type: "INTEGER", nullable: false),
                    InvoiceId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    Pspd = table.Column<decimal>(type: "TEXT", nullable: false),
                    SstId = table.Column<string>(type: "TEXT", nullable: true),
                    Sstt = table.Column<string>(type: "TEXT", nullable: true),
                    Am = table.Column<decimal>(type: "TEXT", nullable: false),
                    Mu = table.Column<string>(type: "TEXT", nullable: true),
                    Nw = table.Column<decimal>(type: "TEXT", nullable: false),
                    Fee = table.Column<decimal>(type: "TEXT", nullable: false),
                    CFee = table.Column<decimal>(type: "TEXT", nullable: false),
                    Cut = table.Column<string>(type: "TEXT", nullable: true),
                    Exr = table.Column<decimal>(type: "TEXT", nullable: false),
                    Ssrv = table.Column<decimal>(type: "TEXT", nullable: false),
                    Sscv = table.Column<decimal>(type: "TEXT", nullable: false),
                    Dis = table.Column<decimal>(type: "TEXT", nullable: false),
                    Vra = table.Column<double>(type: "REAL", nullable: false),
                    Odt = table.Column<string>(type: "TEXT", nullable: true),
                    Odr = table.Column<double>(type: "REAL", nullable: false),
                    Odam = table.Column<decimal>(type: "TEXT", nullable: false),
                    Olt = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Olr = table.Column<double>(type: "REAL", nullable: false),
                    Olam = table.Column<decimal>(type: "TEXT", nullable: false),
                    Consfee = table.Column<decimal>(type: "TEXT", nullable: false),
                    Spro = table.Column<decimal>(type: "TEXT", nullable: false),
                    Bros = table.Column<decimal>(type: "TEXT", nullable: false),
                    Cop = table.Column<decimal>(type: "TEXT", nullable: false),
                    Vop = table.Column<decimal>(type: "TEXT", nullable: false),
                    Mu_1 = table.Column<string>(type: "TEXT", nullable: true),
                    Bsrn = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItem_Invoice_InvoiceId1",
                        column: x => x.InvoiceId1,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CompanyId1",
                table: "Invoice",
                column: "CompanyId1");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItem_InvoiceId1",
                table: "InvoiceItem",
                column: "InvoiceId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "InvoiceItem");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
