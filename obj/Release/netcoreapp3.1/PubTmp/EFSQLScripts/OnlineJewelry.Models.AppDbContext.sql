IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201012191303_CreateDB')
BEGIN
    CREATE TABLE [Categories] (
        [CategoryId] int NOT NULL IDENTITY,
        [CategoryName] nvarchar(max) NULL,
        [CategoryDescription] nvarchar(max) NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201012191303_CreateDB')
BEGIN
    CREATE TABLE [Jewelries] (
        [JewelryId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Price] decimal(18,2) NOT NULL,
        [ImageUrl] nvarchar(max) NULL,
        [ImageThumbnailUrl] nvarchar(max) NULL,
        [IsInStock] bit NOT NULL,
        [CategoryId] int NOT NULL,
        CONSTRAINT [PK_Jewelries] PRIMARY KEY ([JewelryId]),
        CONSTRAINT [FK_Jewelries_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([CategoryId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201012191303_CreateDB')
BEGIN
    CREATE INDEX [IX_Jewelries_CategoryId] ON [Jewelries] ([CategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201012191303_CreateDB')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201012191303_CreateDB', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201012195554_AddData')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryDescription', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([CategoryId], [CategoryDescription], [CategoryName])
    VALUES (1, N'Finest quality of pearls, leather and torquoise Bracelets', N'Bracelet'),
    (2, N'Finest quality of pearls, leather and torquoise Necklace', N'Necklace'),
    (3, N'Finest quality of pearls, leather and torquoise Earrings', N'Earrings'),
    (4, N'Finest quality of pearls, leather and torquoise Silk Ribbons Bracelets', N'Silk Ribbons Bracelets'),
    (5, N'Finest quality of pearls, leather and torquoise Anklet', N'Anklet'),
    (6, N'Finest quality of pearls, leather and torquoise Ring', N'Ring');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryDescription', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201012195554_AddData')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JewelryId', N'CategoryId', N'Description', N'ImageThumbnailUrl', N'ImageUrl', N'IsInStock', N'Name', N'Price') AND [object_id] = OBJECT_ID(N'[Jewelries]'))
        SET IDENTITY_INSERT [Jewelries] ON;
    INSERT INTO [Jewelries] ([JewelryId], [CategoryId], [Description], [ImageThumbnailUrl], [ImageUrl], [IsInStock], [Name], [Price])
    VALUES (1, 1, N'A Wrap Around Bracelet with freshwater pearls. Chocolate Coin pearls, Black freshwater pearls and knots, all on a rich brown leather. When wrapped around wrist the coin pearls set at an angle, very unique. 
                    Total measurements 14". 
                    Fits a size 7" wrist.', N'\Images\thumbnails\CHOCOLATE TIDAL WAVE Bracelet_tn.jpg', N'\Images\CHOCOLATE TIDAL WAVE Bracelet.jpg', CAST(1 AS bit), N'CHOCOLATE TIDAL WAVE Bracelet', 53.0),
    (7, 1, N'Dark,iridescent Peacock Baroque PEARL Bracelet , these pearls are perfect in their imperfections. Knotted on rich brown leather, with a little space between. Finished off with a round, black, cultured pearl. Bracelet measures 7 .5". Pearls measure 22.30 x 13.5 mm.', N'\Images\thumbnails\Black Baroque Pearl Bracelet_tn.jpg', N'\Images\Black Baroque Pearl Bracelet.jpg', CAST(1 AS bit), N'Black Baroque Pearl Bracelet', 71.0),
    (2, 2, N'…..Simplicity is often the most beautiful. This is perfectly seen in this Floating Pearl necklace. Single strand of a natural Greek leather, with one floating pearl.Center Pearl is large, measures 12mm.Closure pearl measures 11mm.Can be worn with one pearl in front(pictures 1 and 2) or both pearls in front as shown in (picture 3 and 4 ).Necklace measures 16". Great piece for this Summer!', N'\Images\thumbnails\Floating Champagne Freshwater Pearl Necklace-1_tn.jpg', N'\Images\Floating Champagne Freshwater Pearl Necklace-1.jpg', CAST(1 AS bit), N'Floating Champagne Freshwater Pearl Necklace-1', 46.0),
    (8, 2, N'A NEW everyday pearl necklace! 
                    Beautiful, Peacock freshwater cultured pearl necklace, using 29 pearls.These pearls are knotted perfectly on natural Greek leather. Measures 17". 
                    Pearls are 10mm. Closure is finished off with a blue, round, freshwater cultured pearl. 
                    A Perfect necklace to layer!', N'\Images\thumbnails\Freshwater Peacock Pearls All Around Necklace_tn.jpg', N'\Images\Freshwater Peacock Pearls All Around Necklace.jpg', CAST(1 AS bit), N'Freshwater Peacock Pearls All Around Necklace', 112.0),
    (3, 3, N'Beautiful White Baroque Pearls strung on Gold-filled wires make a stunning pair of earrings. These exquisite pearls that I used will go with whatever you are wearing. Pearls measure 17.75mm x 14mm, a really nice size. These dangle approximately 1 1 / 2" from the gold-filled earring wires. 
                    * The earrings in the picture are the ones you will receive.', N'\Images\thumbnails\White Baroque PEARL Earrings_tn.jpg', N'\Images\White Baroque PEARL Earrings.jpg', CAST(1 AS bit), N'White Baroque PEARL Earrings', 58.0),
    (9, 3, N'These are not your mother''s pearl earrings. Beautiful White Freshwater Pearls strung on Natural Greek leather make a stunning pair of earrings. These dangle approximately 2 1/4” from the gold-filled earring wire. Pearls measure 11.50 mm.', N'\Images\thumbnails\Everyday White PEARL and Natural Greek Leather Earrings_tn.jpg', N'\Images\Everyday White PEARL and Natural Greek Leather Earrings.jpg', CAST(1 AS bit), N'Everyday White PEARL and Natural Greek Leather Earrings', 56.0),
    (4, 4, N'... Freshwater, Cultured, White Pearl Bracelet. Hand drilled pearls to fit perfectly on the ribbon that they are strung on, pearls can be adjusted to fit your mood. Wrap around your wrist as many times as you wish, knot to finsh. Total length of ribbon 34 inches. Pearl measure between 12.5 - 13.5 mm.Bonus: can be worn as a necklace:>) 
                    I have many colors of ribbon available, Please convo me to let me know if you would like a different color.', N'\Images\thumbnails\Freshwater PEARLS Red Silk RIBBON Bracelet and Necklace_tn.jpg', N'\Images\Freshwater PEARLS Red Silk RIBBON Bracelet and Necklace.jpg', CAST(1 AS bit), N'Freshwater PEARLS Red Silk RIBBON Bracelet/Necklace', 61.0),
    (10, 4, N'FUN FUN FUNThis color ALWAYS makes me think of Summer.Ocean, Waves, Sand & Sun.So what better way to celebrate summer then to wear a beachy color with pearls.
                     ... Freshwater, Cultured, White Pearls strung on a silk ribbon.Hand drilled pearls to fit perfectly on the silk ribbon, pearls can be adjusted to fit your mood.Wrap around your wrist as many times as you wish, knot to finsh.Total length is 34 inches. One pearl measures 12mm, two pearls measure 9mm.When Silk ribbon gets messy take pearls off and just wash in cold water and lay flat to dry. 
                    Bonus: can be worn as a necklace:>) 
                     Notice: this could be a starter pearls and silk ribbon bracelet / necklace. You can purchase more pearls and or different colors of silk ribbon.Please convo me with questions and more information.', N'\Images\thumbnails\Silk RIBBON and PEARLS Bracelet & Necklace_tn.jpg', N'\Images\Silk RIBBON and PEARLS Bracelet/Necklace.jpg', CAST(1 AS bit), N'Silk RIBBON and PEARLS Bracelet/Necklace', 28.0),
    (5, 5, N'ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
                     Natural Greek leather knotted with black seed pearls in between to form the perfect Anklet.Beautifully complemented with with a black cultured freshwater pearl, which also serves as the closure.Anklet measures 10".', N'\Images\thumbnails\Black Pearls and Knots LEATHER Anklet_tn.jpg', N'\Images\Black Pearls and Knots LEATHER Anklet', CAST(1 AS bit), N'Black Pearls and Knots LEATHER Anklet', 71.0),
    (11, 5, N'ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
                     Natural Greek leather with turquoise to form the perfect Anklet. Beautifully complemented with a square turquoise which also serves as the closure. Anklet measures 10".', N'\Images\thumbnails\Turquoise and Natural Greek LEATHER Anklet_tn.jpg', N'\Images\Turquoise and Natural Greek LEATHER Anklet.jpg', CAST(1 AS bit), N'Turquoise and Natural Greek LEATHER Anklet', 45.0),
    (6, 6, N'Freshwater Pearl Ring. This Ring is beautiful!! Blue, Green, Purple hue freshwater Pearl. Pearl measures 15.75 x 20.25 mm on a rich brown leather. Ring size 9.', N'\Images\thumbnails\Akoya Freshwater Blue, Green, Purple Pearl Ring_tn.jpg', N'\Images\Akoya Freshwater Blue, Green, Purple Pearl Ring.jpg', CAST(1 AS bit), N'Akoya Freshwater Blue, Green, Purple Pearl Ring', 46.0),
    (12, 6, N'Black Coin Pearl Ring. This ring is a Black Coin freshwater Pearl with natural Greek leather. Pearl measures 13.30 mm. Ring size 8.', N'\Images\thumbnails\Black Coin Pearl Ring_tn.jpg', N'\Images\Black Coin Pearl Ring.jpg', CAST(1 AS bit), N'Black Coin Pearl Ring', 36.0);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JewelryId', N'CategoryId', N'Description', N'ImageThumbnailUrl', N'ImageUrl', N'IsInStock', N'Name', N'Price') AND [object_id] = OBJECT_ID(N'[Jewelries]'))
        SET IDENTITY_INSERT [Jewelries] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201012195554_AddData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201012195554_AddData', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015075135_UpdateTableJewelry')
BEGIN
    ALTER TABLE [Jewelries] ADD [ShortDescription] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015075135_UpdateTableJewelry')
BEGIN
    UPDATE [Jewelries] SET [Description] = N'A Wrap Around Bracelet with freshwater pearls. Chocolate Coin pearls, Black freshwater pearls and knots, all on a rich brown leather. When wrapped around wrist the coin pearls set at an angle, very unique. 
    Total measurements 14". 
    Fits a size 7" wrist.'
    WHERE [JewelryId] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015075135_UpdateTableJewelry')
BEGIN
    UPDATE [Jewelries] SET [Description] = N'Beautiful White Baroque Pearls strung on Gold-filled wires make a stunning pair of earrings. These exquisite pearls that I used will go with whatever you are wearing. Pearls measure 17.75mm x 14mm, a really nice size. These dangle approximately 1 1 / 2" from the gold-filled earring wires. 
    * The earrings in the picture are the ones you will receive.'
    WHERE [JewelryId] = 3;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015075135_UpdateTableJewelry')
BEGIN
    UPDATE [Jewelries] SET [Description] = N'... Freshwater, Cultured, White Pearl Bracelet. Hand drilled pearls to fit perfectly on the ribbon that they are strung on, pearls can be adjusted to fit your mood. Wrap around your wrist as many times as you wish, knot to finsh. Total length of ribbon 34 inches. Pearl measure between 12.5 - 13.5 mm.Bonus: can be worn as a necklace:>) 
    I have many colors of ribbon available, Please convo me to let me know if you would like a different color.'
    WHERE [JewelryId] = 4;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015075135_UpdateTableJewelry')
BEGIN
    UPDATE [Jewelries] SET [Description] = N'ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
     Natural Greek leather knotted with black seed pearls in between to form the perfect Anklet.Beautifully complemented with with a black cultured freshwater pearl, which also serves as the closure.Anklet measures 10".'
    WHERE [JewelryId] = 5;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015075135_UpdateTableJewelry')
BEGIN
    UPDATE [Jewelries] SET [Description] = N'A NEW everyday pearl necklace! 
    Beautiful, Peacock freshwater cultured pearl necklace, using 29 pearls.These pearls are knotted perfectly on natural Greek leather. Measures 17". 
    Pearls are 10mm. Closure is finished off with a blue, round, freshwater cultured pearl. 
    A Perfect necklace to layer!'
    WHERE [JewelryId] = 8;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015075135_UpdateTableJewelry')
BEGIN
    UPDATE [Jewelries] SET [Description] = N'FUN FUN FUNThis color ALWAYS makes me think of Summer.Ocean, Waves, Sand & Sun.So what better way to celebrate summer then to wear a beachy color with pearls.
     ... Freshwater, Cultured, White Pearls strung on a silk ribbon.Hand drilled pearls to fit perfectly on the silk ribbon, pearls can be adjusted to fit your mood.Wrap around your wrist as many times as you wish, knot to finsh.Total length is 34 inches. One pearl measures 12mm, two pearls measure 9mm.When Silk ribbon gets messy take pearls off and just wash in cold water and lay flat to dry. 
    Bonus: can be worn as a necklace:>) 
     Notice: this could be a starter pearls and silk ribbon bracelet / necklace. You can purchase more pearls and or different colors of silk ribbon.Please convo me with questions and more information.'
    WHERE [JewelryId] = 10;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015075135_UpdateTableJewelry')
BEGIN
    UPDATE [Jewelries] SET [Description] = N'ARE YOU READY FOR SUMMER?........Wait, you need an anklet!
     Natural Greek leather with turquoise to form the perfect Anklet. Beautifully complemented with a square turquoise which also serves as the closure. Anklet measures 10".'
    WHERE [JewelryId] = 11;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015075135_UpdateTableJewelry')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201015075135_UpdateTableJewelry', N'3.1.8');
END;

GO

