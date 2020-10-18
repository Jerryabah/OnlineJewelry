using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJewelry.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Jewelry> Jewelries { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Bracelet", CategoryDescription = "Finest quality of pearls, leather and torquoise Bracelets" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Necklace", CategoryDescription = "Finest quality of pearls, leather and torquoise Necklace" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Earrings", CategoryDescription = "Finest quality of pearls, leather and torquoise Earrings" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Silk Ribbons Bracelets", CategoryDescription = "Finest quality of pearls, leather and torquoise Silk Ribbons Bracelets" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Anklet", CategoryDescription = "Finest quality of pearls, leather and torquoise Anklet" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Ring", CategoryDescription = "Finest quality of pearls, leather and torquoise Ring" });

            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 1,
                Name = "CHOCOLATE TIDAL WAVE Bracelet",
                Price = 53.00M,
                Description = "A Wrap Around Bracelet with freshwater pearls. Chocolate Coin pearls, " +
                "Black freshwater pearls and knots, all on a rich brown leather. " +
                "When wrapped around wrist the coin pearls set at an angle, very unique. " +
                "\nTotal measurements 14\". \nFits a size 7\" wrist.",
                CategoryId = 1,
                ImageUrl = "\\Images\\CHOCOLATE TIDAL WAVE Bracelet.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\CHOCOLATE TIDAL WAVE Bracelet_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 2,
                Name = "Floating Champagne Freshwater Pearl Necklace-1",
                Price = 46.00M,
                Description = "…..Simplicity is often the most beautiful. This is perfectly seen in this Floating Pearl necklace. " +
                "Single strand of a natural Greek leather, with one floating pearl.Center Pearl is large, " +
                "measures 12mm.Closure pearl measures 11mm.Can be worn with one pearl in front(pictures 1 and 2) or " +
                "both pearls in front as shown in (picture 3 and 4 ).Necklace measures 16\". Great piece for this Summer!",
                CategoryId = 2,
                ImageUrl = "\\Images\\Floating Champagne Freshwater Pearl Necklace-1.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Floating Champagne Freshwater Pearl Necklace-1_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 3,
                Name = "White Baroque PEARL Earrings",
                Price = 58.00M,
                Description = "Beautiful White Baroque Pearls strung on Gold-filled wires make a stunning pair of earrings. " +
                "These exquisite pearls that I used will go with whatever you are wearing. Pearls measure 17.75mm x 14mm, " +
                "a really nice size. These dangle approximately 1 1 / 2\" from the gold-filled earring wires. " +
                "\n* The earrings in the picture are the ones you will receive.",
                CategoryId = 3,
                ImageUrl = "\\Images\\White Baroque PEARL Earrings.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\White Baroque PEARL Earrings_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 4,
                Name = "Freshwater PEARLS Red Silk RIBBON Bracelet/Necklace",
                Price = 61.00M,
                Description = "... Freshwater, Cultured, White Pearl Bracelet. Hand drilled pearls to fit perfectly on the ribbon that they are strung on, " +
                "pearls can be adjusted to fit your mood. Wrap around your wrist as many times as you wish, knot to finsh. Total length of ribbon 34 inches. " +
                "Pearl measure between 12.5 - 13.5 mm.Bonus: can be worn as a necklace:>) \nI have many colors of ribbon available, Please convo me to let me know if you would like a different color.",
                CategoryId = 4,
                ImageUrl = "\\Images\\Freshwater PEARLS Red Silk RIBBON Bracelet and Necklace.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Freshwater PEARLS Red Silk RIBBON Bracelet and Necklace_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 5,
                Name = "Black Pearls and Knots LEATHER Anklet",
                Price = 71.00M,
                Description = "ARE YOU READY FOR SUMMER?........Wait, you need an anklet!\n Natural Greek leather knotted with black seed pearls in between to form the perfect Anklet.Beautifully complemented with with a black cultured freshwater pearl, which also serves as the closure.Anklet measures 10\".",
                CategoryId = 5,
                ImageUrl = "\\Images\\Black Pearls and Knots LEATHER Anklet.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Black Pearls and Knots LEATHER Anklet_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 6,
                Name = "Akoya Freshwater Blue, Green, Purple Pearl Ring",
                Price = 46.00M,
                Description = "Freshwater Pearl Ring. This Ring is beautiful!! Blue, Green, Purple hue freshwater Pearl. Pearl measures 15.75 x 20.25 mm on a rich brown leather. Ring size 9.",
                CategoryId = 6,
                ImageUrl = "\\Images\\Akoya Freshwater Blue, Green, Purple Pearl Ring.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Akoya Freshwater Blue, Green, Purple Pearl Ring_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 7,
                Name = "Black Baroque Pearl Bracelet",
                Price = 71.00M,
                Description = "Dark,iridescent Peacock Baroque PEARL Bracelet , these pearls are perfect in their imperfections. " +
                "Knotted on rich brown leather, with a little space between. Finished off with a round, black, cultured pearl. " +
                "Bracelet measures 7 .5\". Pearls measure 22.30 x 13.5 mm.",
                CategoryId = 1,
                ImageUrl = "\\Images\\Black Baroque Pearl Bracelet.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Black Baroque Pearl Bracelet_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 8,
                Name = "Freshwater Peacock Pearls All Around Necklace",
                Price = 112.00M,
                Description = "A NEW everyday pearl necklace! " +
                "\nBeautiful, Peacock freshwater cultured pearl necklace, " +
                "using 29 pearls.These pearls are knotted perfectly on natural Greek leather. " +
                "Measures 17\". \nPearls are 10mm. Closure is finished off with a blue, round, freshwater cultured pearl. " +
                "\nA Perfect necklace to layer!",
                CategoryId = 2,
                ImageUrl = "\\Images\\Freshwater Peacock Pearls All Around Necklace.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Freshwater Peacock Pearls All Around Necklace_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 9,
                Name = "Everyday White PEARL and Natural Greek Leather Earrings",
                Price = 56.00M,
                Description = "These are not your mother's pearl earrings. Beautiful White Freshwater Pearls " +
                "strung on Natural Greek leather make a stunning pair of earrings. " +
                "These dangle approximately 2 1/4” from the gold-filled earring wire. Pearls measure 11.50 mm.",
                CategoryId = 3,
                ImageUrl = "\\Images\\Everyday White PEARL and Natural Greek Leather Earrings.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Everyday White PEARL and Natural Greek Leather Earrings_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 10,
                Name = "Silk RIBBON and PEARLS Bracelet/Necklace",
                Price = 28.00M,
                Description = "FUN FUN FUN This color ALWAYS makes me think of Summer.Ocean, Waves, Sand & Sun." +
                "So what better way to celebrate summer then to wear a beachy color with pearls." +
                "\n ... Freshwater, Cultured, White Pearls strung on a silk ribbon.Hand drilled pearls to fit perfectly on the silk ribbon, " +
                "pearls can be adjusted to fit your mood.Wrap around your wrist as many times as you wish, knot to finsh.Total length is 34 inches. " +
                "One pearl measures 12mm, two pearls measure 9mm.When Silk ribbon gets messy take pearls off and just wash in cold water and lay flat to dry. " +
                "\nBonus: can be worn as a necklace:>) \n Notice: this could be a starter pearls and silk ribbon bracelet / necklace. " +
                "You can purchase more pearls and or different colors of silk ribbon.Please convo me with questions and more information.",
                CategoryId = 4,
                ImageUrl = "\\Images\\Silk RIBBON and PEARLS Bracelet & Necklace.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Silk RIBBON and PEARLS Bracelet & Necklace_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 11,
                Name = "Turquoise and Natural Greek LEATHER Anklet",
                Price = 45.00M,
                Description = "ARE YOU READY FOR SUMMER?........Wait, you need an anklet!" +
                "\n Natural Greek leather with turquoise to form the perfect Anklet." +
                " Beautifully complemented with a square turquoise which also serves as the closure." +
                " Anklet measures 10\".",
                CategoryId = 5,
                ImageUrl = "\\Images\\Turquoise and Natural Greek LEATHER Anklet.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Turquoise and Natural Greek LEATHER Anklet_tn.jpg",
                IsInStock = true,
            });
            modelBuilder.Entity<Jewelry>().HasData(new Jewelry
            {
                JewelryId = 12,
                Name = "Black Coin Pearl Ring",
                Price = 36.00M,
                Description = "Black Coin Pearl Ring. This ring is a Black Coin freshwater Pearl with natural Greek leather." +
                " Pearl measures 13.30 mm. Ring size 8.",
                CategoryId = 6,
                ImageUrl = "\\Images\\Black Coin Pearl Ring.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\Black Coin Pearl Ring_tn.jpg",
                IsInStock = true,
            });


        }
    }
}

