using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineJewelry.Migrations
{
    public partial class UpdateTableJewelry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Jewelries",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 1,
                column: "Description",
                value: @"A Wrap Around Bracelet with freshwater pearls. Chocolate Coin pearls, Black freshwater pearls and knots, all on a rich brown leather. When wrapped around wrist the coin pearls set at an angle, very unique. 
Total measurements 14"". 
Fits a size 7"" wrist.");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 3,
                column: "Description",
                value: @"Beautiful White Baroque Pearls strung on Gold-filled wires make a stunning pair of earrings. These exquisite pearls that I used will go with whatever you are wearing. Pearls measure 17.75mm x 14mm, a really nice size. These dangle approximately 1 1 / 2"" from the gold-filled earring wires. 
* The earrings in the picture are the ones you will receive.");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 4,
                column: "Description",
                value: @"... Freshwater, Cultured, White Pearl Bracelet. Hand drilled pearls to fit perfectly on the ribbon that they are strung on, pearls can be adjusted to fit your mood. Wrap around your wrist as many times as you wish, knot to finsh. Total length of ribbon 34 inches. Pearl measure between 12.5 - 13.5 mm.Bonus: can be worn as a necklace:>) 
I have many colors of ribbon available, Please convo me to let me know if you would like a different color.");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 5,
                column: "Description",
                value: @"ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
 Natural Greek leather knotted with black seed pearls in between to form the perfect Anklet.Beautifully complemented with with a black cultured freshwater pearl, which also serves as the closure.Anklet measures 10"".");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 8,
                column: "Description",
                value: @"A NEW everyday pearl necklace! 
Beautiful, Peacock freshwater cultured pearl necklace, using 29 pearls.These pearls are knotted perfectly on natural Greek leather. Measures 17"". 
Pearls are 10mm. Closure is finished off with a blue, round, freshwater cultured pearl. 
A Perfect necklace to layer!");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 10,
                column: "Description",
                value: @"FUN FUN FUNThis color ALWAYS makes me think of Summer.Ocean, Waves, Sand & Sun.So what better way to celebrate summer then to wear a beachy color with pearls.
 ... Freshwater, Cultured, White Pearls strung on a silk ribbon.Hand drilled pearls to fit perfectly on the silk ribbon, pearls can be adjusted to fit your mood.Wrap around your wrist as many times as you wish, knot to finsh.Total length is 34 inches. One pearl measures 12mm, two pearls measure 9mm.When Silk ribbon gets messy take pearls off and just wash in cold water and lay flat to dry. 
Bonus: can be worn as a necklace:>) 
 Notice: this could be a starter pearls and silk ribbon bracelet / necklace. You can purchase more pearls and or different colors of silk ribbon.Please convo me with questions and more information.");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 11,
                column: "Description",
                value: @"ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
 Natural Greek leather with turquoise to form the perfect Anklet. Beautifully complemented with a square turquoise which also serves as the closure. Anklet measures 10"".");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Jewelries");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 1,
                column: "Description",
                value: @"A Wrap Around Bracelet with freshwater pearls. Chocolate Coin pearls, Black freshwater pearls and knots, all on a rich brown leather. When wrapped around wrist the coin pearls set at an angle, very unique. 
Total measurements 14"". 
Fits a size 7"" wrist.");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 3,
                column: "Description",
                value: @"Beautiful White Baroque Pearls strung on Gold-filled wires make a stunning pair of earrings. These exquisite pearls that I used will go with whatever you are wearing. Pearls measure 17.75mm x 14mm, a really nice size. These dangle approximately 1 1 / 2"" from the gold-filled earring wires. 
* The earrings in the picture are the ones you will receive.");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 4,
                column: "Description",
                value: @"... Freshwater, Cultured, White Pearl Bracelet. Hand drilled pearls to fit perfectly on the ribbon that they are strung on, pearls can be adjusted to fit your mood. Wrap around your wrist as many times as you wish, knot to finsh. Total length of ribbon 34 inches. Pearl measure between 12.5 - 13.5 mm.Bonus: can be worn as a necklace:>) 
I have many colors of ribbon available, Please convo me to let me know if you would like a different color.");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 5,
                column: "Description",
                value: @"ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
 Natural Greek leather knotted with black seed pearls in between to form the perfect Anklet.Beautifully complemented with with a black cultured freshwater pearl, which also serves as the closure.Anklet measures 10"".");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 8,
                column: "Description",
                value: @"A NEW everyday pearl necklace! 
Beautiful, Peacock freshwater cultured pearl necklace, using 29 pearls.These pearls are knotted perfectly on natural Greek leather. Measures 17"". 
Pearls are 10mm. Closure is finished off with a blue, round, freshwater cultured pearl. 
A Perfect necklace to layer!");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 10,
                column: "Description",
                value: @"FUN FUN FUNThis color ALWAYS makes me think of Summer.Ocean, Waves, Sand & Sun.So what better way to celebrate summer then to wear a beachy color with pearls.
 ... Freshwater, Cultured, White Pearls strung on a silk ribbon.Hand drilled pearls to fit perfectly on the silk ribbon, pearls can be adjusted to fit your mood.Wrap around your wrist as many times as you wish, knot to finsh.Total length is 34 inches. One pearl measures 12mm, two pearls measure 9mm.When Silk ribbon gets messy take pearls off and just wash in cold water and lay flat to dry. 
Bonus: can be worn as a necklace:>) 
 Notice: this could be a starter pearls and silk ribbon bracelet / necklace. You can purchase more pearls and or different colors of silk ribbon.Please convo me with questions and more information.");

            migrationBuilder.UpdateData(
                table: "Jewelries",
                keyColumn: "JewelryId",
                keyValue: 11,
                column: "Description",
                value: @"ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
 Natural Greek leather with turquoise to form the perfect Anklet. Beautifully complemented with a square turquoise which also serves as the closure. Anklet measures 10"".");
        }
    }
}
