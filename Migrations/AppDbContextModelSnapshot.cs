﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineJewelry.Models;

namespace OnlineJewelry.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineJewelry.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Finest quality of pearls, leather and torquoise Bracelets",
                            CategoryName = "Bracelet"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Finest quality of pearls, leather and torquoise Necklace",
                            CategoryName = "Necklace"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Finest quality of pearls, leather and torquoise Earrings",
                            CategoryName = "Earrings"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryDescription = "Finest quality of pearls, leather and torquoise Silk Ribbons Bracelets",
                            CategoryName = "Silk Ribbons Bracelets"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryDescription = "Finest quality of pearls, leather and torquoise Anklet",
                            CategoryName = "Anklet"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryDescription = "Finest quality of pearls, leather and torquoise Ring",
                            CategoryName = "Ring"
                        });
                });

            modelBuilder.Entity("OnlineJewelry.Models.Jewelry", b =>
                {
                    b.Property<int>("JewelryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("JewelryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Jewelries");

                    b.HasData(
                        new
                        {
                            JewelryId = 1,
                            CategoryId = 1,
                            Description = @"A Wrap Around Bracelet with freshwater pearls. Chocolate Coin pearls, Black freshwater pearls and knots, all on a rich brown leather. When wrapped around wrist the coin pearls set at an angle, very unique. 
Total measurements 14"". 
Fits a size 7"" wrist.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\CHOCOLATE TIDAL WAVE Bracelet_tn.jpg",
                            ImageUrl = "\\Images\\CHOCOLATE TIDAL WAVE Bracelet.jpg",
                            IsInStock = true,
                            Name = "CHOCOLATE TIDAL WAVE Bracelet",
                            Price = 53.00m
                        },
                        new
                        {
                            JewelryId = 2,
                            CategoryId = 2,
                            Description = "…..Simplicity is often the most beautiful. This is perfectly seen in this Floating Pearl necklace. Single strand of a natural Greek leather, with one floating pearl.Center Pearl is large, measures 12mm.Closure pearl measures 11mm.Can be worn with one pearl in front(pictures 1 and 2) or both pearls in front as shown in (picture 3 and 4 ).Necklace measures 16\". Great piece for this Summer!",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Floating Champagne Freshwater Pearl Necklace-1_tn.jpg",
                            ImageUrl = "\\Images\\Floating Champagne Freshwater Pearl Necklace-1.jpg",
                            IsInStock = true,
                            Name = "Floating Champagne Freshwater Pearl Necklace-1",
                            Price = 46.00m
                        },
                        new
                        {
                            JewelryId = 3,
                            CategoryId = 3,
                            Description = @"Beautiful White Baroque Pearls strung on Gold-filled wires make a stunning pair of earrings. These exquisite pearls that I used will go with whatever you are wearing. Pearls measure 17.75mm x 14mm, a really nice size. These dangle approximately 1 1 / 2"" from the gold-filled earring wires. 
* The earrings in the picture are the ones you will receive.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\White Baroque PEARL Earrings_tn.jpg",
                            ImageUrl = "\\Images\\White Baroque PEARL Earrings.jpg",
                            IsInStock = true,
                            Name = "White Baroque PEARL Earrings",
                            Price = 58.00m
                        },
                        new
                        {
                            JewelryId = 4,
                            CategoryId = 4,
                            Description = @"... Freshwater, Cultured, White Pearl Bracelet. Hand drilled pearls to fit perfectly on the ribbon that they are strung on, pearls can be adjusted to fit your mood. Wrap around your wrist as many times as you wish, knot to finsh. Total length of ribbon 34 inches. Pearl measure between 12.5 - 13.5 mm.Bonus: can be worn as a necklace:>) 
I have many colors of ribbon available, Please convo me to let me know if you would like a different color.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Freshwater PEARLS Red Silk RIBBON Bracelet and Necklace_tn.jpg",
                            ImageUrl = "\\Images\\Freshwater PEARLS Red Silk RIBBON Bracelet and Necklace.jpg",
                            IsInStock = true,
                            Name = "Freshwater PEARLS Red Silk RIBBON Bracelet/Necklace",
                            Price = 61.00m
                        },
                        new
                        {
                            JewelryId = 5,
                            CategoryId = 5,
                            Description = @"ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
 Natural Greek leather knotted with black seed pearls in between to form the perfect Anklet.Beautifully complemented with with a black cultured freshwater pearl, which also serves as the closure.Anklet measures 10"".",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Black Pearls and Knots LEATHER Anklet_tn.jpg",
                            ImageUrl = "\\Images\\Black Pearls and Knots LEATHER Anklet",
                            IsInStock = true,
                            Name = "Black Pearls and Knots LEATHER Anklet",
                            Price = 71.00m
                        },
                        new
                        {
                            JewelryId = 6,
                            CategoryId = 6,
                            Description = "Freshwater Pearl Ring. This Ring is beautiful!! Blue, Green, Purple hue freshwater Pearl. Pearl measures 15.75 x 20.25 mm on a rich brown leather. Ring size 9.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Akoya Freshwater Blue, Green, Purple Pearl Ring_tn.jpg",
                            ImageUrl = "\\Images\\Akoya Freshwater Blue, Green, Purple Pearl Ring.jpg",
                            IsInStock = true,
                            Name = "Akoya Freshwater Blue, Green, Purple Pearl Ring",
                            Price = 46.00m
                        },
                        new
                        {
                            JewelryId = 7,
                            CategoryId = 1,
                            Description = "Dark,iridescent Peacock Baroque PEARL Bracelet , these pearls are perfect in their imperfections. Knotted on rich brown leather, with a little space between. Finished off with a round, black, cultured pearl. Bracelet measures 7 .5\". Pearls measure 22.30 x 13.5 mm.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Black Baroque Pearl Bracelet_tn.jpg",
                            ImageUrl = "\\Images\\Black Baroque Pearl Bracelet.jpg",
                            IsInStock = true,
                            Name = "Black Baroque Pearl Bracelet",
                            Price = 71.00m
                        },
                        new
                        {
                            JewelryId = 8,
                            CategoryId = 2,
                            Description = @"A NEW everyday pearl necklace! 
Beautiful, Peacock freshwater cultured pearl necklace, using 29 pearls.These pearls are knotted perfectly on natural Greek leather. Measures 17"". 
Pearls are 10mm. Closure is finished off with a blue, round, freshwater cultured pearl. 
A Perfect necklace to layer!",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Freshwater Peacock Pearls All Around Necklace_tn.jpg",
                            ImageUrl = "\\Images\\Freshwater Peacock Pearls All Around Necklace.jpg",
                            IsInStock = true,
                            Name = "Freshwater Peacock Pearls All Around Necklace",
                            Price = 112.00m
                        },
                        new
                        {
                            JewelryId = 9,
                            CategoryId = 3,
                            Description = "These are not your mother's pearl earrings. Beautiful White Freshwater Pearls strung on Natural Greek leather make a stunning pair of earrings. These dangle approximately 2 1/4” from the gold-filled earring wire. Pearls measure 11.50 mm.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Everyday White PEARL and Natural Greek Leather Earrings_tn.jpg",
                            ImageUrl = "\\Images\\Everyday White PEARL and Natural Greek Leather Earrings.jpg",
                            IsInStock = true,
                            Name = "Everyday White PEARL and Natural Greek Leather Earrings",
                            Price = 56.00m
                        },
                        new
                        {
                            JewelryId = 10,
                            CategoryId = 4,
                            Description = @"FUN FUN FUNThis color ALWAYS makes me think of Summer.Ocean, Waves, Sand & Sun.So what better way to celebrate summer then to wear a beachy color with pearls.
 ... Freshwater, Cultured, White Pearls strung on a silk ribbon.Hand drilled pearls to fit perfectly on the silk ribbon, pearls can be adjusted to fit your mood.Wrap around your wrist as many times as you wish, knot to finsh.Total length is 34 inches. One pearl measures 12mm, two pearls measure 9mm.When Silk ribbon gets messy take pearls off and just wash in cold water and lay flat to dry. 
Bonus: can be worn as a necklace:>) 
 Notice: this could be a starter pearls and silk ribbon bracelet / necklace. You can purchase more pearls and or different colors of silk ribbon.Please convo me with questions and more information.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Silk RIBBON and PEARLS Bracelet & Necklace_tn.jpg",
                            ImageUrl = "\\Images\\Silk RIBBON and PEARLS Bracelet/Necklace.jpg",
                            IsInStock = true,
                            Name = "Silk RIBBON and PEARLS Bracelet/Necklace",
                            Price = 28.00m
                        },
                        new
                        {
                            JewelryId = 11,
                            CategoryId = 5,
                            Description = @"ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
 Natural Greek leather with turquoise to form the perfect Anklet. Beautifully complemented with a square turquoise which also serves as the closure. Anklet measures 10"".",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Turquoise and Natural Greek LEATHER Anklet_tn.jpg",
                            ImageUrl = "\\Images\\Turquoise and Natural Greek LEATHER Anklet.jpg",
                            IsInStock = true,
                            Name = "Turquoise and Natural Greek LEATHER Anklet",
                            Price = 45.00m
                        },
                        new
                        {
                            JewelryId = 12,
                            CategoryId = 6,
                            Description = "Black Coin Pearl Ring. This ring is a Black Coin freshwater Pearl with natural Greek leather. Pearl measures 13.30 mm. Ring size 8.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\Black Coin Pearl Ring_tn.jpg",
                            ImageUrl = "\\Images\\Black Coin Pearl Ring.jpg",
                            IsInStock = true,
                            Name = "Black Coin Pearl Ring",
                            Price = 36.00m
                        });
                });

            modelBuilder.Entity("OnlineJewelry.Models.Jewelry", b =>
                {
                    b.HasOne("OnlineJewelry.Models.Category", "Category")
                        .WithMany("Jewelries")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
