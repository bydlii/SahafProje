using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sahaf.Migrations
{
    /// <inheritdoc />
    public partial class SahafDbProjesiOlusturuldu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yayinevleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayineviAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yayinevleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    BasimYili = table.Column<int>(type: "int", nullable: false),
                    BaskiSayisi = table.Column<int>(type: "int", nullable: false),
                    KapakYazisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    YayineviId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Yayinevleri_YayineviId",
                        column: x => x.YayineviId,
                        principalTable: "Yayinevleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapYazar",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    YazarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazar", x => new { x.KitapId, x.YazarId });
                    table.ForeignKey(
                        name: "FK_KitapYazar_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYazar_Yazarlar_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazarlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "Edebiyat" },
                    { 2, "Roman" },
                    { 3, "Kişisel Gelişim" },
                    { 4, "Çocuk ve Gelişim" },
                    { 5, "Arastırma - Tarih" },
                    { 6, "Yabanci Dilde Kitaplar" },
                    { 7, "Çizgi Roman" },
                    { 8, "Felsefe Kitapları" }
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "Id", "Ad", "KullaniciAdi", "Parola", "Soyad" },
                values: new object[] { 1, "Sebahattin", "admin", "81dc9bdb52d04dc20036dbd8313ed055", "Abanaz" });

            migrationBuilder.InsertData(
                table: "Yayinevleri",
                columns: new[] { "Id", "YayineviAdi" },
                values: new object[,]
                {
                    { 1, "İş Bankası Kültür Yayınları" },
                    { 2, "Koridor Yayıncılık" },
                    { 3, "Diyojen Yayıncılık" },
                    { 4, "Butik" },
                    { 5, "Taze Kitap" },
                    { 6, "Timaş Çocuk" },
                    { 7, "Everest Yayınları" },
                    { 8, "Alfa Yayıncılık" },
                    { 9, "Yapı Kredi Yayınları" },
                    { 10, "Doğan Kitap" },
                    { 11, "Enkitap" },
                    { 12, "Gece Kitaplığı" },
                    { 13, "Fihrist" },
                    { 14, "Eksik Parça Yayınları" },
                    { 15, "Doğan Kitap" }
                });

            migrationBuilder.InsertData(
                table: "Yazarlar",
                columns: new[] { "Id", "YazarAdi" },
                values: new object[,]
                {
                    { 1, "Adolf Hitler" },
                    { 2, "Mustafa Kemal Atatürk" },
                    { 3, "Aristoteles" },
                    { 4, "John D. Rockefeller" },
                    { 5, "Ales Kot" },
                    { 6, "Orhan Kemal" },
                    { 7, "Ali Kılıç" },
                    { 8, "Jack London" },
                    { 9, "Sebahattin Ali" },
                    { 10, "Fyodor Mihaylovic Dostoyevsiki" },
                    { 11, "Şermin Yaşar" },
                    { 12, "William Golding" },
                    { 13, "Piere Franckh" },
                    { 14, "James Allen" },
                    { 15, "Henry Cloud" },
                    { 16, "Caroline Myss" },
                    { 17, "Şermin Yaşar" },
                    { 18, "Mert Arık" },
                    { 19, "Duncan Beedie" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriId",
                table: "Kitaplar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KullaniciId",
                table: "Kitaplar",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YayineviId",
                table: "Kitaplar",
                column: "YayineviId");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazar_YazarId",
                table: "KitapYazar",
                column: "YazarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapYazar");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Yazarlar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Yayinevleri");
        }
    }
}
