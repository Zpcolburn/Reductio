// See https://aka.ms/new-console-template for more information

using System;
using System.Numerics;

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Invisibility cloak",
        Price = 199.99M,
        ProductTypeId = 0,
        Sold = false
    },
    new Product()
    {
        Name = "Wands",
        Price = 15.91M,
        ProductTypeId = 1,
        Sold = false
    },
    new Product()
    {
        Name = "Robes",
        Price = 8.99m,
        ProductTypeId = 2,
        Sold = false
    },
    new Product()
    {
        Name = "Love potion",
        Price = 2.50m,
        ProductTypeId = 3,
        Sold = false
    },

};

List<ProductType> productTypes = new List<ProductType>()
{
     new ProductType()
    {
        Name = "Enchanted Objects",
        Id = 0
    },

    new ProductType()
    {
       Name = "Wands",
       Id = 1
    },

     new ProductType()
    {
       Name = "Apparel",
       Id = 2
    },

      new ProductType()
    {
       Name = "Potions",
       Id = 3
    }
};

string greeting = @"Welcome to Reductio and Absurdum the only wizarding supply company with a troll in the basement.";
Console.WriteLine(greeting);

string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Please choose an option:
                       0.Exit
                       1. View All Products 
                       2. Type of product
                       3. Add a Product
                       4. Update Product Details
                       5. Delete a Product");
    choice = Console.ReadLine();

    if (choice == "0")
    {
        Console.WriteLine("Goodbye!");
    }
    else if (choice == "1")
    {
        ViewAllProducts();
    }
    else if (choice == "2")
    {
        TypeOfProduct();
    }
    else if (choice == "3")
    {
        AddAProduct();
    }
    else if (choice == "4")
    {
        UpdateProductDetails();
    }
    else if (choice == "5")
    {
        DeleteAProduct();
    }
}
void ViewAllProducts()
{
    for (int i = 0; i < products.Count; i++)
    {
        string status = products[i].Sold ? "was sold" : "is available";
        Console.WriteLine($"{i + 1}. The {products[i].Name} {status} for {products[i].Price} gallons, to help with searching for the product bring this product id {products[i].ProductTypeId} to the nearest clerk.");
    }
}

void AddAProduct()
{
    Console.WriteLine("Adding a new product is easy, lets start with the product name:");
    string name = Console.ReadLine();

    Console.WriteLine("Next lets enter a price:");
    decimal price;
    while (!decimal.TryParse(Console.ReadLine(), out price))
    {
        Console.Write("Invalid price. Figure it out will ya:");
    }

    Console.WriteLine("Is this product available (yes/no):");
    bool isAvailable = Console.ReadLine().ToLower() == "yes";

    Console.WriteLine(@"Choice product type by the Ids below:
                        0. Potions
                        1. Apparel
                        2. Enchanted Objects
                        4. Wands");
    int ID = int.Parse(Console.ReadLine());

    Product newProduct = new Product
    {
        Name = name,
        Price = price,
        Sold = true,
        ProductTypeId = ID

    };
    products.Add(newProduct);
    Console.WriteLine("Product added successfully.");
}
void UpdateProductDetails()
{
    Console.WriteLine("Please pick a product to update:");
    Console.WriteLine("Products:");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }
    Product choosenProduct = null;
    while (choosenProduct == null);
    {
        Console.WriteLine("Enter Product number: ");
        try
        {
            int response = int.Parse(Console.ReadLine().Trim());
            choosenProduct = products[response - 1];
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type only numbers ex. (1,2,3)");
        }
    }

    Console.WriteLine($@" You chose: {chosenProduct.Name},")
}
void TypeOfProduct()
{

}
void DeleteAProduct()
{

}