using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>
            {
                 new Product
                {
                    Name = "Angular Speedster Board 2000",
                    Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl_1 = "/images/products/sb-ang1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Angular Board 3000",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl_1 = "/images/products/sb-ang2.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Board Speed Rush 3",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl_1 = "/images/products/sb-core1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "NetCore",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Net Core Super Board",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl_1 = "/images/products/sb-core2.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "NetCore",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "React Board Super Whizzy Fast",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl_1 = "/images/products/sb-react1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "React",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Typescript Entry Board",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl_1 = "/images/products/sb-ts1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "TypeScript",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Blue Hat",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl_1 = "/images/products/hat-core1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "NetCore",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green React Woolen Hat",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl_1 = "/images/products/hat-react1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "React",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple React Woolen Hat",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl_1 = "/images/products/hat-react2.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "React",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Code Gloves",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl_1 = "/images/products/glove-code1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Code Gloves",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl_1 = "/images/products/glove-code2.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple React Gloves",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl_1 = "/images/products/glove-react1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "React",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green React Gloves",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl_1 = "/images/products/glove-react2.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "React",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Redis Red Boots",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl_1 = "/images/products/boot-redis1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "Redis",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Red Boots",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl_1 = "/images/products/boot-core2.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "NetCore",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Purple Boots",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl_1 = "/images/products/boot-core1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "NetCore",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Angular Purple Boots",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl_1 = "/images/products/boot-ang2.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Angular Blue Boots",
                     Color="red",
                    Storage_Space="5GB",
                    All_Features="The all features of product",
                    Category="Computer",
                    specifications="This is the specification of product",
                    All_Specifications="Complete specifications",
                    Size="big",
                    Video="https://youtu.be/B94jU-Dug1w",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl_1 = "/images/products/boot-ang1.png",
                    PictureUrl_2 = "/images/products/sb-ang1.png",
                    PictureUrl_3 = "/images/products/sb-ang1.png",
                    PictureUrl_4 = "/images/products/sb-ang1.png",
                    PictureUrl_5 = "/images/products/sb-ang1.png",
                    PictureUrl_6 = "/images/products/sb-ang1.png",
                    PictureUrl_7 = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
            };
            foreach(var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}
