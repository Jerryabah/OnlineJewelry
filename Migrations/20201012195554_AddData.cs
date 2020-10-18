using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineJewelry.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Finest quality of pearls, leather and torquoise Bracelets", "Bracelet" },
                    { 2, "Finest quality of pearls, leather and torquoise Necklace", "Necklace" },
                    { 3, "Finest quality of pearls, leather and torquoise Earrings", "Earrings" },
                    { 4, "Finest quality of pearls, leather and torquoise Silk Ribbons Bracelets", "Silk Ribbons Bracelets" },
                    { 5, "Finest quality of pearls, leather and torquoise Anklet", "Anklet" },
                    { 6, "Finest quality of pearls, leather and torquoise Ring", "Ring" }
                });

            migrationBuilder.InsertData(
                table: "Jewelries",
                columns: new[] { "JewelryId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, @"A Wrap Around Bracelet with freshwater pearls. Chocolate Coin pearls, Black freshwater pearls and knots, all on a rich brown leather. When wrapped around wrist the coin pearls set at an angle, very unique. 
                Total measurements 14"". 
                Fits a size 7"" wrist.", "\\Images\\thumbnails\\CHOCOLATE TIDAL WAVE Bracelet_tn.jpg", "\\Images\\CHOCOLATE TIDAL WAVE Bracelet.jpg", true, "CHOCOLATE TIDAL WAVE Bracelet", 53.00m },
                    { 7, 1, "Dark,iridescent Peacock Baroque PEARL Bracelet , these pearls are perfect in their imperfections. Knotted on rich brown leather, with a little space between. Finished off with a round, black, cultured pearl. Bracelet measures 7 .5\". Pearls measure 22.30 x 13.5 mm.", "\\Images\\thumbnails\\Black Baroque Pearl Bracelet_tn.jpg", "\\Images\\Black Baroque Pearl Bracelet.jpg", true, "Black Baroque Pearl Bracelet", 71.00m },
                    { 2, 2, "…..Simplicity is often the most beautiful. This is perfectly seen in this Floating Pearl necklace. Single strand of a natural Greek leather, with one floating pearl.Center Pearl is large, measures 12mm.Closure pearl measures 11mm.Can be worn with one pearl in front(pictures 1 and 2) or both pearls in front as shown in (picture 3 and 4 ).Necklace measures 16\". Great piece for this Summer!", "\\Images\\thumbnails\\Floating Champagne Freshwater Pearl Necklace-1_tn.jpg", "\\Images\\Floating Champagne Freshwater Pearl Necklace-1.jpg", true, "Floating Champagne Freshwater Pearl Necklace-1", 46.00m },
                    { 8, 2, @"A NEW everyday pearl necklace! 
                Beautiful, Peacock freshwater cultured pearl necklace, using 29 pearls.These pearls are knotted perfectly on natural Greek leather. Measures 17"". 
                Pearls are 10mm. Closure is finished off with a blue, round, freshwater cultured pearl. 
                A Perfect necklace to layer!", "\\Images\\thumbnails\\Freshwater Peacock Pearls All Around Necklace_tn.jpg", "\\Images\\Freshwater Peacock Pearls All Around Necklace.jpg", true, "Freshwater Peacock Pearls All Around Necklace", 112.00m },
                    { 3, 3, @"Beautiful White Baroque Pearls strung on Gold-filled wires make a stunning pair of earrings. These exquisite pearls that I used will go with whatever you are wearing. Pearls measure 17.75mm x 14mm, a really nice size. These dangle approximately 1 1 / 2"" from the gold-filled earring wires. 
                * The earrings in the picture are the ones you will receive.", "\\Images\\thumbnails\\White Baroque PEARL Earrings_tn.jpg", "\\Images\\White Baroque PEARL Earrings.jpg", true, "White Baroque PEARL Earrings", 58.00m },
                    { 9, 3, "These are not your mother's pearl earrings. Beautiful White Freshwater Pearls strung on Natural Greek leather make a stunning pair of earrings. These dangle approximately 2 1/4” from the gold-filled earring wire. Pearls measure 11.50 mm.", "\\Images\\thumbnails\\Everyday White PEARL and Natural Greek Leather Earrings_tn.jpg", "\\Images\\Everyday White PEARL and Natural Greek Leather Earrings.jpg", true, "Everyday White PEARL and Natural Greek Leather Earrings", 56.00m },
                    { 4, 4, @"... Freshwater, Cultured, White Pearl Bracelet. Hand drilled pearls to fit perfectly on the ribbon that they are strung on, pearls can be adjusted to fit your mood. Wrap around your wrist as many times as you wish, knot to finsh. Total length of ribbon 34 inches. Pearl measure between 12.5 - 13.5 mm.Bonus: can be worn as a necklace:>) 
                I have many colors of ribbon available, Please convo me to let me know if you would like a different color.", "\\Images\\thumbnails\\Freshwater PEARLS Red Silk RIBBON Bracelet and Necklace_tn.jpg", "\\Images\\Freshwater PEARLS Red Silk RIBBON Bracelet and Necklace.jpg", true, "Freshwater PEARLS Red Silk RIBBON Bracelet/Necklace", 61.00m },
                    { 10, 4, @"FUN FUN FUN This color ALWAYS makes me think of Summer.Ocean, Waves, Sand & Sun.So what better way to celebrate summer then to wear a beachy color with pearls.
                 ... Freshwater, Cultured, White Pearls strung on a silk ribbon.Hand drilled pearls to fit perfectly on the silk ribbon, pearls can be adjusted to fit your mood.Wrap around your wrist as many times as you wish, knot to finsh.Total length is 34 inches. One pearl measures 12mm, two pearls measure 9mm.When Silk ribbon gets messy take pearls off and just wash in cold water and lay flat to dry. 
                Bonus: can be worn as a necklace:>) 
                 Notice: this could be a starter pearls and silk ribbon bracelet / necklace. You can purchase more pearls and or different colors of silk ribbon.Please convo me with questions and more information.", "\\Images\\thumbnails\\Silk RIBBON and PEARLS Bracelet & Necklace_tn.jpg", "\\Images\\Silk RIBBON and PEARLS Bracelet & Necklace.jpg", true, "Silk RIBBON and PEARLS Bracelet/Necklace", 28.00m },
                    { 5, 5, @"ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
                 Natural Greek leather knotted with black seed pearls in between to form the perfect Anklet.Beautifully complemented with with a black cultured freshwater pearl, which also serves as the closure.Anklet measures 10"".", "\\Images\\thumbnails\\Black Pearls and Knots LEATHER Anklet_tn.jpg", "\\Images\\Black Pearls and Knots LEATHER Anklet.jpg", true, "Black Pearls and Knots LEATHER Anklet", 71.00m },
                    { 11, 5, @"ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
                 Natural Greek leather with turquoise to form the perfect Anklet. Beautifully complemented with a square turquoise which also serves as the closure. Anklet measures 10"".", "\\Images\\thumbnails\\Turquoise and Natural Greek LEATHER Anklet_tn.jpg", "\\Images\\Turquoise and Natural Greek LEATHER Anklet.jpg", true, "Turquoise and Natural Greek LEATHER Anklet", 45.00m },
                    { 6, 6, "Freshwater Pearl Ring. This Ring is beautiful!! Blue, Green, Purple hue freshwater Pearl. Pearl measures 15.75 x 20.25 mm on a rich brown leather. Ring size 9.", "\\Images\\thumbnails\\Akoya Freshwater Blue, Green, Purple Pearl Ring_tn.jpg", "\\Images\\Akoya Freshwater Blue, Green, Purple Pearl Ring.jpg", true, "Akoya Freshwater Blue, Green, Purple Pearl Ring", 46.00m },
                    { 12, 6, "Black Coin Pearl Ring. This ring is a Black Coin freshwater Pearl with natural Greek leather. Pearl measures 13.30 mm. Ring size 8.", "\\Images\\thumbnails\\Black Coin Pearl Ring_tn.jpg", "\\Images\\Black Coin Pearl Ring.jpg", true, "Black Coin Pearl Ring", 36.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);
        }
    }
}
