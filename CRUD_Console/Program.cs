// See https://aka.ms/new-console-template for more information
using Business;
using Models;

ProductBusiness business = new ProductBusiness();
Product product = new Product() { Name = "Play Station", Category = "Elektro", Price = -560.00, Quantity = 12 };
try
{
    business.AddProduct(product);
}
catch (Exception ex)
{

    //Console.WriteLine(ex.Message); 
}


// Delete Product
var p = new Product();
p.Name = "TV";
p.Price = 10;
try
{
    business.DeleteProduct(p);
    Console.WriteLine("Product deleted successfully.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Product productToUpdate= new Product();
productToUpdate.Name = "AntiVirus";
productToUpdate.Price = 100;
productToUpdate.Quantity = 1;

try
{
    business.UpdateProduct(productToUpdate);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}



foreach (var item in business.GetAllProducts())
{
    Console.WriteLine(item);
}

business.SaveToTextFile(business.GetAllProducts(), @"c:\Temp\Nlayer.txt");

