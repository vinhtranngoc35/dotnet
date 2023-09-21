﻿using System.Collections;
using buoi_toi.model;
using buoi_toi.service;


bool flag = true;

ProductService.AddProduct(new Product(1, "Cafe", "Ngon", 10000));
ProductService.AddProduct(new Product(2, "Bo Huc", "Ngon", 15000));

while (flag)
{
    Console.WriteLine("1. Them moi");
    Console.WriteLine("2. Xoa");
    Console.WriteLine("3. Sua");
    Console.WriteLine("4. Xem tat ca");
    Console.WriteLine("5. Thoat");
    Console.Write("Chon: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Create();
            break;
        case "2":
            DeleteProduct();
            break;
        case "3":
            EditProduct();
            break;
        case "4":
            PrintAllProducts();
            break;
        case "5":
            Console.WriteLine("Thoat");
            flag = false;
            break;
        default:
            Console.WriteLine("Chon sai");
            break;
    }
}

static void Create()
{
    Console.Write("Nhap ten: ");
    string name = Console.ReadLine();
    Console.Write("Nhap gia: ");
    int price = int.Parse(Console.ReadLine());
    Console.Write("Nhap mo ta: ");
    string description = Console.ReadLine();
    Product product = new();
    product.Name = name;
    product.Price = price;
    product.Description = description;
    ProductService.AddProduct(product);
}

static void PrintAllProducts()
{
    Console.WriteLine("Id|Name| Description | Price |");
    foreach (Product product in ProductService.Products)
    {
        Console.WriteLine($"{product.Id} |{product.Name}  | {product.Description} | {product.Price} |");
    }
}

static void DeleteProduct()
{
    Console.Write("Nhap id: ");
    string id = Console.ReadLine();
    ProductService.RemoveProduct(int.Parse(id));
}

static void EditProduct()
{
    Console.Write("Nhap id: ");
    string id = Console.ReadLine();
    Console.Write("Nhap ten: ");
    string name = Console.ReadLine();
    Console.Write("Nhap gia: ");
    int price = int.Parse(Console.ReadLine());
    Console.Write("Nhap mo ta: ");
    string description = Console.ReadLine();

    Product product = new()
    {
        Id = int.Parse(id),
        Name = name,
        Price = price,
        Description = description
    };
    ProductService.EditProduct(product);
}


